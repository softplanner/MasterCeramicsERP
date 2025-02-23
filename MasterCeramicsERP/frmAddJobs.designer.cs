namespace MasterCeramicsERP
{
    partial class frmAddJobs
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvrawMaterial = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearFeild = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxJob = new System.Windows.Forms.GroupBox();
            this.btnManagePersonJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).BeginInit();
            this.gbxJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(110, 489);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 21);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Job";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Indigo;
            this.lblID.Location = new System.Drawing.Point(8, 375);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.ForeColor = System.Drawing.Color.Indigo;
            this.txtID.Location = new System.Drawing.Point(110, 369);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(239, 21);
            this.txtID.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Location = new System.Drawing.Point(110, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 21);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.dgvrawMaterial.GridColor = System.Drawing.Color.Indigo;
            this.dgvrawMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvrawMaterial.Name = "dgvrawMaterial";
            this.dgvrawMaterial.ReadOnly = true;
            this.dgvrawMaterial.Size = new System.Drawing.Size(772, 342);
            this.dgvrawMaterial.TabIndex = 0;
            this.dgvrawMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrawMaterial_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 639;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.btnRefresh.Location = new System.Drawing.Point(215, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 21);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh Database";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearFeild
            // 
            this.btnClearFeild.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearFeild.ForeColor = System.Drawing.Color.Indigo;
            this.btnClearFeild.Location = new System.Drawing.Point(215, 437);
            this.btnClearFeild.Name = "btnClearFeild";
            this.btnClearFeild.Size = new System.Drawing.Size(134, 21);
            this.btnClearFeild.TabIndex = 8;
            this.btnClearFeild.Text = "Clear Text Feild";
            this.btnClearFeild.UseVisualStyleBackColor = false;
            this.btnClearFeild.Click += new System.EventHandler(this.btnClearFeild_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(110, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 21);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(8, 401);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.ForeColor = System.Drawing.Color.Indigo;
            this.txtName.Location = new System.Drawing.Point(110, 395);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 21);
            this.txtName.TabIndex = 4;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            // 
            // gbxJob
            // 
            this.gbxJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxJob.Controls.Add(this.dgvrawMaterial);
            this.gbxJob.ForeColor = System.Drawing.Color.Indigo;
            this.gbxJob.Location = new System.Drawing.Point(3, 1);
            this.gbxJob.Name = "gbxJob";
            this.gbxJob.Size = new System.Drawing.Size(778, 362);
            this.gbxJob.TabIndex = 0;
            this.gbxJob.TabStop = false;
            this.gbxJob.Text = "Jobs";
            // 
            // btnManagePersonJob
            // 
            this.btnManagePersonJob.BackColor = System.Drawing.SystemColors.Control;
            this.btnManagePersonJob.ForeColor = System.Drawing.Color.Indigo;
            this.btnManagePersonJob.Location = new System.Drawing.Point(605, 484);
            this.btnManagePersonJob.Name = "btnManagePersonJob";
            this.btnManagePersonJob.Size = new System.Drawing.Size(167, 21);
            this.btnManagePersonJob.TabIndex = 10;
            this.btnManagePersonJob.Text = "Manage Person Job\'s";
            this.btnManagePersonJob.UseVisualStyleBackColor = false;
            this.btnManagePersonJob.Click += new System.EventHandler(this.btnManagePersonJob_Click);
            // 
            // frmAddJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnManagePersonJob);
            this.Controls.Add(this.gbxJob);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClearFeild);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddJobs";
            this.Text = "Add & Update Jobs";
            this.Load += new System.EventHandler(this.frmAddJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).EndInit();
            this.gbxJob.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvrawMaterial;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearFeild;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbxJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnManagePersonJob;
    }
}