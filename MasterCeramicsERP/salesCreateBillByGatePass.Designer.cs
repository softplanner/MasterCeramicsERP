namespace MasterCeramicsERP
{
    partial class salesCreateBillByGatePass
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
            this.ColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprintReport = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.gbxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.dtpAttendence = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvViewBy = new System.Windows.Forms.DataGridView();
            this.vDealerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vVehicleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblShop = new System.Windows.Forms.Label();
            this.txtShop = new System.Windows.Forms.TextBox();
            this.gbxCustomerOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorID
            // 
            this.ColorID.DataPropertyName = "ColorID";
            this.ColorID.HeaderText = "ColorID";
            this.ColorID.Name = "ColorID";
            this.ColorID.ReadOnly = true;
            this.ColorID.Visible = false;
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(227, 37);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(143, 21);
            this.cbxSelectJob.TabIndex = 94;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSelectJob.Location = new System.Drawing.Point(227, 14);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(33, 13);
            this.lblSelectJob.TabIndex = 93;
            this.lblSelectJob.Text = "Job ";
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(376, 37);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(143, 21);
            this.cbxWorker.TabIndex = 92;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblWorker.Location = new System.Drawing.Point(373, 14);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(50, 13);
            this.lblWorker.TabIndex = 91;
            this.lblWorker.Text = "Dealer";
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // btnprintReport
            // 
            this.btnprintReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintReport.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnprintReport.Location = new System.Drawing.Point(652, 37);
            this.btnprintReport.Name = "btnprintReport";
            this.btnprintReport.Size = new System.Drawing.Size(122, 21);
            this.btnprintReport.TabIndex = 90;
            this.btnprintReport.Text = "Print Gate Pass Bill";
            this.btnprintReport.UseVisualStyleBackColor = true;
            this.btnprintReport.Click += new System.EventHandler(this.btnprintReport_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnShow.Location = new System.Drawing.Point(524, 37);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(122, 21);
            this.btnShow.TabIndex = 88;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // SizeID
            // 
            this.SizeID.DataPropertyName = "SizeID";
            this.SizeID.HeaderText = "SizeID";
            this.SizeID.Name = "SizeID";
            this.SizeID.ReadOnly = true;
            this.SizeID.Visible = false;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rbtnYear.Location = new System.Drawing.Point(166, 41);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 86;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // gbxCustomerOrder
            // 
            this.gbxCustomerOrder.Controls.Add(this.dgvOrderInfo);
            this.gbxCustomerOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerOrder.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxCustomerOrder.Location = new System.Drawing.Point(10, 237);
            this.gbxCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Name = "gbxCustomerOrder";
            this.gbxCustomerOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Size = new System.Drawing.Size(764, 268);
            this.gbxCustomerOrder.TabIndex = 87;
            this.gbxCustomerOrder.TabStop = false;
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Style,
            this.Size,
            this.Color,
            this.Category,
            this.Quantity,
            this.BillNo,
            this.VehicleDescription,
            this.Date,
            this.ItemID,
            this.StyleID,
            this.SizeID,
            this.ColorID,
            this.CategoryID});
            this.dgvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderInfo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrderInfo.Location = new System.Drawing.Point(4, 14);
            this.dgvOrderInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.Size = new System.Drawing.Size(756, 251);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 140;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 140;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 120;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 120;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "BillNo";
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // VehicleDescription
            // 
            this.VehicleDescription.DataPropertyName = "VehicleDescription";
            this.VehicleDescription.HeaderText = "VehicleDescription";
            this.VehicleDescription.Name = "VehicleDescription";
            this.VehicleDescription.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // StyleID
            // 
            this.StyleID.DataPropertyName = "StyleID";
            this.StyleID.HeaderText = "StyleID";
            this.StyleID.Name = "StyleID";
            this.StyleID.ReadOnly = true;
            this.StyleID.Visible = false;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rbtnMonth.Location = new System.Drawing.Point(87, 41);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 85;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rbtnDay.Location = new System.Drawing.Point(22, 41);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 84;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // dtpAttendence
            // 
            this.dtpAttendence.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendence.Location = new System.Drawing.Point(14, 14);
            this.dtpAttendence.Name = "dtpAttendence";
            this.dtpAttendence.Size = new System.Drawing.Size(207, 21);
            this.dtpAttendence.TabIndex = 83;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(652, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 21);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Create Bill";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvViewBy
            // 
            this.dgvViewBy.AllowUserToAddRows = false;
            this.dgvViewBy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvViewBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vDealerID,
            this.vDealer,
            this.vBillNo,
            this.vDate,
            this.vVehicleDescription});
            this.dgvViewBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewBy.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvViewBy.Location = new System.Drawing.Point(4, 14);
            this.dgvViewBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvViewBy.Name = "dgvViewBy";
            this.dgvViewBy.ReadOnly = true;
            this.dgvViewBy.Size = new System.Drawing.Size(756, 133);
            this.dgvViewBy.TabIndex = 0;
            this.dgvViewBy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBy_CellClick);
            // 
            // vDealerID
            // 
            this.vDealerID.DataPropertyName = "DealerID";
            this.vDealerID.HeaderText = "DealerID";
            this.vDealerID.Name = "vDealerID";
            this.vDealerID.ReadOnly = true;
            this.vDealerID.Visible = false;
            // 
            // vDealer
            // 
            this.vDealer.DataPropertyName = "Dealer";
            this.vDealer.HeaderText = "Dealer";
            this.vDealer.Name = "vDealer";
            this.vDealer.ReadOnly = true;
            this.vDealer.Width = 150;
            // 
            // vBillNo
            // 
            this.vBillNo.DataPropertyName = "BillNo";
            this.vBillNo.HeaderText = "BillNo";
            this.vBillNo.Name = "vBillNo";
            this.vBillNo.ReadOnly = true;
            this.vBillNo.Width = 150;
            // 
            // vDate
            // 
            this.vDate.DataPropertyName = "Date";
            this.vDate.HeaderText = "Date";
            this.vDate.Name = "vDate";
            this.vDate.ReadOnly = true;
            this.vDate.Width = 150;
            // 
            // vVehicleDescription
            // 
            this.vVehicleDescription.DataPropertyName = "VehicleDescription";
            this.vVehicleDescription.HeaderText = "VehicleDescription";
            this.vVehicleDescription.Name = "vVehicleDescription";
            this.vVehicleDescription.ReadOnly = true;
            this.vVehicleDescription.Width = 400;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViewBy);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(764, 150);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDiscount.Location = new System.Drawing.Point(425, 64);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(93, 13);
            this.lblDiscount.TabIndex = 96;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiscount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtDiscount.Location = new System.Drawing.Point(524, 61);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(122, 21);
            this.txtDiscount.TabIndex = 97;
            this.txtDiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDiscount_MouseClick);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShop.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblShop.Location = new System.Drawing.Point(19, 69);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(39, 13);
            this.lblShop.TabIndex = 98;
            this.lblShop.Text = "Shop";
            // 
            // txtShop
            // 
            this.txtShop.BackColor = System.Drawing.SystemColors.Control;
            this.txtShop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShop.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtShop.Location = new System.Drawing.Point(113, 65);
            this.txtShop.Name = "txtShop";
            this.txtShop.Size = new System.Drawing.Size(257, 21);
            this.txtShop.TabIndex = 99;
            // 
            // salesCreateBillByGatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.txtShop);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnprintReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.gbxCustomerOrder);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.dtpAttendence);
            this.Controls.Add(this.btnDelete);
            this.Name = "salesCreateBillByGatePass";
            this.Text = "Create Bill By GatePass";
            this.Load += new System.EventHandler(this.salesCreateBillByGatePass_Load);
            this.gbxCustomerOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColorID;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.Button btnprintReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.GroupBox gbxCustomerOrder;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleID;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.DateTimePicker dtpAttendence;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvViewBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDealerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn vBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vVehicleDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.TextBox txtShop;

    }
}