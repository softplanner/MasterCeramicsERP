namespace MasterCeramicsERP
{
    partial class frmKillenFeedShow
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
            this.btnShow = new System.Windows.Forms.Button();
            this.gbxKillenFeedReport = new System.Windows.Forms.GroupBox();
            this.dgvKillenReport = new System.Windows.Forms.DataGridView();
            this.kItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kBreakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.rbtnMonthlyReport = new System.Windows.Forms.RadioButton();
            this.rbtnDailyReport = new System.Windows.Forms.RadioButton();
            this.dtpDatedReport = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxKillenFeedReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Firebrick;
            this.btnShow.Location = new System.Drawing.Point(141, 56);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(71, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbxKillenFeedReport
            // 
            this.gbxKillenFeedReport.Controls.Add(this.dgvKillenReport);
            this.gbxKillenFeedReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKillenFeedReport.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxKillenFeedReport.Location = new System.Drawing.Point(12, 85);
            this.gbxKillenFeedReport.Name = "gbxKillenFeedReport";
            this.gbxKillenFeedReport.Size = new System.Drawing.Size(760, 420);
            this.gbxKillenFeedReport.TabIndex = 7;
            this.gbxKillenFeedReport.TabStop = false;
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
            this.dgvKillenReport.Size = new System.Drawing.Size(754, 400);
            this.dgvKillenReport.TabIndex = 1;
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
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPrintReport.Location = new System.Drawing.Point(653, 56);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(116, 23);
            this.btnPrintReport.TabIndex = 6;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // rbtnMonthlyReport
            // 
            this.rbtnMonthlyReport.AutoSize = true;
            this.rbtnMonthlyReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonthlyReport.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtnMonthlyReport.Location = new System.Drawing.Point(12, 62);
            this.rbtnMonthlyReport.Name = "rbtnMonthlyReport";
            this.rbtnMonthlyReport.Size = new System.Drawing.Size(123, 17);
            this.rbtnMonthlyReport.TabIndex = 26;
            this.rbtnMonthlyReport.TabStop = true;
            this.rbtnMonthlyReport.Text = "Monthly Report";
            this.rbtnMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // rbtnDailyReport
            // 
            this.rbtnDailyReport.AutoSize = true;
            this.rbtnDailyReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDailyReport.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtnDailyReport.Location = new System.Drawing.Point(12, 39);
            this.rbtnDailyReport.Name = "rbtnDailyReport";
            this.rbtnDailyReport.Size = new System.Drawing.Size(105, 17);
            this.rbtnDailyReport.TabIndex = 25;
            this.rbtnDailyReport.TabStop = true;
            this.rbtnDailyReport.Text = "Daily Report";
            this.rbtnDailyReport.UseVisualStyleBackColor = true;
            // 
            // dtpDatedReport
            // 
            this.dtpDatedReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatedReport.Location = new System.Drawing.Point(12, 12);
            this.dtpDatedReport.Name = "dtpDatedReport";
            this.dtpDatedReport.Size = new System.Drawing.Size(200, 21);
            this.dtpDatedReport.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(698, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmKillenFeedShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rbtnMonthlyReport);
            this.Controls.Add(this.rbtnDailyReport);
            this.Controls.Add(this.dtpDatedReport);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.gbxKillenFeedReport);
            this.Controls.Add(this.btnShow);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmKillenFeedShow";
            this.Text = "Killen Feed Report";
            this.Load += new System.EventHandler(this.frmKillenFeedShow_Load);
            this.gbxKillenFeedReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKillenReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gbxKillenFeedReport;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.RadioButton rbtnMonthlyReport;
        private System.Windows.Forms.RadioButton rbtnDailyReport;
        private System.Windows.Forms.DateTimePicker dtpDatedReport;
        private System.Windows.Forms.DataGridView dgvKillenReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn kItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn kSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn kColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn kQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn kBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn kRemarks;
        private System.Windows.Forms.Button btnDelete;
    }
}