namespace MasterCeramicsERP
{
    partial class frmCompanyItemStock
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
            this.dgvGlazedStock = new System.Windows.Forms.DataGridView();
            this.dgvUnglazeStock = new System.Windows.Forms.DataGridView();
            this.gbxUnglazeStock = new System.Windows.Forms.GroupBox();
            this.gbxGlazedStock = new System.Windows.Forms.GroupBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnReadyItem = new System.Windows.Forms.Button();
            this.btnGlazedItem = new System.Windows.Forms.Button();
            this.btnPrintUnglaze = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtReadyItems = new System.Windows.Forms.TextBox();
            this.lblReadyItem = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUnglazeQuantity = new System.Windows.Forms.TextBox();
            this.txtGlazedQuantity = new System.Windows.Forms.TextBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.lblUnglaze = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGlazedQuantity = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.gbxReadyItem = new System.Windows.Forms.GroupBox();
            this.dgvReadyItems = new System.Windows.Forms.DataGridView();
            this.uItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnglazeStock)).BeginInit();
            this.gbxUnglazeStock.SuspendLayout();
            this.gbxGlazedStock.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxReadyItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGlazedStock
            // 
            this.dgvGlazedStock.AllowUserToAddRows = false;
            this.dgvGlazedStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGlazedStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGlazedStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGlazedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlazedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gItem,
            this.gStyle,
            this.gSize,
            this.gColor,
            this.gQuantity});
            this.dgvGlazedStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGlazedStock.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvGlazedStock.Location = new System.Drawing.Point(3, 17);
            this.dgvGlazedStock.Name = "dgvGlazedStock";
            this.dgvGlazedStock.ReadOnly = true;
            this.dgvGlazedStock.Size = new System.Drawing.Size(547, 129);
            this.dgvGlazedStock.TabIndex = 0;
            // 
            // dgvUnglazeStock
            // 
            this.dgvUnglazeStock.AllowUserToAddRows = false;
            this.dgvUnglazeStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUnglazeStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnglazeStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUnglazeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnglazeStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uItem,
            this.uStyle,
            this.uSize,
            this.uQuantity});
            this.dgvUnglazeStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnglazeStock.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvUnglazeStock.Location = new System.Drawing.Point(3, 17);
            this.dgvUnglazeStock.Name = "dgvUnglazeStock";
            this.dgvUnglazeStock.ReadOnly = true;
            this.dgvUnglazeStock.Size = new System.Drawing.Size(547, 150);
            this.dgvUnglazeStock.TabIndex = 0;
            // 
            // gbxUnglazeStock
            // 
            this.gbxUnglazeStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUnglazeStock.Controls.Add(this.dgvUnglazeStock);
            this.gbxUnglazeStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUnglazeStock.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxUnglazeStock.Location = new System.Drawing.Point(231, -2);
            this.gbxUnglazeStock.Name = "gbxUnglazeStock";
            this.gbxUnglazeStock.Size = new System.Drawing.Size(553, 170);
            this.gbxUnglazeStock.TabIndex = 1;
            this.gbxUnglazeStock.TabStop = false;
            this.gbxUnglazeStock.Text = "Unglaze Stock";
            // 
            // gbxGlazedStock
            // 
            this.gbxGlazedStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxGlazedStock.Controls.Add(this.dgvGlazedStock);
            this.gbxGlazedStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGlazedStock.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxGlazedStock.Location = new System.Drawing.Point(230, 169);
            this.gbxGlazedStock.Name = "gbxGlazedStock";
            this.gbxGlazedStock.Size = new System.Drawing.Size(553, 149);
            this.gbxGlazedStock.TabIndex = 2;
            this.gbxGlazedStock.TabStop = false;
            this.gbxGlazedStock.Text = "Glazed Stock";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSearch.Controls.Add(this.btnReadyItem);
            this.gbxSearch.Controls.Add(this.btnGlazedItem);
            this.gbxSearch.Controls.Add(this.btnPrintUnglaze);
            this.gbxSearch.Controls.Add(this.lblCategory);
            this.gbxSearch.Controls.Add(this.cbxCategory);
            this.gbxSearch.Controls.Add(this.txtReadyItems);
            this.gbxSearch.Controls.Add(this.lblReadyItem);
            this.gbxSearch.Controls.Add(this.btnRefresh);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.txtUnglazeQuantity);
            this.gbxSearch.Controls.Add(this.txtGlazedQuantity);
            this.gbxSearch.Controls.Add(this.cbxColor);
            this.gbxSearch.Controls.Add(this.cbxSize);
            this.gbxSearch.Controls.Add(this.cbxStyle);
            this.gbxSearch.Controls.Add(this.lblUnglaze);
            this.gbxSearch.Controls.Add(this.cbxItem);
            this.gbxSearch.Controls.Add(this.lblColor);
            this.gbxSearch.Controls.Add(this.lblGlazedQuantity);
            this.gbxSearch.Controls.Add(this.lblSize);
            this.gbxSearch.Controls.Add(this.lblStyle);
            this.gbxSearch.Controls.Add(this.lblItem);
            this.gbxSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxSearch.Location = new System.Drawing.Point(4, -1);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(224, 317);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnReadyItem
            // 
            this.btnReadyItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadyItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReadyItem.Location = new System.Drawing.Point(6, 291);
            this.btnReadyItem.Name = "btnReadyItem";
            this.btnReadyItem.Size = new System.Drawing.Size(212, 23);
            this.btnReadyItem.TabIndex = 20;
            this.btnReadyItem.Text = "Print Ready Item Stock Report";
            this.btnReadyItem.UseVisualStyleBackColor = false;
            this.btnReadyItem.Click += new System.EventHandler(this.btnReadyItem_Click);
            // 
            // btnGlazedItem
            // 
            this.btnGlazedItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnGlazedItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlazedItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGlazedItem.Location = new System.Drawing.Point(6, 266);
            this.btnGlazedItem.Name = "btnGlazedItem";
            this.btnGlazedItem.Size = new System.Drawing.Size(212, 23);
            this.btnGlazedItem.TabIndex = 19;
            this.btnGlazedItem.Text = "Print Glaze Stock Report";
            this.btnGlazedItem.UseVisualStyleBackColor = false;
            this.btnGlazedItem.Click += new System.EventHandler(this.btnGlazedItem_Click);
            // 
            // btnPrintUnglaze
            // 
            this.btnPrintUnglaze.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintUnglaze.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintUnglaze.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPrintUnglaze.Location = new System.Drawing.Point(6, 242);
            this.btnPrintUnglaze.Name = "btnPrintUnglaze";
            this.btnPrintUnglaze.Size = new System.Drawing.Size(212, 23);
            this.btnPrintUnglaze.TabIndex = 18;
            this.btnPrintUnglaze.Text = "Print Unglaze Stock Report";
            this.btnPrintUnglaze.UseVisualStyleBackColor = false;
            this.btnPrintUnglaze.Click += new System.EventHandler(this.btnPrintUnglaze_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCategory.Location = new System.Drawing.Point(12, 118);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(92, 115);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(126, 21);
            this.cbxCategory.TabIndex = 9;
            // 
            // txtReadyItems
            // 
            this.txtReadyItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtReadyItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadyItems.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtReadyItems.Location = new System.Drawing.Point(143, 215);
            this.txtReadyItems.Name = "txtReadyItems";
            this.txtReadyItems.ReadOnly = true;
            this.txtReadyItems.Size = new System.Drawing.Size(75, 21);
            this.txtReadyItems.TabIndex = 17;
            // 
            // lblReadyItem
            // 
            this.lblReadyItem.AutoSize = true;
            this.lblReadyItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReadyItem.Location = new System.Drawing.Point(14, 223);
            this.lblReadyItem.Name = "lblReadyItem";
            this.lblReadyItem.Size = new System.Drawing.Size(89, 13);
            this.lblReadyItem.TabIndex = 16;
            this.lblReadyItem.Text = "Ready Items";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(143, 139);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 21);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.Location = new System.Drawing.Point(12, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUnglazeQuantity
            // 
            this.txtUnglazeQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnglazeQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnglazeQuantity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtUnglazeQuantity.Location = new System.Drawing.Point(143, 166);
            this.txtUnglazeQuantity.Name = "txtUnglazeQuantity";
            this.txtUnglazeQuantity.ReadOnly = true;
            this.txtUnglazeQuantity.Size = new System.Drawing.Size(75, 21);
            this.txtUnglazeQuantity.TabIndex = 13;
            // 
            // txtGlazedQuantity
            // 
            this.txtGlazedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlazedQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGlazedQuantity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtGlazedQuantity.Location = new System.Drawing.Point(143, 190);
            this.txtGlazedQuantity.Name = "txtGlazedQuantity";
            this.txtGlazedQuantity.ReadOnly = true;
            this.txtGlazedQuantity.Size = new System.Drawing.Size(75, 21);
            this.txtGlazedQuantity.TabIndex = 15;
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(92, 91);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(126, 21);
            this.cbxColor.TabIndex = 7;
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(92, 67);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(126, 21);
            this.cbxSize.TabIndex = 5;
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(92, 43);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(126, 21);
            this.cbxStyle.Sorted = true;
            this.cbxStyle.TabIndex = 3;
            // 
            // lblUnglaze
            // 
            this.lblUnglaze.AutoSize = true;
            this.lblUnglaze.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUnglaze.Location = new System.Drawing.Point(14, 174);
            this.lblUnglaze.Name = "lblUnglaze";
            this.lblUnglaze.Size = new System.Drawing.Size(118, 13);
            this.lblUnglaze.TabIndex = 12;
            this.lblUnglaze.Text = "Unglaze Quantity";
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(92, 20);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(126, 21);
            this.cbxItem.Sorted = true;
            this.cbxItem.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblColor.Location = new System.Drawing.Point(12, 94);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // lblGlazedQuantity
            // 
            this.lblGlazedQuantity.AutoSize = true;
            this.lblGlazedQuantity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblGlazedQuantity.Location = new System.Drawing.Point(14, 197);
            this.lblGlazedQuantity.Name = "lblGlazedQuantity";
            this.lblGlazedQuantity.Size = new System.Drawing.Size(110, 13);
            this.lblGlazedQuantity.TabIndex = 14;
            this.lblGlazedQuantity.Text = "Glazed Quantity";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSize.Location = new System.Drawing.Point(13, 70);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblStyle.Location = new System.Drawing.Point(12, 46);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 2;
            this.lblStyle.Text = "Style";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblItem.Location = new System.Drawing.Point(13, 23);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // gbxReadyItem
            // 
            this.gbxReadyItem.BackColor = System.Drawing.SystemColors.Control;
            this.gbxReadyItem.Controls.Add(this.dgvReadyItems);
            this.gbxReadyItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReadyItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxReadyItem.Location = new System.Drawing.Point(1, 316);
            this.gbxReadyItem.Name = "gbxReadyItem";
            this.gbxReadyItem.Size = new System.Drawing.Size(784, 203);
            this.gbxReadyItem.TabIndex = 3;
            this.gbxReadyItem.TabStop = false;
            this.gbxReadyItem.Text = "Ready Items Stock";
            // 
            // dgvReadyItems
            // 
            this.dgvReadyItems.AllowUserToAddRows = false;
            this.dgvReadyItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReadyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadyItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rItem,
            this.rStyle,
            this.rSize,
            this.rColor,
            this.rItemCategory,
            this.rQuantity});
            this.dgvReadyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReadyItems.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvReadyItems.Location = new System.Drawing.Point(3, 17);
            this.dgvReadyItems.Name = "dgvReadyItems";
            this.dgvReadyItems.ReadOnly = true;
            this.dgvReadyItems.Size = new System.Drawing.Size(778, 183);
            this.dgvReadyItems.TabIndex = 0;
            // 
            // uItem
            // 
            this.uItem.DataPropertyName = "Item";
            this.uItem.HeaderText = "Item";
            this.uItem.Name = "uItem";
            this.uItem.ReadOnly = true;
            this.uItem.Width = 155;
            // 
            // uStyle
            // 
            this.uStyle.DataPropertyName = "Style";
            this.uStyle.HeaderText = "Style";
            this.uStyle.Name = "uStyle";
            this.uStyle.ReadOnly = true;
            this.uStyle.Width = 155;
            // 
            // uSize
            // 
            this.uSize.DataPropertyName = "Size";
            this.uSize.HeaderText = "Size";
            this.uSize.Name = "uSize";
            this.uSize.ReadOnly = true;
            this.uSize.Width = 125;
            // 
            // uQuantity
            // 
            this.uQuantity.DataPropertyName = "Quantity";
            this.uQuantity.HeaderText = "Quantity";
            this.uQuantity.Name = "uQuantity";
            this.uQuantity.ReadOnly = true;
            this.uQuantity.Width = 70;
            // 
            // gItem
            // 
            this.gItem.DataPropertyName = "Item";
            this.gItem.HeaderText = "Item";
            this.gItem.Name = "gItem";
            this.gItem.ReadOnly = true;
            this.gItem.Width = 115;
            // 
            // gStyle
            // 
            this.gStyle.DataPropertyName = "Style";
            this.gStyle.HeaderText = "Style";
            this.gStyle.Name = "gStyle";
            this.gStyle.ReadOnly = true;
            this.gStyle.Width = 110;
            // 
            // gSize
            // 
            this.gSize.DataPropertyName = "Size";
            this.gSize.HeaderText = "Size";
            this.gSize.Name = "gSize";
            this.gSize.ReadOnly = true;
            this.gSize.Width = 105;
            // 
            // gColor
            // 
            this.gColor.DataPropertyName = "Color";
            this.gColor.HeaderText = "Color";
            this.gColor.Name = "gColor";
            this.gColor.ReadOnly = true;
            this.gColor.Width = 105;
            // 
            // gQuantity
            // 
            this.gQuantity.DataPropertyName = "Quantity";
            this.gQuantity.HeaderText = "Quantity";
            this.gQuantity.Name = "gQuantity";
            this.gQuantity.ReadOnly = true;
            this.gQuantity.Width = 70;
            // 
            // rItem
            // 
            this.rItem.DataPropertyName = "Item";
            this.rItem.HeaderText = "Item";
            this.rItem.Name = "rItem";
            this.rItem.ReadOnly = true;
            this.rItem.Width = 130;
            // 
            // rStyle
            // 
            this.rStyle.DataPropertyName = "Style";
            this.rStyle.HeaderText = "Style";
            this.rStyle.Name = "rStyle";
            this.rStyle.ReadOnly = true;
            this.rStyle.Width = 130;
            // 
            // rSize
            // 
            this.rSize.DataPropertyName = "Size";
            this.rSize.HeaderText = "Size";
            this.rSize.Name = "rSize";
            this.rSize.ReadOnly = true;
            this.rSize.Width = 130;
            // 
            // rColor
            // 
            this.rColor.DataPropertyName = "Color";
            this.rColor.HeaderText = "Color";
            this.rColor.Name = "rColor";
            this.rColor.ReadOnly = true;
            this.rColor.Width = 130;
            // 
            // rItemCategory
            // 
            this.rItemCategory.DataPropertyName = "ItemCategory";
            this.rItemCategory.HeaderText = "Category";
            this.rItemCategory.Name = "rItemCategory";
            this.rItemCategory.ReadOnly = true;
            this.rItemCategory.Width = 120;
            // 
            // rQuantity
            // 
            this.rQuantity.DataPropertyName = "Quantity";
            this.rQuantity.HeaderText = "Quantity";
            this.rQuantity.Name = "rQuantity";
            this.rQuantity.ReadOnly = true;
            // 
            // frmCompanyItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxReadyItem);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxGlazedStock);
            this.Controls.Add(this.gbxUnglazeStock);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmCompanyItemStock";
            this.Text = "Company Item Stock";
            this.Load += new System.EventHandler(this.frmCompanyItemStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnglazeStock)).EndInit();
            this.gbxUnglazeStock.ResumeLayout(false);
            this.gbxGlazedStock.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxReadyItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGlazedStock;
        private System.Windows.Forms.DataGridView dgvUnglazeStock;
        private System.Windows.Forms.GroupBox gbxUnglazeStock;
        private System.Windows.Forms.GroupBox gbxGlazedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtUnglazeQuantity;
        private System.Windows.Forms.TextBox txtGlazedQuantity;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.Label lblUnglaze;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblGlazedQuantity;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbxReadyItem;
        private System.Windows.Forms.TextBox txtReadyItems;
        private System.Windows.Forms.Label lblReadyItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.DataGridView dgvReadyItems;
        private System.Windows.Forms.Button btnReadyItem;
        private System.Windows.Forms.Button btnGlazedItem;
        private System.Windows.Forms.Button btnPrintUnglaze;
        private System.Windows.Forms.DataGridViewTextBoxColumn uItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn uStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn uQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn gColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn rColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn rQuantity;
    }
}