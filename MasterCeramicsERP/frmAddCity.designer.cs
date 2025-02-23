namespace MasterCeramicsERP
{
    partial class frmAddCity
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvrawMaterial = new System.Windows.Forms.DataGridView();
            this.cityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearFeild = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbxCity = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).BeginInit();
            this.gbxCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Indigo;
            this.lblCountry.Location = new System.Drawing.Point(11, 453);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(102, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Select Country";
            // 
            // cbxCountry
            // 
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCountry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCountry.ForeColor = System.Drawing.Color.Indigo;
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(119, 450);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(133, 21);
            this.cbxCountry.TabIndex = 2;
            this.cbxCountry.SelectedValueChanged += new System.EventHandler(this.cbxCountry_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(130, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 21);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Indigo;
            this.lblID.Location = new System.Drawing.Point(513, 453);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Location = new System.Drawing.Point(63, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 21);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.btnRefresh.Location = new System.Drawing.Point(516, 484);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 20);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh Database";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvrawMaterial
            // 
            this.dgvrawMaterial.AllowUserToAddRows = false;
            this.dgvrawMaterial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvrawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityID,
            this.city});
            this.dgvrawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrawMaterial.GridColor = System.Drawing.Color.Indigo;
            this.dgvrawMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvrawMaterial.Name = "dgvrawMaterial";
            this.dgvrawMaterial.ReadOnly = true;
            this.dgvrawMaterial.Size = new System.Drawing.Size(772, 423);
            this.dgvrawMaterial.TabIndex = 0;
            this.dgvrawMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrawMaterial_CellClick);
            // 
            // cityID
            // 
            this.cityID.HeaderText = "City ID";
            this.cityID.Name = "cityID";
            this.cityID.ReadOnly = true;
            this.cityID.Width = 105;
            // 
            // city
            // 
            this.city.HeaderText = "City ";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 640;
            // 
            // btnClearFeild
            // 
            this.btnClearFeild.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFeild.ForeColor = System.Drawing.Color.Indigo;
            this.btnClearFeild.Location = new System.Drawing.Point(655, 484);
            this.btnClearFeild.Name = "btnClearFeild";
            this.btnClearFeild.Size = new System.Drawing.Size(118, 20);
            this.btnClearFeild.TabIndex = 14;
            this.btnClearFeild.Text = "Clear Text Feild";
            this.btnClearFeild.UseVisualStyleBackColor = true;
            this.btnClearFeild.Click += new System.EventHandler(this.btnClearFeild_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(11, 484);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 21);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(613, 453);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Indigo;
            this.txtName.Location = new System.Drawing.Point(663, 451);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 21);
            this.txtName.TabIndex = 8;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.Color.Indigo;
            this.lblProvince.Location = new System.Drawing.Point(261, 453);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(108, 13);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "Select Province";
            // 
            // cbxProvince
            // 
            this.cbxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvince.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvince.ForeColor = System.Drawing.Color.Indigo;
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(375, 450);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(133, 21);
            this.cbxProvince.TabIndex = 4;
            this.cbxProvince.SelectedValueChanged += new System.EventHandler(this.cbxProvince_SelectedValueChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Indigo;
            this.txtID.Location = new System.Drawing.Point(539, 451);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(71, 21);
            this.txtID.TabIndex = 6;
            // 
            // gbxCity
            // 
            this.gbxCity.Controls.Add(this.dgvrawMaterial);
            this.gbxCity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCity.ForeColor = System.Drawing.Color.Indigo;
            this.gbxCity.Location = new System.Drawing.Point(2, 1);
            this.gbxCity.Name = "gbxCity";
            this.gbxCity.Size = new System.Drawing.Size(778, 443);
            this.gbxCity.TabIndex = 0;
            this.gbxCity.TabStop = false;
            this.gbxCity.Text = "Cities";
            // 
            // frmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxCity);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.cbxProvince);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cbxCountry);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClearFeild);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddCity";
            this.Text = "Add & Update City";
            this.Load += new System.EventHandler(this.frmAddCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrawMaterial)).EndInit();
            this.gbxCity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvrawMaterial;
        private System.Windows.Forms.Button btnClearFeild;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbxCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}