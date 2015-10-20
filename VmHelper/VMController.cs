using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Vestris.VMWareLib;

namespace VmHelper
{
    class VMController
    {
        public class HostInfo
        {
            public string name { get; set; }
            public string account { get; set; }
            public string pwd { get; set; }
        }

        public class VMInfo
        {
            public string storage { get; set; }
            public string name { get; set; }
            public string account { get; set; }
            public string pwd { get; set; }
        }

        public VMController(HostInfo hostInfo)
        {
            _host = new VMWareVirtualHost();

            _host.ConnectToVMWareVIServer(hostInfo.name, hostInfo.account, hostInfo.pwd);
        }

        public void CopyFileToGuest(string filePath, string guestPath, VMInfo vmInfo)
        {
            string vmPathName = vmInfo.storage + " " + vmInfo.name + "/" + vmInfo.name + ".vmx";

            using (VMWareVirtualMachine vm = _host.Open(vmPathName))
            {
                vm.WaitForToolsInGuest();
                vm.LoginInGuest(vmInfo.account, vmInfo.pwd);
                string fileName = Path.GetFileName(filePath);

                if (fileName == "file_toucher.pl" || fileName == "smv.pl")
                    vm.RunProgramInGuest(@"C:\windows\system32\attrib.exe", "-r " + guestPath + @"\" + Path.GetFileName(filePath));

                vm.CopyFileFromHostToGuest(filePath, guestPath + @"\" + Path.GetFileName(filePath));
                vm.LogoutFromGuest();
            }
        }

        public void CopyFileToHost(string filePath, string guestPath, VMInfo vmInfo)
        {
            string vmPathName = vmInfo.storage + " " + vmInfo.name + "/" + vmInfo.name + ".vmx";

            using (VMWareVirtualMachine vm = _host.Open(vmPathName))
            {
                vm.WaitForToolsInGuest();
                vm.LoginInGuest(vmInfo.account, vmInfo.pwd);

                vm.CopyFileFromGuestToHost(guestPath + @"\" + Path.GetFileName(filePath), filePath);
                vm.LogoutFromGuest();
            }
        }

        public void TakeSnapshot(string snapshotName, VMInfo vmInfo)
        {
            string vmPathName = GetVmPathName(vmInfo.storage, vmInfo.name);

            using (VMWareVirtualMachine vm = _host.Open(vmPathName))
            {
                const int VIX_SNAPSHOT_INCLUDE_MEMORY = 0x0002;

                using (VMWareSnapshot snapshot = 
                    vm.Snapshots.CreateSnapshot(snapshotName, "", VIX_SNAPSHOT_INCLUDE_MEMORY, 300))
                {
                }
            }
        }

        public void DeleteSnapshot(string snapshotName, VMInfo vmInfo)
        {
            string vmPathName = GetVmPathName(vmInfo.storage, vmInfo.name);

            using (VMWareVirtualMachine vm = _host.Open(vmPathName))
            {
                using (VMWareSnapshot snapshot = vm.Snapshots.GetNamedSnapshot(snapshotName))
                {
                    snapshot.RemoveSnapshot();
                }
            }
        }

        public void RevertToSnapshot(string snapshotName, VMInfo vmInfo)
        {
            string vmPathName = GetVmPathName(vmInfo.storage, vmInfo.name);

            using (VMWareVirtualMachine vm = _host.Open(vmPathName))
            {
                using (VMWareSnapshot snapshot = vm.Snapshots.GetNamedSnapshot(snapshotName))
                {
                    snapshot.RevertToSnapshot();
                }
            }
        }

        public VMWareVirtualMachine.Process RunProgram(string guestPath, VMInfo vmInfo)
        {
            string vmPathName = vmInfo.storage + " " + vmInfo.name + "/" + vmInfo.name + ".vmx";

            using (VMWareVirtualMachine vm = _host.Open(vmPathName))
            {
                vm.WaitForToolsInGuest();
                vm.LoginInGuest(vmInfo.account, vmInfo.pwd);

                VMWareVirtualMachine.Process proc = vm.RunProgramInGuest(guestPath, "", 10);
                vm.LogoutFromGuest();
                return proc;
            }
        }

        private string GetVmPathName(string storage, string vmName)
        {
            return storage + " " + vmName + "/" + vmName + ".vmx";
        }

        private VMWareVirtualHost _host = null;
    }
}
