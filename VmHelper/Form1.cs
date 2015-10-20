using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Web.Script.Serialization;

using Vestris.VMWareLib;

namespace VmHelper
{
    public partial class Form1 : Form
    {
        private class HistoryList
        {
            public string host;
            public string hostAccount;
            public string hostPwd;
            public string guestAccount;
            public string guestPwd;
            public string vmNames;
            public string storage;
            public string pathInGuest;
            public string snapshot;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _historyPath = "history.txt";
            _numHistory = 20;
            _history = new Queue<HistoryList>();
            _toCopyFiles = new List<string>();

            string[] historyStr = File.ReadAllLines(_historyPath);
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            foreach (string str in historyStr)
            {
                    HistoryList list = (HistoryList)serializer.Deserialize(str, typeof(HistoryList));
                    AddHistory(list);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] historyStr = new string[_history.Count];
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            int index = 0;

            foreach (HistoryList list in _history)
                historyStr[index++] += serializer.Serialize(list);

            if (index != 0)
                File.WriteAllLines(_historyPath, historyStr);
        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            int index = box.SelectedIndex;
            HistoryList list = _history.ElementAt(index);

            Host.Text = list.host;
            HostAccount.Text = list.hostAccount;
            HostPassword.Text = list.hostPwd;
            GuestAccount.Text = list.guestAccount;
            GuestPassword.Text = list.guestPwd;
            VmNames.Text = list.vmNames;
            Storage.Text = list.storage;
            PathInGuest.Text = list.pathInGuest;
            SnapshotName.Text = list.snapshot;
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    if (!_toCopyFiles.Contains(fileName))
                        _toCopyFiles.Add(fileName);
                }
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (HostInfoInvalid()) return;
            if (VmInfoInvalid()) return;
            if (string.IsNullOrWhiteSpace(PathInGuest.Text)) return;
            if (_toCopyFiles.Count == 0) return;

            string guestPath = PathInGuest.Text;
            string fileList = "";

            foreach (string file in _toCopyFiles)
                fileList += Path.GetFileName(file) + "\n";

