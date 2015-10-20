namespace VmHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.History = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HostAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HostPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GuestAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GuestPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VmNames = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Storage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PathInGuest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SnapshotName = new System.Windows.Forms.TextBox();
            this.Choose = new System.Windows.Forms.Button();
            this.TakeSnapshot = new System.Windows.Forms.Button();
            this.DeleteSnapshot = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.RevertSnapshot = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.RunProg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(131, 27);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(514, 27);
            this.History.TabIndex = 0;
            this.History.SelectedIndexChanged += new System.EventHandler(this.History_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host";
            // 
            // Host
            // 
            this.Host.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Host.Location = new System.Drawing.Point(131, 74);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(239, 27);
            this.Host.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host Account";
            // 
            // HostAccount
            // 
            this.HostAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HostAccount.Location = new System.Drawing.Point(131, 123);
            this.HostAccount.Name = "HostAccount";
            this.HostAccount.Size = new System.Drawing.Size(186, 27);
            this.HostAccount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(340, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Host Password";
            // 
            // HostPassword
            // 
            this.HostPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HostPassword.Location = new System.Drawing.Point(459, 123);
            this.HostPassword.Name = "HostPassword";
            this.HostPassword.Size = new System.Drawing.Size(186, 27);
            this.HostPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Guest Account";
            // 
            // GuestAccount
            // 
            this.GuestAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GuestAccount.Location = new System.Drawing.Point(131, 176);
            this.GuestAccount.Name = "GuestAccount";
            this.GuestAccount.Size = new System.Drawing.Size(186, 27);
            this.GuestAccount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(332, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Guest Password";
            // 
            // GuestPassword
            // 
            this.GuestPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GuestPassword.Location = new System.Drawing.Point(459, 171);
            this.GuestPassword.Name = "GuestPassword";
            this.GuestPassword.Size = new System.Drawing.Size(186, 27);
            this.GuestPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(39, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "VM Names";
            // 
            // VmNames
            // 
            this.VmNames.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VmNames.Location = new System.Drawing.Point(131, 228);
            this.VmNames.Name = "VmNames";
            this.VmNames.Size = new System.Drawing.Size(514, 27);
            this.VmNames.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(61, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Storage";
            // 
            // Storage
            // 
            this.Storage.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Storage.Location = new System.Drawing.Point(131, 274);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(186, 27);
            this.Storage.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(352, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Path in Guest";
            // 
            // PathInGuest
            // 
            this.PathInGuest.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PathInGuest.Location = new System.Drawing.Point(459, 272);
            this.PathInGuest.Name = "PathInGuest";
            this.PathInGuest.Size = new System.Drawing.Size(186, 27);
            this.PathInGuest.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(51, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Snapshot";
            // 
            // SnapshotName
            // 
            this.SnapshotName.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SnapshotName.Location = new System.Drawing.Point(131, 326);
            this.SnapshotName.Name = "SnapshotName";
            this.SnapshotName.Size = new System.Drawing.Size(186, 27);
            this.SnapshotName.TabIndex = 19;
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(21, 375);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(97, 40);
            this.Choose.TabIndex = 20;
            this.Choose.Text = "Choose";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // TakeSnapshot
            // 
            this.TakeSnapshot.Location = new System.Drawing.Point(356, 375);
            this.TakeSnapshot.Name = "TakeSnapshot";
            this.TakeSnapshot.Size = new System.Drawing.Size(97, 40);
            this.TakeSnapshot.TabIndex = 21;
            this.TakeSnapshot.Text = "Take Snapshot";
            this.TakeSnapshot.UseVisualStyleBackColor = true;
            this.TakeSnapshot.Click += new System.EventHandler(this.TakeSnapshot_Click);
            // 
            // DeleteSnapshot
            // 
            this.DeleteSnapshot.Location = new System.Drawing.Point(469, 375);
            this.DeleteSnapshot.Name = "DeleteSnapshot";
            this.DeleteSnapshot.Size = new System.Drawing.Size(97, 40);
            this.DeleteSnapshot.TabIndex = 22;
            this.DeleteSnapshot.Text = "Delete Snapshot";
            this.DeleteSnapshot.UseVisualStyleBackColor = true;
            this.DeleteSnapshot.Click += new System.EventHandler(this.DeleteSnapshot_Click);
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogBox.Location = new System.Drawing.Point(21, 425);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(645, 235);
            this.LogBox.TabIndex = 23;
            // 
            // RevertSnapshot
            // 
            this.RevertSnapshot.Location = new System.Drawing.Point(244, 375);
            this.RevertSnapshot.Name = "RevertSnapshot";
            this.RevertSnapshot.Size = new System.Drawing.Size(97, 40);
            this.RevertSnapshot.TabIndex = 24;
            this.RevertSnapshot.Text = "Revert Snapshot";
            this.RevertSnapshot.UseVisualStyleBackColor = true;
            this.RevertSnapshot.Click += new System.EventHandler(this.RevertSnapshot_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(131, 375);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(97, 40);
            this.Copy.TabIndex = 25;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // RunProg
            // 
            this.RunProg.Location = new System.Drawing.Point(581, 375);
            this.RunProg.Name = "RunProg";
            this.RunProg.Size = new System.Drawing.Size(96, 39);
            this.RunProg.TabIndex = 26;
            this.RunProg.Text = "Run Prog";
            this.RunProg.UseVisualStyleBackColor = true;
            this.RunProg.Click += new System.EventHandler(this.RunProg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 672);
            this.Controls.Add(this.RunProg);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.RevertSnapshot);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.DeleteSnapshot);
            this.Controls.Add(this.TakeSnapshot);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.SnapshotName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PathInGuest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VmNames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GuestPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GuestAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HostPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HostAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.History);
            this.Name = "Form1";
            this.Text = "VmHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HostAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HostPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GuestAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GuestPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VmNames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Storage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PathInGuest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SnapshotName;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button TakeSnapshot;
        private System.Windows.Forms.Button DeleteSnapshot;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button RevertSnapshot;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button RunProg;
    }
}

