namespace MasterCeramicsERP
{
    partial class frmRawMaterialReportShow
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
            this.txtUnitRate = new System.Windows.Forms.TextBox();
            this.lblUnitRate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.rawmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpMold = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxRawMaterialReport = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.lblCurrencyUnit = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.chkbxDeduct = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxRawMaterialReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnitRate
            // 
            this.txtUnitRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnitRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitRate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtUnitRate.Location = new System.Drawing.Point(91, 15);
            this.txtUnitRate.Name = "txtUnitRate";
            this.txtUnitRate.Size = new System.Drawing.Size(200, 21);
            this.txtUnitRate.TabIndex = 1;
            this.txtUnitRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUnitRate_MouseClick);
            this.txtUnitRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitRate_KeyPress);
            // 
            // lblUnitRate
            // 
            this.lblUnitRate.AutoSize = true;
            this.lblUnitRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitRate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUnitRate.Location = new System.Drawing.Point(12, 18);
            this.lblUnitRate.Name = "lblUnitRate";
            this.lblUnitRate.Size = new System.Drawing.Size(66, 13);
            this.lblUnitRate.TabIndex = 0;
            this.lblUnitRate.Text = "Unit Rate";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtQuantity.Location = new System.Drawing.Point(91, 41);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 21);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblQuantity.Location = new System.Drawing.Point(12, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDelete.Location = new System.Drawing.Point(216, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefresh.Location = new System.Drawing.Point(676, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawmaterial,
            this.Vendor,
            this.unitRate,
            this.quantity,
            this.amount,
            this.date});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvReport.Location = new System.Drawing.Point(3, 14);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(772, 368);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // rawmaterial
            // 
            this.rawmaterial.HeaderText = "Raw Material";
            this.rawmaterial.Name = "rawmaterial";
            this.rawmaterial.ReadOnly = true;
            this.rawmaterial.Width = 150;
            // 
            // Vendor
            // 
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            this.Vendor.Width = 150;
            // 
            // unitRate
            // 
            this.unitRate.HeaderText = "Unit Rate";
            this.unitRate.Name = "unitRate";
            this.unitRate.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 128;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbtnMonth.Location = new System.Drawing.Point(572, 76);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 7;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbtnDay.Location = new System.Drawing.Point(572, 47);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 6;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnShow.Location = new System.Drawing.Point(676, 44);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 23);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblDate.Location = new System.Drawing.Point(483, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Select Date";
            // 
            // dtpMold
            // 
            this.dtpMold.CalendarForeColor = System.Drawing.Color.Olive;
            this.dtpMold.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpMold.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpMold.CalendarTrailingForeColor = System.Drawing.Color.Olive;
            this.dtpMold.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMold.Location = new System.Drawing.Point(572, 12);
            this.dtpMold.Name = "dtpMold";
            this.dtpMold.Size = new System.Drawing.Size(200, 21);
            this.dtpMold.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.Location = new System.Drawing.Point(91, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxRawMaterialReport
            // 
            this.gbxRawMaterialReport.Controls.Add(this.dgvReport);
            this.gbxRawMaterialReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRawMaterialReport.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.gbxRawMaterialReport.Location = new System.Drawing.Point(5, 131);
            this.gbxRawMaterialReport.Name = "gbxRawMaterialReport";
            this.gbxRawMaterialReport.Size = new System.Drawing.Size(778, 385);
            this.gbxRawMaterialReport.TabIndex = 13;
            this.gbxRawMaterialReport.TabStop = false;
            this.gbxRawMaterialReport.Text = "Raw Material Report";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrintReport.Location = new System.Drawing.Point(676, 73);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(96, 23);
            this.btnPrintReport.TabIndex = 12;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // txtVendor
            // 
            this.txtVendor.BackColor = System.Drawing.SystemColors.Control;
            this.txtVendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtVendor.Location = new System.Drawing.Point(91, 69);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(200, 21);
            this.txtVendor.TabIndex = 15;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblVendor.Location = new System.Drawing.Point(12, 72);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(53, 13);
            this.lblVendor.TabIndex = 14;
            this.lblVendor.Text = "Vendor";
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbtnYear.Location = new System.Drawing.Point(572, 105);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 16;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // lblCurrencyUnit
            // 
            this.lblCurrencyUnit.AutoSize = true;
            this.lblCurrencyUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyUnit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCurrencyUnit.Location = new System.Drawing.Point(297, 18);
            this.lblCurrencyUnit.Name = "lblCurrencyUnit";
            this.lblCurrencyUnit.Size = new System.Drawing.Size(26, 13);
            this.lblCurrencyUnit.TabIndex = 18;
            this.lblCurrencyUnit.Text = "Rs.";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUnit.Location = new System.Drawing.Point(297, 44);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(27, 13);
            this.lblUnit.TabIndex = 17;
            this.lblUnit.Text = "Kg.";
            // 
            // chkbxDeduct
            // 
            this.chkbxDeduct.AutoSize = true;
            this.chkbxDeduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDeduct.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkbxDeduct.Location = new System.Drawing.Point(300, 106);
            this.chkbxDeduct.Name = "chkbxDeduct";
            this.chkbxDeduct.Size = new System.Drawing.Size(196, 17);
            this.chkbxDeduct.TabIndex = 19;
            this.chkbxDeduct.Text = "Deduct From Raw Material";
            this.chkbxDeduct.UseVisualStyleBackColor = true;
            // 
            // frmRawMaterialReportShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.chkbxDeduct);
            this.Controls.Add(this.lblCurrencyUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.gbxRawMaterialReport);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpMold);
            this.Controls.Add(this.txtUnitRate);
            this.Controls.Add(this.lblUnitRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmRawMaterialReportShow";
            this.Text = "Update Raw Material Purchase Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxRawMaterialReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnitRate;
        private System.Windows.Forms.Label lblUnitRate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpMold;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxRawMaterialReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.Label lblCurrencyUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.CheckBox chkbxDeduct;
    }
}