            string text = "Do you want to copy the following files\n\n";
            DialogResult dialogResult = MessageBox.Show(text + fileList, "VmManager", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    VMController vmController = new VMController(GetHostInfo());

                    foreach (VMController.VMInfo vmInfo in GetVmInfos())
                    {
                        foreach (string fileName in _toCopyFiles)
                        {
                            vmController.CopyFileToGuest(fileName, guestPath, vmInfo);
                            AppendLogBox("Copy {0} ==> {1}", Path.GetFileName(fileName), vmInfo.name);
                        }
                    }
                    
                    AddHistory();
                }
                catch (Exception ex)
                {
                    AppendLogBox("Copy fail: {0}", ErrMsg(ex));
                }
            }
            else
            {
                _toCopyFiles.Clear();
            }
        }

        private void TakeSnapshot_Click(object sender, EventArgs e)
        {
            if (HostInfoInvalid()) return;
            if (SnapshotInfoInvalid()) return;

            VMController vmController = new VMController(GetHostInfo());

            try
            {
                foreach (VMController.VMInfo vmInfo in GetVmInfos())
                {
                    vmController.TakeSnapshot(SnapshotName.Text, vmInfo);
                    AppendLogBox("Take snapshot {0} on {1}", SnapshotName.Text, vmInfo.name);
                }

                AddHistory();
            }
            catch (Exception ex)
            {
                AppendLogBox("Take snapshot fail: {0}", ErrMsg(ex));
            }
        }

        private void DeleteSnapshot_Click(object sender, EventArgs e)
        {
            if (HostInfoInvalid()) return;
            if (SnapshotInfoInvalid()) return;

            VMController vmController = new VMController(GetHostInfo());

            try
            {
                foreach (VMController.VMInfo vmInfo in GetVmInfos())
                {
                    vmController.DeleteSnapshot(SnapshotName.Text, vmInfo);
                    AppendLogBox("Delete snapshot {0} on {1}", SnapshotName.Text, vmInfo.name);
                }

                AddHistory();
            }
            catch (Exception ex)
            {
                AppendLogBox("Delete snapshot fail: {0}", ErrMsg(ex));
            }
        }

        private void RevertSnapshot_Click(object sender, EventArgs e)
        {
            if (HostInfoInvalid()) return;
            if (SnapshotInfoInvalid()) return;

            VMController vmController = new VMController(GetHostInfo());

            try
            {
                foreach (VMController.VMInfo vmInfo in GetVmInfos())
                {
                    vmController.RevertToSnapshot(SnapshotName.Text, vmInfo);
                    AppendLogBox("Revert to snapshot {0} on {1}", SnapshotName.Text, vmInfo.name);
                }

                AddHistory();
            }
            catch (Exception ex)
            {
                AppendLogBox("Revert snapshot fail: {0}", ErrMsg(ex));
            }
        }


        private void RunProg_Click(object sender, EventArgs e)
        {
            if (HostInfoInvalid()) return;

            VMController vmController = new VMController(GetHostInfo());

            try
            {
                foreach (VMController.VMInfo vmInfo in GetVmInfos())
                {
                    VMWareVirtualMachine.Process proc = vmController.RunProgram(PathInGuest.Text, vmInfo);
                    AppendLogBox("Program Exit Code {0}", proc.ExitCode);
                }

                AddHistory();
            }
            catch (Exception ex)
            {
                AppendLogBox("Run Program Fail: {0}", ErrMsg(ex));
            }
        }

        private bool HostInfoInvalid()
        {
            if (string.IsNullOrWhiteSpace(Host.Text)) return true;
            if (string.IsNullOrWhiteSpace(HostAccount.Text)) return true;
            if (string.IsNullOrWhiteSpace(HostPassword.Text)) return true;

            return false;
        }

        private bool VmInfoInvalid()
        {
            if (string.IsNullOrWhiteSpace(GuestAccount.Text)) return true;
            if (string.IsNullOrWhiteSpace(VmNames.Text)) return true;
            if (string.IsNullOrWhiteSpace(Storage.Text)) return true;

            return false;
        }

        private bool SnapshotInfoInvalid()
        {
            if (string.IsNullOrWhiteSpace(VmNames.Text)) return true;
            if (string.IsNullOrWhiteSpace(Storage.Text)) return true;
            if (string.IsNullOrWhiteSpace(SnapshotName.Text)) return true;

            return false;
        }

        private VMController.VMInfo[] GetVmInfos()
        {
            Match m = Regex.Match(VmNames.Text, @"\d+~\d+");

            if (m.Success)
            {
                string[] split = m.Value.Split(new char[] { '~' });
                int start = int.Parse(split[0]);
                int end = int.Parse(split[1]);
                int numVms = end - start;
                int len = split[0].Length;
                VMController.VMInfo[] vmInfos = new VMController.VMInfo[numVms + 1];

                for (int i = 0; i <= numVms; i++)
                {
                    int num = start + i;

                    vmInfos[i] = new VMController.VMInfo
                    {
                        storage = string.Format("[{0}]", Storage.Text),
                        name = VmNames.Text.Replace(m.Value, num.ToString().PadLeft(len, '0')),
                        account = GuestAccount.Text,
                        pwd = GuestPassword.Text
                    };
                }

                return vmInfos;
            }
            else
            {
                VMController.VMInfo vmInfo = new VMController.VMInfo
                {
                    storage = string.Format("[{0}]", Storage.Text),
                    name = VmNames.Text,
                    account = GuestAccount.Text,
                    pwd = GuestPassword.Text
                };

                return new VMController.VMInfo[] { vmInfo };
            }
        }

        private VMController.HostInfo GetHostInfo()
        {
            return new VMController.HostInfo
            {
                name = Host.Text,
                account = HostAccount.Text,
                pwd = HostPassword.Text
            };
        }

        private void AddHistory(HistoryList list)
        {
            if (_history.Count == _numHistory)
                _history.Dequeue();

            _history.Enqueue(list);

            // Remove the oldest item
            if (History.Items.Count == _numHistory)
                History.Items.RemoveAt(0);

            History.Items.Add(list.vmNames);
        }

        private void AddHistory()
        {
            HistoryList list = new HistoryList
            {
                host         = Host.Text,
                hostAccount  = HostAccount.Text,
                hostPwd      = HostPassword.Text,
                guestAccount = GuestAccount.Text,
                guestPwd     = GuestPassword.Text,
                vmNames      = VmNames.Text,
                storage      = Storage.Text,
                pathInGuest  = PathInGuest.Text,
                snapshot     = SnapshotName.Text
            };
            
            AddHistory(list);
        }

        private string ErrMsg(Exception e)
        {
            return e.InnerException == null ? e.Message : e.InnerException.Message;
        }

        private void AppendLogBox(string format, params object[] arg)
        {
            LogBox.AppendText(string.Format(format, arg) + Environment.NewLine);
        }

        private Queue<HistoryList> _history;
        private string _historyPath;
        private int _numHistory;
        private List<string> _toCopyFiles;
    }
}
