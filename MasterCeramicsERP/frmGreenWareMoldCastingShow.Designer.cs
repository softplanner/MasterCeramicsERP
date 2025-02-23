namespace MasterCeramicsERP
{
    partial class frmGreenWareMoldCastingShow
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
            this.dtpGlazeHouse = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxGreenwareMoldcasting = new System.Windows.Forms.GroupBox();
            this.dgvMold = new System.Windows.Forms.DataGridView();
            this.btnprintReport = new System.Windows.Forms.Button();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.chkbxShowByCaster = new System.Windows.Forms.CheckBox();
            this.chkbxReturnSlip = new System.Windows.Forms.CheckBox();
            this.CasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouldQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouldCasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DryBreakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rejected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGreenwareMoldcasting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnMonth.Location = new System.Drawing.Point(12, 73);
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
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnDay.Location = new System.Drawing.Point(12, 45);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 3;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // dtpGlazeHouse
            // 
            this.dtpGlazeHouse.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpGlazeHouse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGlazeHouse.Location = new System.Drawing.Point(11, 7);
            this.dtpGlazeHouse.Name = "dtpGlazeHouse";
            this.dtpGlazeHouse.Size = new System.Drawing.Size(286, 21);
            this.dtpGlazeHouse.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnShow.Location = new System.Drawing.Point(82, 42);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(713, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxGreenwareMoldcasting
            // 
            this.gbxGreenwareMoldcasting.Controls.Add(this.dgvMold);
            this.gbxGreenwareMoldcasting.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGreenwareMoldcasting.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxGreenwareMoldcasting.Location = new System.Drawing.Point(0, 101);
            this.gbxGreenwareMoldcasting.Name = "gbxGreenwareMoldcasting";
            this.gbxGreenwareMoldcasting.Size = new System.Drawing.Size(777, 404);
            this.gbxGreenwareMoldcasting.TabIndex = 8;
            this.gbxGreenwareMoldcasting.TabStop = false;
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
            this.ItemID,
            this.StyleID,
            this.SizeID,
            this.Caster,
            this.item,
            this.style,
            this.size,
            this.MouldQuantity,
            this.MouldCasting,
            this.BalanceBF,
            this.Total,
            this.Breakage,
            this.DryBreakage,
            this.Rejected,
            this.Checked,
            this.BalanceItems,
            this.Remarks});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMold.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvMold.Location = new System.Drawing.Point(3, 14);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.Size = new System.Drawing.Size(771, 387);
            this.dgvMold.TabIndex = 1;
            this.dgvMold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMold_CellClick);
            // 
            // btnprintReport
            // 
            this.btnprintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintReport.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnprintReport.Location = new System.Drawing.Point(82, 67);
            this.btnprintReport.Name = "btnprintReport";
            this.btnprintReport.Size = new System.Drawing.Size(96, 23);
            this.btnprintReport.TabIndex = 6;
            this.btnprintReport.Text = "Print Report";
            this.btnprintReport.UseVisualStyleBackColor = true;
            this.btnprintReport.Click += new System.EventHandler(this.btnprintReport_Click);
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectJob.Location = new System.Drawing.Point(184, 47);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 18;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(263, 41);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(171, 21);
            this.cbxSelectJob.TabIndex = 19;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(263, 67);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(171, 21);
            this.cbxWorker.TabIndex = 17;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWorker.Location = new System.Drawing.Point(184, 72);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 16;
            this.lblWorker.Text = "Caster";
            // 
            // chkbxShowByCaster
            // 
            this.chkbxShowByCaster.AutoSize = true;
            this.chkbxShowByCaster.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxShowByCaster.Location = new System.Drawing.Point(308, 11);
            this.chkbxShowByCaster.Name = "chkbxShowByCaster";
            this.chkbxShowByCaster.Size = new System.Drawing.Size(126, 17);
            this.chkbxShowByCaster.TabIndex = 22;
            this.chkbxShowByCaster.Text = "Show By Caster";
            this.chkbxShowByCaster.UseVisualStyleBackColor = true;
            // 
            // chkbxReturnSlip
            // 
            this.chkbxReturnSlip.AutoSize = true;
            this.chkbxReturnSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxReturnSlip.ForeColor = System.Drawing.Color.Red;
            this.chkbxReturnSlip.Location = new System.Drawing.Point(620, 71);
            this.chkbxReturnSlip.Name = "chkbxReturnSlip";
            this.chkbxReturnSlip.Size = new System.Drawing.Size(157, 17);
            this.chkbxReturnSlip.TabIndex = 23;
            this.chkbxReturnSlip.Text = "Return Slip To Stock";
            this.chkbxReturnSlip.UseVisualStyleBackColor = true;
            // 
            // CasterID
            // 
            this.CasterID.DataPropertyName = "CasterID";
            this.CasterID.HeaderText = "CasterID";
            this.CasterID.Name = "CasterID";
            this.CasterID.ReadOnly = true;
            this.CasterID.Visible = false;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // StyleID
            // 
            this.StyleID.DataPropertyName = "StyleID";
            this.StyleID.HeaderText = "StyleID";
            this.StyleID.Name = "StyleID";
            this.StyleID.ReadOnly = true;
            this.StyleID.Visible = false;
            // 
            // SizeID
            // 
            this.SizeID.DataPropertyName = "SizeID";
            this.SizeID.HeaderText = "SizeID";
            this.SizeID.Name = "SizeID";
            this.SizeID.ReadOnly = true;
            this.SizeID.Visible = false;
            // 
            // Caster
            // 
            this.Caster.DataPropertyName = "Caster";
            this.Caster.HeaderText = "Caster";
            this.Caster.Name = "Caster";
            this.Caster.ReadOnly = true;
            // 
            // item
            // 
            this.item.DataPropertyName = "Item";
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // style
            // 
            this.style.DataPropertyName = "Style";
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            // 
            // size
            // 
            this.size.DataPropertyName = "Size";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // MouldQuantity
            // 
            this.MouldQuantity.DataPropertyName = "MoldStockQuantity";
            this.MouldQuantity.HeaderText = "Mould Quantity";
            this.MouldQuantity.Name = "MouldQuantity";
            this.MouldQuantity.ReadOnly = true;
            // 
            // MouldCasting
            // 
            this.MouldCasting.DataPropertyName = "MoldCastQuantity";
            this.MouldCasting.HeaderText = "Mould Casting";
            this.MouldCasting.Name = "MouldCasting";
            this.MouldCasting.ReadOnly = true;
            // 
            // BalanceBF
            // 
            this.BalanceBF.DataPropertyName = "BalanceBF";
            this.BalanceBF.HeaderText = "BalanceB.F";
            this.BalanceBF.Name = "BalanceBF";
            this.BalanceBF.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Breakage
            // 
            this.Breakage.DataPropertyName = "Breakage";
            this.Breakage.HeaderText = "Breakage";
            this.Breakage.Name = "Breakage";
            this.Breakage.ReadOnly = true;
            // 
            // DryBreakage
            // 
            this.DryBreakage.DataPropertyName = "DryBreakage";
            this.DryBreakage.HeaderText = "Dry Breakage";
            this.DryBreakage.Name = "DryBreakage";
            this.DryBreakage.ReadOnly = true;
            // 
            // Rejected
            // 
            this.Rejected.DataPropertyName = "Rejected";
            this.Rejected.HeaderText = "Rejected";
            this.Rejected.Name = "Rejected";
            this.Rejected.ReadOnly = true;
            // 
            // Checked
            // 
            this.Checked.DataPropertyName = "Checked";
            this.Checked.HeaderText = "Checked";
            this.Checked.Name = "Checked";
            this.Checked.ReadOnly = true;
            // 
            // BalanceItems
            // 
            this.BalanceItems.DataPropertyName = "Balance";
            this.BalanceItems.HeaderText = "Balance Items";
            this.BalanceItems.Name = "BalanceItems";
            this.BalanceItems.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // frmGreenWareMoldCastingShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.chkbxReturnSlip);
            this.Controls.Add(this.chkbxShowByCaster);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.btnprintReport);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.gbxGreenwareMoldcasting);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.dtpGlazeHouse);
            this.Controls.Add(this.btnDelete);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmGreenWareMoldCastingShow";
            this.Text = "Update Mold Casting Report";
            this.Load += new System.EventHandler(this.frmGreenWareMoldCastingShow_Load);
            this.gbxGreenwareMoldcasting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.DateTimePicker dtpGlazeHouse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxGreenwareMoldcasting;
        private System.Windows.Forms.Button btnprintReport;
        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.CheckBox chkbxShowByCaster;
        private System.Windows.Forms.CheckBox chkbxReturnSlip;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caster;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouldQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouldCasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DryBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}