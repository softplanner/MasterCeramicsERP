namespace MasterCeramicsERP
{
    partial class frmMoldIssueRecordShow
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
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.dtpGlazeHouse = new System.Windows.Forms.DateTimePicker();
            this.chkbxUpdate = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtCaster = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCaster = new System.Windows.Forms.Label();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbxMoldIssueRecord = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.gbxMoldIssueRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSize.Enabled = false;
            this.txtSize.ForeColor = System.Drawing.Color.Navy;
            this.txtSize.Location = new System.Drawing.Point(168, 97);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(220, 21);
            this.txtSize.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDate.Enabled = false;
            this.txtDate.ForeColor = System.Drawing.Color.Navy;
            this.txtDate.Location = new System.Drawing.Point(168, 122);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(220, 21);
            this.txtDate.TabIndex = 9;
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtStyle.Enabled = false;
            this.txtStyle.ForeColor = System.Drawing.Color.Navy;
            this.txtStyle.Location = new System.Drawing.Point(168, 72);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.ReadOnly = true;
            this.txtStyle.Size = new System.Drawing.Size(220, 21);
            this.txtStyle.TabIndex = 5;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtItem.Enabled = false;
            this.txtItem.ForeColor = System.Drawing.Color.Navy;
            this.txtItem.Location = new System.Drawing.Point(168, 47);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(220, 21);
            this.txtItem.TabIndex = 3;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(5, 175);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(157, 13);
            this.lblUpdateQuantity.TabIndex = 12;
            this.lblUpdateQuantity.Text = "Enter updated quantity";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.item_chk,
            this.style_chk,
            this.size_chk,
            this.Quantity,
            this.date});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.Navy;
            this.dgvReport.Location = new System.Drawing.Point(3, 17);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(778, 276);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.Navy;
            this.rbtnMonth.Location = new System.Drawing.Point(578, 92);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 4;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDate.Location = new System.Drawing.Point(578, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Select Date";
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.Navy;
            this.rbtnDay.Location = new System.Drawing.Point(578, 69);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 3;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // dtpGlazeHouse
            // 
            this.dtpGlazeHouse.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpGlazeHouse.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dtpGlazeHouse.CalendarTrailingForeColor = System.Drawing.Color.Navy;
            this.dtpGlazeHouse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGlazeHouse.Location = new System.Drawing.Point(578, 37);
            this.dtpGlazeHouse.Name = "dtpGlazeHouse";
            this.dtpGlazeHouse.Size = new System.Drawing.Size(200, 21);
            this.dtpGlazeHouse.TabIndex = 2;
            // 
            // chkbxUpdate
            // 
            this.chkbxUpdate.AutoSize = true;
            this.chkbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUpdate.ForeColor = System.Drawing.Color.Navy;
            this.chkbxUpdate.Location = new System.Drawing.Point(563, 201);
            this.chkbxUpdate.Name = "chkbxUpdate";
            this.chkbxUpdate.Size = new System.Drawing.Size(132, 17);
            this.chkbxUpdate.TabIndex = 7;
            this.chkbxUpdate.Text = "Enable Updation";
            this.chkbxUpdate.UseVisualStyleBackColor = true;
            this.chkbxUpdate.CheckedChanged += new System.EventHandler(this.chkbxUpdate_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(477, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUpdate.Controls.Add(this.txtSize);
            this.gbxUpdate.Controls.Add(this.txtDate);
            this.gbxUpdate.Controls.Add(this.txtStyle);
            this.gbxUpdate.Controls.Add(this.txtItem);
            this.gbxUpdate.Controls.Add(this.txtCaster);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtQuantity);
            this.gbxUpdate.Controls.Add(this.lblDateUpdate);
            this.gbxUpdate.Controls.Add(this.lblItem);
            this.gbxUpdate.Controls.Add(this.lblStyle);
            this.gbxUpdate.Controls.Add(this.lblSize);
            this.gbxUpdate.Controls.Add(this.lblQuantity);
            this.gbxUpdate.Controls.Add(this.lblCaster);
            this.gbxUpdate.Controls.Add(this.txtUpdateQuantity);
            this.gbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.Location = new System.Drawing.Point(1, 9);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(558, 206);
            this.gbxUpdate.TabIndex = 0;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // txtCaster
            // 
            this.txtCaster.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCaster.Enabled = false;
            this.txtCaster.ForeColor = System.Drawing.Color.Navy;
            this.txtCaster.Location = new System.Drawing.Point(168, 22);
            this.txtCaster.Name = "txtCaster";
            this.txtCaster.ReadOnly = true;
            this.txtCaster.Size = new System.Drawing.Size(220, 21);
            this.txtCaster.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Location = new System.Drawing.Point(394, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtQuantity.Location = new System.Drawing.Point(168, 147);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(220, 21);
            this.txtQuantity.TabIndex = 11;
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.ForeColor = System.Drawing.Color.Navy;
            this.lblDateUpdate.Location = new System.Drawing.Point(5, 125);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(37, 13);
            this.lblDateUpdate.TabIndex = 8;
            this.lblDateUpdate.Text = "Date";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.Navy;
            this.lblItem.Location = new System.Drawing.Point(5, 50);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.Navy;
            this.lblStyle.Location = new System.Drawing.Point(5, 75);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 4;
            this.lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.Navy;
            this.lblSize.Location = new System.Drawing.Point(5, 100);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblQuantity.Location = new System.Drawing.Point(5, 150);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCaster
            // 
            this.lblCaster.AutoSize = true;
            this.lblCaster.ForeColor = System.Drawing.Color.Navy;
            this.lblCaster.Location = new System.Drawing.Point(5, 24);
            this.lblCaster.Name = "lblCaster";
            this.lblCaster.Size = new System.Drawing.Size(49, 13);
            this.lblCaster.TabIndex = 0;
            this.lblCaster.Text = "Caster";
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtUpdateQuantity.Location = new System.Drawing.Point(168, 172);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(220, 21);
            this.txtUpdateQuantity.TabIndex = 13;
            this.txtUpdateQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdateQuantity_MouseClick);
            this.txtUpdateQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateQuantity_KeyPress);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Navy;
            this.btnShow.Location = new System.Drawing.Point(686, 134);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbxMoldIssueRecord
            // 
            this.gbxMoldIssueRecord.Controls.Add(this.dgvReport);
            this.gbxMoldIssueRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldIssueRecord.ForeColor = System.Drawing.Color.Navy;
            this.gbxMoldIssueRecord.Location = new System.Drawing.Point(1, 221);
            this.gbxMoldIssueRecord.Name = "gbxMoldIssueRecord";
            this.gbxMoldIssueRecord.Size = new System.Drawing.Size(784, 296);
            this.gbxMoldIssueRecord.TabIndex = 8;
            this.gbxMoldIssueRecord.TabStop = false;
            this.gbxMoldIssueRecord.Text = "Mold Issue Record";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.Location = new System.Drawing.Point(686, 163);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.Navy;
            this.rbtnYear.Location = new System.Drawing.Point(578, 115);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 9;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.HeaderText = "Caster ";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // item_chk
            // 
            this.item_chk.HeaderText = "Item";
            this.item_chk.Name = "item_chk";
            this.item_chk.ReadOnly = true;
            this.item_chk.Width = 130;
            // 
            // style_chk
            // 
            this.style_chk.HeaderText = "Style";
            this.style_chk.Name = "style_chk";
            this.style_chk.ReadOnly = true;
            this.style_chk.Width = 130;
            // 
            // size_chk
            // 
            this.size_chk.HeaderText = "Size";
            this.size_chk.Name = "size_chk";
            this.size_chk.ReadOnly = true;
            this.size_chk.Width = 130;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity ";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // frmMoldIssueRecordShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbxMoldIssueRecord);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.dtpGlazeHouse);
            this.Controls.Add(this.chkbxUpdate);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.btnShow);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMoldIssueRecordShow";
            this.Text = "Update Mold Issued Report";
            this.Load += new System.EventHandler(this.frmMoldIssueRecordShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxMoldIssueRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.DateTimePicker dtpGlazeHouse;
        private System.Windows.Forms.CheckBox chkbxUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDateUpdate;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtCaster;
        private System.Windows.Forms.Label lblCaster;
        private System.Windows.Forms.GroupBox gbxMoldIssueRecord;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn style_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}