namespace MasterCeramicsERP
{
    partial class frmUpdateSlipPercentage
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
            this.lblSelectRawMaterial_updateSlip = new System.Windows.Forms.Label();
            this.lblValue_updateSlip = new System.Windows.Forms.Label();
            this.btnUpdate_updateSlip = new System.Windows.Forms.Button();
            this.dgvSlipPercentage_updateSlip = new System.Windows.Forms.DataGridView();
            this.rmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshdatabase_updateSlip = new System.Windows.Forms.Button();
            this.gbxUpdateSlipPercentage = new System.Windows.Forms.GroupBox();
            this.txtValue_updateSlip = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipPercentage_updateSlip)).BeginInit();
            this.gbxUpdateSlipPercentage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectRawMaterial_updateSlip
            // 
            this.lblSelectRawMaterial_updateSlip.AutoSize = true;
            this.lblSelectRawMaterial_updateSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSelectRawMaterial_updateSlip.Location = new System.Drawing.Point(21, 20);
            this.lblSelectRawMaterial_updateSlip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectRawMaterial_updateSlip.Name = "lblSelectRawMaterial_updateSlip";
            this.lblSelectRawMaterial_updateSlip.Size = new System.Drawing.Size(120, 13);
            this.lblSelectRawMaterial_updateSlip.TabIndex = 0;
            this.lblSelectRawMaterial_updateSlip.Text = "Selected Material";
            // 
            // lblValue_updateSlip
            // 
            this.lblValue_updateSlip.AutoSize = true;
            this.lblValue_updateSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblValue_updateSlip.Location = new System.Drawing.Point(21, 43);
            this.lblValue_updateSlip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue_updateSlip.Name = "lblValue_updateSlip";
            this.lblValue_updateSlip.Size = new System.Drawing.Size(43, 13);
            this.lblValue_updateSlip.TabIndex = 2;
            this.lblValue_updateSlip.Text = "Value";
            // 
            // btnUpdate_updateSlip
            // 
            this.btnUpdate_updateSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdate_updateSlip.Location = new System.Drawing.Point(151, 69);
            this.btnUpdate_updateSlip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate_updateSlip.Name = "btnUpdate_updateSlip";
            this.btnUpdate_updateSlip.Size = new System.Drawing.Size(136, 23);
            this.btnUpdate_updateSlip.TabIndex = 4;
            this.btnUpdate_updateSlip.Text = "Update";
            this.btnUpdate_updateSlip.UseVisualStyleBackColor = true;
            this.btnUpdate_updateSlip.Click += new System.EventHandler(this.btnUpdate_updateSlip_Click);
            // 
            // dgvSlipPercentage_updateSlip
            // 
            this.dgvSlipPercentage_updateSlip.AllowUserToAddRows = false;
            this.dgvSlipPercentage_updateSlip.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSlipPercentage_updateSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlipPercentage_updateSlip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rmid,
            this.rawMaterial,
            this.percentage});
            this.dgvSlipPercentage_updateSlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlipPercentage_updateSlip.Location = new System.Drawing.Point(4, 17);
            this.dgvSlipPercentage_updateSlip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSlipPercentage_updateSlip.Name = "dgvSlipPercentage_updateSlip";
            this.dgvSlipPercentage_updateSlip.ReadOnly = true;
            this.dgvSlipPercentage_updateSlip.Size = new System.Drawing.Size(772, 367);
            this.dgvSlipPercentage_updateSlip.TabIndex = 0;
            this.dgvSlipPercentage_updateSlip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlipPercentage_updateSlip_CellClick);
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
            this.rawMaterial.Width = 475;
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Quantity Required                   (1kg)";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            this.percentage.Width = 169;
            // 
            // btnRefreshdatabase_updateSlip
            // 
            this.btnRefreshdatabase_updateSlip.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRefreshdatabase_updateSlip.Location = new System.Drawing.Point(151, 98);
            this.btnRefreshdatabase_updateSlip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshdatabase_updateSlip.Name = "btnRefreshdatabase_updateSlip";
            this.btnRefreshdatabase_updateSlip.Size = new System.Drawing.Size(136, 23);
            this.btnRefreshdatabase_updateSlip.TabIndex = 5;
            this.btnRefreshdatabase_updateSlip.Text = "Refresh Database";
            this.btnRefreshdatabase_updateSlip.UseVisualStyleBackColor = true;
            this.btnRefreshdatabase_updateSlip.Click += new System.EventHandler(this.btnRefreshdatabase_updateSlip_Click);
            // 
            // gbxUpdateSlipPercentage
            // 
            this.gbxUpdateSlipPercentage.Controls.Add(this.dgvSlipPercentage_updateSlip);
            this.gbxUpdateSlipPercentage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxUpdateSlipPercentage.Location = new System.Drawing.Point(0, 125);
            this.gbxUpdateSlipPercentage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUpdateSlipPercentage.Name = "gbxUpdateSlipPercentage";
            this.gbxUpdateSlipPercentage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUpdateSlipPercentage.Size = new System.Drawing.Size(780, 387);
            this.gbxUpdateSlipPercentage.TabIndex = 6;
            this.gbxUpdateSlipPercentage.TabStop = false;
            this.gbxUpdateSlipPercentage.Text = "Update Slip Percentage";
            // 
            // txtValue_updateSlip
            // 
            this.txtValue_updateSlip.BackColor = System.Drawing.SystemColors.Control;
            this.txtValue_updateSlip.Location = new System.Drawing.Point(151, 43);
            this.txtValue_updateSlip.Name = "txtValue_updateSlip";
            this.txtValue_updateSlip.Size = new System.Drawing.Size(196, 21);
            this.txtValue_updateSlip.TabIndex = 3;
            this.txtValue_updateSlip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValue_updateSlip_MouseClick_1);
            this.txtValue_updateSlip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_updateSlip_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(151, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 21);
            this.txtName.TabIndex = 7;
            // 
            // frmUpdateSlipPercentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtValue_updateSlip);
            this.Controls.Add(this.gbxUpdateSlipPercentage);
            this.Controls.Add(this.btnRefreshdatabase_updateSlip);
            this.Controls.Add(this.btnUpdate_updateSlip);
            this.Controls.Add(this.lblValue_updateSlip);
            this.Controls.Add(this.lblSelectRawMaterial_updateSlip);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmUpdateSlipPercentage";
            this.Text = "Update Slip Percentage Info";
            this.Load += new System.EventHandler(this.frmUpdateSlipPercentage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipPercentage_updateSlip)).EndInit();
            this.gbxUpdateSlipPercentage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRawMaterial_updateSlip;
        private System.Windows.Forms.Label lblValue_updateSlip;
        private System.Windows.Forms.Button btnUpdate_updateSlip;
        private System.Windows.Forms.DataGridView dgvSlipPercentage_updateSlip;
        private System.Windows.Forms.Button btnRefreshdatabase_updateSlip;
        private System.Windows.Forms.GroupBox gbxUpdateSlipPercentage;
        private System.Windows.Forms.MaskedTextBox txtValue_updateSlip;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.MaskedTextBox txtName;
    }
}