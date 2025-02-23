namespace MasterCeramicsERP
{
    partial class frmAddContact
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.contactType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.cbxContactType = new System.Windows.Forms.ComboBox();
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.gbxContact.SuspendLayout();
            this.gbxPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(698, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Location = new System.Drawing.Point(606, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.btnRefresh.Location = new System.Drawing.Point(514, 489);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(258, 21);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh Contacts Database";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(514, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactType,
            this.number});
            this.dgvAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddress.GridColor = System.Drawing.Color.Indigo;
            this.dgvAddress.Location = new System.Drawing.Point(3, 17);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.Size = new System.Drawing.Size(378, 381);
            this.dgvAddress.TabIndex = 0;
            this.dgvAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddress_CellClick);
            // 
            // contactType
            // 
            this.contactType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contactType.Frozen = true;
            this.contactType.HeaderText = "Contact Type";
            this.contactType.Name = "contactType";
            this.contactType.ReadOnly = true;
            this.contactType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contactType.Width = 150;
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 190;
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
            this.dgvPerson.Location = new System.Drawing.Point(3, 17);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(387, 493);
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
            this.name.Width = 300;
            // 
            // gbxContact
            // 
            this.gbxContact.BackColor = System.Drawing.SystemColors.Control;
            this.gbxContact.Controls.Add(this.dgvAddress);
            this.gbxContact.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContact.ForeColor = System.Drawing.Color.Indigo;
            this.gbxContact.Location = new System.Drawing.Point(397, -2);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(384, 401);
            this.gbxContact.TabIndex = 1;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contact";
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.Color.Indigo;
            this.gbxPerson.Location = new System.Drawing.Point(2, -1);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(393, 513);
            this.gbxPerson.TabIndex = 0;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "Person";
            // 
            // cbxContactType
            // 
            this.cbxContactType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContactType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxContactType.ForeColor = System.Drawing.Color.Indigo;
            this.cbxContactType.FormattingEnabled = true;
            this.cbxContactType.Location = new System.Drawing.Point(514, 405);
            this.cbxContactType.Name = "cbxContactType";
            this.cbxContactType.Size = new System.Drawing.Size(258, 21);
            this.cbxContactType.TabIndex = 3;
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumber.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtNumber.Location = new System.Drawing.Point(514, 432);
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(258, 21);
            this.mtxtNumber.TabIndex = 5;
            this.mtxtNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtNumber_MouseClick);
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactType.ForeColor = System.Drawing.Color.Indigo;
            this.lblContactType.Location = new System.Drawing.Point(401, 405);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(92, 13);
            this.lblContactType.TabIndex = 2;
            this.lblContactType.Text = "Contact Type";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Indigo;
            this.lblNumber.Location = new System.Drawing.Point(401, 432);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Number";
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.cbxContactType);
            this.Controls.Add(this.mtxtNumber);
            this.Controls.Add(this.lblContactType);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.gbxPerson);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "frmAddContact";
            this.Text = "Add & Update Contacts";
            this.Load += new System.EventHandler(this.frmAddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.gbxContact.ResumeLayout(false);
            this.gbxPerson.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.ComboBox cbxContactType;
        private System.Windows.Forms.MaskedTextBox mtxtNumber;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactType;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
    }
}