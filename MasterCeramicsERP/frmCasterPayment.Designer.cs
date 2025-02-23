namespace MasterCeramicsERP
{
    partial class frmCasterPayment
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
            this.lblSize_slipFromItem = new System.Windows.Forms.Label();
            this.lblStyle_slipFromItem = new System.Windows.Forms.Label();
            this.lblItem_slipFromItem = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblShortLoanDeduction = new System.Windows.Forms.Label();
            this.txtShortLoanDeduction = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoan = new System.Windows.Forms.Label();
            this.txtAdvanceLoanDeduction = new System.Windows.Forms.TextBox();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtAdvanceLoanTotal = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoanTotal = new System.Windows.Forms.Label();
            this.txtShortTermLoanTotal = new System.Windows.Forms.TextBox();
            this.lblShortLoanTotal = new System.Windows.Forms.Label();
            this.txtBalanceAdvance = new System.Windows.Forms.TextBox();
            this.lblBalanceAdvance = new System.Windows.Forms.Label();
            this.txtBalanceShortLoan = new System.Windows.Forms.TextBox();
            this.lblBalanceShort = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvanceLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeductShortLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeductAdvanceLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceShortLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAdvanceLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.gbxPerson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxPerson.Location = new System.Drawing.Point(3, 8);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(508, 207);
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
            this.dgvPerson.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(500, 187);
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
            this.Worker.Width = 350;
            // 
            // lblSize_slipFromItem
            // 
            this.lblSize_slipFromItem.AutoSize = true;
            this.lblSize_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize_slipFromItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSize_slipFromItem.Location = new System.Drawing.Point(521, 103);
            this.lblSize_slipFromItem.Name = "lblSize_slipFromItem";
            this.lblSize_slipFromItem.Size = new System.Drawing.Size(34, 13);
            this.lblSize_slipFromItem.TabIndex = 10;
            this.lblSize_slipFromItem.Text = "Size";
            // 
            // lblStyle_slipFromItem
            // 
            this.lblStyle_slipFromItem.AutoSize = true;
            this.lblStyle_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle_slipFromItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStyle_slipFromItem.Location = new System.Drawing.Point(521, 76);
            this.lblStyle_slipFromItem.Name = "lblStyle_slipFromItem";
            this.lblStyle_slipFromItem.Size = new System.Drawing.Size(40, 13);
            this.lblStyle_slipFromItem.TabIndex = 8;
            this.lblStyle_slipFromItem.Text = "Style";
            // 
            // lblItem_slipFromItem
            // 
            this.lblItem_slipFromItem.AutoSize = true;
            this.lblItem_slipFromItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_slipFromItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblItem_slipFromItem.Location = new System.Drawing.Point(521, 49);
            this.lblItem_slipFromItem.Name = "lblItem_slipFromItem";
            this.lblItem_slipFromItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem_slipFromItem.TabIndex = 6;
            this.lblItem_slipFromItem.Text = "Item";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRate.Location = new System.Drawing.Point(521, 214);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(36, 13);
            this.lblRate.TabIndex = 14;
            this.lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtRate.Location = new System.Drawing.Point(655, 211);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(123, 21);
            this.txtRate.TabIndex = 15;
            this.txtRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRate_MouseClick);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblQuantity.Location = new System.Drawing.Point(521, 129);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtQuantity.Location = new System.Drawing.Point(655, 126);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(123, 21);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtTotalAmount.Location = new System.Drawing.Point(655, 237);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(123, 21);
            this.txtTotalAmount.TabIndex = 17;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalAmount.Location = new System.Drawing.Point(521, 240);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(94, 13);
            this.lblTotalAmount.TabIndex = 16;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblShortLoanDeduction
            // 
            this.lblShortLoanDeduction.AutoSize = true;
            this.lblShortLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortLoanDeduction.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblShortLoanDeduction.Location = new System.Drawing.Point(521, 264);
            this.lblShortLoanDeduction.Name = "lblShortLoanDeduction";
            this.lblShortLoanDeduction.Size = new System.Drawing.Size(111, 13);
            this.lblShortLoanDeduction.TabIndex = 18;
            this.lblShortLoanDeduction.Text = "Deduct S.T.Loan";
            // 
            // txtShortLoanDeduction
            // 
            this.txtShortLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortLoanDeduction.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtShortLoanDeduction.Location = new System.Drawing.Point(655, 260);
            this.txtShortLoanDeduction.Name = "txtShortLoanDeduction";
            this.txtShortLoanDeduction.Size = new System.Drawing.Size(123, 21);
            this.txtShortLoanDeduction.TabIndex = 19;
            this.txtShortLoanDeduction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtShortLoanDeduction_MouseClick);
            this.txtShortLoanDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShortLoanDeduction_KeyPress);
            // 
            // lblAdvanceLoan
            // 
            this.lblAdvanceLoan.AutoSize = true;
            this.lblAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAdvanceLoan.Location = new System.Drawing.Point(521, 290);
            this.lblAdvanceLoan.Name = "lblAdvanceLoan";
            this.lblAdvanceLoan.Size = new System.Drawing.Size(124, 13);
            this.lblAdvanceLoan.TabIndex = 20;
            this.lblAdvanceLoan.Text = "Deduct Adva.Loan";
            // 
            // txtAdvanceLoanDeduction
            // 
            this.txtAdvanceLoanDeduction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoanDeduction.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtAdvanceLoanDeduction.Location = new System.Drawing.Point(655, 284);
            this.txtAdvanceLoanDeduction.Name = "txtAdvanceLoanDeduction";
            this.txtAdvanceLoanDeduction.Size = new System.Drawing.Size(123, 21);
            this.txtAdvanceLoanDeduction.TabIndex = 21;
            this.txtAdvanceLoanDeduction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAdvanceLoanDeduction_MouseClick);
            this.txtAdvanceLoanDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvanceLoanDeduction_KeyPress);
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBalanceAmount.Location = new System.Drawing.Point(655, 367);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(123, 21);
            this.txtBalanceAmount.TabIndex = 23;
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBalanceAmount.Location = new System.Drawing.Point(521, 370);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(112, 13);
            this.lblBalanceAmount.TabIndex = 22;
            this.lblBalanceAmount.Text = "Balance Amount";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Location = new System.Drawing.Point(655, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRefresh.Location = new System.Drawing.Point(655, 480);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCalculate.Location = new System.Drawing.Point(655, 422);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 23);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtItem.Location = new System.Drawing.Point(655, 46);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(123, 21);
            this.txtItem.TabIndex = 29;
            // 
            // txtStyle
            // 
            this.txtStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtStyle.Location = new System.Drawing.Point(655, 73);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.ReadOnly = true;
            this.txtStyle.Size = new System.Drawing.Size(123, 21);
            this.txtStyle.TabIndex = 30;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtSize.Location = new System.Drawing.Point(655, 100);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(123, 21);
            this.txtSize.TabIndex = 31;
            // 
            // txtAdvanceLoanTotal
            // 
            this.txtAdvanceLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoanTotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtAdvanceLoanTotal.Location = new System.Drawing.Point(655, 153);
            this.txtAdvanceLoanTotal.Name = "txtAdvanceLoanTotal";
            this.txtAdvanceLoanTotal.ReadOnly = true;
            this.txtAdvanceLoanTotal.Size = new System.Drawing.Size(123, 21);
            this.txtAdvanceLoanTotal.TabIndex = 35;
            // 
            // lblAdvanceLoanTotal
            // 
            this.lblAdvanceLoanTotal.AutoSize = true;
            this.lblAdvanceLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoanTotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAdvanceLoanTotal.Location = new System.Drawing.Point(521, 160);
            this.lblAdvanceLoanTotal.Name = "lblAdvanceLoanTotal";
            this.lblAdvanceLoanTotal.Size = new System.Drawing.Size(102, 13);
            this.lblAdvanceLoanTotal.TabIndex = 34;
            this.lblAdvanceLoanTotal.Text = "Advance Loan ";
            // 
            // txtShortTermLoanTotal
            // 
            this.txtShortTermLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortTermLoanTotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtShortTermLoanTotal.Location = new System.Drawing.Point(655, 184);
            this.txtShortTermLoanTotal.Name = "txtShortTermLoanTotal";
            this.txtShortTermLoanTotal.ReadOnly = true;
            this.txtShortTermLoanTotal.Size = new System.Drawing.Size(123, 21);
            this.txtShortTermLoanTotal.TabIndex = 37;
            // 
            // lblShortLoanTotal
            // 
            this.lblShortLoanTotal.AutoSize = true;
            this.lblShortLoanTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortLoanTotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblShortLoanTotal.Location = new System.Drawing.Point(521, 187);
            this.lblShortLoanTotal.Name = "lblShortLoanTotal";
            this.lblShortLoanTotal.Size = new System.Drawing.Size(115, 13);
            this.lblShortLoanTotal.TabIndex = 36;
            this.lblShortLoanTotal.Text = "Short Term Loan";
            // 
            // txtBalanceAdvance
            // 
            this.txtBalanceAdvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAdvance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBalanceAdvance.Location = new System.Drawing.Point(655, 313);
            this.txtBalanceAdvance.Name = "txtBalanceAdvance";
            this.txtBalanceAdvance.ReadOnly = true;
            this.txtBalanceAdvance.Size = new System.Drawing.Size(123, 21);
            this.txtBalanceAdvance.TabIndex = 39;
            // 
            // lblBalanceAdvance
            // 
            this.lblBalanceAdvance.AutoSize = true;
            this.lblBalanceAdvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAdvance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBalanceAdvance.Location = new System.Drawing.Point(521, 318);
            this.lblBalanceAdvance.Name = "lblBalanceAdvance";
            this.lblBalanceAdvance.Size = new System.Drawing.Size(122, 13);
            this.lblBalanceAdvance.TabIndex = 38;
            this.lblBalanceAdvance.Text = "Balance Adv.Loan";
            // 
            // txtBalanceShortLoan
            // 
            this.txtBalanceShortLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceShortLoan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBalanceShortLoan.Location = new System.Drawing.Point(655, 340);
            this.txtBalanceShortLoan.Name = "txtBalanceShortLoan";
            this.txtBalanceShortLoan.ReadOnly = true;
            this.txtBalanceShortLoan.Size = new System.Drawing.Size(123, 21);
            this.txtBalanceShortLoan.TabIndex = 41;
            // 
            // lblBalanceShort
            // 
            this.lblBalanceShort.AutoSize = true;
            this.lblBalanceShort.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceShort.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBalanceShort.Location = new System.Drawing.Point(521, 343);
            this.lblBalanceShort.Name = "lblBalanceShort";
            this.lblBalanceShort.Size = new System.Drawing.Size(117, 13);
            this.lblBalanceShort.TabIndex = 40;
            this.lblBalanceShort.Text = "Balance S.T.Loan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecord);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(3, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(504, 302);
            this.groupBox1.TabIndex = 42;
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
            this.Item,
            this.Style,
            this.Size,
            this.Quantity,
            this.Rate,
            this.TotalAmount,
            this.ShortLoan,
            this.AdvanceLoan,
            this.DeductShortLoan,
            this.DeductAdvanceLoan,
            this.BalanceShortLoan,
            this.BalanceAdvanceLoan,
            this.BalanceAmount,
            this.Date});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRecord.Location = new System.Drawing.Point(4, 14);
            this.dgvRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(496, 285);
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
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // ShortLoan
            // 
            this.ShortLoan.DataPropertyName = "ShortLoan";
            this.ShortLoan.HeaderText = "ShortLoan";
            this.ShortLoan.Name = "ShortLoan";
            this.ShortLoan.ReadOnly = true;
            // 
            // AdvanceLoan
            // 
            this.AdvanceLoan.DataPropertyName = "AdvanceLoan";
            this.AdvanceLoan.HeaderText = "AdvanceLoan";
            this.AdvanceLoan.Name = "AdvanceLoan";
            this.AdvanceLoan.ReadOnly = true;
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
            // BalanceShortLoan
            // 
            this.BalanceShortLoan.DataPropertyName = "BalanceShortLoan";
            this.BalanceShortLoan.HeaderText = "BalanceShortLoan";
            this.BalanceShortLoan.Name = "BalanceShortLoan";
            this.BalanceShortLoan.ReadOnly = true;
            // 
            // BalanceAdvanceLoan
            // 
            this.BalanceAdvanceLoan.DataPropertyName = "BalanceAdvanceLoan";
            this.BalanceAdvanceLoan.HeaderText = "BalanceAdvanceLoan";
            this.BalanceAdvanceLoan.Name = "BalanceAdvanceLoan";
            this.BalanceAdvanceLoan.ReadOnly = true;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.DataPropertyName = "BalanceAmount";
            this.BalanceAmount.HeaderText = "BalanceAmount";
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(514, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCasterPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBalanceShortLoan);
            this.Controls.Add(this.lblBalanceShort);
            this.Controls.Add(this.txtBalanceAdvance);
            this.Controls.Add(this.lblBalanceAdvance);
            this.Controls.Add(this.txtShortTermLoanTotal);
            this.Controls.Add(this.lblShortLoanTotal);
            this.Controls.Add(this.txtAdvanceLoanTotal);
            this.Controls.Add(this.lblAdvanceLoanTotal);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBalanceAmount);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.lblAdvanceLoan);
            this.Controls.Add(this.txtAdvanceLoanDeduction);
            this.Controls.Add(this.lblShortLoanDeduction);
            this.Controls.Add(this.txtShortLoanDeduction);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSize_slipFromItem);
            this.Controls.Add(this.lblStyle_slipFromItem);
            this.Controls.Add(this.lblItem_slipFromItem);
            this.Controls.Add(this.gbxPerson);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmCasterPayment";
            this.Text = "Caster Payment";
            this.Load += new System.EventHandler(this.frmCasterPayment_Load);
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
        private System.Windows.Forms.Label lblSize_slipFromItem;
        private System.Windows.Forms.Label lblStyle_slipFromItem;
        private System.Windows.Forms.Label lblItem_slipFromItem;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblShortLoanDeduction;
        private System.Windows.Forms.TextBox txtShortLoanDeduction;
        private System.Windows.Forms.Label lblAdvanceLoan;
        private System.Windows.Forms.TextBox txtAdvanceLoanDeduction;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtAdvanceLoanTotal;
        private System.Windows.Forms.Label lblAdvanceLoanTotal;
        private System.Windows.Forms.TextBox txtShortTermLoanTotal;
        private System.Windows.Forms.Label lblShortLoanTotal;
        private System.Windows.Forms.TextBox txtBalanceAdvance;
        private System.Windows.Forms.Label lblBalanceAdvance;
        private System.Windows.Forms.TextBox txtBalanceShortLoan;
        private System.Windows.Forms.Label lblBalanceShort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvanceLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeductShortLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeductAdvanceLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceShortLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAdvanceLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnDelete;
    }
}