namespace MasterCeramicsERP
{
    partial class frmSlipMaterial
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
            this.gbxRawMaterial = new System.Windows.Forms.GroupBox();
            this.dgvrawMaterial = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSlipMaterial = new System.Windows.Forms.GroupBox();
            this.dgvSlipMaterial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSlipPercentage = new System.Windows.Forms.Label();
            this.txtSlipPercentage = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxRawMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).BeginInit();
            this.gbxSlipMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRawMaterial
            // 
            this.gbxRawMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.gbxRawMaterial.Controls.Add(this.dgvrawMaterial);
            this.gbxRawMaterial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRawMaterial.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxRawMaterial.Location = new System.Drawing.Point(-1, 3);
            this.gbxRawMaterial.Name = "gbxRawMaterial";
            this.gbxRawMaterial.Size = new System.Drawing.Size(313, 510);
            this.gbxRawMaterial.TabIndex = 1;
            this.gbxRawMaterial.TabStop = false;
            this.gbxRawMaterial.Text = "Available Raw Material";
            // 
            // dgvrawMaterial
            // 
            this.dgvrawMaterial.AllowUserToAddRows = false;
            this.dgvrawMaterial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvrawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgvrawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrawMaterial.GridColor = System.Drawing.Color.Olive;
            this.dgvrawMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvrawMaterial.Name = "dgvrawMaterial";
            this.dgvrawMaterial.ReadOnly = true;
            this.dgvrawMaterial.Size = new System.Drawing.Size(307, 490);
            this.dgvrawMaterial.TabIndex = 0;
            this.dgvrawMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrawMaterial_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 640;
            // 
            // gbxSlipMaterial
            // 
            this.gbxSlipMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSlipMaterial.Controls.Add(this.dgvSlipMaterial);
            this.gbxSlipMaterial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSlipMaterial.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbxSlipMaterial.Location = new System.Drawing.Point(450, 2);
            this.gbxSlipMaterial.Name = "gbxSlipMaterial";
            this.gbxSlipMaterial.Size = new System.Drawing.Size(322, 510);
            this.gbxSlipMaterial.TabIndex = 2;
            this.gbxSlipMaterial.TabStop = false;
            this.gbxSlipMaterial.Text = "Slip Material";
            // 
            // dgvSlipMaterial
            // 
            this.dgvSlipMaterial.AllowUserToAddRows = false;
            this.dgvSlipMaterial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSlipMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlipMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvSlipMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlipMaterial.GridColor = System.Drawing.Color.Olive;
            this.dgvSlipMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvSlipMaterial.Name = "dgvSlipMaterial";
            this.dgvSlipMaterial.ReadOnly = true;
            this.dgvSlipMaterial.Size = new System.Drawing.Size(316, 490);
            this.dgvSlipMaterial.TabIndex = 0;
            this.dgvSlipMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlipMaterial_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 640;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(321, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSlipPercentage
            // 
            this.lblSlipPercentage.AutoSize = true;
            this.lblSlipPercentage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlipPercentage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSlipPercentage.Location = new System.Drawing.Point(318, 44);
            this.lblSlipPercentage.Name = "lblSlipPercentage";
            this.lblSlipPercentage.Size = new System.Drawing.Size(109, 13);
            this.lblSlipPercentage.TabIndex = 7;
            this.lblSlipPercentage.Text = "Slip Percentage";
            // 
            // txtSlipPercentage
            // 
            this.txtSlipPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.txtSlipPercentage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlipPercentage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtSlipPercentage.Location = new System.Drawing.Point(321, 69);
            this.txtSlipPercentage.Name = "txtSlipPercentage";
            this.txtSlipPercentage.Size = new System.Drawing.Size(123, 21);
            this.txtSlipPercentage.TabIndex = 8;
            this.txtSlipPercentage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSlipPercentage_MouseClick);
            this.txtSlipPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlipPercentage_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Location = new System.Drawing.Point(321, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSlipMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSlipPercentage);
            this.Controls.Add(this.txtSlipPercentage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxSlipMaterial);
            this.Controls.Add(this.gbxRawMaterial);
            this.Name = "frmSlipMaterial";
            this.Text = "Manage Slip Material\'s";
            this.Load += new System.EventHandler(this.frmSlipMaterial_Load);
            this.gbxRawMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).EndInit();
            this.gbxSlipMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlipMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRawMaterial;
        private System.Windows.Forms.DataGridView dgvrawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.GroupBox gbxSlipMaterial;
        private System.Windows.Forms.DataGridView dgvSlipMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSlipPercentage;
        private System.Windows.Forms.TextBox txtSlipPercentage;
        private System.Windows.Forms.Button btnDelete;
    }
}