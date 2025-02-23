namespace MasterCeramicsERP
{
    partial class frmAddItemRate
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblSize_slipFromItem = new System.Windows.Forms.Label();
            this.lblStyle_slipFromItem = new System.Windows.Forms.Label();
            this.lblItem_slipFromItem = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvItemWeight = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxItem = new System.Windows.Forms.GroupBox();
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemWeight)).BeginInit();
            this.gbxItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblWeight.Location = new System.Drawing.Point(12, 58);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(79, 13);
            this.lblWeight.TabIndex = 20;
            this.lblWeight.Text = "Enter Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrice.Location = new System.Drawing.Point(15, 74);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 21);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPrice_MouseClick);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSize.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(328, 34);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(150, 21);
            this.cbxSize.TabIndex = 19;
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(172, 34);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(150, 21);
            this.cbxStyle.Sorted = true;
            this.cbxStyle.TabIndex = 17;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(15, 34);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(150, 21);
            this.cbxItem.Sorted = true;
            this.cbxItem.TabIndex = 15;
            // 
            // lblSize_slipFromItem
            // 
            this.lblSize_slipFromItem.AutoSize = true;
            this.lblSize_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize_slipFromItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSize_slipFromItem.Location = new System.Drawing.Point(325, 9);
            this.lblSize_slipFromItem.Name = "lblSize_slipFromItem";
            this.lblSize_slipFromItem.Size = new System.Drawing.Size(34, 13);
            this.lblSize_slipFromItem.TabIndex = 18;
            this.lblSize_slipFromItem.Text = "Size";
            // 
            // lblStyle_slipFromItem
            // 
            this.lblStyle_slipFromItem.AutoSize = true;
            this.lblStyle_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle_slipFromItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblStyle_slipFromItem.Location = new System.Drawing.Point(169, 9);
            this.lblStyle_slipFromItem.Name = "lblStyle_slipFromItem";
            this.lblStyle_slipFromItem.Size = new System.Drawing.Size(40, 13);
            this.lblStyle_slipFromItem.TabIndex = 16;
            this.lblStyle_slipFromItem.Text = "Style";
            // 
            // lblItem_slipFromItem
            // 
            this.lblItem_slipFromItem.AutoSize = true;
            this.lblItem_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_slipFromItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblItem_slipFromItem.Location = new System.Drawing.Point(12, 9);
            this.lblItem_slipFromItem.Name = "lblItem_slipFromItem";
            this.lblItem_slipFromItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem_slipFromItem.TabIndex = 14;
            this.lblItem_slipFromItem.Text = "Item";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(633, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdate.Location = new System.Drawing.Point(328, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.Location = new System.Drawing.Point(171, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvItemWeight
            // 
            this.dgvItemWeight.AllowUserToAddRows = false;
            this.dgvItemWeight.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItemWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemWeight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Style,
            this.Size,
            this.Color,
            this.Category,
            this.Price});
            this.dgvItemWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemWeight.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvItemWeight.Location = new System.Drawing.Point(3, 18);
            this.dgvItemWeight.Name = "dgvItemWeight";
            this.dgvItemWeight.ReadOnly = true;
            this.dgvItemWeight.Size = new System.Drawing.Size(754, 381);
            this.dgvItemWeight.TabIndex = 0;
            this.dgvItemWeight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemWeight_CellClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 150;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 150;
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
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 137;
            // 
            // gbxItem
            // 
            this.gbxItem.Controls.Add(this.dgvItemWeight);
            this.gbxItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbxItem.Location = new System.Drawing.Point(12, 103);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Size = new System.Drawing.Size(760, 402);
            this.gbxItem.TabIndex = 13;
            this.gbxItem.TabStop = false;
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemCategory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(633, 34);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.Size = new System.Drawing.Size(139, 21);
            this.cbxItemCategory.TabIndex = 27;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblItemCategory.Location = new System.Drawing.Point(634, 9);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(101, 13);
            this.lblItemCategory.TabIndex = 26;
            this.lblItemCategory.Text = "Item Category";
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(484, 34);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(143, 21);
            this.cbxColor.TabIndex = 29;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblColor.Location = new System.Drawing.Point(481, 9);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 28;
            this.lblColor.Text = "Color";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPrint.Location = new System.Drawing.Point(484, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 23);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "Print Price List";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmAddItemRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbxItemCategory);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.lblSize_slipFromItem);
            this.Controls.Add(this.lblStyle_slipFromItem);
            this.Controls.Add(this.lblItem_slipFromItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxItem);
            this.Name = "frmAddItemRate";
            this.Text = "Manage Item Rate";
            this.Load += new System.EventHandler(this.frmAddItemRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemWeight)).EndInit();
            this.gbxItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblSize_slipFromItem;
        private System.Windows.Forms.Label lblStyle_slipFromItem;
        private System.Windows.Forms.Label lblItem_slipFromItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvItemWeight;
        private System.Windows.Forms.GroupBox gbxItem;
        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
    }
}