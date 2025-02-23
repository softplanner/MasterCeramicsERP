namespace MasterCeramicsERP
{
    partial class frmAddNewPerson
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
            this.btnClearFeilds = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtxtName = new System.Windows.Forms.MaskedTextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.cbxJobs = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.mtxtNumber = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClearFeilds
            // 
            this.btnClearFeilds.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFeilds.ForeColor = System.Drawing.Color.Indigo;
            this.btnClearFeilds.Location = new System.Drawing.Point(217, 406);
            this.btnClearFeilds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearFeilds.Name = "btnClearFeilds";
            this.btnClearFeilds.Size = new System.Drawing.Size(82, 27);
            this.btnClearFeilds.TabIndex = 33;
            this.btnClearFeilds.Text = "Clear Text";
            this.btnClearFeilds.UseVisualStyleBackColor = true;
            this.btnClearFeilds.Click += new System.EventHandler(this.btnClearFeilds_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Indigo;
            this.lblAddress.Location = new System.Drawing.Point(3, 277);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 23);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Indigo;
            this.lblContact.Location = new System.Drawing.Point(3, 198);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(76, 23);
            this.lblContact.TabIndex = 14;
            this.lblContact.Text = "Contact";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasic.ForeColor = System.Drawing.Color.Indigo;
            this.lblBasic.Location = new System.Drawing.Point(3, 12);
            this.lblBasic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(56, 23);
            this.lblBasic.TabIndex = 0;
            this.lblBasic.Text = "Basic";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(128, 406);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 27);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mtxtName
            // 
            this.mtxtName.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtName.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtName.Location = new System.Drawing.Point(124, 72);
            this.mtxtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.Size = new System.Drawing.Size(186, 22);
            this.mtxtName.TabIndex = 4;
            this.mtxtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtName_MouseClick);
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreetAddress.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.ForeColor = System.Drawing.Color.Indigo;
            this.txtStreetAddress.Location = new System.Drawing.Point(128, 310);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(643, 73);
            this.txtStreetAddress.TabIndex = 29;
            // 
            // cbxJobs
            // 
            this.cbxJobs.BackColor = System.Drawing.SystemColors.Control;
            this.cbxJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobs.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJobs.ForeColor = System.Drawing.Color.Indigo;
            this.cbxJobs.FormattingEnabled = true;
            this.cbxJobs.Location = new System.Drawing.Point(124, 123);
            this.cbxJobs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxJobs.Name = "cbxJobs";
            this.cbxJobs.Size = new System.Drawing.Size(186, 23);
            this.cbxJobs.TabIndex = 8;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Indigo;
            this.lblNumber.Location = new System.Drawing.Point(13, 236);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 15);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "Contact #";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.ForeColor = System.Drawing.Color.Indigo;
            this.lblStreetAddress.Location = new System.Drawing.Point(13, 313);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(53, 15);
            this.lblStreetAddress.TabIndex = 28;
            this.lblStreetAddress.Text = "Address";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Indigo;
            this.lblJob.Location = new System.Drawing.Point(13, 126);
            this.lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(25, 15);
            this.lblJob.TabIndex = 7;
            this.lblJob.Text = "Job";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(13, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // mtxtID
            // 
            this.mtxtID.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtID.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtID.Location = new System.Drawing.Point(124, 48);
            this.mtxtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.Size = new System.Drawing.Size(186, 22);
            this.mtxtID.TabIndex = 2;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.Indigo;
            this.lblPersonID.Location = new System.Drawing.Point(13, 51);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(61, 15);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "Person ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.btnRefresh.Location = new System.Drawing.Point(306, 406);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 27);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.cbxCategory.Location = new System.Drawing.Point(124, 96);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(186, 23);
            this.cbxCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Indigo;
            this.lblCategory.Location = new System.Drawing.Point(13, 99);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtNumber.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumber.ForeColor = System.Drawing.Color.Indigo;
            this.mtxtNumber.Location = new System.Drawing.Point(124, 233);
            this.mtxtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtNumber.Multiline = true;
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(186, 43);
            this.mtxtNumber.TabIndex = 37;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Indigo;
            this.lblSalary.Location = new System.Drawing.Point(13, 154);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(82, 15);
            this.lblSalary.TabIndex = 38;
            this.lblSalary.Text = "Salary/Wages";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalary.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(128, 152);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(182, 21);
            this.txtSalary.TabIndex = 39;
            this.txtSalary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSalary_MouseClick);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // frmAddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.mtxtNumber);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.mtxtID);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.btnClearFeilds);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mtxtName);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.cbxJobs);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddNewPerson";
            this.Text = "Add NewPerson";
            this.Load += new System.EventHandler(this.frmAddNewPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearFeilds;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtxtName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.ComboBox cbxJobs;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox mtxtNumber;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;

    }
}