namespace MasterCeramicsERP
{
    partial class frmShowDailyGlazingReport
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
            this.gbxShowReport = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxDailyGlazingReport = new System.Windows.Forms.GroupBox();
            this.dgvDatedReport = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbtnMonthlyReport = new System.Windows.Forms.RadioButton();
            this.rbtnDailyReport = new System.Windows.Forms.RadioButton();
            this.dtpDatedReport = new System.Windows.Forms.DateTimePicker();
            this.SprayManID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SprayMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxShowReport.SuspendLayout();
            this.gbxDailyGlazingReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatedReport)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxShowReport
            // 
            this.gbxShowReport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxShowReport.Controls.Add(this.btnShow);
            this.gbxShowReport.Controls.Add(this.btnDelete);
            this.gbxShowReport.Controls.Add(this.gbxDailyGlazingReport);
            this.gbxShowReport.Controls.Add(this.btnPrint);
            this.gbxShowReport.Controls.Add(this.rbtnMonthlyReport);
            this.gbxShowReport.Controls.Add(this.rbtnDailyReport);
            this.gbxShowReport.Controls.Add(this.dtpDatedReport);
            this.gbxShowReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxShowReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShowReport.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxShowReport.Location = new System.Drawing.Point(0, 0);
            this.gbxShowReport.Name = "gbxShowReport";
            this.gbxShowReport.Size = new System.Drawing.Size(784, 517);
            this.gbxShowReport.TabIndex = 0;
            this.gbxShowReport.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnShow.Location = new System.Drawing.Point(219, 67);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 23);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(684, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxDailyGlazingReport
            // 
            this.gbxDailyGlazingReport.Controls.Add(this.dgvDatedReport);
            this.gbxDailyGlazingReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDailyGlazingReport.ForeColor = System.Drawing.Color.DarkMagenta;
            this.gbxDailyGlazingReport.Location = new System.Drawing.Point(12, 96);
            this.gbxDailyGlazingReport.Name = "gbxDailyGlazingReport";
            this.gbxDailyGlazingReport.Size = new System.Drawing.Size(760, 409);
            this.gbxDailyGlazingReport.TabIndex = 26;
            this.gbxDailyGlazingReport.TabStop = false;
            // 
            // dgvDatedReport
            // 
            this.dgvDatedReport.AllowUserToAddRows = false;
            this.dgvDatedReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatedReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatedReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDatedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatedReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SprayManID,
            this.Item,
            this.Style,
            this.Size,
            this.Color,
            this.Quantity,
            this.Breakage,
            this.SprayMan,
            this.Remarks,
            this.Date});
            this.dgvDatedReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatedReport.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvDatedReport.Location = new System.Drawing.Point(3, 14);
            this.dgvDatedReport.Name = "dgvDatedReport";
            this.dgvDatedReport.ReadOnly = true;
            this.dgvDatedReport.Size = new System.Drawing.Size(754, 392);
            this.dgvDatedReport.TabIndex = 0;
            this.dgvDatedReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatedReport_CellClick);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnPrint.Location = new System.Drawing.Point(318, 67);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 23);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbtnMonthlyReport
            // 
            this.rbtnMonthlyReport.AutoSize = true;
            this.rbtnMonthlyReport.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbtnMonthlyReport.Location = new System.Drawing.Point(12, 70);
            this.rbtnMonthlyReport.Name = "rbtnMonthlyReport";
            this.rbtnMonthlyReport.Size = new System.Drawing.Size(123, 17);
            this.rbtnMonthlyReport.TabIndex = 23;
            this.rbtnMonthlyReport.TabStop = true;
            this.rbtnMonthlyReport.Text = "Monthly Report";
            this.rbtnMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // rbtnDailyReport
            // 
            this.rbtnDailyReport.AutoSize = true;
            this.rbtnDailyReport.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbtnDailyReport.Location = new System.Drawing.Point(12, 47);
            this.rbtnDailyReport.Name = "rbtnDailyReport";
            this.rbtnDailyReport.Size = new System.Drawing.Size(105, 17);
            this.rbtnDailyReport.TabIndex = 22;
            this.rbtnDailyReport.TabStop = true;
            this.rbtnDailyReport.Text = "Daily Report";
            this.rbtnDailyReport.UseVisualStyleBackColor = true;
            // 
            // dtpDatedReport
            // 
            this.dtpDatedReport.Location = new System.Drawing.Point(12, 20);
            this.dtpDatedReport.Name = "dtpDatedReport";
            this.dtpDatedReport.Size = new System.Drawing.Size(200, 21);
            this.dtpDatedReport.TabIndex = 21;
            // 
            // SprayManID
            // 
            this.SprayManID.DataPropertyName = "SprayManID";
            this.SprayManID.HeaderText = "SprayManID";
            this.SprayManID.Name = "SprayManID";
            this.SprayManID.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 105;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 105;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // Breakage
            // 
            this.Breakage.DataPropertyName = "Breakage";
            this.Breakage.HeaderText = "Breakage";
            this.Breakage.Name = "Breakage";
            this.Breakage.ReadOnly = true;
            // 
            // SprayMan
            // 
            this.SprayMan.DataPropertyName = "SprayMan";
            this.SprayMan.HeaderText = "SprayMan";
            this.SprayMan.Name = "SprayMan";
            this.SprayMan.ReadOnly = true;
            this.SprayMan.Width = 110;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // frmShowDailyGlazingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxShowReport);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmShowDailyGlazingReport";
            this.Text = "Update Daily Glazing Report";
            this.Load += new System.EventHandler(this.frmShowDailyGlazingReport_Load);
            this.gbxShowReport.ResumeLayout(false);
            this.gbxShowReport.PerformLayout();
            this.gbxDailyGlazingReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatedReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxShowReport;
        private System.Windows.Forms.RadioButton rbtnMonthlyReport;
        private System.Windows.Forms.RadioButton rbtnDailyReport;
        private System.Windows.Forms.DateTimePicker dtpDatedReport;
        private System.Windows.Forms.DataGridView dgvDatedReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbxDailyGlazingReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprayManID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprayMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}