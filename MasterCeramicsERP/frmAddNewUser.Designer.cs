namespace MasterCeramicsERP
{
    partial class frmAddNewUser
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
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnChangePassword = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnchangePassword = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUserType = new System.Windows.Forms.MaskedTextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.MaskedTextBox();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblStrength1 = new System.Windows.Forms.Label();
            this.lblStrength2 = new System.Windows.Forms.Label();
            this.lblStrength3 = new System.Windows.Forms.Label();
            this.lblStrength4 = new System.Windows.Forms.Label();
            this.lblStrength5 = new System.Windows.Forms.Label();
            this.lblStrenght = new System.Windows.Forms.Label();
            this.gbxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDelete.ForeColor = System.Drawing.Color.Red;
            this.rbtnDelete.Location = new System.Drawing.Point(9, 214);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(101, 17);
            this.rbtnDelete.TabIndex = 16;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "Delete User";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            this.rbtnDelete.CheckedChanged += new System.EventHandler(this.rbtnDelete_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(161, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 21);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUser
            // 
            this.gbxUser.Controls.Add(this.dgvUser);
            this.gbxUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUser.ForeColor = System.Drawing.Color.Red;
            this.gbxUser.Location = new System.Drawing.Point(399, 25);
            this.gbxUser.Name = "gbxUser";
            this.gbxUser.Size = new System.Drawing.Size(380, 485);
            this.gbxUser.TabIndex = 23;
            this.gbxUser.TabStop = false;
            this.gbxUser.Text = "User";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.password});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.GridColor = System.Drawing.Color.Red;
            this.dgvUser.Location = new System.Drawing.Point(3, 17);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(374, 465);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarmil_CellClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "User Name";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 160;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 170;
            // 
            // rbtnChangePassword
            // 
            this.rbtnChangePassword.AutoSize = true;
            this.rbtnChangePassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChangePassword.ForeColor = System.Drawing.Color.Red;
            this.rbtnChangePassword.Location = new System.Drawing.Point(9, 187);
            this.rbtnChangePassword.Name = "rbtnChangePassword";
            this.rbtnChangePassword.Size = new System.Drawing.Size(139, 17);
            this.rbtnChangePassword.TabIndex = 15;
            this.rbtnChangePassword.TabStop = true;
            this.rbtnChangePassword.Text = "Change Password";
            this.rbtnChangePassword.UseVisualStyleBackColor = true;
            this.rbtnChangePassword.CheckedChanged += new System.EventHandler(this.rbtnUpdate_CheckedChanged);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.ForeColor = System.Drawing.Color.Red;
            this.rbtnAdd.Location = new System.Drawing.Point(9, 160);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(115, 17);
            this.rbtnAdd.TabIndex = 14;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add New User";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.rbtnAdd_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BeepOnError = true;
            this.txtName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(161, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 21);
            this.txtName.TabIndex = 3;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Red;
            this.btnRefresh.Location = new System.Drawing.Point(161, 239);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 21);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnchangePassword
            // 
            this.btnchangePassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangePassword.ForeColor = System.Drawing.Color.Red;
            this.btnchangePassword.Location = new System.Drawing.Point(161, 185);
            this.btnchangePassword.Name = "btnchangePassword";
            this.btnchangePassword.Size = new System.Drawing.Size(134, 21);
            this.btnchangePassword.TabIndex = 18;
            this.btnchangePassword.Text = "Change Password";
            this.btnchangePassword.UseVisualStyleBackColor = true;
            this.btnchangePassword.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(9, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "User Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(161, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 21);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUserType
            // 
            this.txtUserType.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserType.BeepOnError = true;
            this.txtUserType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserType.ForeColor = System.Drawing.Color.Red;
            this.txtUserType.Location = new System.Drawing.Point(161, 15);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.Size = new System.Drawing.Size(146, 21);
            this.txtUserType.TabIndex = 1;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.Red;
            this.lblUserType.Location = new System.Drawing.Point(9, 18);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(73, 13);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "User Type";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BeepOnError = true;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(161, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(146, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(9, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtRetypePassword.BeepOnError = true;
            this.txtRetypePassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.ForeColor = System.Drawing.Color.Red;
            this.txtRetypePassword.Location = new System.Drawing.Point(161, 96);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.Size = new System.Drawing.Size(146, 21);
            this.txtRetypePassword.TabIndex = 7;
            this.txtRetypePassword.TabStop = false;
            this.txtRetypePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRetypePassword_MouseClick);
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetypePassword.ForeColor = System.Drawing.Color.Red;
            this.lblRetypePassword.Location = new System.Drawing.Point(9, 99);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(127, 13);
            this.lblRetypePassword.TabIndex = 6;
            this.lblRetypePassword.Text = "Re-Type Password";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserType.ForeColor = System.Drawing.Color.Red;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.cbxUserType.Location = new System.Drawing.Point(620, 3);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(146, 21);
            this.cbxUserType.TabIndex = 22;
            this.cbxUserType.SelectionChangeCommitted += new System.EventHandler(this.cbxUserType_SelectionChangeCommitted);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.Red;
            this.lblSelect.Location = new System.Drawing.Point(430, 6);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(117, 13);
            this.lblSelect.TabIndex = 21;
            this.lblSelect.Text = "Select User Type";
            // 
            // lblStrength1
            // 
            this.lblStrength1.AutoSize = true;
            this.lblStrength1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength1.ForeColor = System.Drawing.Color.Transparent;
            this.lblStrength1.Location = new System.Drawing.Point(313, 83);
            this.lblStrength1.Name = "lblStrength1";
            this.lblStrength1.Size = new System.Drawing.Size(17, 16);
            this.lblStrength1.TabIndex = 9;
            this.lblStrength1.Text = "*";
            // 
            // lblStrength2
            // 
            this.lblStrength2.AutoSize = true;
            this.lblStrength2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength2.ForeColor = System.Drawing.Color.Transparent;
            this.lblStrength2.Location = new System.Drawing.Point(331, 83);
            this.lblStrength2.Name = "lblStrength2";
            this.lblStrength2.Size = new System.Drawing.Size(17, 16);
            this.lblStrength2.TabIndex = 10;
            this.lblStrength2.Text = "*";
            // 
            // lblStrength3
            // 
            this.lblStrength3.AutoSize = true;
            this.lblStrength3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength3.ForeColor = System.Drawing.Color.Transparent;
            this.lblStrength3.Location = new System.Drawing.Point(350, 83);
            this.lblStrength3.Name = "lblStrength3";
            this.lblStrength3.Size = new System.Drawing.Size(17, 16);
            this.lblStrength3.TabIndex = 11;
            this.lblStrength3.Text = "*";
            // 
            // lblStrength4
            // 
            this.lblStrength4.AutoSize = true;
            this.lblStrength4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength4.ForeColor = System.Drawing.Color.Transparent;
            this.lblStrength4.Location = new System.Drawing.Point(367, 83);
            this.lblStrength4.Name = "lblStrength4";
            this.lblStrength4.Size = new System.Drawing.Size(17, 16);
            this.lblStrength4.TabIndex = 12;
            this.lblStrength4.Text = "*";
            // 
            // lblStrength5
            // 
            this.lblStrength5.AutoSize = true;
            this.lblStrength5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength5.ForeColor = System.Drawing.Color.Transparent;
            this.lblStrength5.Location = new System.Drawing.Point(384, 83);
            this.lblStrength5.Name = "lblStrength5";
            this.lblStrength5.Size = new System.Drawing.Size(17, 16);
            this.lblStrength5.TabIndex = 13;
            this.lblStrength5.Text = "*";
            // 
            // lblStrenght
            // 
            this.lblStrenght.AutoSize = true;
            this.lblStrenght.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrenght.ForeColor = System.Drawing.Color.Red;
            this.lblStrenght.Location = new System.Drawing.Point(313, 69);
            this.lblStrenght.Name = "lblStrenght";
            this.lblStrenght.Size = new System.Drawing.Size(63, 13);
            this.lblStrenght.TabIndex = 8;
            this.lblStrenght.Text = "Strength";
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblStrenght);
            this.Controls.Add(this.lblStrength5);
            this.Controls.Add(this.lblStrength4);
            this.Controls.Add(this.lblStrength3);
            this.Controls.Add(this.lblStrength2);
            this.Controls.Add(this.lblStrength1);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.txtRetypePassword);
            this.Controls.Add(this.lblRetypePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.rbtnDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUser);
            this.Controls.Add(this.rbtnChangePassword);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnchangePassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddNewUser";
            this.Text = "Add & Update User";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.gbxUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.RadioButton rbtnChangePassword;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnchangePassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtUserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MaskedTextBox txtRetypePassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblStrength1;
        private System.Windows.Forms.Label lblStrength2;
        private System.Windows.Forms.Label lblStrength3;
        private System.Windows.Forms.Label lblStrength4;
        private System.Windows.Forms.Label lblStrength5;
        private System.Windows.Forms.Label lblStrenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;

    }
}