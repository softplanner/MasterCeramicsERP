namespace MasterCeramicsERP
{
    partial class salesAddSubDealer
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
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtDealer = new System.Windows.Forms.TextBox();
            this.txtSubDealer = new System.Windows.Forms.TextBox();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.dgvSelectedCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSelectJobChecker = new System.Windows.Forms.Label();
            this.cbxJobChecker = new System.Windows.Forms.ComboBox();
            this.lblChecker = new System.Windows.Forms.Label();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.cbxChecker = new System.Windows.Forms.ComboBox();
            this.gbxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.Maroon;
            this.lblDealer.Location = new System.Drawing.Point(11, 239);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(50, 13);
            this.lblDealer.TabIndex = 4;
            this.lblDealer.Text = "Dealer";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Maroon;
            this.lblCustomer.Location = new System.Drawing.Point(11, 295);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(78, 13);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Sub Dealer";
            // 
            // txtDealer
            // 
            this.txtDealer.ForeColor = System.Drawing.Color.Maroon;
            this.txtDealer.Location = new System.Drawing.Point(13, 255);
            this.txtDealer.Name = "txtDealer";
            this.txtDealer.ReadOnly = true;
            this.txtDealer.Size = new System.Drawing.Size(290, 20);
            this.txtDealer.TabIndex = 5;
            // 
            // txtSubDealer
            // 
            this.txtSubDealer.ForeColor = System.Drawing.Color.Maroon;
            this.txtSubDealer.Location = new System.Drawing.Point(13, 311);
            this.txtSubDealer.Name = "txtSubDealer";
            this.txtSubDealer.ReadOnly = true;
            this.txtSubDealer.Size = new System.Drawing.Size(290, 20);
            this.txtSubDealer.TabIndex = 7;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.dgvSelectedCustomers);
            this.gbxCustomer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomer.ForeColor = System.Drawing.Color.Maroon;
            this.gbxCustomer.Location = new System.Drawing.Point(312, 7);
            this.gbxCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomer.Size = new System.Drawing.Size(465, 503);
            this.gbxCustomer.TabIndex = 1;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Sub Dealer";
            // 
            // dgvSelectedCustomers
            // 
            this.dgvSelectedCustomers.AllowUserToAddRows = false;
            this.dgvSelectedCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSelectedCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedCustomers.GridColor = System.Drawing.Color.Maroon;
            this.dgvSelectedCustomers.Location = new System.Drawing.Point(4, 17);
            this.dgvSelectedCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSelectedCustomers.Name = "dgvSelectedCustomers";
            this.dgvSelectedCustomers.ReadOnly = true;
            this.dgvSelectedCustomers.Size = new System.Drawing.Size(457, 483);
            this.dgvSelectedCustomers.TabIndex = 0;
            this.dgvSelectedCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedCustomers_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 350;
            // 
            // txtShopName
            // 
            this.txtShopName.BackColor = System.Drawing.SystemColors.Control;
            this.txtShopName.ForeColor = System.Drawing.Color.Maroon;
            this.txtShopName.Location = new System.Drawing.Point(13, 362);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(290, 20);
            this.txtShopName.TabIndex = 9;
            this.txtShopName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtShopName_MouseClick);
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.Maroon;
            this.lblShopName.Location = new System.Drawing.Point(11, 342);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(80, 13);
            this.lblShopName.TabIndex = 8;
            this.lblShopName.Text = "Shop Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(15, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Assingn new sub dealer ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Maroon;
            this.btnRefresh.Location = new System.Drawing.Point(13, 487);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(181, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(13, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete sub dealer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Location = new System.Drawing.Point(13, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(181, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update shop name";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSelectJobChecker
            // 
            this.lblSelectJobChecker.AutoSize = true;
            this.lblSelectJobChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJobChecker.ForeColor = System.Drawing.Color.Maroon;
            this.lblSelectJobChecker.Location = new System.Drawing.Point(12, 108);
            this.lblSelectJobChecker.Name = "lblSelectJobChecker";
            this.lblSelectJobChecker.Size = new System.Drawing.Size(168, 13);
            this.lblSelectJobChecker.TabIndex = 34;
            this.lblSelectJobChecker.Text = "Select job for sub dealer";
            // 
            // cbxJobChecker
            // 
            this.cbxJobChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJobChecker.ForeColor = System.Drawing.Color.Maroon;
            this.cbxJobChecker.FormattingEnabled = true;
            this.cbxJobChecker.Location = new System.Drawing.Point(12, 124);
            this.cbxJobChecker.Name = "cbxJobChecker";
            this.cbxJobChecker.Size = new System.Drawing.Size(293, 21);
            this.cbxJobChecker.TabIndex = 35;
            this.cbxJobChecker.SelectionChangeCommitted += new System.EventHandler(this.cbxJobChecker_SelectionChangeCommitted);
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecker.ForeColor = System.Drawing.Color.Maroon;
            this.lblChecker.Location = new System.Drawing.Point(12, 157);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(88, 13);
            this.lblChecker.TabIndex = 32;
            this.lblChecker.Text = "Sub dealer\'s";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.Maroon;
            this.lblSelectJob.Location = new System.Drawing.Point(12, 7);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(141, 13);
            this.lblSelectJob.TabIndex = 30;
            this.lblSelectJob.Text = "Select job for dealer";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.Maroon;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(12, 23);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(293, 21);
            this.cbxSelectJob.TabIndex = 31;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.Maroon;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(12, 70);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(293, 21);
            this.cbxWorker.TabIndex = 29;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.Maroon;
            this.lblWorker.Location = new System.Drawing.Point(12, 54);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(50, 13);
            this.lblWorker.TabIndex = 28;
            this.lblWorker.Text = "Dealer";
            // 
            // cbxChecker
            // 
            this.cbxChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChecker.ForeColor = System.Drawing.Color.Maroon;
            this.cbxChecker.FormattingEnabled = true;
            this.cbxChecker.Location = new System.Drawing.Point(12, 173);
            this.cbxChecker.Name = "cbxChecker";
            this.cbxChecker.Size = new System.Drawing.Size(293, 21);
            this.cbxChecker.TabIndex = 36;
            this.cbxChecker.SelectionChangeCommitted += new System.EventHandler(this.cbxChecker_SelectionChangeCommitted_1);
            // 
            // salesAddSubDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.cbxChecker);
            this.Controls.Add(this.lblSelectJobChecker);
            this.Controls.Add(this.cbxJobChecker);
            this.Controls.Add(this.lblChecker);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.gbxCustomer);
            this.Controls.Add(this.txtSubDealer);
            this.Controls.Add(this.txtDealer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblDealer);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "salesAddSubDealer";
            this.Text = "Add Sub-Dealer";
            this.Load += new System.EventHandler(this.salesAddSubDealer_Load);
            this.gbxCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtDealer;
        private System.Windows.Forms.TextBox txtSubDealer;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.DataGridView dgvSelectedCustomers;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSelectJobChecker;
        private System.Windows.Forms.ComboBox cbxJobChecker;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cbxChecker;
    }
}