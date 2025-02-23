namespace MasterCeramicsERP
{
    partial class frmMoldReceiveRecordShow
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
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpMold = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbxMoldReceiveRecord = new System.Windows.Forms.GroupBox();
            this.dgvMold = new System.Windows.Forms.DataGridView();
            this.CasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakageCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxMoldReceiveRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.Navy;
            this.rbtnMonth.Location = new System.Drawing.Point(151, 39);
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
            this.rbtnDay.ForeColor = System.Drawing.Color.Navy;
            this.rbtnDay.Location = new System.Drawing.Point(15, 39);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 3;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Navy;
            this.btnShow.Location = new System.Drawing.Point(495, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpMold
            // 
            this.dtpMold.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMold.Location = new System.Drawing.Point(15, 12);
            this.dtpMold.Name = "dtpMold";
            this.dtpMold.Size = new System.Drawing.Size(200, 21);
            this.dtpMold.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.Location = new System.Drawing.Point(635, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gbxMoldReceiveRecord
            // 
            this.gbxMoldReceiveRecord.Controls.Add(this.dgvMold);
            this.gbxMoldReceiveRecord.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldReceiveRecord.ForeColor = System.Drawing.Color.Navy;
            this.gbxMoldReceiveRecord.Location = new System.Drawing.Point(12, 65);
            this.gbxMoldReceiveRecord.Name = "gbxMoldReceiveRecord";
            this.gbxMoldReceiveRecord.Size = new System.Drawing.Size(760, 440);
            this.gbxMoldReceiveRecord.TabIndex = 15;
            this.gbxMoldReceiveRecord.TabStop = false;
            // 
            // dgvMold
            // 
            this.dgvMold.AllowUserToAddRows = false;
            this.dgvMold.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CasterID,
            this.Caster,
            this.Item,
            this.Style,
            this.Size,
            this.DateReceived,
            this.QuantityReceived,
            this.QuantityIssued,
            this.DateExpiry,
            this.Breakage,
            this.BreakageCause,
            this.Balance});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMold.GridColor = System.Drawing.Color.Navy;
            this.dgvMold.Location = new System.Drawing.Point(3, 14);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.Size = new System.Drawing.Size(754, 423);
            this.dgvMold.TabIndex = 0;
            this.dgvMold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMold_CellClick);
            // 
            // CasterID
            // 
            this.CasterID.DataPropertyName = "CasterID";
            this.CasterID.HeaderText = "CasterID";
            this.CasterID.Name = "CasterID";
            this.CasterID.ReadOnly = true;
            // 
            // Caster
            // 
            this.Caster.DataPropertyName = "Caster";
            this.Caster.HeaderText = "Caster";
            this.Caster.Name = "Caster";
            this.Caster.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Mold Name";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Mold Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Mold Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // DateReceived
            // 
            this.DateReceived.DataPropertyName = "DateReceived";
            this.DateReceived.HeaderText = "Received Date";
            this.DateReceived.Name = "DateReceived";
            this.DateReceived.ReadOnly = true;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.DataPropertyName = "QuantityReceived";
            this.QuantityReceived.HeaderText = "QuantityReceived";
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
            // 
            // QuantityIssued
            // 
            this.QuantityIssued.DataPropertyName = "QuantityIssued";
            this.QuantityIssued.HeaderText = "QuantityIssued";
            this.QuantityIssued.Name = "QuantityIssued";
            this.QuantityIssued.ReadOnly = true;
            // 
            // DateExpiry
            // 
            this.DateExpiry.DataPropertyName = "DateExpiry";
            this.DateExpiry.HeaderText = "Expiry Date";
            this.DateExpiry.Name = "DateExpiry";
            this.DateExpiry.ReadOnly = true;
            // 
            // Breakage
            // 
            this.Breakage.DataPropertyName = "Breakage";
            this.Breakage.HeaderText = "Breakage";
            this.Breakage.Name = "Breakage";
            this.Breakage.ReadOnly = true;
            // 
            // BreakageCause
            // 
            this.BreakageCause.DataPropertyName = "BreakageCause";
            this.BreakageCause.HeaderText = "BreakageCause";
            this.BreakageCause.Name = "BreakageCause";
            this.BreakageCause.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // frmMoldReceiveRecordShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxMoldReceiveRecord);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpMold);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMoldReceiveRecordShow";
            this.Text = "Update Mold Received Report";
            this.Load += new System.EventHandler(this.frmMoldReceiveRecordShow_Load);
            this.gbxMoldReceiveRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpMold;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbxMoldReceiveRecord;
        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakageCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}