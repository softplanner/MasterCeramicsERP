namespace MasterCeramicsERP
{
    partial class frmRawMaterialReport
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
            this.rawmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRawMaterial = new System.Windows.Forms.Label();
            this.cbxRawMaterial = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUnitRate = new System.Windows.Forms.TextBox();
            this.lblUnitRate = new System.Windows.Forms.Label();
            this.gbxRawMaterial = new System.Windows.Forms.GroupBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblCurrencyUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxRawMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawmaterial,
            this.Vendor,
            this.unitRate,
            this.quantity,
            this.amount,
            this.date,
            this.id});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvReport.Location = new System.Drawing.Point(3, 17);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(770, 400);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // rawmaterial
            // 
            this.rawmaterial.HeaderText = "Raw Material";
            this.rawmaterial.Name = "rawmaterial";
            this.rawmaterial.ReadOnly = true;
            this.rawmaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rawmaterial.Width = 130;
            // 
            // Vendor
            // 
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            this.Vendor.Width = 140;
            // 
            // unitRate
            // 
            this.unitRate.HeaderText = "Unit Rate";
            this.unitRate.Name = "unitRate";
            this.unitRate.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 160;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 5;
            // 
            // lblRawMaterial
            // 
            this.lblRawMaterial.AutoSize = true;
            this.lblRawMaterial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterial.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblRawMaterial.Location = new System.Drawing.Point(10, 15);
            this.lblRawMaterial.Name = "lblRawMaterial";
            this.lblRawMaterial.Size = new System.Drawing.Size(90, 13);
            this.lblRawMaterial.TabIndex = 0;
            this.lblRawMaterial.Text = "Raw Material";
            // 
            // cbxRawMaterial
            // 
            this.cbxRawMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRawMaterial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRawMaterial.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cbxRawMaterial.FormattingEnabled = true;
            this.cbxRawMaterial.Location = new System.Drawing.Point(106, 12);
            this.cbxRawMaterial.Name = "cbxRawMaterial";
            this.cbxRawMaterial.Size = new System.Drawing.Size(169, 21);
            this.cbxRawMaterial.TabIndex = 1;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSupplier.Location = new System.Drawing.Point(10, 69);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(61, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSupplier.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(106, 66);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(169, 21);
            this.cbxSupplier.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDelete.Location = new System.Drawing.Point(621, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddDB
            // 
            this.btnAddDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddDB.Location = new System.Drawing.Point(697, 23);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(75, 23);
            this.btnAddDB.TabIndex = 14;
            this.btnAddDB.Text = "Save ";
            this.btnAddDB.UseVisualStyleBackColor = false;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefresh.Location = new System.Drawing.Point(697, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.Location = new System.Drawing.Point(621, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtQuantity.Location = new System.Drawing.Point(402, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(149, 21);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblQuantity.Location = new System.Drawing.Point(334, 25);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtUnitRate
            // 
            this.txtUnitRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnitRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitRate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtUnitRate.Location = new System.Drawing.Point(402, 52);
            this.txtUnitRate.Name = "txtUnitRate";
            this.txtUnitRate.Size = new System.Drawing.Size(149, 21);
            this.txtUnitRate.TabIndex = 10;
            this.txtUnitRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUnitRate_MouseClick);
            this.txtUnitRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitRate_KeyPress);
            // 
            // lblUnitRate
            // 
            this.lblUnitRate.AutoSize = true;
            this.lblUnitRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitRate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUnitRate.Location = new System.Drawing.Point(334, 57);
            this.lblUnitRate.Name = "lblUnitRate";
            this.lblUnitRate.Size = new System.Drawing.Size(66, 13);
            this.lblUnitRate.TabIndex = 9;
            this.lblUnitRate.Text = "Unit Rate";
            // 
            // gbxRawMaterial
            // 
            this.gbxRawMaterial.Controls.Add(this.dgvReport);
            this.gbxRawMaterial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRawMaterial.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.gbxRawMaterial.Location = new System.Drawing.Point(4, 93);
            this.gbxRawMaterial.Name = "gbxRawMaterial";
            this.gbxRawMaterial.Size = new System.Drawing.Size(776, 420);
            this.gbxRawMaterial.TabIndex = 16;
            this.gbxRawMaterial.TabStop = false;
            this.gbxRawMaterial.Text = "Raw Material Report";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSelectJob.Location = new System.Drawing.Point(10, 42);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 2;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(106, 39);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(169, 21);
            this.cbxSelectJob.TabIndex = 3;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUnit.Location = new System.Drawing.Point(557, 27);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(27, 13);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Kg.";
            // 
            // lblCurrencyUnit
            // 
            this.lblCurrencyUnit.AutoSize = true;
            this.lblCurrencyUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyUnit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCurrencyUnit.Location = new System.Drawing.Point(557, 57);
            this.lblCurrencyUnit.Name = "lblCurrencyUnit";
            this.lblCurrencyUnit.Size = new System.Drawing.Size(26, 13);
            this.lblCurrencyUnit.TabIndex = 11;
            this.lblCurrencyUnit.Text = "Rs.";
            // 
            // frmRawMaterialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblCurrencyUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.gbxRawMaterial);
            this.Controls.Add(this.txtUnitRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblRawMaterial);
            this.Controls.Add(this.cbxRawMaterial);
            this.Controls.Add(this.lblUnitRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cbxSupplier);
            this.ForeColor = System.Drawing.Color.Olive;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmRawMaterialReport";
            this.Text = "Raw Material Purchase Report";
            this.Load += new System.EventHandler(this.frmRawMaterialReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxRawMaterial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblRawMaterial;
        private System.Windows.Forms.ComboBox cbxRawMaterial;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnitRate;
        private System.Windows.Forms.Label lblUnitRate;
        private System.Windows.Forms.GroupBox gbxRawMaterial;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblCurrencyUnit;
    }
}