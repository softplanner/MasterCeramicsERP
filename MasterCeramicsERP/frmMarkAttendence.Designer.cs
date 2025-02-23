namespace MasterCeramicsERP
{
    partial class frmMarkAttendence
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
            this.btnMarkAttendence = new System.Windows.Forms.Button();
            this.lblExtraAttandance = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpAttandance = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.dgvPerson);
            this.gbxPerson.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPerson.ForeColor = System.Drawing.Color.Maroon;
            this.gbxPerson.Location = new System.Drawing.Point(13, 67);
            this.gbxPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxPerson.Size = new System.Drawing.Size(759, 438);
            this.gbxPerson.TabIndex = 0;
            this.gbxPerson.TabStop = false;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Worker});
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.GridColor = System.Drawing.Color.Maroon;
            this.dgvPerson.Location = new System.Drawing.Point(4, 17);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(751, 418);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            // 
            // btnMarkAttendence
            // 
            this.btnMarkAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAttendence.ForeColor = System.Drawing.Color.Maroon;
            this.btnMarkAttendence.Location = new System.Drawing.Point(12, 38);
            this.btnMarkAttendence.Name = "btnMarkAttendence";
            this.btnMarkAttendence.Size = new System.Drawing.Size(164, 23);
            this.btnMarkAttendence.TabIndex = 2;
            this.btnMarkAttendence.Text = "Mark Attendance";
            this.btnMarkAttendence.UseVisualStyleBackColor = true;
            this.btnMarkAttendence.Click += new System.EventHandler(this.btnMarkAttendence_Click);
            // 
            // lblExtraAttandance
            // 
            this.lblExtraAttandance.AutoSize = true;
            this.lblExtraAttandance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraAttandance.ForeColor = System.Drawing.Color.Maroon;
            this.lblExtraAttandance.Location = new System.Drawing.Point(234, 12);
            this.lblExtraAttandance.Name = "lblExtraAttandance";
            this.lblExtraAttandance.Size = new System.Drawing.Size(120, 13);
            this.lblExtraAttandance.TabIndex = 11;
            this.lblExtraAttandance.Text = "Extra Attendance";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(237, 38);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(117, 21);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // dtpAttandance
            // 
            this.dtpAttandance.Location = new System.Drawing.Point(12, 12);
            this.dtpAttandance.Name = "dtpAttandance";
            this.dtpAttandance.Size = new System.Drawing.Size(200, 20);
            this.dtpAttandance.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(360, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Mark Extra Attandance";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Worker
            // 
            this.Worker.DataPropertyName = "Worker";
            this.Worker.HeaderText = "Worker";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            this.Worker.Width = 700;
            // 
            // frmMarkAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpAttandance);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblExtraAttandance);
            this.Controls.Add(this.btnMarkAttendence);
            this.Controls.Add(this.gbxPerson);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMarkAttendence";
            this.Text = "Save";
            this.Load += new System.EventHandler(this.frmMarkAttendence_Load);
            this.gbxPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btnMarkAttendence;
        private System.Windows.Forms.Label lblExtraAttandance;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpAttandance;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
    }
}