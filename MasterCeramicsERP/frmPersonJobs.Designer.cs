namespace MasterCeramicsERP
{
    partial class frmPersonJobs
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
            this.gbxJob = new System.Windows.Forms.GroupBox();
            this.dgvrawMaterial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllJobs = new System.Windows.Forms.DataGridView();
            this.jobid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.gbxJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.Color.Indigo;
            this.gbxPerson.Location = new System.Drawing.Point(5, 5);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(488, 507);
            this.gbxPerson.TabIndex = 36;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Person";
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
            this.dgvPerson.GridColor = System.Drawing.Color.Indigo;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPerson.Size = new System.Drawing.Size(480, 487);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentClick);
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
            this.name.Width = 367;
            // 
            // gbxJob
            // 
            this.gbxJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxJob.Controls.Add(this.dgvrawMaterial);
            this.gbxJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxJob.ForeColor = System.Drawing.Color.Indigo;
            this.gbxJob.Location = new System.Drawing.Point(499, 5);
            this.gbxJob.Name = "gbxJob";
            this.gbxJob.Size = new System.Drawing.Size(279, 161);
            this.gbxJob.TabIndex = 37;
            this.gbxJob.TabStop = false;
            this.gbxJob.Text = "Selected Person  Jobs";
            // 
            // dgvrawMaterial
            // 
            this.dgvrawMaterial.AllowUserToAddRows = false;
            this.dgvrawMaterial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvrawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvrawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrawMaterial.GridColor = System.Drawing.Color.Indigo;
            this.dgvrawMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvrawMaterial.MultiSelect = false;
            this.dgvrawMaterial.Name = "dgvrawMaterial";
            this.dgvrawMaterial.ReadOnly = true;
            this.dgvrawMaterial.Size = new System.Drawing.Size(273, 141);
            this.dgvrawMaterial.TabIndex = 0;
            this.dgvrawMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrawMaterial_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 237;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvAllJobs);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(499, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 311);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Jobs";
            // 
            // dgvAllJobs
            // 
            this.dgvAllJobs.AllowUserToAddRows = false;
            this.dgvAllJobs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobid,
            this.dataGridViewTextBoxColumn1});
            this.dgvAllJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllJobs.GridColor = System.Drawing.Color.Indigo;
            this.dgvAllJobs.Location = new System.Drawing.Point(3, 17);
            this.dgvAllJobs.MultiSelect = false;
            this.dgvAllJobs.Name = "dgvAllJobs";
            this.dgvAllJobs.ReadOnly = true;
            this.dgvAllJobs.Size = new System.Drawing.Size(270, 291);
            this.dgvAllJobs.TabIndex = 0;
            this.dgvAllJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllJobs_CellClick);
            // 
            // jobid
            // 
            this.jobid.HeaderText = "ID";
            this.jobid.Name = "jobid";
            this.jobid.ReadOnly = true;
            this.jobid.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(500, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 23);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Assign New Job";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(652, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "     Delete Job";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPersonJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxJob);
            this.Controls.Add(this.gbxPerson);
            this.Name = "frmPersonJobs";
            this.Text = "Add & Update Job\'s  ---> Manage Job\'s";
            this.Load += new System.EventHandler(this.frmPersonJobs_Load);
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.gbxJob.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.GroupBox gbxJob;
        private System.Windows.Forms.DataGridView dgvrawMaterial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllJobs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}