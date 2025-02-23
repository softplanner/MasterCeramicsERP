namespace MasterCeramicsERP
{
    partial class frmAddAddress
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
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAddress = new System.Windows.Forms.GroupBox();
            this.gbxAddressInfo = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearFeilds = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.cbxAddressType = new System.Windows.Forms.ComboBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.gbxAddress.SuspendLayout();
            this.gbxAddressInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.Color.Indigo;
            this.gbxPerson.Location = new System.Drawing.Point(2, 1);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(434, 320);
            this.gbxPerson.TabIndex = 0;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Person";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.GridColor = System.Drawing.Color.Indigo;
            this.dgvPerson.Location = new System.Drawing.Point(3, 17);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(428, 300);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
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
            this.name.Width = 350;
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aid,
            this.pname,
            this.atype,
            this.zipCode,
            this.city,
            this.streetAddress});
            this.dgvAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddress.GridColor = System.Drawing.Color.Indigo;
            this.dgvAddress.Location = new System.Drawing.Point(3, 14);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.Size = new System.Drawing.Size(773, 171);
            this.dgvAddress.TabIndex = 0;
            this.dgvAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddress_CellClick);
            // 
            // aid
            // 
            this.aid.HeaderText = "Address ID";
            this.aid.Name = "aid";
            this.aid.ReadOnly = true;
            this.aid.Width = 65;
            // 
            // pname
            // 
            this.pname.HeaderText = "Person Name";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 160;
            // 
            // atype
            // 
            this.atype.HeaderText = "Address Type";
            this.atype.Name = "atype";
            this.atype.ReadOnly = true;
            this.atype.Width = 85;
            // 
            // zipCode
            // 
            this.zipCode.HeaderText = "Zip Code";
            this.zipCode.Name = "zipCode";
            this.zipCode.ReadOnly = true;
            this.zipCode.Width = 60;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 90;
            // 
            // streetAddress
            // 
            this.streetAddress.HeaderText = "Street Address";
            this.streetAddress.Name = "streetAddress";
            this.streetAddress.ReadOnly = true;
            this.streetAddress.Width = 410;
            // 
            // gbxAddress
            // 
            this.gbxAddress.BackColor = System.Drawing.SystemColors.Control;
            this.gbxAddress.Controls.Add(this.dgvAddress);
            this.gbxAddress.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddress.ForeColor = System.Drawing.Color.Indigo;
            this.gbxAddress.Location = new System.Drawing.Point(0, 325);
            this.gbxAddress.Name = "gbxAddress";
            this.gbxAddress.Size = new System.Drawing.Size(779, 188);
            this.gbxAddress.TabIndex = 2;
            this.gbxAddress.TabStop = false;
            this.gbxAddress.Text = "Address";
            // 
            // gbxAddressInfo
            // 
            this.gbxAddressInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbxAddressInfo.Controls.Add(this.btnDelete);
            this.gbxAddressInfo.Controls.Add(this.btnUpdate);
            this.gbxAddressInfo.Controls.Add(this.btnRefresh);
            this.gbxAddressInfo.Controls.Add(this.btnClearFeilds);
            this.gbxAddressInfo.Controls.Add(this.btnAdd);
            this.gbxAddressInfo.Controls.Add(this.mtxtZipCode);
            this.gbxAddressInfo.Controls.Add(this.cbxAddressType);
            this.gbxAddressInfo.Controls.Add(this.txtStreetAddress);
            this.gbxAddressInfo.Controls.Add(this.cbxCity);
            this.gbxAddressInfo.Controls.Add(this.cbxCountry);
            this.gbxAddressInfo.Controls.Add(this.cbxProvince);
            this.gbxAddressInfo.Controls.Add(this.lblZipCode);
            this.gbxAddressInfo.Controls.Add(this.lblAddressType);
            this.gbxAddressInfo.Controls.Add(this.lblStreetAddress);
            this.gbxAddressInfo.Controls.Add(this.lblCity);
            this.gbxAddressInfo.Controls.Add(this.lblCountry);
            this.gbxAddressInfo.Controls.Add(this.lblProvince);
            this.gbxAddressInfo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddressInfo.ForeColor = System.Drawing.Color.Indigo;
            this.gbxAddressInfo.Location = new System.Drawing.Point(440, 3);
            this.gbxAddressInfo.Name = "gbxAddressInfo";
            this.gbxAddressInfo.Size = new System.Drawing.Size(339, 319);
            this.gbxAddressInfo.TabIndex = 1;
            this.gbxAddressInfo.TabStop = false;
            this.gbxAddressInfo.Text = "Address Updation";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(110, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(110, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(201, 250);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 20);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh Database";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearFeilds
            // 
            this.btnClearFeilds.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFeilds.Location = new System.Drawing.Point(201, 282);
            this.btnClearFeilds.Name = "btnClearFeilds";
            this.btnClearFeilds.Size = new System.Drawing.Size(131, 20);
            this.btnClearFeilds.TabIndex = 16;
            this.btnClearFeilds.Text = "Clear Text Feilds";
            this.btnClearFeilds.UseVisualStyleBackColor = true;
            this.btnClearFeilds.Click += new System.EventHandler(this.btnClearFeilds_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(110, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mtxtZipCode
            // 
            this.mtxtZipCode.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtZipCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtZipCode.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtZipCode.Location = new System.Drawing.Point(110, 194);
            this.mtxtZipCode.Name = "mtxtZipCode";
            this.mtxtZipCode.Size = new System.Drawing.Size(219, 21);
            this.mtxtZipCode.TabIndex = 11;
            this.mtxtZipCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtZipCode_MouseClick);
            // 
            // cbxAddressType
            // 
            this.cbxAddressType.BackColor = System.Drawing.SystemColors.Control;
            this.cbxAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddressType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAddressType.ForeColor = System.Drawing.Color.Indigo;
            this.cbxAddressType.FormattingEnabled = true;
            this.cbxAddressType.Location = new System.Drawing.Point(110, 33);
            this.cbxAddressType.Name = "cbxAddressType";
            this.cbxAddressType.Size = new System.Drawing.Size(219, 21);
            this.cbxAddressType.TabIndex = 1;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreetAddress.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.ForeColor = System.Drawing.Color.Indigo;
            this.txtStreetAddress.Location = new System.Drawing.Point(110, 142);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(219, 46);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // cbxCity
            // 
            this.cbxCity.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCity.ForeColor = System.Drawing.Color.Indigo;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(110, 115);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(219, 21);
            this.cbxCity.TabIndex = 7;
            // 
            // cbxCountry
            // 
            this.cbxCountry.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCountry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCountry.ForeColor = System.Drawing.Color.Indigo;
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(110, 60);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(219, 21);
            this.cbxCountry.TabIndex = 3;
            this.cbxCountry.SelectedIndexChanged += new System.EventHandler(this.cbxCountry_SelectedIndexChanged);
            // 
            // cbxProvince
            // 
            this.cbxProvince.BackColor = System.Drawing.SystemColors.Control;
            this.cbxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvince.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvince.ForeColor = System.Drawing.Color.Indigo;
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(110, 88);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(219, 21);
            this.cbxProvince.TabIndex = 5;
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(6, 196);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(63, 13);
            this.lblZipCode.TabIndex = 10;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressType.Location = new System.Drawing.Point(6, 33);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(92, 13);
            this.lblAddressType.TabIndex = 0;
            this.lblAddressType.Text = "AddressType";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(6, 139);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(100, 13);
            this.lblStreetAddress.TabIndex = 8;
            this.lblStreetAddress.Text = "StreetAddress";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 120);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(6, 65);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(6, 93);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(64, 13);
            this.lblProvince.TabIndex = 4;
            this.lblProvince.Text = "Province";
            // 
            // frmAddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxAddressInfo);
            this.Controls.Add(this.gbxAddress);
            this.Controls.Add(this.gbxPerson);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddAddress";
            this.Text = "Add & Update Address";
            this.Load += new System.EventHandler(this.frmAddAddress_Load);
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.gbxAddress.ResumeLayout(false);
            this.gbxAddressInfo.ResumeLayout(false);
            this.gbxAddressInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.GroupBox gbxAddress;
        private System.Windows.Forms.GroupBox gbxAddressInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearFeilds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtxtZipCode;
        private System.Windows.Forms.ComboBox cbxAddressType;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn atype;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}