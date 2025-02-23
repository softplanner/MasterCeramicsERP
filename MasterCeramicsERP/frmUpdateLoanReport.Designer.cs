namespace MasterCeramicsERP
{
    partial class frmUpdateLoanReport
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
            this.gbxWorkerLoan = new System.Windows.Forms.GroupBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnprintReport = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAttendence = new System.Windows.Forms.DateTimePicker();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUpdateAmount = new System.Windows.Forms.Label();
            this.txtUpdatedAmount = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAdvanceLoan = new System.Windows.Forms.TextBox();
            this.txtShortTermLoan = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoan = new System.Windows.Forms.Label();
            this.lblShortTermLoan = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxWorkerLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxWorkerLoan
            // 
            this.gbxWorkerLoan.Controls.Add(this.dgvRecord);
            this.gbxWorkerLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxWorkerLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxWorkerLoan.Location = new System.Drawing.Point(3, 237);
            this.gbxWorkerLoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxWorkerLoan.Name = "gbxWorkerLoan";
            this.gbxWorkerLoan.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxWorkerLoan.Size = new System.Drawing.Size(778, 277);
            this.gbxWorkerLoan.TabIndex = 17;
            this.gbxWorkerLoan.TabStop = false;
            this.gbxWorkerLoan.Text = "Worker Loan Report";
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkerID,
            this.rWorker,
            this.LoanType,
            this.Amount,
            this.Salary,
            this.Date});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRecord.Location = new System.Drawing.Point(4, 17);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(770, 257);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(574, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(201, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnprintReport
            // 
            this.btnprintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprintReport.Location = new System.Drawing.Point(574, 206);
            this.btnprintReport.Name = "btnprintReport";
            this.btnprintReport.Size = new System.Drawing.Size(201, 23);
            this.btnprintReport.TabIndex = 16;
            this.btnprintReport.Text = "Print Report";
            this.btnprintReport.UseVisualStyleBackColor = true;
            this.btnprintReport.Click += new System.EventHandler(this.btnprintReport_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(574, 149);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(201, 23);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnMonth.Location = new System.Drawing.Point(574, 100);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 12;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnDay.Location = new System.Drawing.Point(574, 76);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 11;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(574, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Select Date";
            // 
            // dtpAttendence
            // 
            this.dtpAttendence.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendence.Location = new System.Drawing.Point(574, 49);
            this.dtpAttendence.Name = "dtpAttendence";
            this.dtpAttendence.Size = new System.Drawing.Size(203, 21);
            this.dtpAttendence.TabIndex = 10;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnYear.Location = new System.Drawing.Point(574, 123);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 13;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxPerson.Location = new System.Drawing.Point(3, 5);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(351, 227);
            this.gbxPerson.TabIndex = 0;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Worker";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Worker});
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(343, 207);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Worker
            // 
            this.Worker.DataPropertyName = "Worker";
            this.Worker.HeaderText = "Worker";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            this.Worker.Width = 230;
            // 
            // lblUpdateAmount
            // 
            this.lblUpdateAmount.AutoSize = true;
            this.lblUpdateAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUpdateAmount.Location = new System.Drawing.Point(364, 115);
            this.lblUpdateAmount.Name = "lblUpdateAmount";
            this.lblUpdateAmount.Size = new System.Drawing.Size(96, 13);
            this.lblUpdateAmount.TabIndex = 5;
            this.lblUpdateAmount.Text = "Enter Amount";
            // 
            // txtUpdatedAmount
            // 
            this.txtUpdatedAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatedAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUpdatedAmount.Location = new System.Drawing.Point(364, 141);
            this.txtUpdatedAmount.Name = "txtUpdatedAmount";
            this.txtUpdatedAmount.Size = new System.Drawing.Size(169, 21);
            this.txtUpdatedAmount.TabIndex = 6;
            this.txtUpdatedAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdatedAmount_MouseClick);
            this.txtUpdatedAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdatedAmount_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(364, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Report";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAdvanceLoan
            // 
            this.txtAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAdvanceLoan.Location = new System.Drawing.Point(364, 88);
            this.txtAdvanceLoan.Name = "txtAdvanceLoan";
            this.txtAdvanceLoan.ReadOnly = true;
            this.txtAdvanceLoan.Size = new System.Drawing.Size(169, 21);
            this.txtAdvanceLoan.TabIndex = 4;
            // 
            // txtShortTermLoan
            // 
            this.txtShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortTermLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtShortTermLoan.Location = new System.Drawing.Point(364, 49);
            this.txtShortTermLoan.Name = "txtShortTermLoan";
            this.txtShortTermLoan.ReadOnly = true;
            this.txtShortTermLoan.Size = new System.Drawing.Size(169, 21);
            this.txtShortTermLoan.TabIndex = 2;
            // 
            // lblAdvanceLoan
            // 
            this.lblAdvanceLoan.AutoSize = true;
            this.lblAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdvanceLoan.Location = new System.Drawing.Point(364, 72);
            this.lblAdvanceLoan.Name = "lblAdvanceLoan";
            this.lblAdvanceLoan.Size = new System.Drawing.Size(152, 13);
            this.lblAdvanceLoan.TabIndex = 3;
            this.lblAdvanceLoan.Text = "Advance Loan Amount";
            // 
            // lblShortTermLoan
            // 
            this.lblShortTermLoan.AutoSize = true;
            this.lblShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortTermLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShortTermLoan.Location = new System.Drawing.Point(364, 22);
            this.lblShortTermLoan.Name = "lblShortTermLoan";
            this.lblShortTermLoan.Size = new System.Drawing.Size(169, 13);
            this.lblShortTermLoan.TabIndex = 1;
            this.lblShortTermLoan.Text = "Short Term Loan Amount";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(364, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Report";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // WorkerID
            // 
            this.WorkerID.DataPropertyName = "WorkerID";
            this.WorkerID.HeaderText = "WorkerID";
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.ReadOnly = true;
            this.WorkerID.Width = 70;
            // 
            // rWorker
            // 
            this.rWorker.DataPropertyName = "Worker";
            this.rWorker.HeaderText = "Worker";
            this.rWorker.Name = "rWorker";
            this.rWorker.ReadOnly = true;
            this.rWorker.Width = 230;
            // 
            // LoanType
            // 
            this.LoanType.DataPropertyName = "LoanType";
            this.LoanType.HeaderText = "Loan Type";
            this.LoanType.Name = "LoanType";
            this.LoanType.ReadOnly = true;
            this.LoanType.Width = 200;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 70;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 157;
            // 
            // frmUpdateLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUpdateAmount);
            this.Controls.Add(this.txtUpdatedAmount);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAdvanceLoan);
            this.Controls.Add(this.txtShortTermLoan);
            this.Controls.Add(this.lblAdvanceLoan);
            this.Controls.Add(this.lblShortTermLoan);
            this.Controls.Add(this.gbxPerson);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnprintReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpAttendence);
            this.Controls.Add(this.gbxWorkerLoan);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmUpdateLoanReport";
            this.Text = "View & Update Loan Report";
            this.Load += new System.EventHandler(this.frmUpdateLoanReport_Load);
            this.gbxWorkerLoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxWorkerLoan;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnprintReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAttendence;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label lblUpdateAmount;
        private System.Windows.Forms.TextBox txtUpdatedAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAdvanceLoan;
        private System.Windows.Forms.TextBox txtShortTermLoan;
        private System.Windows.Forms.Label lblAdvanceLoan;
        private System.Windows.Forms.Label lblShortTermLoan;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}