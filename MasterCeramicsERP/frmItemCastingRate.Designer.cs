namespace MasterCeramicsERP
{
    partial class frmItemCastingRate
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
            this.gbxItem = new System.Windows.Forms.GroupBox();
            this.dgvItemWeight = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtItemRate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblSize_slipFromItem = new System.Windows.Forms.Label();
            this.lblStyle_slipFromItem = new System.Windows.Forms.Label();
            this.lblItem_slipFromItem = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbxItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxItem
            // 
            this.gbxItem.Controls.Add(this.dgvItemWeight);
            this.gbxItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxItem.Location = new System.Drawing.Point(7, 81);
            this.gbxItem.Name = "gbxItem";
            this.gbxItem.Size = new System.Drawing.Size(769, 424);
            this.gbxItem.TabIndex = 13;
            this.gbxItem.TabStop = false;
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
            this.Rate});
            this.dgvItemWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemWeight.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvItemWeight.Location = new System.Drawing.Point(3, 17);
            this.dgvItemWeight.Name = "dgvItemWeight";
            this.dgvItemWeight.ReadOnly = true;
            this.dgvItemWeight.Size = new System.Drawing.Size(763, 404);
            this.dgvItemWeight.TabIndex = 0;
            this.dgvItemWeight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemWeight_CellClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 200;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 200;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 200;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 137;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdate.Location = new System.Drawing.Point(696, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRate.Location = new System.Drawing.Point(584, 7);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(83, 13);
            this.lblRate.TabIndex = 24;
            this.lblRate.Text = "Enter Rate :";
            // 
            // txtItemRate
            // 
            this.txtItemRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemRate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtItemRate.Location = new System.Drawing.Point(587, 25);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(185, 21);
            this.txtItemRate.TabIndex = 25;
            this.txtItemRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtItemRate_MouseClick);
            this.txtItemRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemRate_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(589, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(396, 25);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(185, 21);
            this.cbxSize.TabIndex = 23;
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(206, 25);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(184, 21);
            this.cbxStyle.Sorted = true;
            this.cbxStyle.TabIndex = 21;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(15, 25);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(185, 21);
            this.cbxItem.Sorted = true;
            this.cbxItem.TabIndex = 19;
            // 
            // lblSize_slipFromItem
            // 
            this.lblSize_slipFromItem.AutoSize = true;
            this.lblSize_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize_slipFromItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSize_slipFromItem.Location = new System.Drawing.Point(393, 7);
            this.lblSize_slipFromItem.Name = "lblSize_slipFromItem";
            this.lblSize_slipFromItem.Size = new System.Drawing.Size(34, 13);
            this.lblSize_slipFromItem.TabIndex = 22;
            this.lblSize_slipFromItem.Text = "Size";
            // 
            // lblStyle_slipFromItem
            // 
            this.lblStyle_slipFromItem.AutoSize = true;
            this.lblStyle_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle_slipFromItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStyle_slipFromItem.Location = new System.Drawing.Point(203, 9);
            this.lblStyle_slipFromItem.Name = "lblStyle_slipFromItem";
            this.lblStyle_slipFromItem.Size = new System.Drawing.Size(40, 13);
            this.lblStyle_slipFromItem.TabIndex = 20;
            this.lblStyle_slipFromItem.Text = "Style";
            // 
            // lblItem_slipFromItem
            // 
            this.lblItem_slipFromItem.AutoSize = true;
            this.lblItem_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_slipFromItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblItem_slipFromItem.Location = new System.Drawing.Point(12, 9);
            this.lblItem_slipFromItem.Name = "lblItem_slipFromItem";
            this.lblItem_slipFromItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem_slipFromItem.TabIndex = 18;
            this.lblItem_slipFromItem.Text = "Item";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPrint.Location = new System.Drawing.Point(15, 52);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(185, 23);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Print Rate List";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmItemCastingRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtItemRate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.lblSize_slipFromItem);
            this.Controls.Add(this.lblStyle_slipFromItem);
            this.Controls.Add(this.lblItem_slipFromItem);
            this.Controls.Add(this.gbxItem);
            this.Name = "frmItemCastingRate";
            this.Text = "Manage Casting Rate";
            this.Load += new System.EventHandler(this.frmItemCastingRate_Load);
            this.gbxItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxItem;
        private System.Windows.Forms.DataGridView dgvItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtItemRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblSize_slipFromItem;
        private System.Windows.Forms.Label lblStyle_slipFromItem;
        private System.Windows.Forms.Label lblItem_slipFromItem;
        private System.Windows.Forms.Button btnPrint;
    }
}