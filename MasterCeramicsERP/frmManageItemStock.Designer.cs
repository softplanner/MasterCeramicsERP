namespace MasterCeramicsERP
{
    partial class frmManageItemStock
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
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnDeleteReady = new System.Windows.Forms.Button();
            this.btnDeleteGlaze = new System.Windows.Forms.Button();
            this.btnDeleteUnglaze = new System.Windows.Forms.Button();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.lblUnglaze = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGlazedQuantity = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitiess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGlazedStock = new System.Windows.Forms.GroupBox();
            this.dgvGlazedStock = new System.Windows.Forms.DataGridView();
            this.itemss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styless = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReadyItems = new System.Windows.Forms.DataGridView();
            this.itemsss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxReadyItem = new System.Windows.Forms.GroupBox();
            this.items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnglazeStock = new System.Windows.Forms.DataGridView();
            this.gbxUnglazeStock = new System.Windows.Forms.GroupBox();
            this.gbxSearch.SuspendLayout();
            this.gbxGlazedStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyItems)).BeginInit();
            this.gbxReadyItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnglazeStock)).BeginInit();
            this.gbxUnglazeStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadyItem
            // 
            this.btnReadyItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadyItem.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReadyItem.Location = new System.Drawing.Point(6, 291);
            this.btnReadyItem.Name = "btnReadyItem";
            this.btnReadyItem.Size = new System.Drawing.Size(99, 23);
            this.btnReadyItem.TabIndex = 20;
            this.btnReadyItem.Text = "Add to ready stock";
            this.btnReadyItem.UseVisualStyleBackColor = false;
            this.btnReadyItem.Click += new System.EventHandler(this.btnReadyItem_Click);
            // 
            // btnGlazedItem
            // 
            this.btnGlazedItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnGlazedItem.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlazedItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGlazedItem.Location = new System.Drawing.Point(6, 266);
            this.btnGlazedItem.Name = "btnGlazedItem";
            this.btnGlazedItem.Size = new System.Drawing.Size(99, 23);
            this.btnGlazedItem.TabIndex = 19;
            this.btnGlazedItem.Text = "Add to glazed";
            this.btnGlazedItem.UseVisualStyleBackColor = false;
            this.btnGlazedItem.Click += new System.EventHandler(this.btnGlazedItem_Click);
            // 
            // btnPrintUnglaze
            // 
            this.btnPrintUnglaze.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintUnglaze.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintUnglaze.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPrintUnglaze.Location = new System.Drawing.Point(6, 242);
            this.btnPrintUnglaze.Name = "btnPrintUnglaze";
            this.btnPrintUnglaze.Size = new System.Drawing.Size(99, 23);
            this.btnPrintUnglaze.TabIndex = 18;
            this.btnPrintUnglaze.Text = "Add to unglaze";
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
            this.txtReadyItems.Size = new System.Drawing.Size(75, 21);
            this.txtReadyItems.TabIndex = 17;
            this.txtReadyItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReadyItems_KeyPress);
            // 
            // lblReadyItem
            // 
            this.lblReadyItem.AutoSize = true;
            this.lblReadyItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReadyItem.Location = new System.Drawing.Point(16, 220);
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
            this.txtUnglazeQuantity.Size = new System.Drawing.Size(75, 21);
            this.txtUnglazeQuantity.TabIndex = 13;
            this.txtUnglazeQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnglazeQuantity_KeyPress);
            // 
            // txtGlazedQuantity
            // 
            this.txtGlazedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlazedQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGlazedQuantity.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtGlazedQuantity.Location = new System.Drawing.Point(143, 190);
            this.txtGlazedQuantity.Name = "txtGlazedQuantity";
            this.txtGlazedQuantity.Size = new System.Drawing.Size(75, 21);
            this.txtGlazedQuantity.TabIndex = 15;
            this.txtGlazedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlazedQuantity_KeyPress);
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
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSearch.Controls.Add(this.btnDeleteReady);
            this.gbxSearch.Controls.Add(this.btnDeleteGlaze);
            this.gbxSearch.Controls.Add(this.btnDeleteUnglaze);
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
            this.gbxSearch.Location = new System.Drawing.Point(0, -1);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(224, 317);
            this.gbxSearch.TabIndex = 4;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Update";
            // 
            // btnDeleteReady
            // 
            this.btnDeleteReady.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteReady.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReady.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteReady.Location = new System.Drawing.Point(105, 291);
            this.btnDeleteReady.Name = "btnDeleteReady";
            this.btnDeleteReady.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteReady.TabIndex = 23;
            this.btnDeleteReady.Text = "Delete from ready";
            this.btnDeleteReady.UseVisualStyleBackColor = false;
            this.btnDeleteReady.Click += new System.EventHandler(this.btnDeleteReady_Click);
            // 
            // btnDeleteGlaze
            // 
            this.btnDeleteGlaze.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteGlaze.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGlaze.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteGlaze.Location = new System.Drawing.Point(105, 266);
            this.btnDeleteGlaze.Name = "btnDeleteGlaze";
            this.btnDeleteGlaze.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteGlaze.TabIndex = 22;
            this.btnDeleteGlaze.Text = "Delete from glazed";
            this.btnDeleteGlaze.UseVisualStyleBackColor = false;
            this.btnDeleteGlaze.Click += new System.EventHandler(this.btnDeleteGlaze_Click);
            // 
            // btnDeleteUnglaze
            // 
            this.btnDeleteUnglaze.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteUnglaze.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnglaze.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteUnglaze.Location = new System.Drawing.Point(105, 242);
            this.btnDeleteUnglaze.Name = "btnDeleteUnglaze";
            this.btnDeleteUnglaze.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteUnglaze.TabIndex = 21;
            this.btnDeleteUnglaze.Text = "Delete from unglaze";
            this.btnDeleteUnglaze.UseVisualStyleBackColor = false;
            this.btnDeleteUnglaze.Click += new System.EventHandler(this.btnDeleteUnglaze_Click);
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
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 120;
            // 
            // Quantities
            // 
            this.Quantities.HeaderText = "Quantity";
            this.Quantities.Name = "Quantities";
            this.Quantities.ReadOnly = true;
            this.Quantities.Width = 73;
            // 
            // quantitiess
            // 
            this.quantitiess.HeaderText = "Quantity";
            this.quantitiess.Name = "quantitiess";
            this.quantitiess.ReadOnly = true;
            this.quantitiess.Width = 97;
            // 
            // colorss
            // 
            this.colorss.HeaderText = "Color";
            this.colorss.Name = "colorss";
            this.colorss.ReadOnly = true;
            this.colorss.Width = 130;
            // 
            // gbxGlazedStock
            // 
            this.gbxGlazedStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxGlazedStock.Controls.Add(this.dgvGlazedStock);
            this.gbxGlazedStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGlazedStock.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxGlazedStock.Location = new System.Drawing.Point(229, 168);
            this.gbxGlazedStock.Name = "gbxGlazedStock";
            this.gbxGlazedStock.Size = new System.Drawing.Size(553, 149);
            this.gbxGlazedStock.TabIndex = 6;
            this.gbxGlazedStock.TabStop = false;
            this.gbxGlazedStock.Text = "Glazed Stock";
            // 
            // dgvGlazedStock
            // 
            this.dgvGlazedStock.AllowUserToAddRows = false;
            this.dgvGlazedStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGlazedStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGlazedStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGlazedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlazedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemss,
            this.style,
            this.size,
            this.colors,
            this.Quantity});
            this.dgvGlazedStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGlazedStock.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvGlazedStock.Location = new System.Drawing.Point(3, 17);
            this.dgvGlazedStock.Name = "dgvGlazedStock";
            this.dgvGlazedStock.ReadOnly = true;
            this.dgvGlazedStock.Size = new System.Drawing.Size(547, 129);
            this.dgvGlazedStock.TabIndex = 0;
            this.dgvGlazedStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlazedStock_CellClick);
            // 
            // itemss
            // 
            this.itemss.HeaderText = "Item";
            this.itemss.Name = "itemss";
            this.itemss.ReadOnly = true;
            this.itemss.Width = 113;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 110;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 105;
            // 
            // colors
            // 
            this.colors.HeaderText = "Color";
            this.colors.Name = "colors";
            this.colors.ReadOnly = true;
            this.colors.Width = 105;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 70;
            // 
            // sizess
            // 
            this.sizess.HeaderText = "Size";
            this.sizess.Name = "sizess";
            this.sizess.ReadOnly = true;
            this.sizess.Width = 130;
            // 
            // styless
            // 
            this.styless.HeaderText = "Style";
            this.styless.Name = "styless";
            this.styless.ReadOnly = true;
            this.styless.Width = 130;
            // 
            // dgvReadyItems
            // 
            this.dgvReadyItems.AllowUserToAddRows = false;
            this.dgvReadyItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReadyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadyItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemsss,
            this.styless,
            this.sizess,
            this.colorss,
            this.category,
            this.quantitiess});
            this.dgvReadyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReadyItems.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvReadyItems.Location = new System.Drawing.Point(3, 17);
            this.dgvReadyItems.Name = "dgvReadyItems";
            this.dgvReadyItems.ReadOnly = true;
            this.dgvReadyItems.Size = new System.Drawing.Size(778, 183);
            this.dgvReadyItems.TabIndex = 0;
            this.dgvReadyItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReadyItems_CellClick);
            // 
            // itemsss
            // 
            this.itemsss.HeaderText = "Item";
            this.itemsss.Name = "itemsss";
            this.itemsss.ReadOnly = true;
            this.itemsss.Width = 127;
            // 
            // gbxReadyItem
            // 
            this.gbxReadyItem.BackColor = System.Drawing.SystemColors.Control;
            this.gbxReadyItem.Controls.Add(this.dgvReadyItems);
            this.gbxReadyItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReadyItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxReadyItem.Location = new System.Drawing.Point(0, 314);
            this.gbxReadyItem.Name = "gbxReadyItem";
            this.gbxReadyItem.Size = new System.Drawing.Size(784, 203);
            this.gbxReadyItem.TabIndex = 7;
            this.gbxReadyItem.TabStop = false;
            this.gbxReadyItem.Text = "Ready Items Stock";
            // 
            // items
            // 
            this.items.HeaderText = "Item";
            this.items.Name = "items";
            this.items.ReadOnly = true;
            this.items.Width = 150;
            // 
            // styles
            // 
            this.styles.HeaderText = "Style";
            this.styles.Name = "styles";
            this.styles.ReadOnly = true;
            this.styles.Width = 155;
            // 
            // sizes
            // 
            this.sizes.HeaderText = "Size";
            this.sizes.Name = "sizes";
            this.sizes.ReadOnly = true;
            this.sizes.Width = 125;
            // 
            // dgvUnglazeStock
            // 
            this.dgvUnglazeStock.AllowUserToAddRows = false;
            this.dgvUnglazeStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUnglazeStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnglazeStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUnglazeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnglazeStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.items,
            this.styles,
            this.sizes,
            this.Quantities});
            this.dgvUnglazeStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnglazeStock.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvUnglazeStock.Location = new System.Drawing.Point(3, 17);
            this.dgvUnglazeStock.Name = "dgvUnglazeStock";
            this.dgvUnglazeStock.ReadOnly = true;
            this.dgvUnglazeStock.Size = new System.Drawing.Size(547, 150);
            this.dgvUnglazeStock.TabIndex = 0;
            this.dgvUnglazeStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnglazeStock_CellClick);
            // 
            // gbxUnglazeStock
            // 
            this.gbxUnglazeStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUnglazeStock.Controls.Add(this.dgvUnglazeStock);
            this.gbxUnglazeStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUnglazeStock.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxUnglazeStock.Location = new System.Drawing.Point(230, -1);
            this.gbxUnglazeStock.Name = "gbxUnglazeStock";
            this.gbxUnglazeStock.Size = new System.Drawing.Size(553, 170);
            this.gbxUnglazeStock.TabIndex = 5;
            this.gbxUnglazeStock.TabStop = false;
            this.gbxUnglazeStock.Text = "Unglaze Stock";
            // 
            // frmManageItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxGlazedStock);
            this.Controls.Add(this.gbxReadyItem);
            this.Controls.Add(this.gbxUnglazeStock);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmManageItemStock";
            this.Text = "Manage Item\'s ";
            this.Load += new System.EventHandler(this.frmUpdateItemStock_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxGlazedStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadyItems)).EndInit();
            this.gbxReadyItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnglazeStock)).EndInit();
            this.gbxUnglazeStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadyItem;
        private System.Windows.Forms.Button btnGlazedItem;
        private System.Windows.Forms.Button btnPrintUnglaze;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox txtReadyItems;
        private System.Windows.Forms.Label lblReadyItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUnglazeQuantity;
        private System.Windows.Forms.TextBox txtGlazedQuantity;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.Label lblUnglaze;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblGlazedQuantity;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitiess;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorss;
        private System.Windows.Forms.GroupBox gbxGlazedStock;
        private System.Windows.Forms.DataGridView dgvGlazedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemss;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn colors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizess;
        private System.Windows.Forms.DataGridViewTextBoxColumn styless;
        private System.Windows.Forms.DataGridView dgvReadyItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsss;
        private System.Windows.Forms.GroupBox gbxReadyItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn items;
        private System.Windows.Forms.DataGridViewTextBoxColumn styles;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizes;
        private System.Windows.Forms.DataGridView dgvUnglazeStock;
        private System.Windows.Forms.GroupBox gbxUnglazeStock;
        private System.Windows.Forms.Button btnDeleteReady;
        private System.Windows.Forms.Button btnDeleteGlaze;
        private System.Windows.Forms.Button btnDeleteUnglaze;
    }
}