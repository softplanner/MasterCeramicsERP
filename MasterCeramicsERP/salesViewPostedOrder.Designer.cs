namespace MasterCeramicsERP
{
    partial class salesViewPostedOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedCustomers = new System.Windows.Forms.DataGridView();
            this.gbxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.chkbxDealer = new System.Windows.Forms.CheckBox();
            this.chkbxCustomer = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAddOrder = new System.Windows.Forms.DateTimePicker();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewOrderInfo = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.cbxViewBy = new System.Windows.Forms.ComboBox();
            this.lblViewOrder = new System.Windows.Forms.Label();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.Dealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCompnay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).BeginInit();
            this.gbxCustomerOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSelectedCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(213, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(566, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Dealer Customer (Sub Dealer)";
            // 
            // dgvSelectedCustomers
            // 
            this.dgvSelectedCustomers.AllowUserToAddRows = false;
            this.dgvSelectedCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.shop});
            this.dgvSelectedCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSelectedCustomers.Location = new System.Drawing.Point(4, 14);
            this.dgvSelectedCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSelectedCustomers.Name = "dgvSelectedCustomers";
            this.dgvSelectedCustomers.ReadOnly = true;
            this.dgvSelectedCustomers.Size = new System.Drawing.Size(558, 164);
            this.dgvSelectedCustomers.TabIndex = 0;
            this.dgvSelectedCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedCustomers_CellClick);
            // 
            // gbxCustomerOrder
            // 
            this.gbxCustomerOrder.Controls.Add(this.dgvOrderInfo);
            this.gbxCustomerOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxCustomerOrder.Location = new System.Drawing.Point(5, 226);
            this.gbxCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Name = "gbxCustomerOrder";
            this.gbxCustomerOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Size = new System.Drawing.Size(774, 287);
            this.gbxCustomerOrder.TabIndex = 15;
            this.gbxCustomerOrder.TabStop = false;
            this.gbxCustomerOrder.Text = "View  Order Info";
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dealer,
            this.sdealer,
            this.shops,
            this.item,
            this.style,
            this.size,
            this.color,
            this.quantity,
            this.gp,
            this.Bn,
            this.GoodsCompnay,
            this.date});
            this.dgvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOrderInfo.Location = new System.Drawing.Point(4, 14);
            this.dgvOrderInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.RowHeadersVisible = false;
            this.dgvOrderInfo.Size = new System.Drawing.Size(766, 270);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellClick);
            // 
            // chkbxDealer
            // 
            this.chkbxDealer.AutoSize = true;
            this.chkbxDealer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDealer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkbxDealer.Location = new System.Drawing.Point(85, 167);
            this.chkbxDealer.Name = "chkbxDealer";
            this.chkbxDealer.Size = new System.Drawing.Size(100, 16);
            this.chkbxDealer.TabIndex = 26;
            this.chkbxDealer.Text = "View By Dealer";
            this.chkbxDealer.UseVisualStyleBackColor = true;
            // 
            // chkbxCustomer
            // 
            this.chkbxCustomer.AutoSize = true;
            this.chkbxCustomer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkbxCustomer.Location = new System.Drawing.Point(85, 200);
            this.chkbxCustomer.Name = "chkbxCustomer";
            this.chkbxCustomer.Size = new System.Drawing.Size(121, 16);
            this.chkbxCustomer.TabIndex = 28;
            this.chkbxCustomer.Text = "View By Sub Dealer";
            this.chkbxCustomer.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(10, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 12);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Select Date";
            // 
            // dtpAddOrder
            // 
            this.dtpAddOrder.CalendarFont = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddOrder.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAddOrder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddOrder.Location = new System.Drawing.Point(6, 100);
            this.dtpAddOrder.Name = "dtpAddOrder";
            this.dtpAddOrder.Size = new System.Drawing.Size(201, 21);
            this.dtpAddOrder.TabIndex = 21;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnMonth.Location = new System.Drawing.Point(141, 130);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 24;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnDay.Location = new System.Drawing.Point(85, 130);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 23;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.Location = new System.Drawing.Point(6, 196);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(6, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewOrderInfo
            // 
            this.btnViewOrderInfo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrderInfo.Location = new System.Drawing.Point(6, 127);
            this.btnViewOrderInfo.Name = "btnViewOrderInfo";
            this.btnViewOrderInfo.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrderInfo.TabIndex = 22;
            this.btnViewOrderInfo.Text = "View Order";
            this.btnViewOrderInfo.UseVisualStyleBackColor = true;
            this.btnViewOrderInfo.Click += new System.EventHandler(this.btnViewOrderInfo_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTemp.Location = new System.Drawing.Point(4, 47);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(32, 12);
            this.lblTemp.TabIndex = 18;
            this.lblTemp.Text = "Temp";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.Color.LightGray;
            this.txtTemp.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTemp.Location = new System.Drawing.Point(6, 62);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(195, 18);
            this.txtTemp.TabIndex = 19;
            this.txtTemp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTemp_MouseClick);
            // 
            // cbxViewBy
            // 
            this.cbxViewBy.BackColor = System.Drawing.SystemColors.Control;
            this.cbxViewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxViewBy.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxViewBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxViewBy.FormattingEnabled = true;
            this.cbxViewBy.Items.AddRange(new object[] {
            "Gate Pass Number",
            "Bilty Number",
            "Calender/Dealer Info"});
            this.cbxViewBy.Location = new System.Drawing.Point(6, 24);
            this.cbxViewBy.Name = "cbxViewBy";
            this.cbxViewBy.Size = new System.Drawing.Size(195, 20);
            this.cbxViewBy.TabIndex = 17;
            this.cbxViewBy.SelectedValueChanged += new System.EventHandler(this.cbxViewBy_SelectedValueChanged);
            // 
            // lblViewOrder
            // 
            this.lblViewOrder.AutoSize = true;
            this.lblViewOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblViewOrder.Location = new System.Drawing.Point(4, 9);
            this.lblViewOrder.Name = "lblViewOrder";
            this.lblViewOrder.Size = new System.Drawing.Size(77, 12);
            this.lblViewOrder.TabIndex = 16;
            this.lblViewOrder.Text = "View Order By";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectJob.Location = new System.Drawing.Point(214, 4);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(141, 13);
            this.lblSelectJob.TabIndex = 42;
            this.lblSelectJob.Text = "Select job for dealer";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(217, 20);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(186, 21);
            this.cbxSelectJob.TabIndex = 43;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(431, 20);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(186, 21);
            this.cbxWorker.TabIndex = 41;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWorker.Location = new System.Drawing.Point(428, 4);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(50, 13);
            this.lblWorker.TabIndex = 40;
            this.lblWorker.Text = "Dealer";
            // 
            // Dealer
            // 
            this.Dealer.HeaderText = "Dealer";
            this.Dealer.Name = "Dealer";
            this.Dealer.ReadOnly = true;
            // 
            // sdealer
            // 
            this.sdealer.HeaderText = "Sub Dealer";
            this.sdealer.Name = "sdealer";
            this.sdealer.ReadOnly = true;
            // 
            // shops
            // 
            this.shops.HeaderText = "Shop";
            this.shops.Name = "shops";
            this.shops.ReadOnly = true;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 90;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 80;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 70;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 70;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 60;
            // 
            // gp
            // 
            this.gp.HeaderText = "Gate Pass";
            this.gp.Name = "gp";
            this.gp.ReadOnly = true;
            this.gp.Width = 60;
            // 
            // Bn
            // 
            this.Bn.HeaderText = "Bilty No.";
            this.Bn.Name = "Bn";
            this.Bn.ReadOnly = true;
            this.Bn.Width = 60;
            // 
            // GoodsCompnay
            // 
            this.GoodsCompnay.HeaderText = "Goods Company";
            this.GoodsCompnay.Name = "GoodsCompnay";
            this.GoodsCompnay.ReadOnly = true;
            this.GoodsCompnay.Width = 70;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // shop
            // 
            this.shop.HeaderText = "Shop";
            this.shop.Name = "shop";
            this.shop.ReadOnly = true;
            this.shop.Width = 250;
            // 
            // salesViewPostedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.chkbxDealer);
            this.Controls.Add(this.chkbxCustomer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpAddOrder);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewOrderInfo);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.cbxViewBy);
            this.Controls.Add(this.lblViewOrder);
            this.Controls.Add(this.gbxCustomerOrder);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "salesViewPostedOrder";
            this.Text = "View Posted Order\'s";
            this.Load += new System.EventHandler(this.salesViewPostedOrder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).EndInit();
            this.gbxCustomerOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSelectedCustomers;
        private System.Windows.Forms.GroupBox gbxCustomerOrder;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.CheckBox chkbxDealer;
        private System.Windows.Forms.CheckBox chkbxCustomer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAddOrder;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewOrderInfo;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.ComboBox cbxViewBy;
        private System.Windows.Forms.Label lblViewOrder;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn shops;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCompnay;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop;
    }
}