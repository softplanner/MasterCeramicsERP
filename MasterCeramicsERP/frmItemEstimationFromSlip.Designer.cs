namespace MasterCeramicsERP
{
    partial class frmItemEstimationFromSlip
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
            this.lblSlip_itemsFromSlip = new System.Windows.Forms.Label();
            this.txtSlip_itemsFromSlip = new System.Windows.Forms.TextBox();
            this.lblSelect_itemsFromSlip = new System.Windows.Forms.Label();
            this.cbxCategory_itemsFromSlip = new System.Windows.Forms.ComboBox();
            this.dgvEstimateItems_itemsFromSlip = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrepare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculate_itemsFromSlip = new System.Windows.Forms.Button();
            this.gbxEstimation = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateItems_itemsFromSlip)).BeginInit();
            this.gbxEstimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSlip_itemsFromSlip
            // 
            this.lblSlip_itemsFromSlip.AutoSize = true;
            this.lblSlip_itemsFromSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlip_itemsFromSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSlip_itemsFromSlip.Location = new System.Drawing.Point(6, 15);
            this.lblSlip_itemsFromSlip.Name = "lblSlip_itemsFromSlip";
            this.lblSlip_itemsFromSlip.Size = new System.Drawing.Size(70, 13);
            this.lblSlip_itemsFromSlip.TabIndex = 0;
            this.lblSlip_itemsFromSlip.Text = "Enter Slip";
            // 
            // txtSlip_itemsFromSlip
            // 
            this.txtSlip_itemsFromSlip.BackColor = System.Drawing.SystemColors.Control;
            this.txtSlip_itemsFromSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlip_itemsFromSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtSlip_itemsFromSlip.Location = new System.Drawing.Point(89, 12);
            this.txtSlip_itemsFromSlip.Name = "txtSlip_itemsFromSlip";
            this.txtSlip_itemsFromSlip.Size = new System.Drawing.Size(209, 21);
            this.txtSlip_itemsFromSlip.TabIndex = 1;
            this.txtSlip_itemsFromSlip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSlip_itemsFromSlip_MouseClick);
            this.txtSlip_itemsFromSlip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlip_itemsFromSlip_KeyPress);
            // 
            // lblSelect_itemsFromSlip
            // 
            this.lblSelect_itemsFromSlip.AutoSize = true;
            this.lblSelect_itemsFromSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect_itemsFromSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSelect_itemsFromSlip.Location = new System.Drawing.Point(9, 42);
            this.lblSelect_itemsFromSlip.Name = "lblSelect_itemsFromSlip";
            this.lblSelect_itemsFromSlip.Size = new System.Drawing.Size(61, 13);
            this.lblSelect_itemsFromSlip.TabIndex = 2;
            this.lblSelect_itemsFromSlip.Text = "Show By";
            // 
            // cbxCategory_itemsFromSlip
            // 
            this.cbxCategory_itemsFromSlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory_itemsFromSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory_itemsFromSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbxCategory_itemsFromSlip.FormattingEnabled = true;
            this.cbxCategory_itemsFromSlip.Items.AddRange(new object[] {
            "Item",
            "Style",
            "Size"});
            this.cbxCategory_itemsFromSlip.Location = new System.Drawing.Point(89, 39);
            this.cbxCategory_itemsFromSlip.Name = "cbxCategory_itemsFromSlip";
            this.cbxCategory_itemsFromSlip.Size = new System.Drawing.Size(209, 21);
            this.cbxCategory_itemsFromSlip.TabIndex = 3;
            // 
            // dgvEstimateItems_itemsFromSlip
            // 
            this.dgvEstimateItems_itemsFromSlip.AllowUserToAddRows = false;
            this.dgvEstimateItems_itemsFromSlip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstimateItems_itemsFromSlip.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEstimateItems_itemsFromSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstimateItems_itemsFromSlip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.totalPrepare});
            this.dgvEstimateItems_itemsFromSlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstimateItems_itemsFromSlip.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvEstimateItems_itemsFromSlip.Location = new System.Drawing.Point(3, 17);
            this.dgvEstimateItems_itemsFromSlip.Name = "dgvEstimateItems_itemsFromSlip";
            this.dgvEstimateItems_itemsFromSlip.ReadOnly = true;
            this.dgvEstimateItems_itemsFromSlip.RowHeadersVisible = false;
            this.dgvEstimateItems_itemsFromSlip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimateItems_itemsFromSlip.Size = new System.Drawing.Size(766, 355);
            this.dgvEstimateItems_itemsFromSlip.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Master";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Master";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Master";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // totalPrepare
            // 
            this.totalPrepare.HeaderText = "Total Prepare (Approx.)";
            this.totalPrepare.Name = "totalPrepare";
            this.totalPrepare.ReadOnly = true;
            // 
            // btnCalculate_itemsFromSlip
            // 
            this.btnCalculate_itemsFromSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate_itemsFromSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCalculate_itemsFromSlip.Location = new System.Drawing.Point(89, 66);
            this.btnCalculate_itemsFromSlip.Name = "btnCalculate_itemsFromSlip";
            this.btnCalculate_itemsFromSlip.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate_itemsFromSlip.TabIndex = 5;
            this.btnCalculate_itemsFromSlip.Text = "Calculate";
            this.btnCalculate_itemsFromSlip.UseVisualStyleBackColor = true;
            this.btnCalculate_itemsFromSlip.Click += new System.EventHandler(this.btnCalculate_itemsFromSlip_Click);
            // 
            // gbxEstimation
            // 
            this.gbxEstimation.Controls.Add(this.dgvEstimateItems_itemsFromSlip);
            this.gbxEstimation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstimation.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxEstimation.Location = new System.Drawing.Point(6, 135);
            this.gbxEstimation.Name = "gbxEstimation";
            this.gbxEstimation.Size = new System.Drawing.Size(772, 375);
            this.gbxEstimation.TabIndex = 6;
            this.gbxEstimation.TabStop = false;
            this.gbxEstimation.Text = "Item Estimation From Slip";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPrintReport.Location = new System.Drawing.Point(89, 95);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(100, 23);
            this.btnPrintReport.TabIndex = 7;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // frmItemEstimationFromSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.gbxEstimation);
            this.Controls.Add(this.btnCalculate_itemsFromSlip);
            this.Controls.Add(this.cbxCategory_itemsFromSlip);
            this.Controls.Add(this.lblSelect_itemsFromSlip);
            this.Controls.Add(this.txtSlip_itemsFromSlip);
            this.Controls.Add(this.lblSlip_itemsFromSlip);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmItemEstimationFromSlip";
            this.Text = "Item Estimation From Slip";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimateItems_itemsFromSlip)).EndInit();
            this.gbxEstimation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlip_itemsFromSlip;
        private System.Windows.Forms.TextBox txtSlip_itemsFromSlip;
        private System.Windows.Forms.Label lblSelect_itemsFromSlip;
        private System.Windows.Forms.ComboBox cbxCategory_itemsFromSlip;
        private System.Windows.Forms.DataGridView dgvEstimateItems_itemsFromSlip;
        private System.Windows.Forms.Button btnCalculate_itemsFromSlip;
        private System.Windows.Forms.GroupBox gbxEstimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrepare;
        private System.Windows.Forms.Button btnPrintReport;
    }
}