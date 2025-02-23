namespace MasterCeramicsERP
{
    partial class frmDailyWages
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
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdvanceLoan = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoan = new System.Windows.Forms.Label();
            this.lblAttendence = new System.Windows.Forms.Label();
            this.txtAttendence = new System.Windows.Forms.TextBox();
            this.lblPerDay = new System.Windows.Forms.Label();
            this.txtPerDay = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblLoanDeduction = new System.Windows.Forms.Label();
            this.txtLoanDeduction = new System.Windows.Forms.TextBox();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDailyWages = new System.Windows.Forms.DateTimePicker();
            this.txtBalanceAdvance = new System.Windows.Forms.TextBox();
            this.lblBalanceAdvance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvanceLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeductAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxPerson.Location = new System.Drawing.Point(5, 6);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(546, 245);
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
            this.dgvPerson.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(538, 225);
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
            this.Worker.Width = 425;
            // 
            // txtAdvanceLoan
            // 
            this.txtAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAdvanceLoan.Location = new System.Drawing.Point(557, 94);
            this.txtAdvanceLoan.Name = "txtAdvanceLoan";
            this.txtAdvanceLoan.ReadOnly = true;
            this.txtAdvanceLoan.Size = new System.Drawing.Size(209, 21);
            this.txtAdvanceLoan.TabIndex = 3;
            // 
            // lblAdvanceLoan
            // 
            this.lblAdvanceLoan.AutoSize = true;
            this.lblAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdvanceLoan.Location = new System.Drawing.Point(557, 78);
            this.lblAdvanceLoan.Name = "lblAdvanceLoan";
            this.lblAdvanceLoan.Size = new System.Drawing.Size(102, 13);
            this.lblAdvanceLoan.TabIndex = 2;
            this.lblAdvanceLoan.Text = "Advance Loan ";
            // 
            // lblAttendence
            // 
            this.lblAttendence.AutoSize = true;
            this.lblAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAttendence.Location = new System.Drawing.Point(557, 118);
            this.lblAttendence.Name = "lblAttendence";
            this.lblAttendence.Size = new System.Drawing.Size(81, 13);
            this.lblAttendence.TabIndex = 4;
            this.lblAttendence.Text = "Attendence";
            // 
            // txtAttendence
            // 
            this.txtAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendence.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttendence.Location = new System.Drawing.Point(557, 134);
            this.txtAttendence.Name = "txtAttendence";
            this.txtAttendence.Size = new System.Drawing.Size(209, 21);
            this.txtAttendence.TabIndex = 5;
            this.txtAttendence.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAttendence_MouseClick);
            this.txtAttendence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAttendence_KeyPress);
            // 
            // lblPerDay
            // 
            this.lblPerDay.AutoSize = true;
            this.lblPerDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerDay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPerDay.Location = new System.Drawing.Point(557, 158);
            this.lblPerDay.Name = "lblPerDay";
            this.lblPerDay.Size = new System.Drawing.Size(58, 13);
            this.lblPerDay.TabIndex = 6;
            this.lblPerDay.Text = "Per Day";
            // 
            // txtPerDay
            // 
            this.txtPerDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerDay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPerDay.Location = new System.Drawing.Point(557, 174);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(209, 21);
            this.txtPerDay.TabIndex = 7;
            this.txtPerDay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPerDay_MouseClick);
            this.txtPerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerDay_KeyPress);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTotalAmount.Location = new System.Drawing.Point(557, 214);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(209, 21);
            this.txtTotalAmount.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAmount.Location = new System.Drawing.Point(557, 198);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(94, 13);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblLoanDeduction
            // 
            this.lblLoanDeduction.AutoSize = true;
            this.lblLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDeduction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLoanDeduction.Location = new System.Drawing.Point(557, 238);
            this.lblLoanDeduction.Name = "lblLoanDeduction";
            this.lblLoanDeduction.Size = new System.Drawing.Size(107, 13);
            this.lblLoanDeduction.TabIndex = 10;
            this.lblLoanDeduction.Text = "Loan Deduction";
            // 
            // txtLoanDeduction
            // 
            this.txtLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanDeduction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLoanDeduction.Location = new System.Drawing.Point(557, 254);
            this.txtLoanDeduction.Name = "txtLoanDeduction";
            this.txtLoanDeduction.Size = new System.Drawing.Size(209, 21);
            this.txtLoanDeduction.TabIndex = 11;
            this.txtLoanDeduction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLoanDeduction_MouseClick);
            this.txtLoanDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanDeduction_KeyPress);
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBalanceAmount.Location = new System.Drawing.Point(557, 299);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(209, 21);
            this.txtBalanceAmount.TabIndex = 13;
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBalanceAmount.Location = new System.Drawing.Point(557, 283);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(112, 13);
            this.lblBalanceAmount.TabIndex = 12;
            this.lblBalanceAmount.Text = "Balance Amount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalculate.Location = new System.Drawing.Point(560, 375);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(681, 375);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(560, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDailyWages
            // 
            this.dtpDailyWages.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDailyWages.Location = new System.Drawing.Point(558, 47);
            this.dtpDailyWages.Name = "dtpDailyWages";
            this.dtpDailyWages.Size = new System.Drawing.Size(208, 21);
            this.dtpDailyWages.TabIndex = 18;
            // 
            // txtBalanceAdvance
            // 
            this.txtBalanceAdvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAdvance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBalanceAdvance.Location = new System.Drawing.Point(560, 348);
            this.txtBalanceAdvance.Name = "txtBalanceAdvance";
            this.txtBalanceAdvance.ReadOnly = true;
            this.txtBalanceAdvance.Size = new System.Drawing.Size(209, 21);
            this.txtBalanceAdvance.TabIndex = 20;
            // 
            // lblBalanceAdvance
            // 
            this.lblBalanceAdvance.AutoSize = true;
            this.lblBalanceAdvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAdvance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBalanceAdvance.Location = new System.Drawing.Point(560, 332);
            this.lblBalanceAdvance.Name = "lblBalanceAdvance";
            this.lblBalanceAdvance.Size = new System.Drawing.Size(118, 13);
            this.lblBalanceAdvance.TabIndex = 19;
            this.lblBalanceAdvance.Text = "Balance Advance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecord);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(9, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(538, 248);
            this.groupBox1.TabIndex = 21;
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
            this.PerDay,
            this.Attendance,
            this.TotalAmount,
            this.AdvanceLoan,
            this.DeductAdvance,
            this.BalanceAmount,
            this.BalanceAdvance,
            this.Date});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRecord.Location = new System.Drawing.Point(4, 14);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(530, 231);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(681, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // PerDay
            // 
            this.PerDay.DataPropertyName = "PerDay";
            this.PerDay.HeaderText = "PerDay";
            this.PerDay.Name = "PerDay";
            this.PerDay.ReadOnly = true;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "Attendance";
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // AdvanceLoan
            // 
            this.AdvanceLoan.DataPropertyName = "AdvanceLoan";
            this.AdvanceLoan.HeaderText = "AdvanceLoan";
            this.AdvanceLoan.Name = "AdvanceLoan";
            this.AdvanceLoan.ReadOnly = true;
            // 
            // DeductAdvance
            // 
            this.DeductAdvance.DataPropertyName = "DeductAdvance";
            this.DeductAdvance.HeaderText = "DeductAdvance";
            this.DeductAdvance.Name = "DeductAdvance";
            this.DeductAdvance.ReadOnly = true;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.DataPropertyName = "BalanceAmount";
            this.BalanceAmount.HeaderText = "BalanceAmount";
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.ReadOnly = true;
            // 
            // BalanceAdvance
            // 
            this.BalanceAdvance.DataPropertyName = "BalanceAdvance";
            this.BalanceAdvance.HeaderText = "BalanceAdvance";
            this.BalanceAdvance.Name = "BalanceAdvance";
            this.BalanceAdvance.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // frmDailyWages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBalanceAdvance);
            this.Controls.Add(this.lblBalanceAdvance);
            this.Controls.Add(this.dtpDailyWages);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBalanceAmount);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.lblLoanDeduction);
            this.Controls.Add(this.txtLoanDeduction);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblPerDay);
            this.Controls.Add(this.txtPerDay);
            this.Controls.Add(this.lblAttendence);
            this.Controls.Add(this.txtAdvanceLoan);
            this.Controls.Add(this.txtAttendence);
            this.Controls.Add(this.lblAdvanceLoan);
            this.Controls.Add(this.gbxPerson);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmDailyWages";
            this.Text = "Daily Wages Report";
            this.Load += new System.EventHandler(this.frmDailyWages_Load);
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.TextBox txtAdvanceLoan;
        private System.Windows.Forms.Label lblAdvanceLoan;
        private System.Windows.Forms.Label lblAttendence;
        private System.Windows.Forms.TextBox txtAttendence;
        private System.Windows.Forms.Label lblPerDay;
        private System.Windows.Forms.TextBox txtPerDay;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblLoanDeduction;
        private System.Windows.Forms.TextBox txtLoanDeduction;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDailyWages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.TextBox txtBalanceAdvance;
        private System.Windows.Forms.Label lblBalanceAdvance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvanceLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeductAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}