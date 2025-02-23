namespace MasterCeramicsERP
{
    partial class frmAlarmAboutRawStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlarmAboutRawStock));
            this.dgvAlarm = new System.Windows.Forms.DataGridView();
            this.gbxAlarm = new System.Windows.Forms.GroupBox();
            this.rawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompanyNames = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblSlogans = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pbxMono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).BeginInit();
            this.gbxAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlarm
            // 
            this.dgvAlarm.AllowUserToAddRows = false;
            this.dgvAlarm.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawMaterial,
            this.stock,
            this.alarm});
            this.dgvAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarm.Location = new System.Drawing.Point(3, 17);
            this.dgvAlarm.Name = "dgvAlarm";
            this.dgvAlarm.Size = new System.Drawing.Size(769, 394);
            this.dgvAlarm.TabIndex = 0;
            // 
            // gbxAlarm
            // 
            this.gbxAlarm.Controls.Add(this.dgvAlarm);
            this.gbxAlarm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAlarm.Location = new System.Drawing.Point(5, 100);
            this.gbxAlarm.Name = "gbxAlarm";
            this.gbxAlarm.Size = new System.Drawing.Size(775, 414);
            this.gbxAlarm.TabIndex = 2;
            this.gbxAlarm.TabStop = false;
            this.gbxAlarm.Text = "List of the raw material\'s which are found to be shorter in stock.";
            // 
            // rawMaterial
            // 
            this.rawMaterial.HeaderText = "Raw Material";
            this.rawMaterial.Name = "rawMaterial";
            this.rawMaterial.ReadOnly = true;
            this.rawMaterial.Width = 270;
            // 
            // stock
            // 
            this.stock.HeaderText = "Available in stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 270;
            // 
            // alarm
            // 
            this.alarm.HeaderText = "Alarm Quantity";
            this.alarm.Name = "alarm";
            this.alarm.ReadOnly = true;
            this.alarm.Width = 200;
            // 
            // lblCompanyNames
            // 
            this.lblCompanyNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCompanyNames.AutoSize = true;
            this.lblCompanyNames.BackColor = System.Drawing.SystemColors.Control;
            this.lblCompanyNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyNames.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCompanyNames.Location = new System.Drawing.Point(106, 62);
            this.lblCompanyNames.Name = "lblCompanyNames";
            this.lblCompanyNames.Size = new System.Drawing.Size(114, 19);
            this.lblCompanyNames.TabIndex = 66;
            this.lblCompanyNames.Text = "Sanitary Ware";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.SystemColors.Control;
            this.lblCompanyName.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCompanyName.Location = new System.Drawing.Point(102, 22);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(127, 40);
            this.lblCompanyName.TabIndex = 65;
            this.lblCompanyName.Text = "Master";
            // 
            // lblSlogans
            // 
            this.lblSlogans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSlogans.AutoSize = true;
            this.lblSlogans.BackColor = System.Drawing.SystemColors.Control;
            this.lblSlogans.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogans.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSlogans.Location = new System.Drawing.Point(678, 88);
            this.lblSlogans.Name = "lblSlogans";
            this.lblSlogans.Size = new System.Drawing.Size(94, 13);
            this.lblSlogans.TabIndex = 64;
            this.lblSlogans.Text = "there is Master...";
            // 
            // lblSlogan
            // 
            this.lblSlogan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.SystemColors.Control;
            this.lblSlogan.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSlogan.Location = new System.Drawing.Point(597, 69);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(114, 13);
            this.lblSlogan.TabIndex = 63;
            this.lblSlogan.Text = "Where is your home";
            // 
            // pbxMono
            // 
            this.pbxMono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxMono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMono.BackgroundImage")));
            this.pbxMono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMono.Location = new System.Drawing.Point(12, 10);
            this.pbxMono.Name = "pbxMono";
            this.pbxMono.Size = new System.Drawing.Size(84, 84);
            this.pbxMono.TabIndex = 62;
            this.pbxMono.TabStop = false;
            // 
            // frmAlarmAboutRawStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblSlogans);
            this.Controls.Add(this.lblCompanyNames);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.gbxAlarm);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pbxMono);
            this.Name = "frmAlarmAboutRawStock";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.frmAlarmAboutRawStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).EndInit();
            this.gbxAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarm;
        private System.Windows.Forms.GroupBox gbxAlarm;
        private System.Windows.Forms.Label lblCompanyNames;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblSlogans;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.PictureBox pbxMono;
    }
}