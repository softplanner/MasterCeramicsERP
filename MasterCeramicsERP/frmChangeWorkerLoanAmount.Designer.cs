namespace MasterCeramicsERP
{
    partial class frmChangeWorkerLoanAmount
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdvanceLoan = new System.Windows.Forms.TextBox();
            this.txtShortTermLoan = new System.Windows.Forms.TextBox();
            this.lblAdvanceLoan = new System.Windows.Forms.Label();
            this.lblShortTermLoan = new System.Windows.Forms.Label();
            this.lblUpdateAmount = new System.Windows.Forms.Label();
            this.txtUpdatedAmount = new System.Windows.Forms.TextBox();
            this.rbtnShortLoan = new System.Windows.Forms.RadioButton();
            this.rbtnAdvanceLoan = new System.Windows.Forms.RadioButton();
            this.lblSelectAmountType = new System.Windows.Forms.Label();
            this.btnUpdateLoan = new System.Windows.Forms.Button();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.Color.Black;
            this.gbxPerson.Location = new System.Drawing.Point(6, 7);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(558, 506);
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
            this.id,
            this.name});
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.GridColor = System.Drawing.Color.Black;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(550, 486);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 440;
            // 
            // txtAdvanceLoan
            // 
            this.txtAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvanceLoan.ForeColor = System.Drawing.Color.Black;
            this.txtAdvanceLoan.Location = new System.Drawing.Point(574, 118);
            this.txtAdvanceLoan.Name = "txtAdvanceLoan";
            this.txtAdvanceLoan.ReadOnly = true;
            this.txtAdvanceLoan.Size = new System.Drawing.Size(154, 21);
            this.txtAdvanceLoan.TabIndex = 4;
            // 
            // txtShortTermLoan
            // 
            this.txtShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortTermLoan.ForeColor = System.Drawing.Color.Black;
            this.txtShortTermLoan.Location = new System.Drawing.Point(574, 70);
            this.txtShortTermLoan.Name = "txtShortTermLoan";
            this.txtShortTermLoan.ReadOnly = true;
            this.txtShortTermLoan.Size = new System.Drawing.Size(154, 21);
            this.txtShortTermLoan.TabIndex = 2;
            // 
            // lblAdvanceLoan
            // 
            this.lblAdvanceLoan.AutoSize = true;
            this.lblAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceLoan.ForeColor = System.Drawing.Color.Black;
            this.lblAdvanceLoan.Location = new System.Drawing.Point(571, 93);
            this.lblAdvanceLoan.Name = "lblAdvanceLoan";
            this.lblAdvanceLoan.Size = new System.Drawing.Size(152, 13);
            this.lblAdvanceLoan.TabIndex = 3;
            this.lblAdvanceLoan.Text = "Advance Loan Amount";
            // 
            // lblShortTermLoan
            // 
            this.lblShortTermLoan.AutoSize = true;
            this.lblShortTermLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortTermLoan.ForeColor = System.Drawing.Color.Black;
            this.lblShortTermLoan.Location = new System.Drawing.Point(571, 43);
            this.lblShortTermLoan.Name = "lblShortTermLoan";
            this.lblShortTermLoan.Size = new System.Drawing.Size(169, 13);
            this.lblShortTermLoan.TabIndex = 1;
            this.lblShortTermLoan.Text = "Short Term Loan Amount";
            // 
            // lblUpdateAmount
            // 
            this.lblUpdateAmount.AutoSize = true;
            this.lblUpdateAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAmount.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateAmount.Location = new System.Drawing.Point(573, 153);
            this.lblUpdateAmount.Name = "lblUpdateAmount";
            this.lblUpdateAmount.Size = new System.Drawing.Size(96, 13);
            this.lblUpdateAmount.TabIndex = 5;
            this.lblUpdateAmount.Text = "Enter Amount";
            // 
            // txtUpdatedAmount
            // 
            this.txtUpdatedAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatedAmount.ForeColor = System.Drawing.Color.Black;
            this.txtUpdatedAmount.Location = new System.Drawing.Point(574, 179);
            this.txtUpdatedAmount.Name = "txtUpdatedAmount";
            this.txtUpdatedAmount.Size = new System.Drawing.Size(154, 21);
            this.txtUpdatedAmount.TabIndex = 6;
            this.txtUpdatedAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdatedAmount_MouseClick);
            this.txtUpdatedAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdatedAmount_KeyPress);
            // 
            // rbtnShortLoan
            // 
            this.rbtnShortLoan.AutoSize = true;
            this.rbtnShortLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnShortLoan.ForeColor = System.Drawing.Color.Black;
            this.rbtnShortLoan.Location = new System.Drawing.Point(576, 261);
            this.rbtnShortLoan.Name = "rbtnShortLoan";
            this.rbtnShortLoan.Size = new System.Drawing.Size(133, 17);
            this.rbtnShortLoan.TabIndex = 8;
            this.rbtnShortLoan.TabStop = true;
            this.rbtnShortLoan.Text = "Short Term Loan";
            this.rbtnShortLoan.UseVisualStyleBackColor = true;
            // 
            // rbtnAdvanceLoan
            // 
            this.rbtnAdvanceLoan.AutoSize = true;
            this.rbtnAdvanceLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdvanceLoan.ForeColor = System.Drawing.Color.Black;
            this.rbtnAdvanceLoan.Location = new System.Drawing.Point(576, 284);
            this.rbtnAdvanceLoan.Name = "rbtnAdvanceLoan";
            this.rbtnAdvanceLoan.Size = new System.Drawing.Size(116, 17);
            this.rbtnAdvanceLoan.TabIndex = 9;
            this.rbtnAdvanceLoan.TabStop = true;
            this.rbtnAdvanceLoan.Text = "Advance Loan";
            this.rbtnAdvanceLoan.UseVisualStyleBackColor = true;
            // 
            // lblSelectAmountType
            // 
            this.lblSelectAmountType.AutoSize = true;
            this.lblSelectAmountType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAmountType.ForeColor = System.Drawing.Color.Black;
            this.lblSelectAmountType.Location = new System.Drawing.Point(573, 236);
            this.lblSelectAmountType.Name = "lblSelectAmountType";
            this.lblSelectAmountType.Size = new System.Drawing.Size(137, 13);
            this.lblSelectAmountType.TabIndex = 7;
            this.lblSelectAmountType.Text = "Select Amount Type";
            // 
            // btnUpdateLoan
            // 
            this.btnUpdateLoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLoan.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateLoan.Location = new System.Drawing.Point(574, 323);
            this.btnUpdateLoan.Name = "btnUpdateLoan";
            this.btnUpdateLoan.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateLoan.TabIndex = 10;
            this.btnUpdateLoan.Text = "Update Loan Amount";
            this.btnUpdateLoan.UseVisualStyleBackColor = true;
            this.btnUpdateLoan.Click += new System.EventHandler(this.btnUpdateLoan_Click);
            // 
            // frmChangeWorkerLoanAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnUpdateLoan);
            this.Controls.Add(this.lblSelectAmountType);
            this.Controls.Add(this.rbtnAdvanceLoan);
            this.Controls.Add(this.rbtnShortLoan);
            this.Controls.Add(this.lblUpdateAmount);
            this.Controls.Add(this.txtUpdatedAmount);
            this.Controls.Add(this.txtAdvanceLoan);
            this.Controls.Add(this.gbxPerson);
            this.Controls.Add(this.txtShortTermLoan);
            this.Controls.Add(this.lblShortTermLoan);
            this.Controls.Add(this.lblAdvanceLoan);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmChangeWorkerLoanAmount";
            this.Text = "Change Worker Loan Amount";
            this.Load += new System.EventHandler(this.frmChangeWorkerLoanAmount_Load);
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.TextBox txtAdvanceLoan;
        private System.Windows.Forms.TextBox txtShortTermLoan;
        private System.Windows.Forms.Label lblAdvanceLoan;
        private System.Windows.Forms.Label lblShortTermLoan;
        private System.Windows.Forms.Label lblUpdateAmount;
        private System.Windows.Forms.TextBox txtUpdatedAmount;
        private System.Windows.Forms.RadioButton rbtnShortLoan;
        private System.Windows.Forms.RadioButton rbtnAdvanceLoan;
        private System.Windows.Forms.Label lblSelectAmountType;
        private System.Windows.Forms.Button btnUpdateLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}