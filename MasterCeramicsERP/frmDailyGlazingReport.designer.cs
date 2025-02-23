namespace MasterCeramicsERP
{
    partial class frmDailyGlazingReport
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
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.txtBreakage = new System.Windows.Forms.TextBox();
            this.lblBreakage = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.dgvUnGlaze = new System.Windows.Forms.DataGridView();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvDailyGlazinReport = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.uItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSprayManID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBreakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSprayMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnGlaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyGlazinReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblSelectJob.Location = new System.Drawing.Point(277, 166);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 37;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(281, 182);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(119, 21);
            this.cbxSelectJob.TabIndex = 38;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(406, 182);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(119, 21);
            this.cbxWorker.TabIndex = 36;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblWorker.Location = new System.Drawing.Point(403, 166);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(71, 13);
            this.lblWorker.TabIndex = 35;
            this.lblWorker.Text = "SprayMan";
            // 
            // txtBreakage
            // 
            this.txtBreakage.BackColor = System.Drawing.SystemColors.Control;
            this.txtBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakage.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtBreakage.Location = new System.Drawing.Point(205, 182);
            this.txtBreakage.Name = "txtBreakage";
            this.txtBreakage.Size = new System.Drawing.Size(70, 21);
            this.txtBreakage.TabIndex = 34;
            this.txtBreakage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBreakage_MouseClick);
            this.txtBreakage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreakage_KeyPress);
            // 
            // lblBreakage
            // 
            this.lblBreakage.AutoSize = true;
            this.lblBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakage.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblBreakage.Location = new System.Drawing.Point(202, 166);
            this.lblBreakage.Name = "lblBreakage";
            this.lblBreakage.Size = new System.Drawing.Size(69, 13);
            this.lblBreakage.TabIndex = 33;
            this.lblBreakage.Text = "Breakage";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.Location = new System.Drawing.Point(695, 12);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(77, 23);
            this.btnDeleteRecord.TabIndex = 30;
            this.btnDeleteRecord.Text = "Delete ";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(4, 182);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(119, 21);
            this.cbxColor.TabIndex = 26;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblColor.Location = new System.Drawing.Point(1, 166);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 13);
            this.lblColor.TabIndex = 25;
            this.lblColor.Text = "Color";
            // 
            // dgvUnGlaze
            // 
            this.dgvUnGlaze.AllowUserToAddRows = false;
            this.dgvUnGlaze.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUnGlaze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnGlaze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uItem,
            this.uStyle,
            this.uSize,
            this.uQuantity});
            this.dgvUnGlaze.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvUnGlaze.Location = new System.Drawing.Point(3, 7);
            this.dgvUnGlaze.Name = "dgvUnGlaze";
            this.dgvUnGlaze.ReadOnly = true;
            this.dgvUnGlaze.Size = new System.Drawing.Size(563, 153);
            this.dgvUnGlaze.TabIndex = 24;
            this.dgvUnGlaze.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnGlaze_CellClick);
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAddDB.Location = new System.Drawing.Point(695, 137);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(77, 23);
            this.btnAddDB.TabIndex = 31;
            this.btnAddDB.Text = "Save Into Database";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtQuantity.Location = new System.Drawing.Point(129, 182);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(70, 21);
            this.txtQuantity.TabIndex = 28;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // dgvDailyGlazinReport
            // 
            this.dgvDailyGlazinReport.AllowUserToAddRows = false;
            this.dgvDailyGlazinReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDailyGlazinReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDailyGlazinReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDailyGlazinReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyGlazinReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gSprayManID,
            this.gItem,
            this.gStyle,
            this.gSize,
            this.gColor,
            this.gQuantity,
            this.gBreakage,
            this.gSprayMan,
            this.gRemarks});
            this.dgvDailyGlazinReport.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvDailyGlazinReport.Location = new System.Drawing.Point(4, 209);
            this.dgvDailyGlazinReport.Name = "dgvDailyGlazinReport";
            this.dgvDailyGlazinReport.ReadOnly = true;
            this.dgvDailyGlazinReport.Size = new System.Drawing.Size(777, 296);
            this.dgvDailyGlazinReport.TabIndex = 32;
            this.dgvDailyGlazinReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailyGlazinReport_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAdd.Location = new System.Drawing.Point(572, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblQuantity.Location = new System.Drawing.Point(126, 166);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtRemarks.Location = new System.Drawing.Point(531, 182);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(250, 21);
            this.txtRemarks.TabIndex = 40;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblRemarks.Location = new System.Drawing.Point(528, 166);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 39;
            this.lblRemarks.Text = "Remarks";
            // 
            // uItem
            // 
            this.uItem.DataPropertyName = "Item";
            this.uItem.HeaderText = "Item";
            this.uItem.Name = "uItem";
            this.uItem.ReadOnly = true;
            this.uItem.Width = 155;
            // 
            // uStyle
            // 
            this.uStyle.DataPropertyName = "Style";
            this.uStyle.HeaderText = "Style";
            this.uStyle.Name = "uStyle";
            this.uStyle.ReadOnly = true;
            this.uStyle.Width = 130;
            // 
            // uSize
            // 
            this.uSize.DataPropertyName = "Size";
            this.uSize.HeaderText = "Size";
            this.uSize.Name = "uSize";
            this.uSize.ReadOnly = true;
            this.uSize.Width = 130;
            // 
            // uQuantity
            // 
            this.uQuantity.DataPropertyName = "Quantity";
            this.uQuantity.HeaderText = "Quantity";
            this.uQuantity.Name = "uQuantity";
            this.uQuantity.ReadOnly = true;
            this.uQuantity.Width = 105;
            // 
            // gSprayManID
            // 
            this.gSprayManID.DataPropertyName = "gSprayManID";
            this.gSprayManID.HeaderText = "SprayManID";
            this.gSprayManID.Name = "gSprayManID";
            this.gSprayManID.ReadOnly = true;
            // 
            // gItem
            // 
            this.gItem.DataPropertyName = "gItem";
            this.gItem.HeaderText = "Item";
            this.gItem.Name = "gItem";
            this.gItem.ReadOnly = true;
            this.gItem.Width = 150;
            // 
            // gStyle
            // 
            this.gStyle.DataPropertyName = "gStyle";
            this.gStyle.HeaderText = "Style";
            this.gStyle.Name = "gStyle";
            this.gStyle.ReadOnly = true;
            this.gStyle.Width = 150;
            // 
            // gSize
            // 
            this.gSize.DataPropertyName = "gSize";
            this.gSize.HeaderText = "Size";
            this.gSize.Name = "gSize";
            this.gSize.ReadOnly = true;
            this.gSize.Width = 150;
            // 
            // gColor
            // 
            this.gColor.DataPropertyName = "gColor";
            this.gColor.HeaderText = "Color";
            this.gColor.Name = "gColor";
            this.gColor.ReadOnly = true;
            this.gColor.Width = 150;
            // 
            // gQuantity
            // 
            this.gQuantity.DataPropertyName = "gQuantity";
            this.gQuantity.HeaderText = "Quantity";
            this.gQuantity.Name = "gQuantity";
            this.gQuantity.ReadOnly = true;
            this.gQuantity.Width = 150;
            // 
            // gBreakage
            // 
            this.gBreakage.DataPropertyName = "gBreakage";
            this.gBreakage.HeaderText = "Breakage";
            this.gBreakage.Name = "gBreakage";
            this.gBreakage.ReadOnly = true;
            // 
            // gSprayMan
            // 
            this.gSprayMan.DataPropertyName = "gSprayMan";
            this.gSprayMan.HeaderText = "SparayMan";
            this.gSprayMan.Name = "gSprayMan";
            this.gSprayMan.ReadOnly = true;
            // 
            // gRemarks
            // 
            this.gRemarks.DataPropertyName = "gRemarks";
            this.gRemarks.HeaderText = "Remarks";
            this.gRemarks.Name = "gRemarks";
            this.gRemarks.ReadOnly = true;
            // 
            // frmDailyGlazingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.txtBreakage);
            this.Controls.Add(this.lblBreakage);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.dgvUnGlaze);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dgvDailyGlazinReport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "frmDailyGlazingReport";
            this.Text = "Add Daily Glazing Report";
            this.Load += new System.EventHandler(this.frmDailyGlazingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnGlaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyGlazinReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtBreakage;
        private System.Windows.Forms.Label lblBreakage;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridView dgvUnGlaze;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvDailyGlazinReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn uItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn uStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn uQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSprayManID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn gColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSprayMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRemarks;

    }
}