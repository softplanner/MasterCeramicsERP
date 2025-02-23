namespace MasterCeramicsERP
{
    partial class salesPostOrder
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAddOrder = new System.Windows.Forms.DateTimePicker();
            this.gbxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedCustomers = new System.Windows.Forms.DataGridView();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnViewOrderInfo = new System.Windows.Forms.Button();
            this.lblgatePass = new System.Windows.Forms.Label();
            this.txtGatePass = new System.Windows.Forms.TextBox();
            this.lblBiltyNo = new System.Windows.Forms.Label();
            this.txtBiltyNo = new System.Windows.Forms.TextBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.cbxGoodsCompany = new System.Windows.Forms.ComboBox();
            this.lblGoodsCompany1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCustomerOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(1, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Select Date";
            // 
            // dtpAddOrder
            // 
            this.dtpAddOrder.CalendarFont = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddOrder.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAddOrder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddOrder.Location = new System.Drawing.Point(4, 157);
            this.dtpAddOrder.Name = "dtpAddOrder";
            this.dtpAddOrder.Size = new System.Drawing.Size(201, 21);
            this.dtpAddOrder.TabIndex = 4;
            // 
            // gbxCustomerOrder
            // 
            this.gbxCustomerOrder.Controls.Add(this.dgvOrderInfo);
            this.gbxCustomerOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxCustomerOrder.Location = new System.Drawing.Point(4, 238);
            this.gbxCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Name = "gbxCustomerOrder";
            this.gbxCustomerOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Size = new System.Drawing.Size(775, 275);
            this.gbxCustomerOrder.TabIndex = 5;
            this.gbxCustomerOrder.TabStop = false;
            this.gbxCustomerOrder.Text = "View  Order Info";
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.style,
            this.size,
            this.color,
            this.quantity,
            this.date});
            this.dgvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOrderInfo.Location = new System.Drawing.Point(4, 14);
            this.dgvOrderInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.Size = new System.Drawing.Size(767, 258);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSelectedCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(334, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(447, 233);
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
            this.dgvSelectedCustomers.Size = new System.Drawing.Size(439, 216);
            this.dgvSelectedCustomers.TabIndex = 0;
            this.dgvSelectedCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedCustomers_CellClick);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnMonth.Location = new System.Drawing.Point(8, 211);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 14;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtnDay.Location = new System.Drawing.Point(9, 186);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 13;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.Location = new System.Drawing.Point(216, 209);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(130, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddOrder.Location = new System.Drawing.Point(216, 184);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(111, 23);
            this.btnAddOrder.TabIndex = 15;
            this.btnAddOrder.Text = "Post Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnViewOrderInfo
            // 
            this.btnViewOrderInfo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrderInfo.Location = new System.Drawing.Point(130, 184);
            this.btnViewOrderInfo.Name = "btnViewOrderInfo";
            this.btnViewOrderInfo.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrderInfo.TabIndex = 12;
            this.btnViewOrderInfo.Text = "View Order";
            this.btnViewOrderInfo.UseVisualStyleBackColor = true;
            this.btnViewOrderInfo.Click += new System.EventHandler(this.btnViewOrderInfo_Click);
            // 
            // lblgatePass
            // 
            this.lblgatePass.AutoSize = true;
            this.lblgatePass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgatePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblgatePass.Location = new System.Drawing.Point(213, 97);
            this.lblgatePass.Name = "lblgatePass";
            this.lblgatePass.Size = new System.Drawing.Size(71, 13);
            this.lblgatePass.TabIndex = 6;
            this.lblgatePass.Text = "Gate Pass";
            // 
            // txtGatePass
            // 
            this.txtGatePass.BackColor = System.Drawing.SystemColors.Control;
            this.txtGatePass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGatePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGatePass.Location = new System.Drawing.Point(216, 113);
            this.txtGatePass.Name = "txtGatePass";
            this.txtGatePass.Size = new System.Drawing.Size(111, 21);
            this.txtGatePass.TabIndex = 7;
            this.txtGatePass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGatePass_MouseClick);
            // 
            // lblBiltyNo
            // 
            this.lblBiltyNo.AutoSize = true;
            this.lblBiltyNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiltyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBiltyNo.Location = new System.Drawing.Point(213, 141);
            this.lblBiltyNo.Name = "lblBiltyNo";
            this.lblBiltyNo.Size = new System.Drawing.Size(57, 13);
            this.lblBiltyNo.TabIndex = 8;
            this.lblBiltyNo.Text = "Bilty No";
            // 
            // txtBiltyNo
            // 
            this.txtBiltyNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtBiltyNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiltyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBiltyNo.Location = new System.Drawing.Point(216, 157);
            this.txtBiltyNo.Name = "txtBiltyNo";
            this.txtBiltyNo.Size = new System.Drawing.Size(111, 21);
            this.txtBiltyNo.TabIndex = 9;
            this.txtBiltyNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBiltyNo_MouseClick);
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectJob.Location = new System.Drawing.Point(1, 6);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(141, 13);
            this.lblSelectJob.TabIndex = 38;
            this.lblSelectJob.Text = "Select job for dealer";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(4, 22);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(323, 21);
            this.cbxSelectJob.TabIndex = 39;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(4, 65);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(323, 21);
            this.cbxWorker.TabIndex = 37;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWorker.Location = new System.Drawing.Point(1, 49);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(50, 13);
            this.lblWorker.TabIndex = 36;
            this.lblWorker.Text = "Dealer";
            // 
            // cbxGoodsCompany
            // 
            this.cbxGoodsCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsCompany.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGoodsCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxGoodsCompany.FormattingEnabled = true;
            this.cbxGoodsCompany.Location = new System.Drawing.Point(4, 113);
            this.cbxGoodsCompany.Name = "cbxGoodsCompany";
            this.cbxGoodsCompany.Size = new System.Drawing.Size(201, 21);
            this.cbxGoodsCompany.TabIndex = 41;
            // 
            // lblGoodsCompany1
            // 
            this.lblGoodsCompany1.AutoSize = true;
            this.lblGoodsCompany1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsCompany1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGoodsCompany1.Location = new System.Drawing.Point(1, 97);
            this.lblGoodsCompany1.Name = "lblGoodsCompany1";
            this.lblGoodsCompany1.Size = new System.Drawing.Size(153, 13);
            this.lblGoodsCompany1.TabIndex = 40;
            this.lblGoodsCompany1.Text = "Select goods company";
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
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // shop
            // 
            this.shop.HeaderText = "Shop";
            this.shop.Name = "shop";
            this.shop.ReadOnly = true;
            this.shop.Width = 200;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 125;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 125;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // salesPostOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.cbxGoodsCompany);
            this.Controls.Add(this.lblGoodsCompany1);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblBiltyNo);
            this.Controls.Add(this.txtBiltyNo);
            this.Controls.Add(this.lblgatePass);
            this.Controls.Add(this.txtGatePass);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnViewOrderInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpAddOrder);
            this.Controls.Add(this.gbxCustomerOrder);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "salesPostOrder";
            this.Text = "Add Posted Order\'s";
            this.Load += new System.EventHandler(this.salesPostOrder_Load);
            this.gbxCustomerOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAddOrder;
        private System.Windows.Forms.GroupBox gbxCustomerOrder;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSelectedCustomers;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnViewOrderInfo;
        private System.Windows.Forms.Label lblgatePass;
        private System.Windows.Forms.TextBox txtGatePass;
        private System.Windows.Forms.Label lblBiltyNo;
        private System.Windows.Forms.TextBox txtBiltyNo;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cbxGoodsCompany;
        private System.Windows.Forms.Label lblGoodsCompany1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop;
    }
}