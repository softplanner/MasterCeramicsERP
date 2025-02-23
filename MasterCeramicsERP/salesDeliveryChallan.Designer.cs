namespace MasterCeramicsERP
{
    partial class salesDeliveryChallan
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblSize_slipFromItem = new System.Windows.Forms.Label();
            this.lblItem_slipFromItem = new System.Windows.Forms.Label();
            this.lblStyle_slipFromItem = new System.Windows.Forms.Label();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblGpass = new System.Windows.Forms.Label();
            this.txtGPass = new System.Windows.Forms.TextBox();
            this.chkbxDeductStock = new System.Windows.Forms.CheckBox();
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.gbxCustomerOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(314, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(713, 134);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 23);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(247, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddOrder.Location = new System.Drawing.Point(183, 132);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(62, 23);
            this.btnAddOrder.TabIndex = 38;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(559, 84);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(220, 21);
            this.cbxColor.TabIndex = 36;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblColor.Location = new System.Drawing.Point(482, 87);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 35;
            this.lblColor.Text = "Color";
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(559, 57);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(220, 21);
            this.cbxSize.TabIndex = 34;
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(559, 32);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(221, 21);
            this.cbxStyle.TabIndex = 32;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(559, 5);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(221, 21);
            this.cbxItem.TabIndex = 30;
            // 
            // lblSize_slipFromItem
            // 
            this.lblSize_slipFromItem.AutoSize = true;
            this.lblSize_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize_slipFromItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSize_slipFromItem.Location = new System.Drawing.Point(482, 60);
            this.lblSize_slipFromItem.Name = "lblSize_slipFromItem";
            this.lblSize_slipFromItem.Size = new System.Drawing.Size(34, 13);
            this.lblSize_slipFromItem.TabIndex = 33;
            this.lblSize_slipFromItem.Text = "Size";
            // 
            // lblItem_slipFromItem
            // 
            this.lblItem_slipFromItem.AutoSize = true;
            this.lblItem_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_slipFromItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItem_slipFromItem.Location = new System.Drawing.Point(482, 8);
            this.lblItem_slipFromItem.Name = "lblItem_slipFromItem";
            this.lblItem_slipFromItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem_slipFromItem.TabIndex = 29;
            this.lblItem_slipFromItem.Text = "Item";
            // 
            // lblStyle_slipFromItem
            // 
            this.lblStyle_slipFromItem.AutoSize = true;
            this.lblStyle_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle_slipFromItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStyle_slipFromItem.Location = new System.Drawing.Point(482, 35);
            this.lblStyle_slipFromItem.Name = "lblStyle_slipFromItem";
            this.lblStyle_slipFromItem.Size = new System.Drawing.Size(40, 13);
            this.lblStyle_slipFromItem.TabIndex = 31;
            this.lblStyle_slipFromItem.Text = "Style";
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
            this.Category});
            this.dgvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderInfo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrderInfo.Location = new System.Drawing.Point(4, 14);
            this.dgvOrderInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.Size = new System.Drawing.Size(765, 336);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellClick);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 140;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 140;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 120;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 120;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 200;
            // 
            // gbxCustomerOrder
            // 
            this.gbxCustomerOrder.Controls.Add(this.dgvOrderInfo);
            this.gbxCustomerOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxCustomerOrder.Location = new System.Drawing.Point(6, 152);
            this.gbxCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Name = "gbxCustomerOrder";
            this.gbxCustomerOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Size = new System.Drawing.Size(773, 353);
            this.gbxCustomerOrder.TabIndex = 37;
            this.gbxCustomerOrder.TabStop = false;
            this.gbxCustomerOrder.Text = "View  Order Info";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSelectJob.Location = new System.Drawing.Point(12, 12);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(141, 13);
            this.lblSelectJob.TabIndex = 50;
            this.lblSelectJob.Text = "Select job for dealer";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(161, 4);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(249, 21);
            this.cbxSelectJob.TabIndex = 51;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(161, 31);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(249, 21);
            this.cbxWorker.TabIndex = 49;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWorker.Location = new System.Drawing.Point(12, 34);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(50, 13);
            this.lblWorker.TabIndex = 48;
            this.lblWorker.Text = "Dealer";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuantity.Location = new System.Drawing.Point(12, 86);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 13);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "Enter Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtQuantity.Location = new System.Drawing.Point(161, 83);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(249, 21);
            this.txtQuantity.TabIndex = 53;
            // 
            // lblGpass
            // 
            this.lblGpass.AutoSize = true;
            this.lblGpass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGpass.Location = new System.Drawing.Point(12, 63);
            this.lblGpass.Name = "lblGpass";
            this.lblGpass.Size = new System.Drawing.Size(96, 13);
            this.lblGpass.TabIndex = 56;
            this.lblGpass.Text = "Gate Pass No.";
            // 
            // txtGPass
            // 
            this.txtGPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtGPass.Enabled = false;
            this.txtGPass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGPass.Location = new System.Drawing.Point(161, 60);
            this.txtGPass.Name = "txtGPass";
            this.txtGPass.Size = new System.Drawing.Size(249, 21);
            this.txtGPass.TabIndex = 57;
            // 
            // chkbxDeductStock
            // 
            this.chkbxDeductStock.AutoSize = true;
            this.chkbxDeductStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxDeductStock.ForeColor = System.Drawing.Color.Red;
            this.chkbxDeductStock.Location = new System.Drawing.Point(559, 138);
            this.chkbxDeductStock.Name = "chkbxDeductStock";
            this.chkbxDeductStock.Size = new System.Drawing.Size(149, 17);
            this.chkbxDeductStock.TabIndex = 58;
            this.chkbxDeductStock.Text = "Deduct From Stock";
            this.chkbxDeductStock.UseVisualStyleBackColor = true;
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(559, 111);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.Size = new System.Drawing.Size(220, 21);
            this.cbxItemCategory.TabIndex = 60;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCategory.Location = new System.Drawing.Point(482, 114);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(66, 13);
            this.lblItemCategory.TabIndex = 59;
            this.lblItemCategory.Text = "Category";
            // 
            // salesDeliveryChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.cbxItemCategory);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.chkbxDeductStock);
            this.Controls.Add(this.lblGpass);
            this.Controls.Add(this.txtGPass);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.lblSize_slipFromItem);
            this.Controls.Add(this.lblItem_slipFromItem);
            this.Controls.Add(this.lblStyle_slipFromItem);
            this.Controls.Add(this.gbxCustomerOrder);
            this.Name = "salesDeliveryChallan";
            this.Text = "Create Delivery Challan";
            this.Load += new System.EventHandler(this.salesDeliveryChallan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.gbxCustomerOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblSize_slipFromItem;
        private System.Windows.Forms.Label lblItem_slipFromItem;
        private System.Windows.Forms.Label lblStyle_slipFromItem;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.GroupBox gbxCustomerOrder;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblGpass;
        private System.Windows.Forms.TextBox txtGPass;
        private System.Windows.Forms.CheckBox chkbxDeductStock;
        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}