namespace MasterCeramicsERP
{
    partial class frmKillenFeed
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
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvKillenReport = new System.Windows.Forms.DataGridView();
            this.kItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kBreakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dgvGlazedStock = new System.Windows.Forms.DataGridView();
            this.gItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGlazedStock = new System.Windows.Forms.GroupBox();
            this.gbxKillenFeedReport = new System.Windows.Forms.GroupBox();
            this.txtBreakage = new System.Windows.Forms.TextBox();
            this.lblBreakage = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).BeginInit();
            this.gbxGlazedStock.SuspendLayout();
            this.gbxKillenFeedReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.Location = new System.Drawing.Point(686, 254);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteRecord.TabIndex = 6;
            this.btnDeleteRecord.Text = "Delete";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAddDB.Location = new System.Drawing.Point(485, 254);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(86, 23);
            this.btnAddDB.TabIndex = 8;
            this.btnAddDB.Text = "Save ";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Firebrick;
            this.txtQuantity.Location = new System.Drawing.Point(94, 213);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(69, 21);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // dgvKillenReport
            // 
            this.dgvKillenReport.AllowUserToAddRows = false;
            this.dgvKillenReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKillenReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKillenReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKillenReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKillenReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kItem,
            this.kStyle,
            this.kSize,
            this.kColor,
            this.kQuantity,
            this.kBreakage,
            this.kRemarks});
            this.dgvKillenReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKillenReport.GridColor = System.Drawing.Color.Firebrick;
            this.dgvKillenReport.Location = new System.Drawing.Point(3, 17);
            this.dgvKillenReport.Name = "dgvKillenReport";
            this.dgvKillenReport.ReadOnly = true;
            this.dgvKillenReport.Size = new System.Drawing.Size(779, 202);
            this.dgvKillenReport.TabIndex = 0;
            this.dgvKillenReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKillenReport_CellClick);
            // 
            // kItem
            // 
            this.kItem.DataPropertyName = "Item";
            this.kItem.HeaderText = "Item";
            this.kItem.Name = "kItem";
            this.kItem.ReadOnly = true;
            this.kItem.Width = 140;
            // 
            // kStyle
            // 
            this.kStyle.DataPropertyName = "Style";
            this.kStyle.HeaderText = "Style";
            this.kStyle.Name = "kStyle";
            this.kStyle.ReadOnly = true;
            this.kStyle.Width = 140;
            // 
            // kSize
            // 
            this.kSize.DataPropertyName = "Size";
            this.kSize.HeaderText = "Size";
            this.kSize.Name = "kSize";
            this.kSize.ReadOnly = true;
            this.kSize.Width = 115;
            // 
            // kColor
            // 
            this.kColor.DataPropertyName = "Color";
            this.kColor.HeaderText = "Color";
            this.kColor.Name = "kColor";
            this.kColor.ReadOnly = true;
            // 
            // kQuantity
            // 
            this.kQuantity.DataPropertyName = "Quantity";
            this.kQuantity.HeaderText = "Quantity";
            this.kQuantity.Name = "kQuantity";
            this.kQuantity.ReadOnly = true;
            // 
            // kBreakage
            // 
            this.kBreakage.DataPropertyName = "Breakage";
            this.kBreakage.HeaderText = "Breakage";
            this.kBreakage.Name = "kBreakage";
            this.kBreakage.ReadOnly = true;
            // 
            // kRemarks
            // 
            this.kRemarks.DataPropertyName = "Remarks";
            this.kRemarks.HeaderText = "Remarks";
            this.kRemarks.Name = "kRemarks";
            this.kRemarks.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAdd.Location = new System.Drawing.Point(393, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Firebrick;
            this.lblQuantity.Location = new System.Drawing.Point(9, 216);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Killen Feed";
            // 
            // dgvGlazedStock
            // 
            this.dgvGlazedStock.AllowUserToAddRows = false;
            this.dgvGlazedStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGlazedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlazedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gItem,
            this.gStyle,
            this.gSize,
            this.gColor,
            this.gQuantity});
            this.dgvGlazedStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGlazedStock.GridColor = System.Drawing.Color.Firebrick;
            this.dgvGlazedStock.Location = new System.Drawing.Point(3, 17);
            this.dgvGlazedStock.Name = "dgvGlazedStock";
            this.dgvGlazedStock.ReadOnly = true;
            this.dgvGlazedStock.Size = new System.Drawing.Size(778, 184);
            this.dgvGlazedStock.TabIndex = 0;
            this.dgvGlazedStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlazedStock_CellClick);
            // 
            // gItem
            // 
            this.gItem.DataPropertyName = "Item";
            this.gItem.HeaderText = "Item";
            this.gItem.Name = "gItem";
            this.gItem.ReadOnly = true;
            this.gItem.Width = 170;
            // 
            // gStyle
            // 
            this.gStyle.DataPropertyName = "Style";
            this.gStyle.HeaderText = "Style";
            this.gStyle.Name = "gStyle";
            this.gStyle.ReadOnly = true;
            this.gStyle.Width = 150;
            // 
            // gSize
            // 
            this.gSize.DataPropertyName = "Size";
            this.gSize.HeaderText = "Size";
            this.gSize.Name = "gSize";
            this.gSize.ReadOnly = true;
            this.gSize.Width = 150;
            // 
            // gColor
            // 
            this.gColor.DataPropertyName = "Color";
            this.gColor.HeaderText = "Color";
            this.gColor.Name = "gColor";
            this.gColor.ReadOnly = true;
            this.gColor.Width = 170;
            // 
            // gQuantity
            // 
            this.gQuantity.DataPropertyName = "Quantity";
            this.gQuantity.HeaderText = "Quantity";
            this.gQuantity.Name = "gQuantity";
            this.gQuantity.ReadOnly = true;
            // 
            // gbxGlazedStock
            // 
            this.gbxGlazedStock.Controls.Add(this.dgvGlazedStock);
            this.gbxGlazedStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGlazedStock.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxGlazedStock.Location = new System.Drawing.Point(0, 3);
            this.gbxGlazedStock.Name = "gbxGlazedStock";
            this.gbxGlazedStock.Size = new System.Drawing.Size(784, 204);
            this.gbxGlazedStock.TabIndex = 0;
            this.gbxGlazedStock.TabStop = false;
            this.gbxGlazedStock.Text = "Glazed Stock";
            // 
            // gbxKillenFeedReport
            // 
            this.gbxKillenFeedReport.Controls.Add(this.dgvKillenReport);
            this.gbxKillenFeedReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKillenFeedReport.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxKillenFeedReport.Location = new System.Drawing.Point(-1, 283);
            this.gbxKillenFeedReport.Name = "gbxKillenFeedReport";
            this.gbxKillenFeedReport.Size = new System.Drawing.Size(785, 222);
            this.gbxKillenFeedReport.TabIndex = 9;
            this.gbxKillenFeedReport.TabStop = false;
            // 
            // txtBreakage
            // 
            this.txtBreakage.BackColor = System.Drawing.SystemColors.Control;
            this.txtBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakage.ForeColor = System.Drawing.Color.Firebrick;
            this.txtBreakage.Location = new System.Drawing.Point(248, 213);
            this.txtBreakage.Name = "txtBreakage";
            this.txtBreakage.Size = new System.Drawing.Size(69, 21);
            this.txtBreakage.TabIndex = 11;
            this.txtBreakage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBreakage_MouseClick);
            this.txtBreakage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreakage_KeyPress);
            // 
            // lblBreakage
            // 
            this.lblBreakage.AutoSize = true;
            this.lblBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBreakage.Location = new System.Drawing.Point(173, 216);
            this.lblBreakage.Name = "lblBreakage";
            this.lblBreakage.Size = new System.Drawing.Size(69, 13);
            this.lblBreakage.TabIndex = 10;
            this.lblBreakage.Text = "Breakage";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.Firebrick;
            this.txtRemarks.Location = new System.Drawing.Point(393, 213);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(379, 21);
            this.txtRemarks.TabIndex = 13;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRemarks.Location = new System.Drawing.Point(323, 216);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 12;
            this.lblRemarks.Text = "Remarks";
            // 
            // frmKillenFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtBreakage);
            this.Controls.Add(this.lblBreakage);
            this.Controls.Add(this.gbxKillenFeedReport);
            this.Controls.Add(this.gbxGlazedStock);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmKillenFeed";
            this.Text = "Add Killen Feed Report";
            this.Load += new System.EventHandler(this.frmKillenFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlazedStock)).EndInit();
            this.gbxGlazedStock.ResumeLayout(false);
            this.gbxKillenFeedReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvKillenReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dgvGlazedStock;
        private System.Windows.Forms.GroupBox gbxGlazedStock;
        private System.Windows.Forms.GroupBox gbxKillenFeedReport;
        private System.Windows.Forms.TextBox txtBreakage;
        private System.Windows.Forms.Label lblBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn kItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn kSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn kColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn kQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn kBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn kRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn gColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gQuantity;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;



    }
}