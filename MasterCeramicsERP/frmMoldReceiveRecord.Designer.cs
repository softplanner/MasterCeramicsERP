namespace MasterCeramicsERP
{
    partial class frmMoldReceiveRecord
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
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantityReceived = new System.Windows.Forms.TextBox();
            this.lblQuantityReceived = new System.Windows.Forms.Label();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxMoldReceiveRecord = new System.Windows.Forms.GroupBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.dtpDateExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReceipt = new System.Windows.Forms.DateTimePicker();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.lblDateExpiry = new System.Windows.Forms.Label();
            this.txtQunatityIssued = new System.Windows.Forms.TextBox();
            this.lblQuantityIssued = new System.Windows.Forms.Label();
            this.txtBreakage = new System.Windows.Forms.TextBox();
            this.lblBreakage = new System.Windows.Forms.Label();
            this.txtBreakageCause = new System.Windows.Forms.TextBox();
            this.lblBreakageCause = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.CasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakageCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).BeginInit();
            this.gbxMoldReceiveRecord.SuspendLayout();
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
            this.Item,
            this.Style,
            this.Size,
            this.DateReceived,
            this.QuantityReceived,
            this.QuantityIssued,
            this.DateExpiry,
            this.Breakage,
            this.BreakageCause,
            this.Balance});
            this.dgvMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMold.GridColor = System.Drawing.Color.Navy;
            this.dgvMold.Location = new System.Drawing.Point(3, 14);
            this.dgvMold.Name = "dgvMold";
            this.dgvMold.ReadOnly = true;
            this.dgvMold.Size = new System.Drawing.Size(754, 301);
            this.dgvMold.TabIndex = 0;
            this.dgvMold.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMold_CellClick);
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.Navy;
            this.btnAddDB.Location = new System.Drawing.Point(103, 156);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(82, 25);
            this.btnAddDB.TabIndex = 12;
            this.btnAddDB.Text = "Save";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Location = new System.Drawing.Point(15, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantityReceived
            // 
            this.txtQuantityReceived.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantityReceived.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityReceived.ForeColor = System.Drawing.Color.Navy;
            this.txtQuantityReceived.Location = new System.Drawing.Point(166, 80);
            this.txtQuantityReceived.Name = "txtQuantityReceived";
            this.txtQuantityReceived.Size = new System.Drawing.Size(145, 21);
            this.txtQuantityReceived.TabIndex = 9;
            this.txtQuantityReceived.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantityReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantityReceived
            // 
            this.lblQuantityReceived.AutoSize = true;
            this.lblQuantityReceived.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityReceived.ForeColor = System.Drawing.Color.Navy;
            this.lblQuantityReceived.Location = new System.Drawing.Point(163, 61);
            this.lblQuantityReceived.Name = "lblQuantityReceived";
            this.lblQuantityReceived.Size = new System.Drawing.Size(96, 13);
            this.lblQuantityReceived.TabIndex = 8;
            this.lblQuantityReceived.Text = "Received Qty.";
            // 
            // cbxSize
            // 
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSize.ForeColor = System.Drawing.Color.Navy;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(619, 31);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(145, 21);
            this.cbxSize.TabIndex = 5;
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.ForeColor = System.Drawing.Color.Navy;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Location = new System.Drawing.Point(468, 31);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(145, 21);
            this.cbxStyle.Sorted = true;
            this.cbxStyle.TabIndex = 3;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.ForeColor = System.Drawing.Color.Navy;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(317, 31);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(145, 21);
            this.cbxItem.Sorted = true;
            this.cbxItem.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Navy;
            this.lblSize.Location = new System.Drawing.Point(616, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(68, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Mold Size";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.ForeColor = System.Drawing.Color.Navy;
            this.lblStyle.Location = new System.Drawing.Point(465, 9);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(74, 13);
            this.lblStyle.TabIndex = 2;
            this.lblStyle.Text = "Mold Style";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Navy;
            this.lblItem.Location = new System.Drawing.Point(314, 9);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(78, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Mold Name";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.Location = new System.Drawing.Point(531, 156);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(82, 25);
            this.btnDeleteRecord.TabIndex = 13;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxMoldReceiveRecord
            // 
            this.gbxMoldReceiveRecord.Controls.Add(this.dgvMold);
            this.gbxMoldReceiveRecord.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoldReceiveRecord.ForeColor = System.Drawing.Color.Navy;
            this.gbxMoldReceiveRecord.Location = new System.Drawing.Point(12, 187);
            this.gbxMoldReceiveRecord.Name = "gbxMoldReceiveRecord";
            this.gbxMoldReceiveRecord.Size = new System.Drawing.Size(760, 318);
            this.gbxMoldReceiveRecord.TabIndex = 14;
            this.gbxMoldReceiveRecord.TabStop = false;
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.Navy;
            this.lblSelectJob.Location = new System.Drawing.Point(12, 9);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(73, 13);
            this.lblSelectJob.TabIndex = 26;
            this.lblSelectJob.Text = "Select Job";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.Navy;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(15, 31);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(145, 21);
            this.cbxSelectJob.TabIndex = 27;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.Navy;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(166, 31);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(145, 21);
            this.cbxWorker.TabIndex = 25;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.Navy;
            this.lblWorker.Location = new System.Drawing.Point(163, 9);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 24;
            this.lblWorker.Text = "Caster";
            // 
            // dtpDateExpiry
            // 
            this.dtpDateExpiry.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpDateExpiry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateExpiry.Location = new System.Drawing.Point(468, 80);
            this.dtpDateExpiry.Name = "dtpDateExpiry";
            this.dtpDateExpiry.Size = new System.Drawing.Size(145, 21);
            this.dtpDateExpiry.TabIndex = 28;
            // 
            // dtpDateReceipt
            // 
            this.dtpDateReceipt.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpDateReceipt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateReceipt.Location = new System.Drawing.Point(15, 80);
            this.dtpDateReceipt.Name = "dtpDateReceipt";
            this.dtpDateReceipt.Size = new System.Drawing.Size(145, 21);
            this.dtpDateReceipt.TabIndex = 29;
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceived.ForeColor = System.Drawing.Color.Navy;
            this.lblDateReceived.Location = new System.Drawing.Point(12, 61);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(100, 13);
            this.lblDateReceived.TabIndex = 30;
            this.lblDateReceived.Text = "Received Date";
            // 
            // lblDateExpiry
            // 
            this.lblDateExpiry.AutoSize = true;
            this.lblDateExpiry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpiry.ForeColor = System.Drawing.Color.Navy;
            this.lblDateExpiry.Location = new System.Drawing.Point(465, 61);
            this.lblDateExpiry.Name = "lblDateExpiry";
            this.lblDateExpiry.Size = new System.Drawing.Size(83, 13);
            this.lblDateExpiry.TabIndex = 31;
            this.lblDateExpiry.Text = "Expiry Date";
            // 
            // txtQunatityIssued
            // 
            this.txtQunatityIssued.BackColor = System.Drawing.SystemColors.Control;
            this.txtQunatityIssued.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQunatityIssued.ForeColor = System.Drawing.Color.Navy;
            this.txtQunatityIssued.Location = new System.Drawing.Point(317, 83);
            this.txtQunatityIssued.Name = "txtQunatityIssued";
            this.txtQunatityIssued.Size = new System.Drawing.Size(145, 21);
            this.txtQunatityIssued.TabIndex = 33;
            this.txtQunatityIssued.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQunatityIssued_MouseClick);
            this.txtQunatityIssued.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQunatityIssued_KeyPress);
            // 
            // lblQuantityIssued
            // 
            this.lblQuantityIssued.AutoSize = true;
            this.lblQuantityIssued.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityIssued.ForeColor = System.Drawing.Color.Navy;
            this.lblQuantityIssued.Location = new System.Drawing.Point(314, 61);
            this.lblQuantityIssued.Name = "lblQuantityIssued";
            this.lblQuantityIssued.Size = new System.Drawing.Size(85, 13);
            this.lblQuantityIssued.TabIndex = 32;
            this.lblQuantityIssued.Text = "Issued Qty. ";
            // 
            // txtBreakage
            // 
            this.txtBreakage.BackColor = System.Drawing.SystemColors.Control;
            this.txtBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakage.ForeColor = System.Drawing.Color.Navy;
            this.txtBreakage.Location = new System.Drawing.Point(619, 80);
            this.txtBreakage.Name = "txtBreakage";
            this.txtBreakage.Size = new System.Drawing.Size(145, 21);
            this.txtBreakage.TabIndex = 35;
            this.txtBreakage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBreakage_MouseClick);
            this.txtBreakage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreakage_KeyPress);
            // 
            // lblBreakage
            // 
            this.lblBreakage.AutoSize = true;
            this.lblBreakage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakage.ForeColor = System.Drawing.Color.Navy;
            this.lblBreakage.Location = new System.Drawing.Point(615, 61);
            this.lblBreakage.Name = "lblBreakage";
            this.lblBreakage.Size = new System.Drawing.Size(69, 13);
            this.lblBreakage.TabIndex = 34;
            this.lblBreakage.Text = "Breakage";
            // 
            // txtBreakageCause
            // 
            this.txtBreakageCause.BackColor = System.Drawing.SystemColors.Control;
            this.txtBreakageCause.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakageCause.ForeColor = System.Drawing.Color.Navy;
            this.txtBreakageCause.Location = new System.Drawing.Point(15, 129);
            this.txtBreakageCause.Name = "txtBreakageCause";
            this.txtBreakageCause.Size = new System.Drawing.Size(597, 21);
            this.txtBreakageCause.TabIndex = 37;
            // 
            // lblBreakageCause
            // 
            this.lblBreakageCause.AutoSize = true;
            this.lblBreakageCause.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakageCause.ForeColor = System.Drawing.Color.Navy;
            this.lblBreakageCause.Location = new System.Drawing.Point(12, 113);
            this.lblBreakageCause.Name = "lblBreakageCause";
            this.lblBreakageCause.Size = new System.Drawing.Size(112, 13);
            this.lblBreakageCause.TabIndex = 36;
            this.lblBreakageCause.Text = "Breakage Cause";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBalance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Navy;
            this.txtBalance.Location = new System.Drawing.Point(618, 129);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(146, 21);
            this.txtBalance.TabIndex = 39;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Navy;
            this.lblBalance.Location = new System.Drawing.Point(615, 113);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(58, 13);
            this.lblBalance.TabIndex = 38;
            this.lblBalance.Text = "Balance";
            // 
            // CasterID
            // 
            this.CasterID.DataPropertyName = "CasterID";
            this.CasterID.HeaderText = "CasterID";
            this.CasterID.Name = "CasterID";
            this.CasterID.ReadOnly = true;
            // 
            // Caster
            // 
            this.Caster.DataPropertyName = "Caster";
            this.Caster.HeaderText = "Caster";
            this.Caster.Name = "Caster";
            this.Caster.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Mold Name";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Mold Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Mold Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // DateReceived
            // 
            this.DateReceived.DataPropertyName = "DateReceived";
            this.DateReceived.HeaderText = "Received Date";
            this.DateReceived.Name = "DateReceived";
            this.DateReceived.ReadOnly = true;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.DataPropertyName = "QuantityReceived";
            this.QuantityReceived.HeaderText = "QuantityReceived";
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
            // 
            // QuantityIssued
            // 
            this.QuantityIssued.DataPropertyName = "QuantityIssued";
            this.QuantityIssued.HeaderText = "QuantityIssued";
            this.QuantityIssued.Name = "QuantityIssued";
            this.QuantityIssued.ReadOnly = true;
            // 
            // DateExpiry
            // 
            this.DateExpiry.DataPropertyName = "DateExpiry";
            this.DateExpiry.HeaderText = "Expiry Date";
            this.DateExpiry.Name = "DateExpiry";
            this.DateExpiry.ReadOnly = true;
            // 
            // Breakage
            // 
            this.Breakage.DataPropertyName = "Breakage";
            this.Breakage.HeaderText = "Breakage";
            this.Breakage.Name = "Breakage";
            this.Breakage.ReadOnly = true;
            // 
            // BreakageCause
            // 
            this.BreakageCause.DataPropertyName = "BreakageCause";
            this.BreakageCause.HeaderText = "BreakageCause";
            this.BreakageCause.Name = "BreakageCause";
            this.BreakageCause.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // frmMoldReceiveRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtBreakageCause);
            this.Controls.Add(this.lblBreakageCause);
            this.Controls.Add(this.txtBreakage);
            this.Controls.Add(this.lblBreakage);
            this.Controls.Add(this.txtQunatityIssued);
            this.Controls.Add(this.lblQuantityIssued);
            this.Controls.Add(this.lblDateExpiry);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.dtpDateReceipt);
            this.Controls.Add(this.dtpDateExpiry);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.gbxMoldReceiveRecord);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantityReceived);
            this.Controls.Add(this.lblQuantityReceived);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblItem);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmMoldReceiveRecord";
            this.Text = "Mold Register Record";
            this.Load += new System.EventHandler(this.frmMoldReceiveRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMold)).EndInit();
            this.gbxMoldReceiveRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMold;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantityReceived;
        private System.Windows.Forms.Label lblQuantityReceived;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxMoldReceiveRecord;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DateTimePicker dtpDateExpiry;
        private System.Windows.Forms.DateTimePicker dtpDateReceipt;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lblDateExpiry;
        private System.Windows.Forms.TextBox txtQunatityIssued;
        private System.Windows.Forms.Label lblQuantityIssued;
        private System.Windows.Forms.TextBox txtBreakage;
        private System.Windows.Forms.Label lblBreakage;
        private System.Windows.Forms.TextBox txtBreakageCause;
        private System.Windows.Forms.Label lblBreakageCause;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breakage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakageCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}