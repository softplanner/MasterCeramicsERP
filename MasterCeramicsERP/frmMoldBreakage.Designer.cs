namespace MasterCeramicsERP
{
    partial class frmMoldBreakage
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
            this.dgvMoldBreakage = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.ItemRemainingItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleRemainingItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRemainingItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkbxAddRemarks = new System.Windows.Forms.CheckBox();
            this.cbxRemarks = new System.Windows.Forms.ComboBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.gbxStock = new System.Windows.Forms.GroupBox();
            this.gbxMoldBreakageReport = new System.Windows.Forms.GroupBox();
            this.btnIncreaseStock = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoldBreakage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.gbxStock.SuspendLayout();
            this.gbxMoldBreakageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMoldBreakage
            // 
            this.dgvMoldBreakage.AllowUserToAddRows = false;
            this.dgvMoldBreakage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMoldBreakage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMoldBreakage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMoldBreakage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoldBreakage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.style,
            this.size,
            this.quantity,
            this.remark});
            this.dgvMoldBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMoldBreakage.GridColor = System.Drawing.Color.Navy;
            this.dgvMoldBreakage.Location = new System.Drawing.Point(3, 14);
            this.dgvMoldBreakage.Name = "dgvMoldBreakage";
            this.dgvMoldBreakage.ReadOnly = true;
            this.dgvMoldBreakage.Size = new System.Drawing.Size(773, 270);
            this.dgvMoldBreakage.TabIndex = 0;
            this.dgvMoldBreakage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoldBreakage_CellClick);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 150;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 150;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 180;
            // 
            // btnAddDB
            // 
            this.btnAddDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.Navy;
            this.btnAddDB.Location = new System.Drawing.Point(145, 199);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(66, 22);
            this.btnAddDB.TabIndex = 8;
            this.btnAddDB.Text = "Save Into Database";
            this.btnAddDB.UseVisualStyleBackColor = false;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(214, 198);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(5, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtQuantity.Location = new System.Drawing.Point(565, 74);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(205, 21);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblQuantity.Location = new System.Drawing.Point(458, 76);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemRemainingItem,
            this.styleRemainingItem,
            this.sizeRemainingItem,
            this.quantities});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.GridColor = System.Drawing.Color.Navy;
            this.dgvStock.Location = new System.Drawing.Point(3, 14);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(451, 171);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // ItemRemainingItem
            // 
            this.ItemRemainingItem.HeaderText = "Item";
            this.ItemRemainingItem.Name = "ItemRemainingItem";
            this.ItemRemainingItem.ReadOnly = true;
            this.ItemRemainingItem.Width = 110;
            // 
            // styleRemainingItem
            // 
            this.styleRemainingItem.HeaderText = "Style";
            this.styleRemainingItem.Name = "styleRemainingItem";
            this.styleRemainingItem.ReadOnly = true;
            // 
            // sizeRemainingItem
            // 
            this.sizeRemainingItem.HeaderText = "Size";
            this.sizeRemainingItem.Name = "sizeRemainingItem";
            this.sizeRemainingItem.ReadOnly = true;
            // 
            // quantities
            // 
            this.quantities.HeaderText = "Quantity";
            this.quantities.Name = "quantities";
            this.quantities.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(75, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 22);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkbxAddRemarks
            // 
            this.chkbxAddRemarks.AutoSize = true;
            this.chkbxAddRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.chkbxAddRemarks.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxAddRemarks.ForeColor = System.Drawing.Color.Navy;
            this.chkbxAddRemarks.Location = new System.Drawing.Point(565, 128);
            this.chkbxAddRemarks.Name = "chkbxAddRemarks";
            this.chkbxAddRemarks.Size = new System.Drawing.Size(90, 16);
            this.chkbxAddRemarks.TabIndex = 15;
            this.chkbxAddRemarks.Text = "Add Remarks";
            this.chkbxAddRemarks.UseVisualStyleBackColor = false;
            this.chkbxAddRemarks.CheckStateChanged += new System.EventHandler(this.chkbxAddRemarks_CheckStateChanged);
            // 
            // cbxRemarks
            // 
            this.cbxRemarks.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRemarks.FormattingEnabled = true;
            this.cbxRemarks.Location = new System.Drawing.Point(565, 101);
            this.cbxRemarks.Name = "cbxRemarks";
            this.cbxRemarks.Size = new System.Drawing.Size(207, 21);
            this.cbxRemarks.TabIndex = 14;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.BackColor = System.Drawing.SystemColors.Control;
            this.lblRemark.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.Color.Navy;
            this.lblRemark.Location = new System.Drawing.Point(458, 101);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(64, 13);
            this.lblRemark.TabIndex = 13;
            this.lblRemark.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(565, 150);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(207, 71);
            this.txtRemarks.TabIndex = 16;
            this.txtRemarks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRemarks_MouseClick);
            // 
            // gbxStock
            // 
            this.gbxStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxStock.Controls.Add(this.dgvStock);
            this.gbxStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStock.ForeColor = System.Drawing.Color.Navy;
            this.gbxStock.Location = new System.Drawing.Point(2, 8);
            this.gbxStock.Name = "gbxStock";
            this.gbxStock.Size = new System.Drawing.Size(457, 188);
            this.gbxStock.TabIndex = 0;
            this.gbxStock.TabStop = false;
            this.gbxStock.Text = "Stock";
            // 
            // gbxMoldBreakageReport
            // 
            this.gbxMoldBreakageReport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxMoldBreakageReport.Controls.Add(this.dgvMoldBreakage);
            this.gbxMoldBreakageReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldBreakageReport.ForeColor = System.Drawing.Color.Navy;
            this.gbxMoldBreakageReport.Location = new System.Drawing.Point(3, 227);
            this.gbxMoldBreakageReport.Name = "gbxMoldBreakageReport";
            this.gbxMoldBreakageReport.Size = new System.Drawing.Size(779, 287);
            this.gbxMoldBreakageReport.TabIndex = 17;
            this.gbxMoldBreakageReport.TabStop = false;
            this.gbxMoldBreakageReport.Text = "Mold Breakage Report";
            // 
            // btnIncreaseStock
            // 
            this.btnIncreaseStock.BackColor = System.Drawing.SystemColors.Control;
            this.btnIncreaseStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseStock.ForeColor = System.Drawing.Color.Navy;
            this.btnIncreaseStock.Location = new System.Drawing.Point(301, 198);
            this.btnIncreaseStock.Name = "btnIncreaseStock";
            this.btnIncreaseStock.Size = new System.Drawing.Size(76, 23);
            this.btnIncreaseStock.TabIndex = 2;
            this.btnIncreaseStock.Text = "Increase";
            this.btnIncreaseStock.UseVisualStyleBackColor = false;
            this.btnIncreaseStock.Click += new System.EventHandler(this.btnIncreaseStock_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.SystemColors.Control;
            this.btnDecrease.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.ForeColor = System.Drawing.Color.Navy;
            this.btnDecrease.Location = new System.Drawing.Point(383, 198);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(76, 23);
            this.btnDecrease.TabIndex = 3;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.Navy;
            this.lblSelectJob.Location = new System.Drawing.Point(458, 23);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(72, 13);
            this.lblSelectJob.TabIndex = 38;
            this.lblSelectJob.Text = "Select job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.Navy;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(565, 20);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(205, 21);
            this.cbxSelectJob.TabIndex = 39;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.Navy;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(565, 47);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(205, 21);
            this.cbxWorker.TabIndex = 37;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.Navy;
            this.lblWorker.Location = new System.Drawing.Point(458, 50);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(55, 13);
            this.lblWorker.TabIndex = 36;
            this.lblWorker.Text = "Worker";
            // 
            // frmMoldBreakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncreaseStock);
            this.Controls.Add(this.gbxMoldBreakageReport);
            this.Controls.Add(this.gbxStock);
            this.Controls.Add(this.chkbxAddRemarks);
            this.Controls.Add(this.cbxRemarks);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMoldBreakage";
            this.Text = "Add Mold Breakage Report & Add And Update Mold Stock";
            this.Load += new System.EventHandler(this.frmMoldBreakage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoldBreakage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.gbxStock.ResumeLayout(false);
            this.gbxMoldBreakageReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoldBreakage;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkbxAddRemarks;
        private System.Windows.Forms.ComboBox cbxRemarks;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.GroupBox gbxStock;
        private System.Windows.Forms.GroupBox gbxMoldBreakageReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemainingItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleRemainingItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRemainingItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.Button btnIncreaseStock;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
    }
}