namespace MasterCeramicsERP
{
    partial class frmAddKillen
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
            this.gbxBarmil = new System.Windows.Forms.GroupBox();
            this.dgvBarmil = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.mtxtName = new System.Windows.Forms.MaskedTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxBarmil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarmil)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtnDelete.Location = new System.Drawing.Point(596, 178);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(67, 17);
            this.rbtnDelete.TabIndex = 7;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "Delete";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            this.rbtnDelete.CheckedChanged += new System.EventHandler(this.rbtnDelete_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Location = new System.Drawing.Point(683, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxBarmil
            // 
            this.gbxBarmil.Controls.Add(this.dgvBarmil);
            this.gbxBarmil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBarmil.ForeColor = System.Drawing.Color.Firebrick;
            this.gbxBarmil.Location = new System.Drawing.Point(6, 6);
            this.gbxBarmil.Name = "gbxBarmil";
            this.gbxBarmil.Size = new System.Drawing.Size(502, 504);
            this.gbxBarmil.TabIndex = 0;
            this.gbxBarmil.TabStop = false;
            this.gbxBarmil.Text = "Killen";
            // 
            // dgvBarmil
            // 
            this.dgvBarmil.AllowUserToAddRows = false;
            this.dgvBarmil.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBarmil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarmil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.weight});
            this.dgvBarmil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarmil.GridColor = System.Drawing.Color.Firebrick;
            this.dgvBarmil.Location = new System.Drawing.Point(3, 17);
            this.dgvBarmil.Name = "dgvBarmil";
            this.dgvBarmil.ReadOnly = true;
            this.dgvBarmil.Size = new System.Drawing.Size(496, 484);
            this.dgvBarmil.TabIndex = 0;
            this.dgvBarmil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarmil_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // weight
            // 
            this.weight.HeaderText = "Name";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 405;
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUpdate.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtnUpdate.Location = new System.Drawing.Point(596, 149);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(71, 17);
            this.rbtnUpdate.TabIndex = 6;
            this.rbtnUpdate.TabStop = true;
            this.rbtnUpdate.Text = "Update";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            this.rbtnUpdate.CheckedChanged += new System.EventHandler(this.rbtnUpdate_CheckedChanged);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.ForeColor = System.Drawing.Color.Firebrick;
            this.rbtnAdd.Location = new System.Drawing.Point(596, 120);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(50, 17);
            this.rbtnAdd.TabIndex = 5;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.rbtnAdd_CheckedChanged);
            // 
            // mtxtID
            // 
            this.mtxtID.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtID.BeepOnError = true;
            this.mtxtID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtID.ForeColor = System.Drawing.Color.Firebrick;
            this.mtxtID.Location = new System.Drawing.Point(596, 53);
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.ReadOnly = true;
            this.mtxtID.Size = new System.Drawing.Size(174, 21);
            this.mtxtID.TabIndex = 2;
            // 
            // mtxtName
            // 
            this.mtxtName.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtName.BeepOnError = true;
            this.mtxtName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtName.ForeColor = System.Drawing.Color.Firebrick;
            this.mtxtName.Location = new System.Drawing.Point(596, 79);
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.Size = new System.Drawing.Size(175, 21);
            this.mtxtName.TabIndex = 4;
            this.mtxtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtName_MouseClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Firebrick;
            this.btnRefresh.Location = new System.Drawing.Point(596, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh Database";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUpdate.Location = new System.Drawing.Point(683, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(514, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblID.Location = new System.Drawing.Point(514, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Killen ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAdd.Location = new System.Drawing.Point(683, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddKillen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.rbtnDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxBarmil);
            this.Controls.Add(this.rbtnUpdate);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.mtxtID);
            this.Controls.Add(this.mtxtName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddKillen";
            this.Text = "Add & Update Killen";
            this.Load += new System.EventHandler(this.frmAddKillen_Load);
            this.gbxBarmil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarmil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxBarmil;
        private System.Windows.Forms.DataGridView dgvBarmil;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.MaskedTextBox mtxtName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
    }
}