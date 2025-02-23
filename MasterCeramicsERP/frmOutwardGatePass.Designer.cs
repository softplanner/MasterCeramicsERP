namespace MasterCeramicsERP
{
    partial class frmOutwardGatePass
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
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.txtGPass = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.gbxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.lblGpass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.dtpAttendence = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbxCustomerOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(456, 105);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.Size = new System.Drawing.Size(148, 21);
            this.cbxItemCategory.TabIndex = 84;
            // 
            // txtGPass
            // 
            this.txtGPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtGPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGPass.Enabled = false;
            this.txtGPass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGPass.Location = new System.Drawing.Point(12, 65);
            this.txtGPass.Name = "txtGPass";
            this.txtGPass.Size = new System.Drawing.Size(216, 21);
            this.txtGPass.TabIndex = 81;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtQuantity.Location = new System.Drawing.Point(456, 145);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 21);
            this.txtQuantity.TabIndex = 79;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(456, 25);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(148, 21);
            this.cbxSelectJob.TabIndex = 77;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuantity.Location = new System.Drawing.Point(453, 129);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 13);
            this.lblQuantity.TabIndex = 78;
            this.lblQuantity.Text = "Enter Quantity";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSelectJob.Location = new System.Drawing.Point(453, 9);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(33, 13);
            this.lblSelectJob.TabIndex = 76;
            this.lblSelectJob.Text = "Job ";
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(456, 65);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(148, 21);
            this.cbxWorker.TabIndex = 75;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWorker.Location = new System.Drawing.Point(453, 49);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(50, 13);
            this.lblWorker.TabIndex = 74;
            this.lblWorker.Text = "Dealer";
            // 
            // gbxCustomerOrder
            // 
            this.gbxCustomerOrder.Controls.Add(this.dgvOrderInfo);
            this.gbxCustomerOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxCustomerOrder.Location = new System.Drawing.Point(12, 177);
            this.gbxCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Name = "gbxCustomerOrder";
            this.gbxCustomerOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Size = new System.Drawing.Size(759, 328);
            this.gbxCustomerOrder.TabIndex = 69;
            this.gbxCustomerOrder.TabStop = false;
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.StyleID,
            this.SizeID,
            this.ColorID,
            this.CategoryID,
            this.Item,
            this.Style,
            this.Size,
            this.Color,
            this.Category,
            this.Quantity});
            this.dgvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderInfo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrderInfo.Location = new System.Drawing.Point(4, 14);
            this.dgvOrderInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.Size = new System.Drawing.Size(751, 311);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellClick);
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
            // SizeID
            // 
            this.SizeID.DataPropertyName = "SizeID";
            this.SizeID.HeaderText = "SizeID";
            this.SizeID.Name = "SizeID";
            this.SizeID.ReadOnly = true;
            this.SizeID.Visible = false;
            // 
            // ColorID
            // 
            this.ColorID.DataPropertyName = "ColorID";
            this.ColorID.HeaderText = "ColorID";
            this.ColorID.Name = "ColorID";
            this.ColorID.ReadOnly = true;
            this.ColorID.Visible = false;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 130;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 130;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 130;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 130;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCategory.Location = new System.Drawing.Point(453, 89);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(66, 13);
            this.lblItemCategory.TabIndex = 83;
            this.lblItemCategory.Text = "Category";
            // 
            // lblGpass
            // 
            this.lblGpass.AutoSize = true;
            this.lblGpass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGpass.Location = new System.Drawing.Point(12, 49);
            this.lblGpass.Name = "lblGpass";
            this.lblGpass.Size = new System.Drawing.Size(44, 13);
            this.lblGpass.TabIndex = 80;
            this.lblGpass.Text = "Bill #.";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(15, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(15, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddOrder.Location = new System.Drawing.Point(15, 92);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(117, 23);
            this.btnAddOrder.TabIndex = 70;
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
            this.cbxColor.Location = new System.Drawing.Point(624, 145);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(148, 21);
            this.cbxColor.TabIndex = 68;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblColor.Location = new System.Drawing.Point(621, 129);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 67;
            this.lblColor.Text = "Color";
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(624, 105);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(148, 21);
            this.cbxSize.TabIndex = 66;
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(624, 65);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(148, 21);
            this.cbxStyle.TabIndex = 64;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(624, 25);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(148, 21);
            this.cbxItem.TabIndex = 62;
            // 
            // lblSize_slipFromItem
            // 
            this.lblSize_slipFromItem.AutoSize = true;
            this.lblSize_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize_slipFromItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSize_slipFromItem.Location = new System.Drawing.Point(621, 89);
            this.lblSize_slipFromItem.Name = "lblSize_slipFromItem";
            this.lblSize_slipFromItem.Size = new System.Drawing.Size(34, 13);
            this.lblSize_slipFromItem.TabIndex = 65;
            this.lblSize_slipFromItem.Text = "Size";
            // 
            // lblItem_slipFromItem
            // 
            this.lblItem_slipFromItem.AutoSize = true;
            this.lblItem_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_slipFromItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItem_slipFromItem.Location = new System.Drawing.Point(621, 9);
            this.lblItem_slipFromItem.Name = "lblItem_slipFromItem";
            this.lblItem_slipFromItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem_slipFromItem.TabIndex = 61;
            this.lblItem_slipFromItem.Text = "Item";
            // 
            // lblStyle_slipFromItem
            // 
            this.lblStyle_slipFromItem.AutoSize = true;
            this.lblStyle_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle_slipFromItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStyle_slipFromItem.Location = new System.Drawing.Point(621, 49);
            this.lblStyle_slipFromItem.Name = "lblStyle_slipFromItem";
            this.lblStyle_slipFromItem.Size = new System.Drawing.Size(40, 13);
            this.lblStyle_slipFromItem.TabIndex = 63;
            this.lblStyle_slipFromItem.Text = "Style";
            // 
            // txtVehicle
            // 
            this.txtVehicle.BackColor = System.Drawing.SystemColors.Control;
            this.txtVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtVehicle.Location = new System.Drawing.Point(234, 25);
            this.txtVehicle.Multiline = true;
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(216, 61);
            this.txtVehicle.TabIndex = 86;
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleInfo.Location = new System.Drawing.Point(231, 9);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(93, 13);
            this.lblVehicleInfo.TabIndex = 85;
            this.lblVehicleInfo.Text = "Vehicle Desc.";
            // 
            // dtpAttendence
            // 
            this.dtpAttendence.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendence.Location = new System.Drawing.Point(12, 25);
            this.dtpAttendence.Name = "dtpAttendence";
            this.dtpAttendence.Size = new System.Drawing.Size(216, 21);
            this.dtpAttendence.TabIndex = 87;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 13);
            this.lblDate.TabIndex = 88;
            this.lblDate.Text = "Date Time";
            // 
            // frmOutwardGatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpAttendence);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.lblVehicleInfo);
            this.Controls.Add(this.cbxItemCategory);
            this.Controls.Add(this.txtGPass);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.gbxCustomerOrder);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.lblGpass);
            this.Controls.Add(this.btnSave);
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
            this.Name = "frmOutwardGatePass";
            this.Text = "Outward GatePass";
            this.Load += new System.EventHandler(this.frmOutwardGatePass_Load);
            this.gbxCustomerOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.TextBox txtGPass;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.GroupBox gbxCustomerOrder;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.Label lblGpass;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.DateTimePicker dtpAttendence;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}