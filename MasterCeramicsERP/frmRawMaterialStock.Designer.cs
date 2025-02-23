namespace MasterCeramicsERP
{
    partial class frmRawMaterialStock
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
            this.dgvRawMaterialStock = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAlarmQuantity = new System.Windows.Forms.Label();
            this.mtxtName = new System.Windows.Forms.MaskedTextBox();
            this.mtxtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAlarmQuantity = new System.Windows.Forms.MaskedTextBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnDeduct = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxRawMaterialStock = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialStock)).BeginInit();
            this.gbxRawMaterialStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRawMaterialStock
            // 
            this.dgvRawMaterialStock.AllowUserToAddRows = false;
            this.dgvRawMaterialStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRawMaterialStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterialStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.vendorName,
            this.Quantity,
            this.alarmQuantity});
            this.dgvRawMaterialStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMaterialStock.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvRawMaterialStock.Location = new System.Drawing.Point(3, 17);
            this.dgvRawMaterialStock.Name = "dgvRawMaterialStock";
            this.dgvRawMaterialStock.ReadOnly = true;
            this.dgvRawMaterialStock.Size = new System.Drawing.Size(772, 346);
            this.dgvRawMaterialStock.TabIndex = 0;
            this.dgvRawMaterialStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRawMaterialStock_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // vendorName
            // 
            this.vendorName.HeaderText = "Name";
            this.vendorName.Name = "vendorName";
            this.vendorName.ReadOnly = true;
            this.vendorName.Width = 378;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // alarmQuantity
            // 
            this.alarmQuantity.HeaderText = "Alarm Quantity";
            this.alarmQuantity.Name = "alarmQuantity";
            this.alarmQuantity.ReadOnly = true;
            this.alarmQuantity.Width = 150;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblQuantity.Location = new System.Drawing.Point(12, 57);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAlarmQuantity
            // 
            this.lblAlarmQuantity.AutoSize = true;
            this.lblAlarmQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblAlarmQuantity.Location = new System.Drawing.Point(12, 97);
            this.lblAlarmQuantity.Name = "lblAlarmQuantity";
            this.lblAlarmQuantity.Size = new System.Drawing.Size(105, 13);
            this.lblAlarmQuantity.TabIndex = 4;
            this.lblAlarmQuantity.Text = "Alarm Quantity";
            // 
            // mtxtName
            // 
            this.mtxtName.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.mtxtName.Location = new System.Drawing.Point(123, 15);
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.Size = new System.Drawing.Size(566, 21);
            this.mtxtName.TabIndex = 1;
            // 
            // mtxtQuantity
            // 
            this.mtxtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.mtxtQuantity.Location = new System.Drawing.Point(123, 51);
            this.mtxtQuantity.Name = "mtxtQuantity";
            this.mtxtQuantity.Size = new System.Drawing.Size(566, 21);
            this.mtxtQuantity.TabIndex = 3;
            this.mtxtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtQuantity_MouseClick);
            this.mtxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtQuantity_KeyPress);
            // 
            // mtxtAlarmQuantity
            // 
            this.mtxtAlarmQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtAlarmQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtAlarmQuantity.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.mtxtAlarmQuantity.Location = new System.Drawing.Point(123, 91);
            this.mtxtAlarmQuantity.Name = "mtxtAlarmQuantity";
            this.mtxtAlarmQuantity.Size = new System.Drawing.Size(566, 21);
            this.mtxtAlarmQuantity.TabIndex = 5;
            this.mtxtAlarmQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtAlarmQuantity_MouseClick);
            this.mtxtAlarmQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtAlarmQuantity_KeyPress);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbtnAdd.Location = new System.Drawing.Point(700, 19);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(50, 17);
            this.rbtnAdd.TabIndex = 6;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnDeduct
            // 
            this.rbtnDeduct.AutoSize = true;
            this.rbtnDeduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDeduct.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbtnDeduct.Location = new System.Drawing.Point(700, 42);
            this.rbtnDeduct.Name = "rbtnDeduct";
            this.rbtnDeduct.Size = new System.Drawing.Size(70, 17);
            this.rbtnDeduct.TabIndex = 7;
            this.rbtnDeduct.TabStop = true;
            this.rbtnDeduct.Text = "Deduct";
            this.rbtnDeduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.Location = new System.Drawing.Point(696, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefresh.Location = new System.Drawing.Point(695, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUpdate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbtnUpdate.Location = new System.Drawing.Point(700, 65);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(71, 17);
            this.rbtnUpdate.TabIndex = 8;
            this.rbtnUpdate.TabStop = true;
            this.rbtnUpdate.Text = "Update";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            this.rbtnUpdate.CheckedChanged += new System.EventHandler(this.rbtnUpdate_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDelete.Location = new System.Drawing.Point(614, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxRawMaterialStock
            // 
            this.gbxRawMaterialStock.Controls.Add(this.dgvRawMaterialStock);
            this.gbxRawMaterialStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRawMaterialStock.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.gbxRawMaterialStock.Location = new System.Drawing.Point(3, 147);
            this.gbxRawMaterialStock.Name = "gbxRawMaterialStock";
            this.gbxRawMaterialStock.Size = new System.Drawing.Size(778, 366);
            this.gbxRawMaterialStock.TabIndex = 12;
            this.gbxRawMaterialStock.TabStop = false;
            this.gbxRawMaterialStock.Text = "Raw Material Stock Report";
            // 
            // frmRawMaterialStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxRawMaterialStock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rbtnUpdate);
            this.Controls.Add(this.rbtnDeduct);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.mtxtAlarmQuantity);
            this.Controls.Add(this.mtxtQuantity);
            this.Controls.Add(this.mtxtName);
            this.Controls.Add(this.lblAlarmQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmRawMaterialStock";
            this.Text = "Add & Update Raw Material Stock";
            this.Load += new System.EventHandler(this.frmRawMaterialStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialStock)).EndInit();
            this.gbxRawMaterialStock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRawMaterialStock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAlarmQuantity;
        private System.Windows.Forms.MaskedTextBox mtxtName;
        private System.Windows.Forms.MaskedTextBox mtxtQuantity;
        private System.Windows.Forms.MaskedTextBox mtxtAlarmQuantity;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnDeduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxRawMaterialStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmQuantity;
    }
}