namespace MasterCeramicsERP
{
    partial class frmMoldIssueRecord
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
            this.dgvCompanyStock = new System.Windows.Forms.DataGridView();
            this.item_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMold = new System.Windows.Forms.DataGridView();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIssueQuantity = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxCompantStock = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtIssueQuantity = new System.Windows.Forms.TextBox();
            this.gbxMoldIssueRecord = new System.Windows.Forms.GroupBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.gbxCompantStock.SuspendLayout();
            this.gbxMoldIssueRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompanyStock
            // 
            this.dgvCompanyStock.AllowUserToAddRows = false;
            this.dgvCompanyStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCompanyStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompanyStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCompanyStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_chk,
            this.style_chk,
            this.size_chk,
            this.quantity});
            this.dgvCompanyStock.GridColor = System.Drawing.Color.Navy;
            this.dgvCompanyStock.Location = new System.Drawing.Point(3, 19);
            this.dgvCompanyStock.Name = "dgvCompanyStock";
            this.dgvCompanyStock.ReadOnly = true;
            this.dgvCompanyStock.Size = new System.Drawing.Size(518, 232);
            this.dgvCompanyStock.TabIndex = 0;
            this.dgvCompanyStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompanyStock_CellClick);
            // 
            // item_chk
            // 
            this.item_chk.HeaderText = "Item";
            this.item_chk.Name = "item_chk";
            this.item_chk.ReadOnly = true;
            this.item_chk.Width = 135;
            // 
            // style_chk
            // 
            this.style_chk.HeaderText = "Style";
            this.style_chk.Name = "style_chk";
            this.style_chk.ReadOnly = true;
            this.style_chk.Width = 135;
            // 
            // size_chk
            // 
            this.size_chk.HeaderText = "Size";
            this.size_chk.Name = "size_chk";
            this.size_chk.ReadOnly = true;
            this.size_chk.Width = 135;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity ";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 70;
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
            this.issueTo,
            this.issueQuantity});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMold.GridColor = System.Drawing.Color.Navy;
            this.dgvMold.Location = new System.Drawing.Point(3, 17);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.Size = new System.Drawing.Size(774, 208);
            this.dgvMold.TabIndex = 0;
            this.dgvMold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMold_CellClick);
            // 
            // btnAddDB
            // 
            this.btnAddDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.Navy;
            this.btnAddDB.Location = new System.Drawing.Point(170, 261);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(75, 23);
            this.btnAddDB.TabIndex = 3;
            this.btnAddDB.Text = "Save ";
            this.btnAddDB.UseVisualStyleBackColor = false;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(251, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(8, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIssueQuantity
            // 
            this.lblIssueQuantity.AutoSize = true;
            this.lblIssueQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lblIssueQuantity.Location = new System.Drawing.Point(523, 229);
            this.lblIssueQuantity.Name = "lblIssueQuantity";
            this.lblIssueQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblIssueQuantity.TabIndex = 5;
            this.lblIssueQuantity.Text = "Quantity";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Navy;
            this.btnDeleteRecord.Location = new System.Drawing.Point(89, 261);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRecord.TabIndex = 4;
            this.btnDeleteRecord.Text = "Delete ";
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxCompantStock
            // 
            this.gbxCompantStock.Controls.Add(this.lblSelectJob);
            this.gbxCompantStock.Controls.Add(this.txtIssueQuantity);
            this.gbxCompantStock.Controls.Add(this.cbxSelectJob);
            this.gbxCompantStock.Controls.Add(this.cbxWorker);
            this.gbxCompantStock.Controls.Add(this.lblWorker);
            this.gbxCompantStock.Controls.Add(this.txtSize);
            this.gbxCompantStock.Controls.Add(this.txtStyle);
            this.gbxCompantStock.Controls.Add(this.txtItem);
            this.gbxCompantStock.Controls.Add(this.lblIssueQuantity);
            this.gbxCompantStock.Controls.Add(this.lblItem);
            this.gbxCompantStock.Controls.Add(this.lblStyle);
            this.gbxCompantStock.Controls.Add(this.lblSize);
            this.gbxCompantStock.Controls.Add(this.dgvCompanyStock);
            this.gbxCompantStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCompantStock.ForeColor = System.Drawing.Color.Navy;
            this.gbxCompantStock.Location = new System.Drawing.Point(2, 2);
            this.gbxCompantStock.Name = "gbxCompantStock";
            this.gbxCompantStock.Size = new System.Drawing.Size(777, 258);
            this.gbxCompantStock.TabIndex = 0;
            this.gbxCompantStock.TabStop = false;
            this.gbxCompantStock.Text = "Company Stock";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.Control;
            this.txtSize.Enabled = false;
            this.txtSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.Navy;
            this.txtSize.Location = new System.Drawing.Point(530, 205);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(240, 21);
            this.txtSize.TabIndex = 6;
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.SystemColors.Control;
            this.txtStyle.Enabled = false;
            this.txtStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStyle.ForeColor = System.Drawing.Color.Navy;
            this.txtStyle.Location = new System.Drawing.Point(530, 165);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(240, 21);
            this.txtStyle.TabIndex = 4;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.ForeColor = System.Drawing.Color.Navy;
            this.txtItem.Location = new System.Drawing.Point(530, 125);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(240, 21);
            this.txtItem.TabIndex = 2;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Navy;
            this.lblItem.Location = new System.Drawing.Point(523, 109);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.ForeColor = System.Drawing.Color.Navy;
            this.lblStyle.Location = new System.Drawing.Point(523, 149);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 3;
            this.lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Navy;
            this.lblSize.Location = new System.Drawing.Point(523, 189);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // txtIssueQuantity
            // 
            this.txtIssueQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtIssueQuantity.ForeColor = System.Drawing.Color.Navy;
            this.txtIssueQuantity.Location = new System.Drawing.Point(591, 229);
            this.txtIssueQuantity.Name = "txtIssueQuantity";
            this.txtIssueQuantity.Size = new System.Drawing.Size(179, 18);
            this.txtIssueQuantity.TabIndex = 6;
            this.txtIssueQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIssueQuantity_MouseClick);
            this.txtIssueQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIssueQuantity_KeyPress);
            // 
            // gbxMoldIssueRecord
            // 
            this.gbxMoldIssueRecord.Controls.Add(this.dgvMold);
            this.gbxMoldIssueRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldIssueRecord.ForeColor = System.Drawing.Color.Navy;
            this.gbxMoldIssueRecord.Location = new System.Drawing.Point(1, 287);
            this.gbxMoldIssueRecord.Name = "gbxMoldIssueRecord";
            this.gbxMoldIssueRecord.Size = new System.Drawing.Size(780, 228);
            this.gbxMoldIssueRecord.TabIndex = 7;
            this.gbxMoldIssueRecord.TabStop = false;
            this.gbxMoldIssueRecord.Text = "Mold Issue Record";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.Navy;
            this.lblSelectJob.Location = new System.Drawing.Point(523, 20);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(72, 13);
            this.lblSelectJob.TabIndex = 34;
            this.lblSelectJob.Text = "Select job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.Navy;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(526, 36);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(244, 21);
            this.cbxSelectJob.TabIndex = 35;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.Navy;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(526, 76);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(244, 21);
            this.cbxWorker.TabIndex = 33;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.Navy;
            this.lblWorker.Location = new System.Drawing.Point(523, 60);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(106, 13);
            this.lblWorker.TabIndex = 32;
            this.lblWorker.Text = "Select receiver";
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
            // issueTo
            // 
            this.issueTo.HeaderText = "Issued to";
            this.issueTo.Name = "issueTo";
            this.issueTo.ReadOnly = true;
            this.issueTo.Width = 172;
            // 
            // issueQuantity
            // 
            this.issueQuantity.HeaderText = "Issued Quantity";
            this.issueQuantity.Name = "issueQuantity";
            this.issueQuantity.ReadOnly = true;
            this.issueQuantity.Width = 108;
            // 
            // frmMoldIssueRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxMoldIssueRecord);
            this.Controls.Add(this.gbxCompantStock);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMoldIssueRecord";
            this.Text = "Add Mold Issued Report";
            this.Load += new System.EventHandler(this.frmMoldIssueRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.gbxCompantStock.ResumeLayout(false);
            this.gbxCompantStock.PerformLayout();
            this.gbxMoldIssueRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompanyStock;
        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIssueQuantity;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxCompantStock;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtIssueQuantity;
        private System.Windows.Forms.GroupBox gbxMoldIssueRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn style_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueQuantity;
    }
}