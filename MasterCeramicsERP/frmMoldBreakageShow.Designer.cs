namespace MasterCeramicsERP
{
    partial class frmMoldBreakageShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtCaster = new System.Windows.Forms.TextBox();
            this.lblCaster = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpGlazeHouse = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.chkbxUpdate = new System.Windows.Forms.CheckBox();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.dgvBreakage = new System.Windows.Forms.DataGridView();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.gbxMoldBreakageReport = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.casterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakage)).BeginInit();
            this.gbxMoldBreakageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUpdate.Controls.Add(this.txtCaster);
            this.gbxUpdate.Controls.Add(this.lblCaster);
            this.gbxUpdate.Controls.Add(this.txtSize);
            this.gbxUpdate.Controls.Add(this.txtDate);
            this.gbxUpdate.Controls.Add(this.txtRemarks);
            this.gbxUpdate.Controls.Add(this.txtStyle);
            this.gbxUpdate.Controls.Add(this.txtItem);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtQuantity);
            this.gbxUpdate.Controls.Add(this.lblRemarks);
            this.gbxUpdate.Controls.Add(this.lblDateUpdate);
            this.gbxUpdate.Controls.Add(this.lblItem);
            this.gbxUpdate.Controls.Add(this.lblStyle);
            this.gbxUpdate.Controls.Add(this.lblSize);
            this.gbxUpdate.Controls.Add(this.lblQuantity);
            this.gbxUpdate.Controls.Add(this.txtUpdateQuantity);
            this.gbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.Navy;
            this.gbxUpdate.Location = new System.Drawing.Point(1, 8);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(568, 244);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // txtCaster
            // 
            this.txtCaster.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCaster.Enabled = false;
            this.txtCaster.ForeColor = System.Drawing.Color.Navy;
            this.txtCaster.Location = new System.Drawing.Point(189, 17);
            this.txtCaster.Name = "txtCaster";
            this.txtCaster.ReadOnly = true;
            this.txtCaster.Size = new System.Drawing.Size(198, 21);
            this.txtCaster.TabIndex = 1;
            // 
            // lblCaster
            // 
            this.lblCaster.AutoSize = true;
            this.lblCaster.ForeColor = System.Drawing.Color.Navy;
            this.lblCaster.Location = new System.Drawing.Point(11, 20);
            this.lblCaster.Name = "lblCaster";
            this.lblCaster.Size = new System.Drawing.Size(59, 13);
            this.lblCaster.TabIndex = 0;
            this.lblCaster.Text = "Breaker";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSize.Enabled = false;
            this.txtSize.ForeColor = System.Drawing.Color.Navy;
            this.txtSize.Location = new System.Drawing.Point(189, 94);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(198, 21);
            this.txtSize.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDate.Enabled = false;
            this.txtDate.ForeColor = System.Drawing.Color.Navy;
            this.txtDate.Location = new System.Drawing.Point(189, 144);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(198, 21);
            this.txtDate.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtRemarks.Enabled = false;
            this.txtRemarks.ForeColor = System.Drawing.Color.Navy;
            this.txtRemarks.Location = new System.Drawing.Point(189, 119);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(198, 21);
            this.txtRemarks.TabIndex = 11;
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtStyle.Enabled = false;
            this.txtStyle.ForeColor = System.Drawing.Color.Navy;
            this.txtStyle.Location = new System.Drawing.Point(189, 69);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.ReadOnly = true;
            this.txtStyle.Size = new System.Drawing.Size(198, 21);
            this.txtStyle.TabIndex = 7;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtItem.Enabled = false;
            this.txtItem.ForeColor = System.Drawing.Color.Navy;
            this.txtItem.Location = new System.Drawing.Point(189, 44);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(198, 21);
            this.txtItem.TabIndex = 5;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(11, 199);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(157, 13);
            this.lblUpdateQuantity.TabIndex = 16;
            this.lblUpdateQuantity.Text = "Enter updated quantity";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(487, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Location = new System.Drawing.Point(391, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtQuantity.Location = new System.Drawing.Point(189, 169);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(198, 21);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.Navy;
            this.lblRemarks.Location = new System.Drawing.Point(11, 122);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.ForeColor = System.Drawing.Color.Navy;
            this.lblDateUpdate.Location = new System.Drawing.Point(11, 147);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(37, 13);
            this.lblDateUpdate.TabIndex = 12;
            this.lblDateUpdate.Text = "Date";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.Navy;
            this.lblItem.Location = new System.Drawing.Point(11, 47);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.Navy;
            this.lblStyle.Location = new System.Drawing.Point(11, 72);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 6;
            this.lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.Navy;
            this.lblSize.Location = new System.Drawing.Point(11, 97);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblQuantity.Location = new System.Drawing.Point(11, 172);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtUpdateQuantity.Location = new System.Drawing.Point(189, 196);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(198, 21);
            this.txtUpdateQuantity.TabIndex = 17;
            this.txtUpdateQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdateQuantity_MouseClick);
            this.txtUpdateQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateQuantity_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDate.Location = new System.Drawing.Point(580, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Select Date";
            // 
            // dtpGlazeHouse
            // 
            this.dtpGlazeHouse.CalendarForeColor = System.Drawing.Color.DarkOliveGreen;
            this.dtpGlazeHouse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGlazeHouse.Location = new System.Drawing.Point(576, 32);
            this.dtpGlazeHouse.Name = "dtpGlazeHouse";
            this.dtpGlazeHouse.Size = new System.Drawing.Size(200, 21);
            this.dtpGlazeHouse.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Navy;
            this.btnShow.Location = new System.Drawing.Point(679, 118);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chkbxUpdate
            // 
            this.chkbxUpdate.AutoSize = true;
            this.chkbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUpdate.ForeColor = System.Drawing.Color.Navy;
            this.chkbxUpdate.Location = new System.Drawing.Point(574, 229);
            this.chkbxUpdate.Name = "chkbxUpdate";
            this.chkbxUpdate.Size = new System.Drawing.Size(132, 17);
            this.chkbxUpdate.TabIndex = 8;
            this.chkbxUpdate.Text = "Enable Updation";
            this.chkbxUpdate.UseVisualStyleBackColor = true;
            this.chkbxUpdate.CheckedChanged += new System.EventHandler(this.chkbxUpdate_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.Navy;
            this.rbtnMonth.Location = new System.Drawing.Point(580, 87);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 5;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // dgvBreakage
            // 
            this.dgvBreakage.AllowUserToAddRows = false;
            this.dgvBreakage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBreakage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBreakage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBreakage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.casterName,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.remarks,
            this.date});
            this.dgvBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBreakage.GridColor = System.Drawing.Color.Navy;
            this.dgvBreakage.Location = new System.Drawing.Point(3, 14);
            this.dgvBreakage.Name = "dgvBreakage";
            this.dgvBreakage.ReadOnly = true;
            this.dgvBreakage.Size = new System.Drawing.Size(769, 236);
            this.dgvBreakage.TabIndex = 0;
            this.dgvBreakage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBreakage_CellClick);
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.Navy;
            this.rbtnDay.Location = new System.Drawing.Point(580, 64);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 4;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // gbxMoldBreakageReport
            // 
            this.gbxMoldBreakageReport.Controls.Add(this.dgvBreakage);
            this.gbxMoldBreakageReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldBreakageReport.ForeColor = System.Drawing.Color.Navy;
            this.gbxMoldBreakageReport.Location = new System.Drawing.Point(4, 259);
            this.gbxMoldBreakageReport.Name = "gbxMoldBreakageReport";
            this.gbxMoldBreakageReport.Size = new System.Drawing.Size(775, 253);
            this.gbxMoldBreakageReport.TabIndex = 0;
            this.gbxMoldBreakageReport.TabStop = false;
            this.gbxMoldBreakageReport.Text = "Mold Breakage Report";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.Location = new System.Drawing.Point(679, 155);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.Navy;
            this.rbtnYear.Location = new System.Drawing.Point(580, 110);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 9;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // casterName
            // 
            this.casterName.HeaderText = "Breaker";
            this.casterName.Name = "casterName";
            this.casterName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Style";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // remarks
            // 
            this.remarks.HeaderText = "Remarks";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // frmMoldBreakageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbxMoldBreakageReport);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpGlazeHouse);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkbxUpdate);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMoldBreakageShow";
            this.Text = "Update Mold Breakage Report";
            this.Load += new System.EventHandler(this.frmMoldBreakageShow_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakage)).EndInit();
            this.gbxMoldBreakageReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDateUpdate;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpGlazeHouse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox chkbxUpdate;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.DataGridView dgvBreakage;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.TextBox txtCaster;
        private System.Windows.Forms.Label lblCaster;
        private System.Windows.Forms.GroupBox gbxMoldBreakageReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}