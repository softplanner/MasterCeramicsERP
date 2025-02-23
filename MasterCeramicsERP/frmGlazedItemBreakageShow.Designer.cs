namespace MasterCeramicsERP
{
    partial class frmGlazedItemBreakageShow
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
            this.txtGlazedItemInStock = new System.Windows.Forms.TextBox();
            this.lblGlazedStockAvailable = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtSprayMans = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.txtSprayMan = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.chkbxUpdate = new System.Windows.Forms.CheckBox();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.dgvBreakage = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpGlazeHouse = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbxReport = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakage)).BeginInit();
            this.gbxReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUpdate.Controls.Add(this.txtGlazedItemInStock);
            this.gbxUpdate.Controls.Add(this.lblGlazedStockAvailable);
            this.gbxUpdate.Controls.Add(this.txtSize);
            this.gbxUpdate.Controls.Add(this.txtDate);
            this.gbxUpdate.Controls.Add(this.txtRemarks);
            this.gbxUpdate.Controls.Add(this.txtStyle);
            this.gbxUpdate.Controls.Add(this.txtColor);
            this.gbxUpdate.Controls.Add(this.txtSprayMans);
            this.gbxUpdate.Controls.Add(this.txtItem);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.txtSprayMan);
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtQuantity);
            this.gbxUpdate.Controls.Add(this.lblRemarks);
            this.gbxUpdate.Controls.Add(this.lblDateUpdate);
            this.gbxUpdate.Controls.Add(this.lblItem);
            this.gbxUpdate.Controls.Add(this.lblColor);
            this.gbxUpdate.Controls.Add(this.lblStyle);
            this.gbxUpdate.Controls.Add(this.lblSize);
            this.gbxUpdate.Controls.Add(this.lblQuantity);
            this.gbxUpdate.Controls.Add(this.txtUpdateQuantity);
            this.gbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxUpdate.Location = new System.Drawing.Point(5, 7);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(552, 240);
            this.gbxUpdate.TabIndex = 0;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // txtGlazedItemInStock
            // 
            this.txtGlazedItemInStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlazedItemInStock.Location = new System.Drawing.Point(392, 44);
            this.txtGlazedItemInStock.Name = "txtGlazedItemInStock";
            this.txtGlazedItemInStock.Size = new System.Drawing.Size(141, 21);
            this.txtGlazedItemInStock.TabIndex = 21;
            // 
            // lblGlazedStockAvailable
            // 
            this.lblGlazedStockAvailable.AutoSize = true;
            this.lblGlazedStockAvailable.ForeColor = System.Drawing.Color.Crimson;
            this.lblGlazedStockAvailable.Location = new System.Drawing.Point(389, 23);
            this.lblGlazedStockAvailable.Name = "lblGlazedStockAvailable";
            this.lblGlazedStockAvailable.Size = new System.Drawing.Size(144, 13);
            this.lblGlazedStockAvailable.TabIndex = 20;
            this.lblGlazedStockAvailable.Text = "Glazed Item In Stock";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(181, 92);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(205, 21);
            this.txtSize.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(181, 164);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(205, 21);
            this.txtDate.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Location = new System.Drawing.Point(181, 140);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(205, 21);
            this.txtRemarks.TabIndex = 11;
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtStyle.Enabled = false;
            this.txtStyle.Location = new System.Drawing.Point(181, 68);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(205, 21);
            this.txtStyle.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(181, 116);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(205, 21);
            this.txtColor.TabIndex = 9;
            // 
            // txtSprayMans
            // 
            this.txtSprayMans.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSprayMans.Enabled = false;
            this.txtSprayMans.Location = new System.Drawing.Point(181, 20);
            this.txtSprayMans.Name = "txtSprayMans";
            this.txtSprayMans.Size = new System.Drawing.Size(205, 21);
            this.txtSprayMans.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(181, 44);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(205, 21);
            this.txtItem.TabIndex = 3;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(11, 219);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(157, 13);
            this.lblUpdateQuantity.TabIndex = 16;
            this.lblUpdateQuantity.Text = "Enter updated quantity";
            // 
            // txtSprayMan
            // 
            this.txtSprayMan.AutoSize = true;
            this.txtSprayMan.Location = new System.Drawing.Point(11, 23);
            this.txtSprayMan.Name = "txtSprayMan";
            this.txtSprayMan.Size = new System.Drawing.Size(49, 13);
            this.txtSprayMan.TabIndex = 0;
            this.txtSprayMan.Text = "Glazer";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(471, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(388, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(181, 188);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(205, 21);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(11, 143);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.Location = new System.Drawing.Point(11, 167);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(37, 13);
            this.lblDateUpdate.TabIndex = 12;
            this.lblDateUpdate.Text = "Date";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(11, 47);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(11, 119);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(11, 70);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 4;
            this.lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(11, 95);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(11, 191);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateQuantity.Location = new System.Drawing.Point(181, 212);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(205, 21);
            this.txtUpdateQuantity.TabIndex = 17;
            this.txtUpdateQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdateQuantity_MouseClick);
            this.txtUpdateQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateQuantity_KeyPress);
            // 
            // chkbxUpdate
            // 
            this.chkbxUpdate.AutoSize = true;
            this.chkbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUpdate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkbxUpdate.Location = new System.Drawing.Point(563, 230);
            this.chkbxUpdate.Name = "chkbxUpdate";
            this.chkbxUpdate.Size = new System.Drawing.Size(132, 17);
            this.chkbxUpdate.TabIndex = 7;
            this.chkbxUpdate.Text = "Enable Updation";
            this.chkbxUpdate.UseVisualStyleBackColor = true;
            this.chkbxUpdate.CheckedChanged += new System.EventHandler(this.chkbxUpdate_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbtnMonth.Location = new System.Drawing.Point(571, 80);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 4;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbtnDay.Location = new System.Drawing.Point(571, 57);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 3;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // dgvBreakage
            // 
            this.dgvBreakage.AllowUserToAddRows = false;
            this.dgvBreakage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBreakage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBreakage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBreakage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colors,
            this.dataGridViewTextBoxColumn4,
            this.remarks,
            this.date});
            this.dgvBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBreakage.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvBreakage.Location = new System.Drawing.Point(3, 14);
            this.dgvBreakage.Name = "dgvBreakage";
            this.dgvBreakage.ReadOnly = true;
            this.dgvBreakage.Size = new System.Drawing.Size(768, 249);
            this.dgvBreakage.TabIndex = 0;
            this.dgvBreakage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBreakage_CellClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblDate.Location = new System.Drawing.Point(568, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Select Date";
            // 
            // dtpGlazeHouse
            // 
            this.dtpGlazeHouse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGlazeHouse.Location = new System.Drawing.Point(568, 30);
            this.dtpGlazeHouse.Name = "dtpGlazeHouse";
            this.dtpGlazeHouse.Size = new System.Drawing.Size(200, 21);
            this.dtpGlazeHouse.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnShow.Location = new System.Drawing.Point(668, 121);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbxReport
            // 
            this.gbxReport.Controls.Add(this.dgvBreakage);
            this.gbxReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReport.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxReport.Location = new System.Drawing.Point(5, 251);
            this.gbxReport.Name = "gbxReport";
            this.gbxReport.Size = new System.Drawing.Size(774, 266);
            this.gbxReport.TabIndex = 8;
            this.gbxReport.TabStop = false;
            this.gbxReport.Text = "Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnPrint.Location = new System.Drawing.Point(668, 150);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbtnYear.Location = new System.Drawing.Point(571, 103);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 9;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.HeaderText = "Glazer";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Style";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // colors
            // 
            this.colors.HeaderText = "Color";
            this.colors.Name = "colors";
            this.colors.ReadOnly = true;
            this.colors.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
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
            // frmGlazedItemBreakageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbxReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.chkbxUpdate);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpGlazeHouse);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmGlazedItemBreakageShow";
            this.Text = "Update Glazed Item Breakage Report";
            this.Load += new System.EventHandler(this.frmGlazedItemBreakageShow_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakage)).EndInit();
            this.gbxReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDateUpdate;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.CheckBox chkbxUpdate;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.DataGridView dgvBreakage;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpGlazeHouse;
        private System.Windows.Forms.Label txtSprayMan;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtSprayMans;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox gbxReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblGlazedStockAvailable;
        private System.Windows.Forms.TextBox txtGlazedItemInStock;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;

    }
}