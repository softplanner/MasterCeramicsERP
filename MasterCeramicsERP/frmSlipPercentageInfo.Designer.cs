namespace MasterCeramicsERP
{
    partial class frmSlipPercentageInfo
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
            this.dgvSlipPercentageInfo = new System.Windows.Forms.DataGridView();
            this.rmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipPercentageInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSlipPercentageInfo
            // 
            this.dgvSlipPercentageInfo.AllowUserToAddRows = false;
            this.dgvSlipPercentageInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSlipPercentageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlipPercentageInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rmid,
            this.rawMaterial,
            this.percentage});
            this.dgvSlipPercentageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlipPercentageInfo.GridColor = System.Drawing.Color.SaddleBrown;
            this.dgvSlipPercentageInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvSlipPercentageInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSlipPercentageInfo.Name = "dgvSlipPercentageInfo";
            this.dgvSlipPercentageInfo.ReadOnly = true;
            this.dgvSlipPercentageInfo.RowHeadersVisible = false;
            this.dgvSlipPercentageInfo.Size = new System.Drawing.Size(784, 517);
            this.dgvSlipPercentageInfo.TabIndex = 0;
            // 
            // rmid
            // 
            this.rmid.HeaderText = "ID";
            this.rmid.Name = "rmid";
            this.rmid.ReadOnly = true;
            // 
            // rawMaterial
            // 
            this.rawMaterial.HeaderText = "Raw Material";
            this.rawMaterial.Name = "rawMaterial";
            this.rawMaterial.ReadOnly = true;
            this.rawMaterial.Width = 450;
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Percentage";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            this.percentage.Width = 230;
            // 
            // frmSlipPercentageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.dgvSlipPercentageInfo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSlipPercentageInfo";
            this.Text = "Slip Percentage Info";
            this.Load += new System.EventHandler(this.frmSlipPercentageInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipPercentageInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSlipPercentageInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
    }
}