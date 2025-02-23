namespace MasterCeramicsERP
{
    partial class frmUpdateCasterReport
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
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.btnprintReport = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.dtpAttendence = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(435, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbtnYear.Location = new System.Drawing.Point(435, 101);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 5;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // btnprintReport
            // 
            this.btnprintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintReport.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnprintReport.Location = new System.Drawing.Point(672, 83);
            this.btnprintReport.Name = "btnprintReport";
            this.btnprintReport.Size = new System.Drawing.Size(100, 23);
            this.btnprintReport.TabIndex = 8;
            this.btnprintReport.Text = "Print Report";
            this.btnprintReport.UseVisualStyleBackColor = true;
            this.btnprintReport.Click += new System.EventHandler(this.btnprintReport_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShow.Location = new System.Drawing.Point(672, 54);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbtnMonth.Location = new System.Drawing.Point(434, 78);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 4;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbtnDay.Location = new System.Drawing.Point(435, 55);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 3;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // dtpAttendence
            // 
            this.dtpAttendence.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendence.Location = new System.Drawing.Point(435, 28);
            this.dtpAttendence.Name = "dtpAttendence";
            this.dtpAttendence.Size = new System.Drawing.Size(337, 21);
            this.dtpAttendence.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPerson);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(423, 196);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker";
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
            this.dgvPerson.Size = new System.Drawing.Size(415, 176);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRecord);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(8, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(764, 302);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
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
            this.dgvRecord.Size = new System.Drawing.Size(756, 285);
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
            // frmUpdateCasterReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.btnprintReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.dtpAttendence);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmUpdateCasterReport";
            this.Text = "View & Delete Caster Payment Report";
            this.Load += new System.EventHandler(this.frmUpdateCasterReport_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.Button btnprintReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.DateTimePicker dtpAttendence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;

    }
}