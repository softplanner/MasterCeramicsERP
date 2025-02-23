namespace MasterCeramicsERP
{
    partial class frmCalculateSlipPecentege
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
            this.lblBarmilSize = new System.Windows.Forms.Label();
            this.txtBarmilWeight = new System.Windows.Forms.TextBox();
            this.dgvSlipPercentageInfo = new System.Windows.Forms.DataGridView();
            this.rawMaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.gbxSlip = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipPercentageInfo)).BeginInit();
            this.gbxSlip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarmilSize
            // 
            this.lblBarmilSize.AutoSize = true;
            this.lblBarmilSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarmilSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBarmilSize.Location = new System.Drawing.Point(12, 15);
            this.lblBarmilSize.Name = "lblBarmilSize";
            this.lblBarmilSize.Size = new System.Drawing.Size(137, 13);
            this.lblBarmilSize.TabIndex = 0;
            this.lblBarmilSize.Text = "Enter Barmil Weight";
            // 
            // txtBarmilWeight
            // 
            this.txtBarmilWeight.BackColor = System.Drawing.SystemColors.Control;
            this.txtBarmilWeight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarmilWeight.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBarmilWeight.Location = new System.Drawing.Point(172, 12);
            this.txtBarmilWeight.Name = "txtBarmilWeight";
            this.txtBarmilWeight.Size = new System.Drawing.Size(103, 21);
            this.txtBarmilWeight.TabIndex = 1;
            this.txtBarmilWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBarmilWeight_MouseClick);
            this.txtBarmilWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarmilWeight_KeyPress);
            // 
            // dgvSlipPercentageInfo
            // 
            this.dgvSlipPercentageInfo.AllowUserToAddRows = false;
            this.dgvSlipPercentageInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSlipPercentageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlipPercentageInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawMaterialID,
            this.rawmaterial,
            this.quantityRequired});
            this.dgvSlipPercentageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlipPercentageInfo.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvSlipPercentageInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvSlipPercentageInfo.Name = "dgvSlipPercentageInfo";
            this.dgvSlipPercentageInfo.ReadOnly = true;
            this.dgvSlipPercentageInfo.Size = new System.Drawing.Size(771, 454);
            this.dgvSlipPercentageInfo.TabIndex = 2;
            // 
            // rawMaterialID
            // 
            this.rawMaterialID.HeaderText = "ID";
            this.rawMaterialID.Name = "rawMaterialID";
            this.rawMaterialID.ReadOnly = true;
            // 
            // rawmaterial
            // 
            this.rawmaterial.HeaderText = "Raw Material";
            this.rawmaterial.Name = "rawmaterial";
            this.rawmaterial.ReadOnly = true;
            this.rawmaterial.Width = 500;
            // 
            // quantityRequired
            // 
            this.quantityRequired.HeaderText = "Quantity Required(kg)";
            this.quantityRequired.Name = "quantityRequired";
            this.quantityRequired.ReadOnly = true;
            this.quantityRequired.Width = 137;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCalculate.Location = new System.Drawing.Point(329, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightUnit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblWeightUnit.Location = new System.Drawing.Point(281, 15);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(23, 13);
            this.lblWeightUnit.TabIndex = 4;
            this.lblWeightUnit.Text = "kg";
            // 
            // gbxSlip
            // 
            this.gbxSlip.Controls.Add(this.dgvSlipPercentageInfo);
            this.gbxSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxSlip.Location = new System.Drawing.Point(2, 38);
            this.gbxSlip.Name = "gbxSlip";
            this.gbxSlip.Size = new System.Drawing.Size(777, 474);
            this.gbxSlip.TabIndex = 5;
            this.gbxSlip.TabStop = false;
            this.gbxSlip.Text = "Slip Amount";
            // 
            // frmCalculateSlipPecentege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxSlip);
            this.Controls.Add(this.lblWeightUnit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBarmilWeight);
            this.Controls.Add(this.lblBarmilSize);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "frmCalculateSlipPecentege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Slip Amount";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipPercentageInfo)).EndInit();
            this.gbxSlip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarmilSize;
        private System.Windows.Forms.TextBox txtBarmilWeight;
        private System.Windows.Forms.DataGridView dgvSlipPercentageInfo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.GroupBox gbxSlip;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityRequired;
    }
}