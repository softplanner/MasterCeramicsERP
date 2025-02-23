namespace MasterCeramicsERP
{
    partial class Main
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
            this.btnBackupDB = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackupDB
            // 
            this.btnBackupDB.Location = new System.Drawing.Point(40, 34);
            this.btnBackupDB.Name = "btnBackupDB";
            this.btnBackupDB.Size = new System.Drawing.Size(75, 23);
            this.btnBackupDB.TabIndex = 0;
            this.btnBackupDB.Text = "Manage DB";
            this.btnBackupDB.UseVisualStyleBackColor = true;
            this.btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(121, 34);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(75, 23);
            this.btnAdministrator.TabIndex = 1;
            this.btnAdministrator.Text = "Admin";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(40, 63);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.Location = new System.Drawing.Point(121, 63);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(75, 23);
            this.btnPayroll.TabIndex = 3;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(81, 92);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 23);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.btnBackupDB);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackupDB;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnSales;
    }
}