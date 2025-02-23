namespace MasterCeramicsERP
{
    partial class frmDailyKillenReport
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
            this.btnAddDB = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvKillenReport = new System.Windows.Forms.DataGridView();
            this.rKillenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxReport = new System.Windows.Forms.GroupBox();
            this.dgvKillenFeedStock = new System.Windows.Forms.DataGridView();
            this.sItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxKillenFeedStock = new System.Windows.Forms.GroupBox();
            this.txtKillenNo = new System.Windows.Forms.TextBox();
            this.lblKillenID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenReport)).BeginInit();
            this.gbxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenFeedStock)).BeginInit();
            this.gbxKillenFeedStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAddDB.Location = new System.Drawing.Point(485, 233);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(86, 22);
            this.btnAddDB.TabIndex = 15;
            this.btnAddDB.Text = "Save ";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Firebrick;
            this.txtQuantity.Location = new System.Drawing.Point(584, 119);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(188, 21);
            this.txtQuantity.TabIndex = 7;
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
            this.rKillenID,
            this.rItem,
            this.rStyle,
            this.rSize,
            this.rColor,
            this.rItemCategory,
            this.rQuantity,
            this.rRemarks});
            this.dgvKillenReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKillenReport.GridColor = System.Drawing.Color.Firebrick;
            this.dgvKillenReport.Location = new System.Drawing.Point(3, 14);
            this.dgvKillenReport.Name = "dgvKillenReport";
            this.dgvKillenReport.ReadOnly = true;
            this.dgvKillenReport.Size = new System.Drawing.Size(754, 227);
            this.dgvKillenReport.TabIndex = 0;
            this.dgvKillenReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKillenReport_CellClick);
            // 
            // rKillenID
            // 
            this.rKillenID.DataPropertyName = "KillenID";
            this.rKillenID.HeaderText = "KillenID";
            this.rKillenID.Name = "rKillenID";
            this.rKillenID.ReadOnly = true;
            this.rKillenID.Width = 90;
            // 
            // rItem
            // 
            this.rItem.DataPropertyName = "Item";
            this.rItem.HeaderText = "Item";
            this.rItem.Name = "rItem";
            this.rItem.ReadOnly = true;
            this.rItem.Width = 90;
            // 
            // rStyle
            // 
            this.rStyle.DataPropertyName = "Style";
            this.rStyle.HeaderText = "Style";
            this.rStyle.Name = "rStyle";
            this.rStyle.ReadOnly = true;
            this.rStyle.Width = 90;
            // 
            // rSize
            // 
            this.rSize.DataPropertyName = "Size";
            this.rSize.HeaderText = "Size";
            this.rSize.Name = "rSize";
            this.rSize.ReadOnly = true;
            this.rSize.Width = 90;
            // 
            // rColor
            // 
            this.rColor.DataPropertyName = "Color";
            this.rColor.HeaderText = "Color";
            this.rColor.Name = "rColor";
            this.rColor.ReadOnly = true;
            this.rColor.Width = 90;
            // 
            // rItemCategory
            // 
            this.rItemCategory.DataPropertyName = "ItemCategory";
            this.rItemCategory.HeaderText = "ItemCategory";
            this.rItemCategory.Name = "rItemCategory";
            this.rItemCategory.ReadOnly = true;
            this.rItemCategory.Width = 90;
            // 
            // rQuantity
            // 
            this.rQuantity.DataPropertyName = "Quantity";
            this.rQuantity.HeaderText = "Quantity";
            this.rQuantity.Name = "rQuantity";
            this.rQuantity.ReadOnly = true;
            this.rQuantity.Width = 70;
            // 
            // rRemarks
            // 
            this.rRemarks.DataPropertyName = "Remarks";
            this.rRemarks.HeaderText = "Remarks";
            this.rRemarks.Name = "rRemarks";
            this.rRemarks.ReadOnly = true;
            this.rRemarks.Width = 135;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAdd.Location = new System.Drawing.Point(393, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 22);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Firebrick;
            this.lblQuantity.Location = new System.Drawing.Point(579, 103);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.ForeColor = System.Drawing.Color.Firebrick;
            this.lblItemCategory.Location = new System.Drawing.Point(579, 60);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(101, 13);
            this.lblItemCategory.TabIndex = 4;
            this.lblItemCategory.Text = "Item Category";
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemCategory.ForeColor = System.Drawing.Color.Firebrick;
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(581, 79);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.Size = new System.Drawing.Size(191, 21);
            this.cbxItemCategory.TabIndex = 5;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(578, 168);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(194, 56);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRemarks_MouseClick);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRemarks.Location = new System.Drawing.Point(578, 150);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "Remarks";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.Location = new System.Drawing.Point(686, 230);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(86, 22);
            this.btnDeleteRecord.TabIndex = 14;
            this.btnDeleteRecord.Text = "Delete";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxReport
            // 
            this.gbxReport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxReport.Controls.Add(this.dgvKillenReport);
            this.gbxReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReport.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxReport.Location = new System.Drawing.Point(12, 261);
            this.gbxReport.Name = "gbxReport";
            this.gbxReport.Size = new System.Drawing.Size(760, 244);
            this.gbxReport.TabIndex = 17;
            this.gbxReport.TabStop = false;
            this.gbxReport.Text = "Daily Killen Report";
            // 
            // dgvKillenFeedStock
            // 
            this.dgvKillenFeedStock.AllowUserToAddRows = false;
            this.dgvKillenFeedStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKillenFeedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKillenFeedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sItem,
            this.sStyle,
            this.sSize,
            this.sColor,
            this.sQuantity});
            this.dgvKillenFeedStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKillenFeedStock.GridColor = System.Drawing.Color.Firebrick;
            this.dgvKillenFeedStock.Location = new System.Drawing.Point(3, 14);
            this.dgvKillenFeedStock.Name = "dgvKillenFeedStock";
            this.dgvKillenFeedStock.ReadOnly = true;
            this.dgvKillenFeedStock.Size = new System.Drawing.Size(565, 207);
            this.dgvKillenFeedStock.TabIndex = 0;
            this.dgvKillenFeedStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKillenFeedStock_CellClick);
            // 
            // sItem
            // 
            this.sItem.DataPropertyName = "Item";
            this.sItem.HeaderText = "Item";
            this.sItem.Name = "sItem";
            this.sItem.ReadOnly = true;
            this.sItem.Width = 125;
            // 
            // sStyle
            // 
            this.sStyle.DataPropertyName = "Style";
            this.sStyle.HeaderText = "Style";
            this.sStyle.Name = "sStyle";
            this.sStyle.ReadOnly = true;
            // 
            // sSize
            // 
            this.sSize.DataPropertyName = "Size";
            this.sSize.HeaderText = "Size";
            this.sSize.Name = "sSize";
            this.sSize.ReadOnly = true;
            // 
            // sColor
            // 
            this.sColor.DataPropertyName = "Color";
            this.sColor.HeaderText = "Color";
            this.sColor.Name = "sColor";
            this.sColor.ReadOnly = true;
            // 
            // sQuantity
            // 
            this.sQuantity.DataPropertyName = "Quantity";
            this.sQuantity.HeaderText = "Quantity";
            this.sQuantity.Name = "sQuantity";
            this.sQuantity.ReadOnly = true;
            // 
            // gbxKillenFeedStock
            // 
            this.gbxKillenFeedStock.Controls.Add(this.dgvKillenFeedStock);
            this.gbxKillenFeedStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKillenFeedStock.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxKillenFeedStock.Location = new System.Drawing.Point(3, 3);
            this.gbxKillenFeedStock.Name = "gbxKillenFeedStock";
            this.gbxKillenFeedStock.Size = new System.Drawing.Size(571, 224);
            this.gbxKillenFeedStock.TabIndex = 1;
            this.gbxKillenFeedStock.TabStop = false;
            this.gbxKillenFeedStock.Text = "Killen Feed Stock";
            // 
            // txtKillenNo
            // 
            this.txtKillenNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillenNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillenNo.ForeColor = System.Drawing.Color.Firebrick;
            this.txtKillenNo.Location = new System.Drawing.Point(577, 36);
            this.txtKillenNo.Name = "txtKillenNo";
            this.txtKillenNo.Size = new System.Drawing.Size(188, 21);
            this.txtKillenNo.TabIndex = 19;
            this.txtKillenNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKillenNo_MouseClick);
            this.txtKillenNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKillenNo_KeyPress);
            // 
            // lblKillenID
            // 
            this.lblKillenID.AutoSize = true;
            this.lblKillenID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKillenID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblKillenID.Location = new System.Drawing.Point(574, 20);
            this.lblKillenID.Name = "lblKillenID";
            this.lblKillenID.Size = new System.Drawing.Size(56, 13);
            this.lblKillenID.TabIndex = 18;
            this.lblKillenID.Text = "Killen #";
            // 
            // frmDailyKillenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtKillenNo);
            this.Controls.Add(this.lblKillenID);
            this.Controls.Add(this.gbxKillenFeedStock);
            this.Controls.Add(this.gbxReport);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.cbxItemCategory);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmDailyKillenReport";
            this.Text = "Add Daily Killen Report";
            this.Load += new System.EventHandler(this.frmDailyKillenReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenReport)).EndInit();
            this.gbxReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenFeedStock)).EndInit();
            this.gbxKillenFeedStock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvKillenReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxReport;
        private System.Windows.Forms.DataGridView dgvKillenFeedStock;
        private System.Windows.Forms.GroupBox gbxKillenFeedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn sItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rKillenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn rColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn rQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRemarks;
        private System.Windows.Forms.TextBox txtKillenNo;
        private System.Windows.Forms.Label lblKillenID;
    }
}