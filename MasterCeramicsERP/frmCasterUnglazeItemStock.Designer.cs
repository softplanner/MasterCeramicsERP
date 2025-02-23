namespace MasterCeramicsERP
{
    partial class frmCasterUnglazeItemStock
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
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.gbxCasterMoldStock = new System.Windows.Forms.GroupBox();
            this.dgvCaster = new System.Windows.Forms.DataGridView();
            this.ItemRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRemainingMold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSearch.SuspendLayout();
            this.gbxCasterMoldStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectJob.Location = new System.Drawing.Point(6, 23);
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
            this.cbxSelectJob.Location = new System.Drawing.Point(106, 19);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(171, 21);
            this.cbxSelectJob.TabIndex = 19;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(106, 47);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(171, 21);
            this.cbxWorker.TabIndex = 17;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWorker.Location = new System.Drawing.Point(6, 51);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 16;
            this.lblWorker.Text = "Caster";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPrint.Location = new System.Drawing.Point(665, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Location = new System.Drawing.Point(106, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 21);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(106, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 21);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Location = new System.Drawing.Point(212, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 21);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Location = new System.Drawing.Point(212, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(550, 68);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(211, 21);
            this.cbxSize.TabIndex = 5;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(481, 98);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateQuantity.TabIndex = 8;
            this.lblUpdateQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Location = new System.Drawing.Point(550, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(211, 21);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCastQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCastQuantity_KeyPress);
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(550, 43);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(211, 21);
            this.cbxStyle.Sorted = true;
            this.cbxStyle.TabIndex = 3;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lblSelectJob);
            this.gbxSearch.Controls.Add(this.cbxSelectJob);
            this.gbxSearch.Controls.Add(this.cbxWorker);
            this.gbxSearch.Controls.Add(this.lblWorker);
            this.gbxSearch.Controls.Add(this.btnPrint);
            this.gbxSearch.Controls.Add(this.btnDelete);
            this.gbxSearch.Controls.Add(this.btnAdd);
            this.gbxSearch.Controls.Add(this.btnUpdate);
            this.gbxSearch.Controls.Add(this.lblUpdateQuantity);
            this.gbxSearch.Controls.Add(this.btnRefresh);
            this.gbxSearch.Controls.Add(this.txtQuantity);
            this.gbxSearch.Controls.Add(this.cbxSize);
            this.gbxSearch.Controls.Add(this.cbxStyle);
            this.gbxSearch.Controls.Add(this.cbxItem);
            this.gbxSearch.Controls.Add(this.lblSize);
            this.gbxSearch.Controls.Add(this.lblStyle);
            this.gbxSearch.Controls.Add(this.lblItem);
            this.gbxSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxSearch.Location = new System.Drawing.Point(3, 3);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(779, 153);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(550, 19);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(211, 21);
            this.cbxItem.Sorted = true;
            this.cbxItem.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSize.Location = new System.Drawing.Point(481, 74);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStyle.Location = new System.Drawing.Point(481, 46);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 2;
            this.lblStyle.Text = "Style";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblItem.Location = new System.Drawing.Point(481, 22);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // gbxCasterMoldStock
            // 
            this.gbxCasterMoldStock.Controls.Add(this.dgvCaster);
            this.gbxCasterMoldStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCasterMoldStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxCasterMoldStock.Location = new System.Drawing.Point(0, 159);
            this.gbxCasterMoldStock.Name = "gbxCasterMoldStock";
            this.gbxCasterMoldStock.Size = new System.Drawing.Size(785, 358);
            this.gbxCasterMoldStock.TabIndex = 3;
            this.gbxCasterMoldStock.TabStop = false;
            this.gbxCasterMoldStock.Text = "Caster unglaze item\'s stock";
            // 
            // dgvCaster
            // 
            this.dgvCaster.AllowUserToAddRows = false;
            this.dgvCaster.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemRemainingMold,
            this.styleRemainingMold,
            this.sizeRemainingMold,
            this.quantity});
            this.dgvCaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCaster.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvCaster.Location = new System.Drawing.Point(3, 17);
            this.dgvCaster.Name = "dgvCaster";
            this.dgvCaster.ReadOnly = true;
            this.dgvCaster.Size = new System.Drawing.Size(779, 338);
            this.dgvCaster.TabIndex = 0;
            this.dgvCaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaster_CellClick);
            // 
            // ItemRemainingMold
            // 
            this.ItemRemainingMold.HeaderText = "Item";
            this.ItemRemainingMold.Name = "ItemRemainingMold";
            this.ItemRemainingMold.ReadOnly = true;
            this.ItemRemainingMold.Width = 200;
            // 
            // styleRemainingMold
            // 
            this.styleRemainingMold.HeaderText = "Style";
            this.styleRemainingMold.Name = "styleRemainingMold";
            this.styleRemainingMold.ReadOnly = true;
            this.styleRemainingMold.Width = 200;
            // 
            // sizeRemainingMold
            // 
            this.sizeRemainingMold.HeaderText = "Size";
            this.sizeRemainingMold.Name = "sizeRemainingMold";
            this.sizeRemainingMold.ReadOnly = true;
            this.sizeRemainingMold.Width = 200;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 150;
            // 
            // frmCasterUnglazeItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCasterMoldStock);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmCasterUnglazeItemStock";
            this.Text = "Manage caster unglaze item\'s stock";
            this.Load += new System.EventHandler(this.frmCasterUnglazeItemStock_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxCasterMoldStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.GroupBox gbxCasterMoldStock;
        private System.Windows.Forms.DataGridView dgvCaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRemainingMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}