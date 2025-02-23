namespace MasterCeramicsERP
{
    partial class frmUnGlazeItemBreakage
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.ItemRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxUnglazedItemBreakage = new System.Windows.Forms.GroupBox();
            this.gbxCasterStockInfo = new System.Windows.Forms.GroupBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.chkbxRemarks = new System.Windows.Forms.CheckBox();
            this.cbxRemarks = new System.Windows.Forms.ComboBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cbxBreakageType = new System.Windows.Forms.ComboBox();
            this.lblBreakageType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.gbxUnglazedItemBreakage.SuspendLayout();
            this.gbxCasterStockInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worker,
            this.item,
            this.style,
            this.size,
            this.breakageType,
            this.quantity,
            this.remark});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvReport.Location = new System.Drawing.Point(4, 17);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(778, 222);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // worker
            // 
            this.worker.HeaderText = "Caster";
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            this.worker.Width = 150;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // breakageType
            // 
            this.breakageType.HeaderText = "Breakage Type";
            this.breakageType.Name = "breakageType";
            this.breakageType.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 70;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 115;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 231);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemRemainingMold,
            this.styleRemainingMold,
            this.sizeRemainingMold,
            this.quantities});
            this.dgvStock.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvStock.Location = new System.Drawing.Point(269, 13);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(502, 243);
            this.dgvStock.TabIndex = 1;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorker_CellClick);
            // 
            // ItemRemainingMold
            // 
            this.ItemRemainingMold.HeaderText = "Item";
            this.ItemRemainingMold.Name = "ItemRemainingMold";
            this.ItemRemainingMold.ReadOnly = true;
            this.ItemRemainingMold.Width = 130;
            // 
            // styleRemainingMold
            // 
            this.styleRemainingMold.HeaderText = "Style";
            this.styleRemainingMold.Name = "styleRemainingMold";
            this.styleRemainingMold.ReadOnly = true;
            this.styleRemainingMold.Width = 120;
            // 
            // sizeRemainingMold
            // 
            this.sizeRemainingMold.HeaderText = "Size";
            this.sizeRemainingMold.Name = "sizeRemainingMold";
            this.sizeRemainingMold.ReadOnly = true;
            this.sizeRemainingMold.Width = 120;
            // 
            // quantities
            // 
            this.quantities.HeaderText = "Quantity";
            this.quantities.Name = "quantities";
            this.quantities.ReadOnly = true;
            this.quantities.Width = 84;
            // 
            // btnAddDB
            // 
            this.btnAddDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.Location = new System.Drawing.Point(195, 231);
            this.btnAddDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(66, 25);
            this.btnAddDB.TabIndex = 12;
            this.btnAddDB.Text = "Save";
            this.btnAddDB.UseVisualStyleBackColor = false;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(101, 231);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(66, 25);
            this.btnDeleteRecord.TabIndex = 11;
            this.btnDeleteRecord.Text = "Delete ";
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxUnglazedItemBreakage
            // 
            this.gbxUnglazedItemBreakage.Controls.Add(this.dgvReport);
            this.gbxUnglazedItemBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUnglazedItemBreakage.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxUnglazedItemBreakage.Location = new System.Drawing.Point(0, 274);
            this.gbxUnglazedItemBreakage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUnglazedItemBreakage.Name = "gbxUnglazedItemBreakage";
            this.gbxUnglazedItemBreakage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUnglazedItemBreakage.Size = new System.Drawing.Size(786, 242);
            this.gbxUnglazedItemBreakage.TabIndex = 1;
            this.gbxUnglazedItemBreakage.TabStop = false;
            this.gbxUnglazedItemBreakage.Text = "Unglazed Item Breakage Report";
            // 
            // gbxCasterStockInfo
            // 
            this.gbxCasterStockInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbxCasterStockInfo.Controls.Add(this.lblSelectJob);
            this.gbxCasterStockInfo.Controls.Add(this.cbxSelectJob);
            this.gbxCasterStockInfo.Controls.Add(this.cbxWorker);
            this.gbxCasterStockInfo.Controls.Add(this.lblWorker);
            this.gbxCasterStockInfo.Controls.Add(this.chkbxRemarks);
            this.gbxCasterStockInfo.Controls.Add(this.cbxRemarks);
            this.gbxCasterStockInfo.Controls.Add(this.dgvStock);
            this.gbxCasterStockInfo.Controls.Add(this.btnDeleteRecord);
            this.gbxCasterStockInfo.Controls.Add(this.lblRemark);
            this.gbxCasterStockInfo.Controls.Add(this.btnAddDB);
            this.gbxCasterStockInfo.Controls.Add(this.txtRemarks);
            this.gbxCasterStockInfo.Controls.Add(this.cbxBreakageType);
            this.gbxCasterStockInfo.Controls.Add(this.btnAdd);
            this.gbxCasterStockInfo.Controls.Add(this.lblBreakageType);
            this.gbxCasterStockInfo.Controls.Add(this.lblQuantity);
            this.gbxCasterStockInfo.Controls.Add(this.txtQuantity);
            this.gbxCasterStockInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxCasterStockInfo.Location = new System.Drawing.Point(5, 4);
            this.gbxCasterStockInfo.Name = "gbxCasterStockInfo";
            this.gbxCasterStockInfo.Size = new System.Drawing.Size(773, 264);
            this.gbxCasterStockInfo.TabIndex = 0;
            this.gbxCasterStockInfo.TabStop = false;
            this.gbxCasterStockInfo.Text = "Caster Casted Mold Stock";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectJob.Location = new System.Drawing.Point(1, 26);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 18;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(114, 23);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(148, 21);
            this.cbxSelectJob.TabIndex = 19;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(114, 50);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(148, 21);
            this.cbxWorker.TabIndex = 17;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWorker.Location = new System.Drawing.Point(1, 53);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 16;
            this.lblWorker.Text = "Caster";
            // 
            // chkbxRemarks
            // 
            this.chkbxRemarks.AutoSize = true;
            this.chkbxRemarks.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxRemarks.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkbxRemarks.Location = new System.Drawing.Point(114, 158);
            this.chkbxRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkbxRemarks.Name = "chkbxRemarks";
            this.chkbxRemarks.Size = new System.Drawing.Size(90, 16);
            this.chkbxRemarks.TabIndex = 8;
            this.chkbxRemarks.Text = "Add Remarks";
            this.chkbxRemarks.UseVisualStyleBackColor = true;
            this.chkbxRemarks.CheckedChanged += new System.EventHandler(this.chkbxRemarks_CheckedChanged);
            // 
            // cbxRemarks
            // 
            this.cbxRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRemarks.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxRemarks.FormattingEnabled = true;
            this.cbxRemarks.Location = new System.Drawing.Point(114, 131);
            this.cbxRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxRemarks.Name = "cbxRemarks";
            this.cbxRemarks.Size = new System.Drawing.Size(148, 21);
            this.cbxRemarks.TabIndex = 7;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRemark.Location = new System.Drawing.Point(1, 134);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(64, 13);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtRemarks.Location = new System.Drawing.Point(8, 180);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(253, 45);
            this.txtRemarks.TabIndex = 9;
            this.txtRemarks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRemarks_MouseClick);
            // 
            // cbxBreakageType
            // 
            this.cbxBreakageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBreakageType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBreakageType.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxBreakageType.FormattingEnabled = true;
            this.cbxBreakageType.Items.AddRange(new object[] {
            "Dry ",
            "Before Dry "});
            this.cbxBreakageType.Location = new System.Drawing.Point(114, 77);
            this.cbxBreakageType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxBreakageType.Name = "cbxBreakageType";
            this.cbxBreakageType.Size = new System.Drawing.Size(148, 21);
            this.cbxBreakageType.TabIndex = 3;
            // 
            // lblBreakageType
            // 
            this.lblBreakageType.AutoSize = true;
            this.lblBreakageType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakageType.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBreakageType.Location = new System.Drawing.Point(1, 80);
            this.lblBreakageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreakageType.Name = "lblBreakageType";
            this.lblBreakageType.Size = new System.Drawing.Size(105, 13);
            this.lblBreakageType.TabIndex = 2;
            this.lblBreakageType.Text = "Breakage Type";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblQuantity.Location = new System.Drawing.Point(1, 107);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtQuantity.Location = new System.Drawing.Point(114, 104);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 21);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // frmUnGlazeItemBreakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxCasterStockInfo);
            this.Controls.Add(this.gbxUnglazedItemBreakage);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmUnGlazeItemBreakage";
            this.Text = "Add UnGlazed Item Breakage Report";
            this.Load += new System.EventHandler(this.frmUnGlazeItemBreakage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.gbxUnglazedItemBreakage.ResumeLayout(false);
            this.gbxCasterStockInfo.ResumeLayout(false);
            this.gbxCasterStockInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxUnglazedItemBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantities;
        private System.Windows.Forms.GroupBox gbxCasterStockInfo;
        private System.Windows.Forms.CheckBox chkbxRemarks;
        private System.Windows.Forms.ComboBox cbxRemarks;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cbxBreakageType;
        private System.Windows.Forms.Label lblBreakageType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
    }
}