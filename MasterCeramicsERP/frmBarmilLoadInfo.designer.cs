namespace MasterCeramicsERP
{
    partial class frmbarmilLoadInfo
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
            this.dgvUnloadbarmil = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.chkbxBarmilLoading = new System.Windows.Forms.CheckBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.gbxBarmilLoading = new System.Windows.Forms.GroupBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.mtxtSlip = new System.Windows.Forms.MaskedTextBox();
            this.lblSlip = new System.Windows.Forms.Label();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.mtxtWeight = new System.Windows.Forms.MaskedTextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvBarmil = new System.Windows.Forms.DataGridView();
            this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxUnLoadBarmil = new System.Windows.Forms.GroupBox();
            this.chkbxRawMaterial = new System.Windows.Forms.CheckBox();
            this.chkbxAddToStock = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkbxUnloadBarmil = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unloadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barmilMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnloadbarmil)).BeginInit();
            this.gbxBarmilLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarmil)).BeginInit();
            this.gbxUnLoadBarmil.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUnloadbarmil
            // 
            this.dgvUnloadbarmil.AllowUserToAddRows = false;
            this.dgvUnloadbarmil.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUnloadbarmil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnloadbarmil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.weight,
            this.loadDate,
            this.unloadDate,
            this.barmilMan,
            this.Status});
            this.dgvUnloadbarmil.GridColor = System.Drawing.Color.Crimson;
            this.dgvUnloadbarmil.Location = new System.Drawing.Point(9, 20);
            this.dgvUnloadbarmil.Name = "dgvUnloadbarmil";
            this.dgvUnloadbarmil.ReadOnly = true;
            this.dgvUnloadbarmil.Size = new System.Drawing.Size(753, 181);
            this.dgvUnloadbarmil.TabIndex = 0;
            this.dgvUnloadbarmil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnloadbarmil_CellClick);
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.Color.Crimson;
            this.btnLoad.Location = new System.Drawing.Point(614, 164);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load Barmil";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUnload
            // 
            this.btnUnload.ForeColor = System.Drawing.Color.Crimson;
            this.btnUnload.Location = new System.Drawing.Point(375, 203);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(107, 23);
            this.btnUnload.TabIndex = 2;
            this.btnUnload.Text = "UnLoad Barmil";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // chkbxBarmilLoading
            // 
            this.chkbxBarmilLoading.AutoSize = true;
            this.chkbxBarmilLoading.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxBarmilLoading.ForeColor = System.Drawing.Color.Crimson;
            this.chkbxBarmilLoading.Location = new System.Drawing.Point(11, 1);
            this.chkbxBarmilLoading.Name = "chkbxBarmilLoading";
            this.chkbxBarmilLoading.Size = new System.Drawing.Size(129, 17);
            this.chkbxBarmilLoading.TabIndex = 0;
            this.chkbxBarmilLoading.Text = "Ballmill Loading";
            this.chkbxBarmilLoading.UseVisualStyleBackColor = true;
            this.chkbxBarmilLoading.CheckedChanged += new System.EventHandler(this.chkbxBarmilLoading_CheckedChanged);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.ForeColor = System.Drawing.Color.Crimson;
            this.lblWorker.Location = new System.Drawing.Point(535, 60);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(69, 13);
            this.lblWorker.TabIndex = 1;
            this.lblWorker.Text = "Ballmiller";
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.ForeColor = System.Drawing.Color.Crimson;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(614, 57);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(151, 21);
            this.cbxWorker.TabIndex = 2;
            // 
            // gbxBarmilLoading
            // 
            this.gbxBarmilLoading.Controls.Add(this.lblUnit);
            this.gbxBarmilLoading.Controls.Add(this.lblSelectJob);
            this.gbxBarmilLoading.Controls.Add(this.cbxSelectJob);
            this.gbxBarmilLoading.Controls.Add(this.mtxtSlip);
            this.gbxBarmilLoading.Controls.Add(this.lblSlip);
            this.gbxBarmilLoading.Controls.Add(this.mtxtID);
            this.gbxBarmilLoading.Controls.Add(this.mtxtWeight);
            this.gbxBarmilLoading.Controls.Add(this.lblWeight);
            this.gbxBarmilLoading.Controls.Add(this.lblID);
            this.gbxBarmilLoading.Controls.Add(this.dgvBarmil);
            this.gbxBarmilLoading.Controls.Add(this.btnLoad);
            this.gbxBarmilLoading.Controls.Add(this.cbxWorker);
            this.gbxBarmilLoading.Controls.Add(this.lblWorker);
            this.gbxBarmilLoading.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBarmilLoading.ForeColor = System.Drawing.Color.Crimson;
            this.gbxBarmilLoading.Location = new System.Drawing.Point(4, 19);
            this.gbxBarmilLoading.Name = "gbxBarmilLoading";
            this.gbxBarmilLoading.Size = new System.Drawing.Size(773, 236);
            this.gbxBarmilLoading.TabIndex = 1;
            this.gbxBarmilLoading.TabStop = false;
            this.gbxBarmilLoading.Text = "Ballmill Loading";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.Color.Crimson;
            this.lblUnit.Location = new System.Drawing.Point(742, 142);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(23, 13);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "Kg";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.Crimson;
            this.lblSelectJob.Location = new System.Drawing.Point(535, 33);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 10;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.Crimson;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(614, 30);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(153, 21);
            this.cbxSelectJob.TabIndex = 11;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // mtxtSlip
            // 
            this.mtxtSlip.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtSlip.Enabled = false;
            this.mtxtSlip.ForeColor = System.Drawing.Color.Crimson;
            this.mtxtSlip.Location = new System.Drawing.Point(614, 137);
            this.mtxtSlip.Name = "mtxtSlip";
            this.mtxtSlip.Size = new System.Drawing.Size(126, 21);
            this.mtxtSlip.TabIndex = 8;
            // 
            // lblSlip
            // 
            this.lblSlip.AutoSize = true;
            this.lblSlip.ForeColor = System.Drawing.Color.Crimson;
            this.lblSlip.Location = new System.Drawing.Point(535, 142);
            this.lblSlip.Name = "lblSlip";
            this.lblSlip.Size = new System.Drawing.Size(31, 13);
            this.lblSlip.TabIndex = 7;
            this.lblSlip.Text = "Slip";
            // 
            // mtxtID
            // 
            this.mtxtID.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtID.Enabled = false;
            this.mtxtID.ForeColor = System.Drawing.Color.Crimson;
            this.mtxtID.Location = new System.Drawing.Point(614, 84);
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.Size = new System.Drawing.Size(151, 21);
            this.mtxtID.TabIndex = 4;
            // 
            // mtxtWeight
            // 
            this.mtxtWeight.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtWeight.Enabled = false;
            this.mtxtWeight.ForeColor = System.Drawing.Color.Crimson;
            this.mtxtWeight.Location = new System.Drawing.Point(614, 110);
            this.mtxtWeight.Name = "mtxtWeight";
            this.mtxtWeight.Size = new System.Drawing.Size(151, 21);
            this.mtxtWeight.TabIndex = 6;
            this.mtxtWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtWeight_MouseClick);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ForeColor = System.Drawing.Color.Crimson;
            this.lblWeight.Location = new System.Drawing.Point(535, 115);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 13);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Crimson;
            this.lblID.Location = new System.Drawing.Point(535, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Ballmil ID";
            // 
            // dgvBarmil
            // 
            this.dgvBarmil.AllowUserToAddRows = false;
            this.dgvBarmil.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBarmil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarmil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ids,
            this.weights});
            this.dgvBarmil.GridColor = System.Drawing.Color.Crimson;
            this.dgvBarmil.Location = new System.Drawing.Point(6, 18);
            this.dgvBarmil.Name = "dgvBarmil";
            this.dgvBarmil.ReadOnly = true;
            this.dgvBarmil.Size = new System.Drawing.Size(526, 212);
            this.dgvBarmil.TabIndex = 0;
            this.dgvBarmil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarmil_CellClick_1);
            // 
            // ids
            // 
            this.ids.HeaderText = "ID";
            this.ids.Name = "ids";
            this.ids.ReadOnly = true;
            // 
            // weights
            // 
            this.weights.HeaderText = "Weight (Kg)";
            this.weights.Name = "weights";
            this.weights.ReadOnly = true;
            this.weights.Width = 385;
            // 
            // gbxUnLoadBarmil
            // 
            this.gbxUnLoadBarmil.Controls.Add(this.chkbxRawMaterial);
            this.gbxUnLoadBarmil.Controls.Add(this.chkbxAddToStock);
            this.gbxUnLoadBarmil.Controls.Add(this.btnRefresh);
            this.gbxUnLoadBarmil.Controls.Add(this.dgvUnloadbarmil);
            this.gbxUnLoadBarmil.Controls.Add(this.btnUnload);
            this.gbxUnLoadBarmil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUnLoadBarmil.ForeColor = System.Drawing.Color.Crimson;
            this.gbxUnLoadBarmil.Location = new System.Drawing.Point(7, 280);
            this.gbxUnLoadBarmil.Name = "gbxUnLoadBarmil";
            this.gbxUnLoadBarmil.Size = new System.Drawing.Size(770, 232);
            this.gbxUnLoadBarmil.TabIndex = 3;
            this.gbxUnLoadBarmil.TabStop = false;
            this.gbxUnLoadBarmil.Text = "Unload Ballmill";
            // 
            // chkbxRawMaterial
            // 
            this.chkbxRawMaterial.AutoSize = true;
            this.chkbxRawMaterial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxRawMaterial.ForeColor = System.Drawing.Color.Crimson;
            this.chkbxRawMaterial.Location = new System.Drawing.Point(152, 208);
            this.chkbxRawMaterial.Name = "chkbxRawMaterial";
            this.chkbxRawMaterial.Size = new System.Drawing.Size(159, 17);
            this.chkbxRawMaterial.TabIndex = 4;
            this.chkbxRawMaterial.Text = "Update Raw Material";
            this.chkbxRawMaterial.UseVisualStyleBackColor = true;
            // 
            // chkbxAddToStock
            // 
            this.chkbxAddToStock.AutoSize = true;
            this.chkbxAddToStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxAddToStock.ForeColor = System.Drawing.Color.Crimson;
            this.chkbxAddToStock.Location = new System.Drawing.Point(8, 208);
            this.chkbxAddToStock.Name = "chkbxAddToStock";
            this.chkbxAddToStock.Size = new System.Drawing.Size(138, 17);
            this.chkbxAddToStock.TabIndex = 1;
            this.chkbxAddToStock.Text = "Add slip to stock ";
            this.chkbxAddToStock.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Location = new System.Drawing.Point(488, 203);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkbxUnloadBarmil
            // 
            this.chkbxUnloadBarmil.AutoSize = true;
            this.chkbxUnloadBarmil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUnloadBarmil.ForeColor = System.Drawing.Color.Crimson;
            this.chkbxUnloadBarmil.Location = new System.Drawing.Point(7, 260);
            this.chkbxUnloadBarmil.Name = "chkbxUnloadBarmil";
            this.chkbxUnloadBarmil.Size = new System.Drawing.Size(143, 17);
            this.chkbxUnloadBarmil.TabIndex = 2;
            this.chkbxUnloadBarmil.Text = "Ballmill Unloading";
            this.chkbxUnloadBarmil.UseVisualStyleBackColor = true;
            this.chkbxUnloadBarmil.CheckedChanged += new System.EventHandler(this.chkbxUnloadBarmil_CheckedChanged_1);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight (Kg)";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // loadDate
            // 
            this.loadDate.HeaderText = "Load Date";
            this.loadDate.Name = "loadDate";
            this.loadDate.ReadOnly = true;
            this.loadDate.Width = 125;
            // 
            // unloadDate
            // 
            this.unloadDate.HeaderText = "Unload Date";
            this.unloadDate.Name = "unloadDate";
            this.unloadDate.ReadOnly = true;
            this.unloadDate.Width = 125;
            // 
            // barmilMan
            // 
            this.barmilMan.HeaderText = "Ballmiller";
            this.barmilMan.Name = "barmilMan";
            this.barmilMan.ReadOnly = true;
            this.barmilMan.Width = 160;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frmbarmilLoadInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.chkbxUnloadBarmil);
            this.Controls.Add(this.gbxUnLoadBarmil);
            this.Controls.Add(this.gbxBarmilLoading);
            this.Controls.Add(this.chkbxBarmilLoading);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmbarmilLoadInfo";
            this.Text = "Add & Update Ball Mill Load Info";
            this.Load += new System.EventHandler(this.frmbarmilLoadInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnloadbarmil)).EndInit();
            this.gbxBarmilLoading.ResumeLayout(false);
            this.gbxBarmilLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarmil)).EndInit();
            this.gbxUnLoadBarmil.ResumeLayout(false);
            this.gbxUnLoadBarmil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnloadbarmil;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.CheckBox chkbxBarmilLoading;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.GroupBox gbxBarmilLoading;
        private System.Windows.Forms.DataGridView dgvBarmil;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.MaskedTextBox mtxtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbxUnLoadBarmil;
        private System.Windows.Forms.CheckBox chkbxUnloadBarmil;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkbxAddToStock;
        private System.Windows.Forms.MaskedTextBox mtxtSlip;
        private System.Windows.Forms.Label lblSlip;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn weights;
        private System.Windows.Forms.CheckBox chkbxRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn unloadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn barmilMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}