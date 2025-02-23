namespace MasterCeramicsERP
{
    partial class frmMonthlySalary
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPerDay = new System.Windows.Forms.Label();
            this.txtPerDay = new System.Windows.Forms.TextBox();
            this.lblAttendence = new System.Windows.Forms.Label();
            this.txtAttendence = new System.Windows.Forms.TextBox();
            this.txtAdvanceLoanTotal = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoanTotal = new System.Windows.Forms.Label();
            this.lblEAttendence = new System.Windows.Forms.Label();
            this.txtExtraAttendence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAttendence = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoan = new System.Windows.Forms.Label();
            this.txtAdvanceLoanDeduction = new System.Windows.Forms.TextBox();
            this.lblShortLoanDeduction = new System.Windows.Forms.Label();
            this.txtShortLoanDeduction = new System.Windows.Forms.TextBox();
            this.dtpMonthlySalary = new System.Windows.Forms.DateTimePicker();
            this.lblDatesSelect = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.lblShortLoanTotal = new System.Windows.Forms.Label();
            this.txtShortTermLoanTotal = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtBalanceShortLoan = new System.Windows.Forms.TextBox();
            this.lblbalanceShortLoan = new System.Windows.Forms.Label();
            this.txtBalanceAdvance = new System.Windows.Forms.TextBox();
            this.lblBalAdvance = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbxPerson.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbxPerson.Location = new System.Drawing.Point(4, 5);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(494, 195);
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
            this.dgvPerson.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(486, 175);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDate.Location = new System.Drawing.Point(505, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Location = new System.Drawing.Point(597, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.Location = new System.Drawing.Point(690, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 23);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalculate.Location = new System.Drawing.Point(509, 464);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 23);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBalanceAmount.Location = new System.Drawing.Point(672, 372);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(100, 21);
            this.txtBalanceAmount.TabIndex = 21;
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBalanceAmount.Location = new System.Drawing.Point(505, 375);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(112, 13);
            this.lblBalanceAmount.TabIndex = 20;
            this.lblBalanceAmount.Text = "Balance Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalAmount.Location = new System.Drawing.Point(672, 291);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 21);
            this.txtTotalAmount.TabIndex = 15;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalAmount.Location = new System.Drawing.Point(505, 294);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(94, 13);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblPerDay
            // 
            this.lblPerDay.AutoSize = true;
            this.lblPerDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerDay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPerDay.Location = new System.Drawing.Point(505, 267);
            this.lblPerDay.Name = "lblPerDay";
            this.lblPerDay.Size = new System.Drawing.Size(58, 13);
            this.lblPerDay.TabIndex = 12;
            this.lblPerDay.Text = "Per Day";
            // 
            // txtPerDay
            // 
            this.txtPerDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerDay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPerDay.Location = new System.Drawing.Point(672, 264);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.ReadOnly = true;
            this.txtPerDay.Size = new System.Drawing.Size(100, 21);
            this.txtPerDay.TabIndex = 13;
            this.txtPerDay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPerDay_MouseClick);
            this.txtPerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerDay_KeyPress);
            // 
            // lblAttendence
            // 
            this.lblAttendence.AutoSize = true;
            this.lblAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAttendence.Location = new System.Drawing.Point(505, 186);
            this.lblAttendence.Name = "lblAttendence";
            this.lblAttendence.Size = new System.Drawing.Size(81, 13);
            this.lblAttendence.TabIndex = 6;
            this.lblAttendence.Text = "Attendence";
            // 
            // txtAttendence
            // 
            this.txtAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendence.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAttendence.Location = new System.Drawing.Point(672, 183);
            this.txtAttendence.Name = "txtAttendence";
            this.txtAttendence.ReadOnly = true;
            this.txtAttendence.Size = new System.Drawing.Size(100, 21);
            this.txtAttendence.TabIndex = 7;
            // 
            // txtAdvanceLoanTotal
            // 
            this.txtAdvanceLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoanTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAdvanceLoanTotal.Location = new System.Drawing.Point(672, 156);
            this.txtAdvanceLoanTotal.Name = "txtAdvanceLoanTotal";
            this.txtAdvanceLoanTotal.ReadOnly = true;
            this.txtAdvanceLoanTotal.Size = new System.Drawing.Size(100, 21);
            this.txtAdvanceLoanTotal.TabIndex = 5;
            // 
            // lblAdvanceLoanTotal
            // 
            this.lblAdvanceLoanTotal.AutoSize = true;
            this.lblAdvanceLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoanTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdvanceLoanTotal.Location = new System.Drawing.Point(505, 159);
            this.lblAdvanceLoanTotal.Name = "lblAdvanceLoanTotal";
            this.lblAdvanceLoanTotal.Size = new System.Drawing.Size(102, 13);
            this.lblAdvanceLoanTotal.TabIndex = 4;
            this.lblAdvanceLoanTotal.Text = "Advance Loan ";
            // 
            // lblEAttendence
            // 
            this.lblEAttendence.AutoSize = true;
            this.lblEAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEAttendence.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEAttendence.Location = new System.Drawing.Point(505, 213);
            this.lblEAttendence.Name = "lblEAttendence";
            this.lblEAttendence.Size = new System.Drawing.Size(120, 13);
            this.lblEAttendence.TabIndex = 8;
            this.lblEAttendence.Text = "Extra Attendence";
            // 
            // txtExtraAttendence
            // 
            this.txtExtraAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraAttendence.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtExtraAttendence.Location = new System.Drawing.Point(672, 210);
            this.txtExtraAttendence.Name = "txtExtraAttendence";
            this.txtExtraAttendence.ReadOnly = true;
            this.txtExtraAttendence.Size = new System.Drawing.Size(100, 21);
            this.txtExtraAttendence.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(505, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Attendence";
            // 
            // txtTotalAttendence
            // 
            this.txtTotalAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAttendence.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotalAttendence.Location = new System.Drawing.Point(672, 237);
            this.txtTotalAttendence.Name = "txtTotalAttendence";
            this.txtTotalAttendence.ReadOnly = true;
            this.txtTotalAttendence.Size = new System.Drawing.Size(100, 21);
            this.txtTotalAttendence.TabIndex = 11;
            // 
            // lblAdvanceLoan
            // 
            this.lblAdvanceLoan.AutoSize = true;
            this.lblAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdvanceLoan.Location = new System.Drawing.Point(505, 348);
            this.lblAdvanceLoan.Name = "lblAdvanceLoan";
            this.lblAdvanceLoan.Size = new System.Drawing.Size(147, 13);
            this.lblAdvanceLoan.TabIndex = 18;
            this.lblAdvanceLoan.Text = "Deduct Advance Loan";
            // 
            // txtAdvanceLoanDeduction
            // 
            this.txtAdvanceLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoanDeduction.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAdvanceLoanDeduction.Location = new System.Drawing.Point(672, 345);
            this.txtAdvanceLoanDeduction.Name = "txtAdvanceLoanDeduction";
            this.txtAdvanceLoanDeduction.Size = new System.Drawing.Size(100, 21);
            this.txtAdvanceLoanDeduction.TabIndex = 19;
            this.txtAdvanceLoanDeduction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdvanceLoanDeduction_MouseClick);
            this.txtAdvanceLoanDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceLoanDeduction_KeyPress);
            // 
            // lblShortLoanDeduction
            // 
            this.lblShortLoanDeduction.AutoSize = true;
            this.lblShortLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortLoanDeduction.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblShortLoanDeduction.Location = new System.Drawing.Point(505, 321);
            this.lblShortLoanDeduction.Name = "lblShortLoanDeduction";
            this.lblShortLoanDeduction.Size = new System.Drawing.Size(164, 13);
            this.lblShortLoanDeduction.TabIndex = 16;
            this.lblShortLoanDeduction.Text = "Deduct Short Term Loan";
            // 
            // txtShortLoanDeduction
            // 
            this.txtShortLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortLoanDeduction.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtShortLoanDeduction.Location = new System.Drawing.Point(672, 318);
            this.txtShortLoanDeduction.Name = "txtShortLoanDeduction";
            this.txtShortLoanDeduction.Size = new System.Drawing.Size(100, 21);
            this.txtShortLoanDeduction.TabIndex = 17;
            this.txtShortLoanDeduction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtShortLoanDeduction_MouseClick);
            this.txtShortLoanDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShortLoanDeduction_KeyPress);
            // 
            // dtpMonthlySalary
            // 
            this.dtpMonthlySalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMonthlySalary.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthlySalary.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonthlySalary.Location = new System.Drawing.Point(505, 74);
            this.dtpMonthlySalary.Name = "dtpMonthlySalary";
            this.dtpMonthlySalary.Size = new System.Drawing.Size(267, 21);
            this.dtpMonthlySalary.TabIndex = 25;
            // 
            // lblDatesSelect
            // 
            this.lblDatesSelect.AutoSize = true;
            this.lblDatesSelect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatesSelect.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDatesSelect.Location = new System.Drawing.Point(505, 50);
            this.lblDatesSelect.Name = "lblDatesSelect";
            this.lblDatesSelect.Size = new System.Drawing.Size(102, 13);
            this.lblDatesSelect.TabIndex = 26;
            this.lblDatesSelect.Text = "Select Month ::";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecord);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(5, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(494, 302);
            this.groupBox1.TabIndex = 1;
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
            this.Date});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRecord.Location = new System.Drawing.Point(4, 14);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(486, 285);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellClick);
            // 
            // lblShortLoanTotal
            // 
            this.lblShortLoanTotal.AutoSize = true;
            this.lblShortLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortLoanTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblShortLoanTotal.Location = new System.Drawing.Point(505, 132);
            this.lblShortLoanTotal.Name = "lblShortLoanTotal";
            this.lblShortLoanTotal.Size = new System.Drawing.Size(115, 13);
            this.lblShortLoanTotal.TabIndex = 2;
            this.lblShortLoanTotal.Text = "Short Term Loan";
            // 
            // txtShortTermLoanTotal
            // 
            this.txtShortTermLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortTermLoanTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtShortTermLoanTotal.Location = new System.Drawing.Point(672, 129);
            this.txtShortTermLoanTotal.Name = "txtShortTermLoanTotal";
            this.txtShortTermLoanTotal.ReadOnly = true;
            this.txtShortTermLoanTotal.Size = new System.Drawing.Size(100, 21);
            this.txtShortTermLoanTotal.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSalary.Location = new System.Drawing.Point(672, 102);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(100, 21);
            this.txtSalary.TabIndex = 30;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSalary.Location = new System.Drawing.Point(505, 105);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(49, 13);
            this.lblSalary.TabIndex = 29;
            this.lblSalary.Text = "Salary";
            // 
            // txtBalanceShortLoan
            // 
            this.txtBalanceShortLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceShortLoan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBalanceShortLoan.Location = new System.Drawing.Point(672, 399);
            this.txtBalanceShortLoan.Name = "txtBalanceShortLoan";
            this.txtBalanceShortLoan.ReadOnly = true;
            this.txtBalanceShortLoan.Size = new System.Drawing.Size(100, 21);
            this.txtBalanceShortLoan.TabIndex = 32;
            // 
            // lblbalanceShortLoan
            // 
            this.lblbalanceShortLoan.AutoSize = true;
            this.lblbalanceShortLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalanceShortLoan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblbalanceShortLoan.Location = new System.Drawing.Point(505, 402);
            this.lblbalanceShortLoan.Name = "lblbalanceShortLoan";
            this.lblbalanceShortLoan.Size = new System.Drawing.Size(132, 13);
            this.lblbalanceShortLoan.TabIndex = 31;
            this.lblbalanceShortLoan.Text = "Balance Short Loan";
            // 
            // txtBalanceAdvance
            // 
            this.txtBalanceAdvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAdvance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBalanceAdvance.Location = new System.Drawing.Point(672, 426);
            this.txtBalanceAdvance.Name = "txtBalanceAdvance";
            this.txtBalanceAdvance.ReadOnly = true;
            this.txtBalanceAdvance.Size = new System.Drawing.Size(100, 21);
            this.txtBalanceAdvance.TabIndex = 34;
            // 
            // lblBalAdvance
            // 
            this.lblBalAdvance.AutoSize = true;
            this.lblBalAdvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalAdvance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBalAdvance.Location = new System.Drawing.Point(505, 429);
            this.lblBalAdvance.Name = "lblBalAdvance";
            this.lblBalAdvance.Size = new System.Drawing.Size(118, 13);
            this.lblBalAdvance.TabIndex = 33;
            this.lblBalAdvance.Text = "Balance Advance";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(690, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.Worker.Width = 380;
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
            // frmMonthlySalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBalanceAdvance);
            this.Controls.Add(this.lblBalAdvance);
            this.Controls.Add(this.txtBalanceShortLoan);
            this.Controls.Add(this.lblbalanceShortLoan);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDatesSelect);
            this.Controls.Add(this.dtpMonthlySalary);
            this.Controls.Add(this.lblAdvanceLoan);
            this.Controls.Add(this.txtAdvanceLoanDeduction);
            this.Controls.Add(this.lblShortLoanDeduction);
            this.Controls.Add(this.txtShortLoanDeduction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalAttendence);
            this.Controls.Add(this.lblEAttendence);
            this.Controls.Add(this.txtExtraAttendence);
            this.Controls.Add(this.txtAdvanceLoanTotal);
            this.Controls.Add(this.lblAdvanceLoanTotal);
            this.Controls.Add(this.txtShortTermLoanTotal);
            this.Controls.Add(this.lblShortLoanTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBalanceAmount);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblPerDay);
            this.Controls.Add(this.txtPerDay);
            this.Controls.Add(this.lblAttendence);
            this.Controls.Add(this.txtAttendence);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gbxPerson);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMonthlySalary";
            this.Text = "Monthly Salary Report";
            this.Load += new System.EventHandler(this.frmMonthlySalary_Load);
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPerDay;
        private System.Windows.Forms.TextBox txtPerDay;
        private System.Windows.Forms.Label lblAttendence;
        private System.Windows.Forms.TextBox txtAttendence;
        private System.Windows.Forms.TextBox txtAdvanceLoanTotal;
        private System.Windows.Forms.Label lblAdvanceLoanTotal;
        private System.Windows.Forms.Label lblEAttendence;
        private System.Windows.Forms.TextBox txtExtraAttendence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAttendence;
        private System.Windows.Forms.Label lblAdvanceLoan;
        private System.Windows.Forms.TextBox txtAdvanceLoanDeduction;
        private System.Windows.Forms.Label lblShortLoanDeduction;
        private System.Windows.Forms.TextBox txtShortLoanDeduction;
        private System.Windows.Forms.DateTimePicker dtpMonthlySalary;
        private System.Windows.Forms.Label lblDatesSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Label lblShortLoanTotal;
        private System.Windows.Forms.TextBox txtShortTermLoanTotal;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtBalanceShortLoan;
        private System.Windows.Forms.Label lblbalanceShortLoan;
        private System.Windows.Forms.TextBox txtBalanceAdvance;
        private System.Windows.Forms.Label lblBalAdvance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
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
    }
}