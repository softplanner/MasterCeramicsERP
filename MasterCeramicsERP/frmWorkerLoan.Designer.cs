namespace MasterCeramicsERP
{
    partial class frmWorkerLoan
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
            this.lblShortTermLoan = new System.Windows.Forms.Label();
            this.lblAdvanceLoan = new System.Windows.Forms.Label();
            this.txtShortTermLoan = new System.Windows.Forms.TextBox();
            this.txtAdvanceLoan = new System.Windows.Forms.TextBox();
            this.btnAddShortLoan = new System.Windows.Forms.Button();
            this.btnAddAdvanceLoan = new System.Windows.Forms.Button();
            this.btnDeductShortTermLoan = new System.Windows.Forms.Button();
            this.btnDeductAdvanceLoan = new System.Windows.Forms.Button();
            this.txtUpdatedAmount = new System.Windows.Forms.TextBox();
            this.lblUpdateAmount = new System.Windows.Forms.Label();
            this.rbtnDailyWager = new System.Windows.Forms.RadioButton();
            this.rbtnOtherWorker = new System.Windows.Forms.RadioButton();
            this.lblWorkerType = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dtpLoan = new System.Windows.Forms.DateTimePicker();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxPerson.Location = new System.Drawing.Point(6, 6);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(561, 505);
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
            this.dgvPerson.Size = new System.Drawing.Size(553, 485);
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
            this.Worker.Width = 500;
            // 
            // lblShortTermLoan
            // 
            this.lblShortTermLoan.AutoSize = true;
            this.lblShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortTermLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShortTermLoan.Location = new System.Drawing.Point(575, 72);
            this.lblShortTermLoan.Name = "lblShortTermLoan";
            this.lblShortTermLoan.Size = new System.Drawing.Size(119, 13);
            this.lblShortTermLoan.TabIndex = 3;
            this.lblShortTermLoan.Text = "Short Term Loan ";
            // 
            // lblAdvanceLoan
            // 
            this.lblAdvanceLoan.AutoSize = true;
            this.lblAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdvanceLoan.Location = new System.Drawing.Point(575, 23);
            this.lblAdvanceLoan.Name = "lblAdvanceLoan";
            this.lblAdvanceLoan.Size = new System.Drawing.Size(102, 13);
            this.lblAdvanceLoan.TabIndex = 1;
            this.lblAdvanceLoan.Text = "Advance Loan ";
            // 
            // txtShortTermLoan
            // 
            this.txtShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortTermLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtShortTermLoan.Location = new System.Drawing.Point(575, 88);
            this.txtShortTermLoan.Name = "txtShortTermLoan";
            this.txtShortTermLoan.ReadOnly = true;
            this.txtShortTermLoan.Size = new System.Drawing.Size(157, 21);
            this.txtShortTermLoan.TabIndex = 4;
            // 
            // txtAdvanceLoan
            // 
            this.txtAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAdvanceLoan.Location = new System.Drawing.Point(575, 48);
            this.txtAdvanceLoan.Name = "txtAdvanceLoan";
            this.txtAdvanceLoan.ReadOnly = true;
            this.txtAdvanceLoan.Size = new System.Drawing.Size(157, 21);
            this.txtAdvanceLoan.TabIndex = 2;
            // 
            // btnAddShortLoan
            // 
            this.btnAddShortLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShortLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddShortLoan.Location = new System.Drawing.Point(578, 227);
            this.btnAddShortLoan.Name = "btnAddShortLoan";
            this.btnAddShortLoan.Size = new System.Drawing.Size(157, 23);
            this.btnAddShortLoan.TabIndex = 7;
            this.btnAddShortLoan.Text = "Add Short Term Loan";
            this.btnAddShortLoan.UseVisualStyleBackColor = true;
            this.btnAddShortLoan.Click += new System.EventHandler(this.btnAddShortLoan_Click);
            // 
            // btnAddAdvanceLoan
            // 
            this.btnAddAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdvanceLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAdvanceLoan.Location = new System.Drawing.Point(578, 285);
            this.btnAddAdvanceLoan.Name = "btnAddAdvanceLoan";
            this.btnAddAdvanceLoan.Size = new System.Drawing.Size(157, 23);
            this.btnAddAdvanceLoan.TabIndex = 9;
            this.btnAddAdvanceLoan.Text = "Add Advance Loan";
            this.btnAddAdvanceLoan.UseVisualStyleBackColor = true;
            this.btnAddAdvanceLoan.Click += new System.EventHandler(this.btnAddAdvanceLoan_Click);
            // 
            // btnDeductShortTermLoan
            // 
            this.btnDeductShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductShortTermLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeductShortTermLoan.Location = new System.Drawing.Point(578, 256);
            this.btnDeductShortTermLoan.Name = "btnDeductShortTermLoan";
            this.btnDeductShortTermLoan.Size = new System.Drawing.Size(157, 23);
            this.btnDeductShortTermLoan.TabIndex = 8;
            this.btnDeductShortTermLoan.Text = "Deduct Short Term Loan";
            this.btnDeductShortTermLoan.UseVisualStyleBackColor = true;
            this.btnDeductShortTermLoan.Click += new System.EventHandler(this.btnDeductShortTermLoan_Click);
            // 
            // btnDeductAdvanceLoan
            // 
            this.btnDeductAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductAdvanceLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeductAdvanceLoan.Location = new System.Drawing.Point(578, 314);
            this.btnDeductAdvanceLoan.Name = "btnDeductAdvanceLoan";
            this.btnDeductAdvanceLoan.Size = new System.Drawing.Size(157, 23);
            this.btnDeductAdvanceLoan.TabIndex = 10;
            this.btnDeductAdvanceLoan.Text = "Deduct Advance Loan";
            this.btnDeductAdvanceLoan.UseVisualStyleBackColor = true;
            this.btnDeductAdvanceLoan.Click += new System.EventHandler(this.btnDeductAdvanceLoan_Click);
            // 
            // txtUpdatedAmount
            // 
            this.txtUpdatedAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatedAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUpdatedAmount.Location = new System.Drawing.Point(575, 137);
            this.txtUpdatedAmount.Name = "txtUpdatedAmount";
            this.txtUpdatedAmount.Size = new System.Drawing.Size(157, 21);
            this.txtUpdatedAmount.TabIndex = 6;
            this.txtUpdatedAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdatedAmount_MouseClick);
            this.txtUpdatedAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdatedAmount_KeyPress);
            // 
            // lblUpdateAmount
            // 
            this.lblUpdateAmount.AutoSize = true;
            this.lblUpdateAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUpdateAmount.Location = new System.Drawing.Point(575, 121);
            this.lblUpdateAmount.Name = "lblUpdateAmount";
            this.lblUpdateAmount.Size = new System.Drawing.Size(96, 13);
            this.lblUpdateAmount.TabIndex = 5;
            this.lblUpdateAmount.Text = "Enter Amount";
            // 
            // rbtnDailyWager
            // 
            this.rbtnDailyWager.AutoSize = true;
            this.rbtnDailyWager.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDailyWager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnDailyWager.Location = new System.Drawing.Point(578, 377);
            this.rbtnDailyWager.Name = "rbtnDailyWager";
            this.rbtnDailyWager.Size = new System.Drawing.Size(157, 17);
            this.rbtnDailyWager.TabIndex = 12;
            this.rbtnDailyWager.TabStop = true;
            this.rbtnDailyWager.Text = "Daily Wages Worker";
            this.rbtnDailyWager.UseVisualStyleBackColor = true;
            this.rbtnDailyWager.CheckedChanged += new System.EventHandler(this.rbtnDailyWager_CheckedChanged);
            // 
            // rbtnOtherWorker
            // 
            this.rbtnOtherWorker.AutoSize = true;
            this.rbtnOtherWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOtherWorker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnOtherWorker.Location = new System.Drawing.Point(578, 400);
            this.rbtnOtherWorker.Name = "rbtnOtherWorker";
            this.rbtnOtherWorker.Size = new System.Drawing.Size(61, 17);
            this.rbtnOtherWorker.TabIndex = 13;
            this.rbtnOtherWorker.TabStop = true;
            this.rbtnOtherWorker.Text = "Other";
            this.rbtnOtherWorker.UseVisualStyleBackColor = true;
            this.rbtnOtherWorker.CheckedChanged += new System.EventHandler(this.rbtnOtherWorker_CheckedChanged);
            // 
            // lblWorkerType
            // 
            this.lblWorkerType.AutoSize = true;
            this.lblWorkerType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWorkerType.Location = new System.Drawing.Point(578, 352);
            this.lblWorkerType.Name = "lblWorkerType";
            this.lblWorkerType.Size = new System.Drawing.Size(103, 13);
            this.lblWorkerType.TabIndex = 11;
            this.lblWorkerType.Text = "Worker Type ::";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Verdana", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectDate.Location = new System.Drawing.Point(574, 170);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(150, 12);
            this.lblSelectDate.TabIndex = 14;
            this.lblSelectDate.Text = "Select Date For Manage Loan";
            // 
            // dtpLoan
            // 
            this.dtpLoan.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoan.Location = new System.Drawing.Point(570, 192);
            this.dtpLoan.Name = "dtpLoan";
            this.dtpLoan.Size = new System.Drawing.Size(212, 21);
            this.dtpLoan.TabIndex = 15;
            // 
            // frmWorkerLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.dtpLoan);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblWorkerType);
            this.Controls.Add(this.rbtnOtherWorker);
            this.Controls.Add(this.rbtnDailyWager);
            this.Controls.Add(this.lblUpdateAmount);
            this.Controls.Add(this.txtUpdatedAmount);
            this.Controls.Add(this.btnDeductAdvanceLoan);
            this.Controls.Add(this.btnDeductShortTermLoan);
            this.Controls.Add(this.btnAddAdvanceLoan);
            this.Controls.Add(this.btnAddShortLoan);
            this.Controls.Add(this.txtAdvanceLoan);
            this.Controls.Add(this.txtShortTermLoan);
            this.Controls.Add(this.lblAdvanceLoan);
            this.Controls.Add(this.lblShortTermLoan);
            this.Controls.Add(this.gbxPerson);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmWorkerLoan";
            this.Text = "Manage Worker Loan ";
            this.Load += new System.EventHandler(this.frmWorkerLoan_Load);
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label lblShortTermLoan;
        private System.Windows.Forms.Label lblAdvanceLoan;
        private System.Windows.Forms.TextBox txtShortTermLoan;
        private System.Windows.Forms.TextBox txtAdvanceLoan;
        private System.Windows.Forms.Button btnAddShortLoan;
        private System.Windows.Forms.Button btnAddAdvanceLoan;
        private System.Windows.Forms.Button btnDeductShortTermLoan;
        private System.Windows.Forms.Button btnDeductAdvanceLoan;
        private System.Windows.Forms.TextBox txtUpdatedAmount;
        private System.Windows.Forms.Label lblUpdateAmount;
        private System.Windows.Forms.RadioButton rbtnDailyWager;
        private System.Windows.Forms.RadioButton rbtnOtherWorker;
        private System.Windows.Forms.Label lblWorkerType;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker dtpLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
    }
}