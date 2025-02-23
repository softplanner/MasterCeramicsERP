namespace MasterCeramicsERP
{
    partial class frmCompanyMoldStock
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
            this.dgvMold = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.txtMoldQuantity = new System.Windows.Forms.TextBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblMoldQuantity = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.gbxMold = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.gbxMold.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMold
            // 
            this.dgvMold.AllowUserToAddRows = false;
            this.dgvMold.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.style,
            this.size,
            this.Quantity});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMold.GridColor = System.Drawing.Color.Navy;
            this.dgvMold.Location = new System.Drawing.Point(3, 17);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.Size = new System.Drawing.Size(764, 313);
            this.dgvMold.TabIndex = 0;
            this.dgvMold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMold_CellClick);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 213;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 200;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 190;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 118;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnDelete);
            this.gbxSearch.Controls.Add(this.btnAdd);
            this.gbxSearch.Controls.Add(this.btnPrint);
            this.gbxSearch.Controls.Add(this.btnUpdate);
            this.gbxSearch.Controls.Add(this.lblUpdateQuantity);
            this.gbxSearch.Controls.Add(this.btnRefresh);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.txtUpdate);
            this.gbxSearch.Controls.Add(this.txtMoldQuantity);
            this.gbxSearch.Controls.Add(this.cbxSize);
            this.gbxSearch.Controls.Add(this.cbxStyle);
            this.gbxSearch.Controls.Add(this.cbxItem);
            this.gbxSearch.Controls.Add(this.lblMoldQuantity);
            this.gbxSearch.Controls.Add(this.lblSize);
            this.gbxSearch.Controls.Add(this.lblStyle);
            this.gbxSearch.Controls.Add(this.lblItem);
            this.gbxSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.Location = new System.Drawing.Point(7, 7);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(769, 165);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Mold Stock";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(397, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Mold";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(397, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add New Mold";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.Location = new System.Drawing.Point(651, 136);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Location = new System.Drawing.Point(397, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(9, 136);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(151, 13);
            this.lblUpdateQuantity.TabIndex = 8;
            this.lblUpdateQuantity.Text = "Enter Update Quantity";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(397, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(397, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdate.ForeColor = System.Drawing.Color.Navy;
            this.txtUpdate.Location = new System.Drawing.Point(166, 133);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(225, 21);
            this.txtUpdate.TabIndex = 9;
            this.txtUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdate_MouseClick);
            this.txtUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdate_KeyPress);
            // 
            // txtMoldQuantity
            // 
            this.txtMoldQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoldQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtMoldQuantity.Location = new System.Drawing.Point(166, 106);
            this.txtMoldQuantity.Name = "txtMoldQuantity";
            this.txtMoldQuantity.Size = new System.Drawing.Size(225, 21);
            this.txtMoldQuantity.TabIndex = 7;
            this.txtMoldQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMoldQuantity_MouseClick);
            this.txtMoldQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoldQuantity_KeyPress);
            // 
            // cbxSize
            // 
            this.cbxSize.BackColor = System.Drawing.SystemColors.Control;
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.ForeColor = System.Drawing.Color.Navy;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(166, 79);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(225, 21);
            this.cbxSize.TabIndex = 5;
            // 
            // cbxStyle
            // 
            this.cbxStyle.BackColor = System.Drawing.SystemColors.Control;
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.ForeColor = System.Drawing.Color.Navy;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(166, 52);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(225, 21);
            this.cbxStyle.Sorted = true;
            this.cbxStyle.TabIndex = 3;
            // 
            // cbxItem
            // 
            this.cbxItem.BackColor = System.Drawing.SystemColors.Control;
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.ForeColor = System.Drawing.Color.Navy;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(166, 25);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(225, 21);
            this.cbxItem.Sorted = true;
            this.cbxItem.TabIndex = 1;
            // 
            // lblMoldQuantity
            // 
            this.lblMoldQuantity.AutoSize = true;
            this.lblMoldQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblMoldQuantity.Location = new System.Drawing.Point(9, 108);
            this.lblMoldQuantity.Name = "lblMoldQuantity";
            this.lblMoldQuantity.Size = new System.Drawing.Size(96, 13);
            this.lblMoldQuantity.TabIndex = 6;
            this.lblMoldQuantity.Text = "Mold Quantity";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.Navy;
            this.lblSize.Location = new System.Drawing.Point(9, 82);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.Navy;
            this.lblStyle.Location = new System.Drawing.Point(9, 55);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 2;
            this.lblStyle.Text = "Style";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.Navy;
            this.lblItem.Location = new System.Drawing.Point(9, 28);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // gbxMold
            // 
            this.gbxMold.Controls.Add(this.dgvMold);
            this.gbxMold.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMold.ForeColor = System.Drawing.Color.Navy;
            this.gbxMold.Location = new System.Drawing.Point(6, 178);
            this.gbxMold.Name = "gbxMold";
            this.gbxMold.Size = new System.Drawing.Size(770, 333);
            this.gbxMold.TabIndex = 1;
            this.gbxMold.TabStop = false;
            this.gbxMold.Text = "Company Mold Stock";
            // 
            // frmCompanyMoldStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxMold);
            this.Controls.Add(this.gbxSearch);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmCompanyMoldStock";
            this.Text = "Company Mold Stock";
            this.Load += new System.EventHandler(this.frmCompanyMoldStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxMold.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMoldQuantity;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblMoldQuantity;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.GroupBox gbxMold;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}