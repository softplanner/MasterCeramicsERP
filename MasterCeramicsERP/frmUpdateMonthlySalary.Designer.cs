namespace MasterCeramicsERP
{
    partial class frmUpdateMonthlySalary
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnprintReport = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpAttendence = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeductShortLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeductAdvanceLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAdvanceLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceShortLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(674, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnprintReport
            // 
            this.btnprintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintReport.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnprintReport.Location = new System.Drawing.Point(264, 36);
            this.btnprintReport.Name = "btnprintReport";
            this.btnprintReport.Size = new System.Drawing.Size(93, 23);
            this.btnprintReport.TabIndex = 8;
            this.btnprintReport.Text = "Print Report";
            this.btnprintReport.UseVisualStyleBackColor = true;
            this.btnprintReport.Click += new System.EventHandler(this.btnprintReport_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnShow.Location = new System.Drawing.Point(165, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpAttendence
            // 
            this.dtpAttendence.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendence.Location = new System.Drawing.Point(8, 12);
            this.dtpAttendence.Name = "dtpAttendence";
            this.dtpAttendence.Size = new System.Drawing.Size(349, 21);
            this.dtpAttendence.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecord);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(758, 443);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkerID,
            this.rWorker,
            this.Salary,
            this.Attendance,
            this.ExtraAttendance,
            this.TotalAttendance,
            this.PerDay,
            this.TotalAmount,
            this.DeductShortLoan,
            this.DeductAdvanceLoan,
            this.BalanceAmount,
            this.BalanceAdvanceLoan,
            this.BalanceShortLoan,
            this.Date,
            this.ReportDate});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRecord.Location = new System.Drawing.Point(4, 14);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(750, 426);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellClick);
            // 
            // WorkerID
            // 
            this.WorkerID.DataPropertyName = "WorkerID";
            this.WorkerID.HeaderText = "WorkerID";
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.ReadOnly = true;
            this.WorkerID.Visible = false;
            this.WorkerID.Width = 70;
            // 
            // rWorker
            // 
            this.rWorker.DataPropertyName = "Worker";
            this.rWorker.HeaderText = "Worker";
            this.rWorker.Name = "rWorker";
            this.rWorker.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "Attendance";
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // ExtraAttendance
            // 
            this.ExtraAttendance.DataPropertyName = "ExtraAttendance";
            this.ExtraAttendance.HeaderText = "ExtraAttendance";
            this.ExtraAttendance.Name = "ExtraAttendance";
            this.ExtraAttendance.ReadOnly = true;
            // 
            // TotalAttendance
            // 
            this.TotalAttendance.DataPropertyName = "TotalAttendance";
            this.TotalAttendance.HeaderText = "TotalAttendance";
            this.TotalAttendance.Name = "TotalAttendance";
            this.TotalAttendance.ReadOnly = true;
            // 
            // PerDay
            // 
            this.PerDay.DataPropertyName = "PerDay";
            this.PerDay.HeaderText = "PerDay";
            this.PerDay.Name = "PerDay";
            this.PerDay.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // DeductShortLoan
            // 
            this.DeductShortLoan.DataPropertyName = "DeductShortLoan";
            this.DeductShortLoan.HeaderText = "DeductShortLoan";
            this.DeductShortLoan.Name = "DeductShortLoan";
            this.DeductShortLoan.ReadOnly = true;
            // 
            // DeductAdvanceLoan
            // 
            this.DeductAdvanceLoan.DataPropertyName = "DeductAdvanceLoan";
            this.DeductAdvanceLoan.HeaderText = "DeductAdvanceLoan";
            this.DeductAdvanceLoan.Name = "DeductAdvanceLoan";
            this.DeductAdvanceLoan.ReadOnly = true;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.DataPropertyName = "BalanceAmount";
            this.BalanceAmount.HeaderText = "BalanceAmount";
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.ReadOnly = true;
            // 
            // BalanceAdvanceLoan
            // 
            this.BalanceAdvanceLoan.DataPropertyName = "BalanceAdvanceLoan";
            this.BalanceAdvanceLoan.HeaderText = "BalanceAdvanceLoan";
            this.BalanceAdvanceLoan.Name = "BalanceAdvanceLoan";
            this.BalanceAdvanceLoan.ReadOnly = true;
            // 
            // BalanceShortLoan
            // 
            this.BalanceShortLoan.DataPropertyName = "BalanceShortLoan";
            this.BalanceShortLoan.HeaderText = "BalanceShortLoan";
            this.BalanceShortLoan.Name = "BalanceShortLoan";
            this.BalanceShortLoan.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ReportDate
            // 
            this.ReportDate.DataPropertyName = "ReportDate";
            this.ReportDate.HeaderText = "ReportDate";
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.ReadOnly = true;
            // 
            // frmUpdateMonthlySalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnprintReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpAttendence);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmUpdateMonthlySalary";
            this.Text = "View & Delete Monthly Salary Report";
            this.Load += new System.EventHandler(this.frmUpdateMonthlySalary_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnprintReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpAttendence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeductShortLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeductAdvanceLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAdvanceLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceShortLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportDate;
    }
}