namespace MasterCeramicsERP
{
    partial class frmGlazedItemBreakage
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
            this.cbxRemarks = new System.Windows.Forms.ComboBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.dgvItemBreakage = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxBreakageReport = new System.Windows.Forms.GroupBox();
            this.gbxGlazedStock = new System.Windows.Forms.GroupBox();
            this.dgvGlazedStock = new System.Windows.Forms.DataGridView();
            this.ItemRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.chkbxAddRemarks = new System.Windows.Forms.CheckBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemBreakage)).BeginInit();
            this.gbxBreakageReport.SuspendLayout();
            this.gbxGlazedStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRemarks
            // 
            this.cbxRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRemarks.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbxRemarks.FormattingEnabled = true;
            this.cbxRemarks.Location = new System.Drawing.Point(581, 115);
            this.cbxRemarks.Name = "cbxRemarks";
            this.cbxRemarks.Size = new System.Drawing.Size(200, 21);
            this.cbxRemarks.TabIndex = 5;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblRemark.Location = new System.Drawing.Point(576, 99);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(64, 13);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "Remarks";
            // 
            // dgvItemBreakage
            // 
            this.dgvItemBreakage.AllowUserToAddRows = false;
            this.dgvItemBreakage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItemBreakage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItemBreakage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItemBreakage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemBreakage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.style,
            this.size,
            this.color,
            this.quantity,
            this.remark});
            this.dgvItemBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemBreakage.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvItemBreakage.Location = new System.Drawing.Point(3, 14);
            this.dgvItemBreakage.Name = "dgvItemBreakage";
            this.dgvItemBreakage.ReadOnly = true;
            this.dgvItemBreakage.Size = new System.Drawing.Size(781, 222);
            this.dgvItemBreakage.TabIndex = 0;
            this.dgvItemBreakage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemBreakage_CellClick);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 130;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 130;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 130;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 130;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 150;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnRefresh.Location = new System.Drawing.Point(498, 249);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 25);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAdd.Location = new System.Drawing.Point(247, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(581, 71);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(200, 21);
            this.cbxWorker.TabIndex = 3;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblWorker.Location = new System.Drawing.Point(575, 55);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 2;
            this.lblWorker.Text = "Glazer";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblQuantity.Location = new System.Drawing.Point(578, 139);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAddDB.Location = new System.Drawing.Point(414, 249);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(78, 25);
            this.btnAddDB.TabIndex = 12;
            this.btnAddDB.Text = "Save";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtQuantity.Location = new System.Drawing.Point(581, 158);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(195, 21);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnDeleteRecord.Location = new System.Drawing.Point(331, 249);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(78, 25);
            this.btnDeleteRecord.TabIndex = 13;
            this.btnDeleteRecord.Text = "Delete ";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxBreakageReport
            // 
            this.gbxBreakageReport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxBreakageReport.Controls.Add(this.dgvItemBreakage);
            this.gbxBreakageReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBreakageReport.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxBreakageReport.Location = new System.Drawing.Point(-2, 275);
            this.gbxBreakageReport.Name = "gbxBreakageReport";
            this.gbxBreakageReport.Size = new System.Drawing.Size(787, 239);
            this.gbxBreakageReport.TabIndex = 14;
            this.gbxBreakageReport.TabStop = false;
            this.gbxBreakageReport.Text = "Glazed Item Breakage Report";
            // 
            // gbxGlazedStock
            // 
            this.gbxGlazedStock.Controls.Add(this.dgvGlazedStock);
            this.gbxGlazedStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGlazedStock.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxGlazedStock.Location = new System.Drawing.Point(3, 3);
            this.gbxGlazedStock.Name = "gbxGlazedStock";
            this.gbxGlazedStock.Size = new System.Drawing.Size(573, 244);
            this.gbxGlazedStock.TabIndex = 1;
            this.gbxGlazedStock.TabStop = false;
            this.gbxGlazedStock.Text = "Glazed Item Stock";
            // 
            // dgvGlazedStock
            // 
            this.dgvGlazedStock.AllowUserToAddRows = false;
            this.dgvGlazedStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGlazedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlazedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemRemainingMold,
            this.styleRemainingMold,
            this.sizeRemainingMold,
            this.colors,
            this.quantities});
            this.dgvGlazedStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGlazedStock.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvGlazedStock.Location = new System.Drawing.Point(3, 14);
            this.dgvGlazedStock.Name = "dgvGlazedStock";
            this.dgvGlazedStock.ReadOnly = true;
            this.dgvGlazedStock.Size = new System.Drawing.Size(567, 227);
            this.dgvGlazedStock.TabIndex = 0;
            this.dgvGlazedStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlazedStock_CellClick);
            // 
            // ItemRemainingMold
            // 
            this.ItemRemainingMold.HeaderText = "Item";
            this.ItemRemainingMold.Name = "ItemRemainingMold";
            this.ItemRemainingMold.ReadOnly = true;
            this.ItemRemainingMold.Width = 125;
            // 
            // styleRemainingMold
            // 
            this.styleRemainingMold.HeaderText = "Style";
            this.styleRemainingMold.Name = "styleRemainingMold";
            this.styleRemainingMold.ReadOnly = true;
            // 
            // sizeRemainingMold
            // 
            this.sizeRemainingMold.HeaderText = "Size";
            this.sizeRemainingMold.Name = "sizeRemainingMold";
            this.sizeRemainingMold.ReadOnly = true;
            // 
            // colors
            // 
            this.colors.HeaderText = "Color";
            this.colors.Name = "colors";
            this.colors.ReadOnly = true;
            // 
            // quantities
            // 
            this.quantities.HeaderText = "Quantity";
            this.quantities.Name = "quantities";
            this.quantities.ReadOnly = true;
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblSelectJob.Location = new System.Drawing.Point(575, 16);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 18;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(579, 31);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(202, 21);
            this.cbxSelectJob.TabIndex = 19;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // chkbxAddRemarks
            // 
            this.chkbxAddRemarks.AutoSize = true;
            this.chkbxAddRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxAddRemarks.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkbxAddRemarks.Location = new System.Drawing.Point(582, 185);
            this.chkbxAddRemarks.Name = "chkbxAddRemarks";
            this.chkbxAddRemarks.Size = new System.Drawing.Size(112, 17);
            this.chkbxAddRemarks.TabIndex = 20;
            this.chkbxAddRemarks.Text = "Add Remarks";
            this.chkbxAddRemarks.UseVisualStyleBackColor = true;
            this.chkbxAddRemarks.CheckedChanged += new System.EventHandler(this.chkbxAddRemarks_CheckedChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtRemarks.Location = new System.Drawing.Point(582, 208);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(203, 67);
            this.txtRemarks.TabIndex = 21;
            // 
            // frmGlazedItemBreakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.chkbxAddRemarks);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.gbxGlazedStock);
            this.Controls.Add(this.gbxBreakageReport);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.cbxRemarks);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.txtQuantity);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmGlazedItemBreakage";
            this.Text = "Add Glazed Item Breakage Report";
            this.Load += new System.EventHandler(this.frmGlazedItemBreakage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemBreakage)).EndInit();
            this.gbxBreakageReport.ResumeLayout(false);
            this.gbxGlazedStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRemarks;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.DataGridView dgvItemBreakage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxBreakageReport;
        private System.Windows.Forms.GroupBox gbxGlazedStock;
        private System.Windows.Forms.DataGridView dgvGlazedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colors;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantities;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.CheckBox chkbxAddRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}