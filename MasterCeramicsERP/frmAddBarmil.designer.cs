namespace MasterCeramicsERP
{
    partial class frmAddBarmil
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBarmil = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtxtWeight = new System.Windows.Forms.MaskedTextBox();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.gbxBarmil = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarmil)).BeginInit();
            this.gbxBarmil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Crimson;
            this.btnAdd.Location = new System.Drawing.Point(663, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvBarmil.GridColor = System.Drawing.Color.Crimson;
            this.dgvBarmil.Location = new System.Drawing.Point(3, 17);
            this.dgvBarmil.Name = "dgvBarmil";
            this.dgvBarmil.ReadOnly = true;
            this.dgvBarmil.Size = new System.Drawing.Size(526, 496);
            this.dgvBarmil.TabIndex = 0;
            this.dgvBarmil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarmil_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 120;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 460;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Crimson;
            this.lblID.Location = new System.Drawing.Point(542, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(72, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "BallMill ID";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Crimson;
            this.lblWeight.Location = new System.Drawing.Point(542, 70);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Location = new System.Drawing.Point(663, 242);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 22);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh Database";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(663, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtxtWeight
            // 
            this.mtxtWeight.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtWeight.BeepOnError = true;
            this.mtxtWeight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtWeight.ForeColor = System.Drawing.Color.Crimson;
            this.mtxtWeight.Location = new System.Drawing.Point(663, 69);
            this.mtxtWeight.Name = "mtxtWeight";
            this.mtxtWeight.Size = new System.Drawing.Size(119, 21);
            this.mtxtWeight.TabIndex = 4;
            this.mtxtWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtWeight_MouseClick);
            this.mtxtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtWeight_KeyPress);
            // 
            // mtxtID
            // 
            this.mtxtID.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtID.BeepOnError = true;
            this.mtxtID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtID.ForeColor = System.Drawing.Color.Crimson;
            this.mtxtID.Location = new System.Drawing.Point(664, 44);
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.Size = new System.Drawing.Size(118, 21);
            this.mtxtID.TabIndex = 2;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.ForeColor = System.Drawing.Color.Crimson;
            this.rbtnAdd.Location = new System.Drawing.Point(663, 116);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(50, 17);
            this.rbtnAdd.TabIndex = 5;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.rbtnAdd_CheckedChanged);
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.rbtnDelete.Location = new System.Drawing.Point(663, 139);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(67, 17);
            this.rbtnDelete.TabIndex = 7;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "Delete";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            this.rbtnDelete.CheckedChanged += new System.EventHandler(this.rbtnDelete_CheckedChanged);
            // 
            // gbxBarmil
            // 
            this.gbxBarmil.Controls.Add(this.dgvBarmil);
            this.gbxBarmil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBarmil.ForeColor = System.Drawing.Color.Crimson;
            this.gbxBarmil.Location = new System.Drawing.Point(4, 6);
            this.gbxBarmil.Name = "gbxBarmil";
            this.gbxBarmil.Size = new System.Drawing.Size(532, 516);
            this.gbxBarmil.TabIndex = 0;
            this.gbxBarmil.TabStop = false;
            this.gbxBarmil.Text = "BallMill";
            // 
            // frmAddBarmil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 527);
            this.Controls.Add(this.gbxBarmil);
            this.Controls.Add(this.rbtnDelete);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.mtxtID);
            this.Controls.Add(this.mtxtWeight);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmAddBarmil";
            this.Text = "Add & Update Ball Mill";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.frmAddBarmil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarmil)).EndInit();
            this.gbxBarmil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBarmil;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox mtxtWeight;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.GroupBox gbxBarmil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
    }
}