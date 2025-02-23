namespace MasterCeramicsERP
{
    partial class frmGreenWareMoldCasting
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
            this.dgvMold = new System.Windows.Forms.DataGridView();
            this.gbxMoldCastingReport = new System.Windows.Forms.GroupBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtBalanceItems = new System.Windows.Forms.TextBox();
            this.txtSlip = new System.Windows.Forms.TextBox();
            this.txtDryBreakage = new System.Windows.Forms.TextBox();
            this.txtBreakage = new System.Windows.Forms.TextBox();
            this.lblBreakage = new System.Windows.Forms.Label();
            this.lblSlip = new System.Windows.Forms.Label();
            this.lblDryBreakage = new System.Windows.Forms.Label();
            this.lblBalanceItems = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxWorkerStock = new System.Windows.Forms.GroupBox();
            this.dgvWorkerStock = new System.Windows.Forms.DataGridView();
            this.CasterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoldQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.txtBalanceBF = new System.Windows.Forms.TextBox();
            this.lblBalanceBF = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtCheckedItems = new System.Windows.Forms.TextBox();
            this.lblCheckedItems = new System.Windows.Forms.Label();
            this.txtMouldCasting = new System.Windows.Forms.TextBox();
            this.lblMouldCasting = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRejected = new System.Windows.Forms.TextBox();
            this.lblRejected = new System.Windows.Forms.Label();
            this.CasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouldQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouldCasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DryBreakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rejected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.gbxMoldCastingReport.SuspendLayout();
            this.gbxWorkerStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMold
            // 
            this.dgvMold.AllowUserToAddRows = false;
            this.dgvMold.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CasterID,
            this.Caster,
            this.item,
            this.style,
            this.size,
            this.MouldQuantity,
            this.MouldCasting,
            this.Breakage,
            this.DryBreakage,
            this.BalanceBF,
            this.Total,
            this.Rejected,
            this.Checked,
            this.BalanceItems,
            this.Remarks});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMold.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvMold.Location = new System.Drawing.Point(3, 14);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.Size = new System.Drawing.Size(758, 252);
            this.dgvMold.TabIndex = 0;
            this.dgvMold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMold_CellClick);
            // 
            // gbxMoldCastingReport
            // 
            this.gbxMoldCastingReport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxMoldCastingReport.Controls.Add(this.dgvMold);
            this.gbxMoldCastingReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldCastingReport.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxMoldCastingReport.Location = new System.Drawing.Point(8, 236);
            this.gbxMoldCastingReport.Name = "gbxMoldCastingReport";
            this.gbxMoldCastingReport.Size = new System.Drawing.Size(764, 269);
            this.gbxMoldCastingReport.TabIndex = 1;
            this.gbxMoldCastingReport.TabStop = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUnit.Location = new System.Drawing.Point(622, 188);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(23, 13);
            this.lblUnit.TabIndex = 28;
            this.lblUnit.Text = "Kg";
            // 
            // txtBalanceItems
            // 
            this.txtBalanceItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtBalanceItems.Enabled = false;
            this.txtBalanceItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceItems.Location = new System.Drawing.Point(395, 180);
            this.txtBalanceItems.Name = "txtBalanceItems";
            this.txtBalanceItems.Size = new System.Drawing.Size(53, 21);
            this.txtBalanceItems.TabIndex = 25;
            this.txtBalanceItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCastQuantity_MouseClick);
            this.txtBalanceItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCastQuantity_KeyPress);
            // 
            // txtSlip
            // 
            this.txtSlip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSlip.Enabled = false;
            this.txtSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlip.Location = new System.Drawing.Point(554, 183);
            this.txtSlip.Name = "txtSlip";
            this.txtSlip.Size = new System.Drawing.Size(53, 21);
            this.txtSlip.TabIndex = 27;
            // 
            // txtDryBreakage
            // 
            this.txtDryBreakage.BackColor = System.Drawing.SystemColors.Control;
            this.txtDryBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDryBreakage.Location = new System.Drawing.Point(395, 153);
            this.txtDryBreakage.Name = "txtDryBreakage";
            this.txtDryBreakage.Size = new System.Drawing.Size(53, 21);
            this.txtDryBreakage.TabIndex = 23;
            this.txtDryBreakage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDryBreakage_MouseClick);
            this.txtDryBreakage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDryBreakage_KeyPress);
            // 
            // txtBreakage
            // 
            this.txtBreakage.BackColor = System.Drawing.SystemColors.Control;
            this.txtBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakage.Location = new System.Drawing.Point(232, 153);
            this.txtBreakage.Name = "txtBreakage";
            this.txtBreakage.Size = new System.Drawing.Size(53, 21);
            this.txtBreakage.TabIndex = 19;
            this.txtBreakage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBreakage_MouseClick);
            this.txtBreakage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreakage_KeyPress);
            // 
            // lblBreakage
            // 
            this.lblBreakage.AutoSize = true;
            this.lblBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBreakage.Location = new System.Drawing.Point(159, 156);
            this.lblBreakage.Name = "lblBreakage";
            this.lblBreakage.Size = new System.Drawing.Size(69, 13);
            this.lblBreakage.TabIndex = 18;
            this.lblBreakage.Text = "Breakage";
            // 
            // lblSlip
            // 
            this.lblSlip.AutoSize = true;
            this.lblSlip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlip.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSlip.Location = new System.Drawing.Point(454, 183);
            this.lblSlip.Name = "lblSlip";
            this.lblSlip.Size = new System.Drawing.Size(35, 13);
            this.lblSlip.TabIndex = 26;
            this.lblSlip.Text = "Slip ";
            // 
            // lblDryBreakage
            // 
            this.lblDryBreakage.AutoSize = true;
            this.lblDryBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDryBreakage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDryBreakage.Location = new System.Drawing.Point(291, 156);
            this.lblDryBreakage.Name = "lblDryBreakage";
            this.lblDryBreakage.Size = new System.Drawing.Size(96, 13);
            this.lblDryBreakage.TabIndex = 22;
            this.lblDryBreakage.Text = "Dry Breakage";
            // 
            // lblBalanceItems
            // 
            this.lblBalanceItems.AutoSize = true;
            this.lblBalanceItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceItems.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalanceItems.Location = new System.Drawing.Point(291, 183);
            this.lblBalanceItems.Name = "lblBalanceItems";
            this.lblBalanceItems.Size = new System.Drawing.Size(100, 13);
            this.lblBalanceItems.TabIndex = 24;
            this.lblBalanceItems.Text = "Balance Items";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteRecord.Location = new System.Drawing.Point(613, 207);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRecord.TabIndex = 33;
            this.btnDeleteRecord.Text = "Delete";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddDB.Location = new System.Drawing.Point(694, 207);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(75, 23);
            this.btnAddDB.TabIndex = 32;
            this.btnAddDB.Text = "Save Into Database";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(532, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxWorkerStock
            // 
            this.gbxWorkerStock.Controls.Add(this.dgvWorkerStock);
            this.gbxWorkerStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxWorkerStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxWorkerStock.Location = new System.Drawing.Point(7, 34);
            this.gbxWorkerStock.Name = "gbxWorkerStock";
            this.gbxWorkerStock.Size = new System.Drawing.Size(765, 113);
            this.gbxWorkerStock.TabIndex = 29;
            this.gbxWorkerStock.TabStop = false;
            this.gbxWorkerStock.Text = "Caster Mould Stock";
            // 
            // dgvWorkerStock
            // 
            this.dgvWorkerStock.AllowUserToAddRows = false;
            this.dgvWorkerStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvWorkerStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorkerStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvWorkerStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkerStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CasterName,
            this.ItemName,
            this.StyleName,
            this.SizeName,
            this.MoldQuantity,
            this.ItemBF});
            this.dgvWorkerStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkerStock.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvWorkerStock.Location = new System.Drawing.Point(3, 14);
            this.dgvWorkerStock.Name = "dgvWorkerStock";
            this.dgvWorkerStock.ReadOnly = true;
            this.dgvWorkerStock.Size = new System.Drawing.Size(759, 96);
            this.dgvWorkerStock.TabIndex = 0;
            this.dgvWorkerStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkerStock_CellClick);
            // 
            // CasterName
            // 
            this.CasterName.DataPropertyName = "CasterName";
            this.CasterName.HeaderText = "Caster";
            this.CasterName.Name = "CasterName";
            this.CasterName.ReadOnly = true;
            this.CasterName.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // StyleName
            // 
            this.StyleName.DataPropertyName = "StyleName";
            this.StyleName.HeaderText = "Style";
            this.StyleName.Name = "StyleName";
            this.StyleName.ReadOnly = true;
            this.StyleName.Width = 125;
            // 
            // SizeName
            // 
            this.SizeName.DataPropertyName = "SizeName";
            this.SizeName.HeaderText = "Size";
            this.SizeName.Name = "SizeName";
            this.SizeName.ReadOnly = true;
            this.SizeName.Width = 125;
            // 
            // MoldQuantity
            // 
            this.MoldQuantity.DataPropertyName = "MoldQuantity";
            this.MoldQuantity.HeaderText = "Mould (Qt.)";
            this.MoldQuantity.Name = "MoldQuantity";
            this.MoldQuantity.ReadOnly = true;
            this.MoldQuantity.Width = 125;
            // 
            // ItemBF
            // 
            this.ItemBF.DataPropertyName = "ItemBF";
            this.ItemBF.HeaderText = "Item B.F (Qt.)";
            this.ItemBF.Name = "ItemBF";
            this.ItemBF.ReadOnly = true;
            this.ItemBF.Width = 125;
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectJob.Location = new System.Drawing.Point(14, 9);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 14;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(93, 7);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(171, 21);
            this.cbxSelectJob.TabIndex = 15;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(325, 7);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(171, 21);
            this.cbxWorker.TabIndex = 13;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWorker.Location = new System.Drawing.Point(270, 9);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 12;
            this.lblWorker.Text = "Caster";
            // 
            // txtBalanceBF
            // 
            this.txtBalanceBF.BackColor = System.Drawing.SystemColors.Control;
            this.txtBalanceBF.Enabled = false;
            this.txtBalanceBF.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceBF.Location = new System.Drawing.Point(554, 153);
            this.txtBalanceBF.Name = "txtBalanceBF";
            this.txtBalanceBF.Size = new System.Drawing.Size(53, 21);
            this.txtBalanceBF.TabIndex = 35;
            // 
            // lblBalanceBF
            // 
            this.lblBalanceBF.AutoSize = true;
            this.lblBalanceBF.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceBF.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalanceBF.Location = new System.Drawing.Point(454, 156);
            this.lblBalanceBF.Name = "lblBalanceBF";
            this.lblBalanceBF.Size = new System.Drawing.Size(82, 13);
            this.lblBalanceBF.TabIndex = 34;
            this.lblBalanceBF.Text = "Balance B.F";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalItems.Enabled = false;
            this.txtTotalItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItems.Location = new System.Drawing.Point(707, 156);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(53, 21);
            this.txtTotalItems.TabIndex = 37;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalItems.Location = new System.Drawing.Point(618, 159);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(82, 13);
            this.lblTotalItems.TabIndex = 36;
            this.lblTotalItems.Text = "Total Items";
            // 
            // txtCheckedItems
            // 
            this.txtCheckedItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtCheckedItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckedItems.Location = new System.Drawing.Point(232, 180);
            this.txtCheckedItems.Name = "txtCheckedItems";
            this.txtCheckedItems.Size = new System.Drawing.Size(53, 21);
            this.txtCheckedItems.TabIndex = 39;
            this.txtCheckedItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCheckedItems_MouseClick);
            this.txtCheckedItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckedItems_KeyPress);
            // 
            // lblCheckedItems
            // 
            this.lblCheckedItems.AutoSize = true;
            this.lblCheckedItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckedItems.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCheckedItems.Location = new System.Drawing.Point(159, 183);
            this.lblCheckedItems.Name = "lblCheckedItems";
            this.lblCheckedItems.Size = new System.Drawing.Size(66, 13);
            this.lblCheckedItems.TabIndex = 38;
            this.lblCheckedItems.Text = "Checked ";
            // 
            // txtMouldCasting
            // 
            this.txtMouldCasting.BackColor = System.Drawing.SystemColors.Control;
            this.txtMouldCasting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMouldCasting.Location = new System.Drawing.Point(103, 156);
            this.txtMouldCasting.Name = "txtMouldCasting";
            this.txtMouldCasting.Size = new System.Drawing.Size(53, 21);
            this.txtMouldCasting.TabIndex = 41;
            this.txtMouldCasting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMouldCasting_MouseClick);
            this.txtMouldCasting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMouldCasting_KeyPress);
            // 
            // lblMouldCasting
            // 
            this.lblMouldCasting.AutoSize = true;
            this.lblMouldCasting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouldCasting.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMouldCasting.Location = new System.Drawing.Point(5, 156);
            this.lblMouldCasting.Name = "lblMouldCasting";
            this.lblMouldCasting.Size = new System.Drawing.Size(97, 13);
            this.lblMouldCasting.TabIndex = 40;
            this.lblMouldCasting.Text = "Mould Casting";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(103, 207);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(423, 21);
            this.txtRemarks.TabIndex = 44;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRemarks.Location = new System.Drawing.Point(8, 212);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 43;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRejected
            // 
            this.txtRejected.BackColor = System.Drawing.SystemColors.Control;
            this.txtRejected.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRejected.Location = new System.Drawing.Point(103, 180);
            this.txtRejected.Name = "txtRejected";
            this.txtRejected.Size = new System.Drawing.Size(53, 21);
            this.txtRejected.TabIndex = 46;
            this.txtRejected.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRejected_MouseClick);
            this.txtRejected.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRejected_KeyPress);
            // 
            // lblRejected
            // 
            this.lblRejected.AutoSize = true;
            this.lblRejected.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejected.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRejected.Location = new System.Drawing.Point(5, 183);
            this.lblRejected.Name = "lblRejected";
            this.lblRejected.Size = new System.Drawing.Size(48, 13);
            this.lblRejected.TabIndex = 45;
            this.lblRejected.Text = "Reject";
            // 
            // CasterID
            // 
            this.CasterID.HeaderText = "CasterID";
            this.CasterID.Name = "CasterID";
            this.CasterID.ReadOnly = true;
            // 
            // Caster
            // 
            this.Caster.HeaderText = "Caster";
            this.Caster.Name = "Caster";
            this.Caster.ReadOnly = true;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // MouldQuantity
            // 
            this.MouldQuantity.HeaderText = "Mould Quantity";
            this.MouldQuantity.Name = "MouldQuantity";
            this.MouldQuantity.ReadOnly = true;
            // 
            // MouldCasting
            // 
            this.MouldCasting.HeaderText = "Mould Casting";
            this.MouldCasting.Name = "MouldCasting";
            this.MouldCasting.ReadOnly = true;
            // 
            // Breakage
            // 
            this.Breakage.HeaderText = "Breakage";
            this.Breakage.Name = "Breakage";
            this.Breakage.ReadOnly = true;
            // 
            // DryBreakage
            // 
            this.DryBreakage.HeaderText = "Dry Breakage";
            this.DryBreakage.Name = "DryBreakage";
            this.DryBreakage.ReadOnly = true;
            // 
            // BalanceBF
            // 
            this.BalanceBF.HeaderText = "BalanceB.F";
            this.BalanceBF.Name = "BalanceBF";
            this.BalanceBF.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Rejected
            // 
            this.Rejected.DataPropertyName = "Rejected";
            this.Rejected.HeaderText = "Rejected";
            this.Rejected.Name = "Rejected";
            this.Rejected.ReadOnly = true;
            // 
            // Checked
            // 
            this.Checked.HeaderText = "Checked";
            this.Checked.Name = "Checked";
            this.Checked.ReadOnly = true;
            // 
            // BalanceItems
            // 
            this.BalanceItems.HeaderText = "Balance Items";
            this.BalanceItems.Name = "BalanceItems";
            this.BalanceItems.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // frmGreenWareMoldCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtRejected);
            this.Controls.Add(this.lblRejected);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtMouldCasting);
            this.Controls.Add(this.lblMouldCasting);
            this.Controls.Add(this.txtCheckedItems);
            this.Controls.Add(this.lblCheckedItems);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.txtBalanceBF);
            this.Controls.Add(this.lblBalanceBF);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxWorkerStock);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.gbxMoldCastingReport);
            this.Controls.Add(this.txtBalanceItems);
            this.Controls.Add(this.txtSlip);
            this.Controls.Add(this.lblBalanceItems);
            this.Controls.Add(this.txtDryBreakage);
            this.Controls.Add(this.lblDryBreakage);
            this.Controls.Add(this.txtBreakage);
            this.Controls.Add(this.lblSlip);
            this.Controls.Add(this.lblBreakage);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmGreenWareMoldCasting";
            this.Text = "Daily Report Green Ware";
            this.Load += new System.EventHandler(this.frmMoldCasting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.gbxMoldCastingReport.ResumeLayout(false);
            this.gbxWorkerStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.GroupBox gbxMoldCastingReport;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtBalanceItems;
        private System.Windows.Forms.TextBox txtSlip;
        private System.Windows.Forms.TextBox txtDryBreakage;
        private System.Windows.Forms.TextBox txtBreakage;
        private System.Windows.Forms.Label lblBreakage;
        private System.Windows.Forms.Label lblSlip;
        private System.Windows.Forms.Label lblDryBreakage;
        private System.Windows.Forms.Label lblBalanceItems;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxWorkerStock;
        private System.Windows.Forms.DataGridView dgvWorkerStock;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtBalanceBF;
        private System.Windows.Forms.Label lblBalanceBF;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtCheckedItems;
        private System.Windows.Forms.Label lblCheckedItems;
        private System.Windows.Forms.TextBox txtMouldCasting;
        private System.Windows.Forms.Label lblMouldCasting;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoldQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBF;
        private System.Windows.Forms.TextBox txtRejected;
        private System.Windows.Forms.Label lblRejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caster;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouldQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouldCasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DryBreakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;

    }
}