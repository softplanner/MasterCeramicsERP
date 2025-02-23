namespace MasterCeramicsERP
{
    partial class BackupDatabase
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
            this.gbxSetting = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.gbxBackup = new System.Windows.Forms.GroupBox();
            this.btndatabaseForUse = new System.Windows.Forms.Button();
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.lblDatabases = new System.Windows.Forms.Label();
            this.openBackupDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveBackupDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbxSetting.SuspendLayout();
            this.gbxBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSetting
            // 
            this.gbxSetting.Controls.Add(this.btnRefresh);
            this.gbxSetting.Controls.Add(this.btnConnect);
            this.gbxSetting.Controls.Add(this.txtPassword);
            this.gbxSetting.Controls.Add(this.txtUsername);
            this.gbxSetting.Controls.Add(this.cbxServer);
            this.gbxSetting.Controls.Add(this.lblPassword);
            this.gbxSetting.Controls.Add(this.lblUsername);
            this.gbxSetting.Controls.Add(this.lblServer);
            this.gbxSetting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSetting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxSetting.Location = new System.Drawing.Point(7, 6);
            this.gbxSetting.Name = "gbxSetting";
            this.gbxSetting.Size = new System.Drawing.Size(270, 133);
            this.gbxSetting.TabIndex = 0;
            this.gbxSetting.TabStop = false;
            this.gbxSetting.Text = "Setting";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(82, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnect.Location = new System.Drawing.Point(185, 102);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(82, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 18);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(82, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 18);
            this.txtUsername.TabIndex = 3;
            // 
            // cbxServer
            // 
            this.cbxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(82, 27);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(179, 20);
            this.cbxServer.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(6, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Location = new System.Drawing.Point(6, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "username";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServer.Location = new System.Drawing.Point(6, 30);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(50, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "server";
            // 
            // gbxBackup
            // 
            this.gbxBackup.Controls.Add(this.btndatabaseForUse);
            this.gbxBackup.Controls.Add(this.btnCreateBackup);
            this.gbxBackup.Controls.Add(this.cbxDatabase);
            this.gbxBackup.Controls.Add(this.lblDatabases);
            this.gbxBackup.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBackup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxBackup.Location = new System.Drawing.Point(7, 145);
            this.gbxBackup.Name = "gbxBackup";
            this.gbxBackup.Size = new System.Drawing.Size(270, 151);
            this.gbxBackup.TabIndex = 1;
            this.gbxBackup.TabStop = false;
            this.gbxBackup.Text = "Setting";
            // 
            // btndatabaseForUse
            // 
            this.btndatabaseForUse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndatabaseForUse.Location = new System.Drawing.Point(120, 97);
            this.btndatabaseForUse.Name = "btndatabaseForUse";
            this.btndatabaseForUse.Size = new System.Drawing.Size(140, 23);
            this.btndatabaseForUse.TabIndex = 3;
            this.btndatabaseForUse.Text = "Database for use...";
            this.btndatabaseForUse.UseVisualStyleBackColor = true;
            this.btndatabaseForUse.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateBackup.Location = new System.Drawing.Point(120, 68);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(140, 23);
            this.btnCreateBackup.TabIndex = 2;
            this.btnCreateBackup.Text = "Create backup";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDatabase.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDatabase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Location = new System.Drawing.Point(6, 41);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(254, 20);
            this.cbxDatabase.TabIndex = 1;
            // 
            // lblDatabases
            // 
            this.lblDatabases.AutoSize = true;
            this.lblDatabases.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatabases.Location = new System.Drawing.Point(5, 25);
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.Size = new System.Drawing.Size(110, 13);
            this.lblDatabases.TabIndex = 0;
            this.lblDatabases.Text = "select database";
            // 
            // openBackupDialog
            // 
            this.openBackupDialog.FileName = "openFileDialog1";
            // 
            // BackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 298);
            this.Controls.Add(this.gbxBackup);
            this.Controls.Add(this.gbxSetting);
            this.Name = "BackupDatabase";
            this.Text = "Database Setting & Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.gbxSetting.ResumeLayout(false);
            this.gbxSetting.PerformLayout();
            this.gbxBackup.ResumeLayout(false);
            this.gbxBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSetting;
        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbxBackup;
        private System.Windows.Forms.Button btndatabaseForUse;
        private System.Windows.Forms.Button btnCreateBackup;
        private System.Windows.Forms.ComboBox cbxDatabase;
        private System.Windows.Forms.Label lblDatabases;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.OpenFileDialog openBackupDialog;
        private System.Windows.Forms.SaveFileDialog saveBackupDialog;
    }
}