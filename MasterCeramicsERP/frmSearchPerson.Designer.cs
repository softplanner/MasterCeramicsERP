namespace MasterCeramicsERP
{
    partial class frmSearchPerson
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
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mtxtNumber = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxJobs = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.mtxtName = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSearch.Controls.Add(this.txtSalary);
            this.gbxSearch.Controls.Add(this.lblSalary);
            this.gbxSearch.Controls.Add(this.btnDelete);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.btnRefresh);
            this.gbxSearch.Controls.Add(this.btnUpdate);
            this.gbxSearch.Controls.Add(this.mtxtNumber);
            this.gbxSearch.Controls.Add(this.txtStreetAddress);
            this.gbxSearch.Controls.Add(this.lblNumber);
            this.gbxSearch.Controls.Add(this.lblStreetAddress);
            this.gbxSearch.Controls.Add(this.cbxCategory);
            this.gbxSearch.Controls.Add(this.lblCategory);
            this.gbxSearch.Controls.Add(this.cbxJobs);
            this.gbxSearch.Controls.Add(this.lblJob);
            this.gbxSearch.Controls.Add(this.mtxtName);
            this.gbxSearch.Controls.Add(this.lblName);
            this.gbxSearch.Controls.Add(this.dgvPerson);
            this.gbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.ForeColor = System.Drawing.Color.Indigo;
            this.gbxSearch.Location = new System.Drawing.Point(0, 0);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxSearch.Size = new System.Drawing.Size(784, 517);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(192, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 27);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Indigo;
            this.btnSearch.Location = new System.Drawing.Point(103, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 27);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.btnRefresh.Location = new System.Drawing.Point(280, 476);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 27);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Location = new System.Drawing.Point(103, 476);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 27);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNumber.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumber.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtNumber.Location = new System.Drawing.Point(103, 336);
            this.mtxtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtNumber.Multiline = true;
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(668, 43);
            this.mtxtNumber.TabIndex = 42;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreetAddress.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.ForeColor = System.Drawing.Color.Indigo;
            this.txtStreetAddress.Location = new System.Drawing.Point(103, 385);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(668, 40);
            this.txtStreetAddress.TabIndex = 41;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Indigo;
            this.lblNumber.Location = new System.Drawing.Point(10, 339);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 15);
            this.lblNumber.TabIndex = 38;
            this.lblNumber.Text = "Contact #";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.ForeColor = System.Drawing.Color.Indigo;
            this.lblStreetAddress.Location = new System.Drawing.Point(10, 388);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(53, 15);
            this.lblStreetAddress.TabIndex = 40;
            this.lblStreetAddress.Text = "Address";
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.ForeColor = System.Drawing.Color.Indigo;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Worker",
            "Other"});
            this.cbxCategory.Location = new System.Drawing.Point(105, 48);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(666, 23);
            this.cbxCategory.TabIndex = 11;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Indigo;
            this.lblCategory.Location = new System.Drawing.Point(10, 51);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 15);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Select Category";
            // 
            // cbxJobs
            // 
            this.cbxJobs.BackColor = System.Drawing.SystemColors.Control;
            this.cbxJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobs.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJobs.ForeColor = System.Drawing.Color.Indigo;
            this.cbxJobs.FormattingEnabled = true;
            this.cbxJobs.Location = new System.Drawing.Point(105, 303);
            this.cbxJobs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxJobs.Name = "cbxJobs";
            this.cbxJobs.Size = new System.Drawing.Size(668, 23);
            this.cbxJobs.TabIndex = 13;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Indigo;
            this.lblJob.Location = new System.Drawing.Point(10, 306);
            this.lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(25, 15);
            this.lblJob.TabIndex = 12;
            this.lblJob.Text = "Job";
            // 
            // mtxtName
            // 
            this.mtxtName.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtName.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtName.Location = new System.Drawing.Point(105, 20);
            this.mtxtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.Size = new System.Drawing.Size(666, 22);
            this.mtxtName.TabIndex = 9;
            this.mtxtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtName_MouseClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(10, 23);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Enter Name";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.GridColor = System.Drawing.Color.Indigo;
            this.dgvPerson.Location = new System.Drawing.Point(4, 119);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(776, 178);
            this.dgvPerson.TabIndex = 7;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalary.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(105, 431);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(182, 21);
            this.txtSalary.TabIndex = 49;
            this.txtSalary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSalary_MouseClick);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Indigo;
            this.lblSalary.Location = new System.Drawing.Point(10, 437);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(82, 15);
            this.lblSalary.TabIndex = 48;
            this.lblSalary.Text = "Salary/Wages";
            // 
            // frmSearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmSearchPerson";
            this.Text = "Search & Update Person Info";
            this.Load += new System.EventHandler(this.frmSearchPerson_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.MaskedTextBox mtxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxJobs;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox mtxtNumber;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
    }
}