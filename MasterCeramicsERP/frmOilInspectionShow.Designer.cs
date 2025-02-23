namespace MasterCeramicsERP
{
    partial class frmOilInspectionShow
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
            this.chkbxCaster = new System.Windows.Forms.CheckBox();
            this.cbxCaster = new System.Windows.Forms.ComboBox();
            this.lblRejectedQuantity = new System.Windows.Forms.Label();
            this.lblCaster = new System.Windows.Forms.Label();
            this.lblChecker = new System.Windows.Forms.Label();
            this.cbxChecker = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbxCasterCastingStock = new System.Windows.Forms.GroupBox();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.txtRejectedItems = new System.Windows.Forms.TextBox();
            this.txtSelectedQuantity = new System.Windows.Forms.TextBox();
            this.txtCastedMold = new System.Windows.Forms.TextBox();
            this.txtFreeMold = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblFreeMold = new System.Windows.Forms.Label();
            this.lblCastedMold = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.lblUpdatedrejectedItems = new System.Windows.Forms.Label();
            this.txtUpdatedRejectedItems = new System.Windows.Forms.TextBox();
            this.txtUpdatedSelectedItems = new System.Windows.Forms.TextBox();
            this.lblUpdatedSelectedItems = new System.Windows.Forms.Label();
            this.txtCaster = new System.Windows.Forms.TextBox();
            this.lblCasters = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtChecker = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCheckers = new System.Windows.Forms.Label();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpGlazeHouse = new System.Windows.Forms.DateTimePicker();
            this.chkbxChecker = new System.Windows.Forms.CheckBox();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.gbxOilInspection = new System.Windows.Forms.GroupBox();
            this.checkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedQuantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectedItemss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxCasterCastingStock.SuspendLayout();
            this.gbxOilInspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbxCaster
            // 
            this.chkbxCaster.AutoSize = true;
            this.chkbxCaster.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxCaster.ForeColor = System.Drawing.Color.DarkViolet;
            this.chkbxCaster.Location = new System.Drawing.Point(641, 217);
            this.chkbxCaster.Name = "chkbxCaster";
            this.chkbxCaster.Size = new System.Drawing.Size(126, 17);
            this.chkbxCaster.TabIndex = 34;
            this.chkbxCaster.Text = "Show By Caster";
            this.chkbxCaster.UseVisualStyleBackColor = true;
            this.chkbxCaster.CheckedChanged += new System.EventHandler(this.chkbxCaster_CheckedChanged);
            // 
            // cbxCaster
            // 
            this.cbxCaster.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaster.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxCaster.FormattingEnabled = true;
            this.cbxCaster.Location = new System.Drawing.Point(570, 78);
            this.cbxCaster.Name = "cbxCaster";
            this.cbxCaster.Size = new System.Drawing.Size(204, 21);
            this.cbxCaster.TabIndex = 24;
            // 
            // lblRejectedQuantity
            // 
            this.lblRejectedQuantity.AutoSize = true;
            this.lblRejectedQuantity.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRejectedQuantity.Location = new System.Drawing.Point(12, 223);
            this.lblRejectedQuantity.Name = "lblRejectedQuantity";
            this.lblRejectedQuantity.Size = new System.Drawing.Size(177, 13);
            this.lblRejectedQuantity.TabIndex = 16;
            this.lblRejectedQuantity.Text = "Rejected Items (Quantity)";
            // 
            // lblCaster
            // 
            this.lblCaster.AutoSize = true;
            this.lblCaster.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblCaster.Location = new System.Drawing.Point(479, 81);
            this.lblCaster.Name = "lblCaster";
            this.lblCaster.Size = new System.Drawing.Size(49, 13);
            this.lblCaster.TabIndex = 23;
            this.lblCaster.Text = "Caster";
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblChecker.Location = new System.Drawing.Point(478, 108);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(60, 13);
            this.lblChecker.TabIndex = 25;
            this.lblChecker.Text = "Checker";
            // 
            // cbxChecker
            // 
            this.cbxChecker.BackColor = System.Drawing.SystemColors.Control;
            this.cbxChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxChecker.FormattingEnabled = true;
            this.cbxChecker.Location = new System.Drawing.Point(570, 105);
            this.cbxChecker.Name = "cbxChecker";
            this.cbxChecker.Size = new System.Drawing.Size(204, 21);
            this.cbxChecker.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnUpdate.Location = new System.Drawing.Point(426, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 24);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkerName,
            this.casterName,
            this.item_chk,
            this.style_chk,
            this.size_chk,
            this.selectedQuantities,
            this.rejectedItemss,
            this.remarkss,
            this.date});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.DarkViolet;
            this.dgvReport.Location = new System.Drawing.Point(3, 14);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(772, 232);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.Location = new System.Drawing.Point(503, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 24);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnShow.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnShow.Location = new System.Drawing.Point(639, 189);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 22);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbxCasterCastingStock
            // 
            this.gbxCasterCastingStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxCasterCastingStock.Controls.Add(this.rbtnYear);
            this.gbxCasterCastingStock.Controls.Add(this.txtRejectedItems);
            this.gbxCasterCastingStock.Controls.Add(this.txtSelectedQuantity);
            this.gbxCasterCastingStock.Controls.Add(this.txtCastedMold);
            this.gbxCasterCastingStock.Controls.Add(this.txtFreeMold);
            this.gbxCasterCastingStock.Controls.Add(this.btnRefresh);
            this.gbxCasterCastingStock.Controls.Add(this.lblFreeMold);
            this.gbxCasterCastingStock.Controls.Add(this.lblCastedMold);
            this.gbxCasterCastingStock.Controls.Add(this.btnPrintReport);
            this.gbxCasterCastingStock.Controls.Add(this.lblUpdatedrejectedItems);
            this.gbxCasterCastingStock.Controls.Add(this.txtUpdatedRejectedItems);
            this.gbxCasterCastingStock.Controls.Add(this.txtUpdatedSelectedItems);
            this.gbxCasterCastingStock.Controls.Add(this.lblUpdatedSelectedItems);
            this.gbxCasterCastingStock.Controls.Add(this.txtCaster);
            this.gbxCasterCastingStock.Controls.Add(this.lblCasters);
            this.gbxCasterCastingStock.Controls.Add(this.txtSize);
            this.gbxCasterCastingStock.Controls.Add(this.txtDate);
            this.gbxCasterCastingStock.Controls.Add(this.txtRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.txtStyle);
            this.gbxCasterCastingStock.Controls.Add(this.txtItem);
            this.gbxCasterCastingStock.Controls.Add(this.txtChecker);
            this.gbxCasterCastingStock.Controls.Add(this.lblRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.lblDateUpdate);
            this.gbxCasterCastingStock.Controls.Add(this.lblItem);
            this.gbxCasterCastingStock.Controls.Add(this.lblStyle);
            this.gbxCasterCastingStock.Controls.Add(this.lblSize);
            this.gbxCasterCastingStock.Controls.Add(this.lblCheckers);
            this.gbxCasterCastingStock.Controls.Add(this.rbtnMonth);
            this.gbxCasterCastingStock.Controls.Add(this.rbtnDay);
            this.gbxCasterCastingStock.Controls.Add(this.lblDate);
            this.gbxCasterCastingStock.Controls.Add(this.dtpGlazeHouse);
            this.gbxCasterCastingStock.Controls.Add(this.chkbxChecker);
            this.gbxCasterCastingStock.Controls.Add(this.chkbxCaster);
            this.gbxCasterCastingStock.Controls.Add(this.btnUpdate);
            this.gbxCasterCastingStock.Controls.Add(this.btnDelete);
            this.gbxCasterCastingStock.Controls.Add(this.cbxCaster);
            this.gbxCasterCastingStock.Controls.Add(this.lblRejectedQuantity);
            this.gbxCasterCastingStock.Controls.Add(this.lblCaster);
            this.gbxCasterCastingStock.Controls.Add(this.lblChecker);
            this.gbxCasterCastingStock.Controls.Add(this.cbxChecker);
            this.gbxCasterCastingStock.Controls.Add(this.btnShow);
            this.gbxCasterCastingStock.Controls.Add(this.lblSelectedItems);
            this.gbxCasterCastingStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCasterCastingStock.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbxCasterCastingStock.Location = new System.Drawing.Point(3, 2);
            this.gbxCasterCastingStock.Name = "gbxCasterCastingStock";
            this.gbxCasterCastingStock.Size = new System.Drawing.Size(778, 255);
            this.gbxCasterCastingStock.TabIndex = 0;
            this.gbxCasterCastingStock.TabStop = false;
            this.gbxCasterCastingStock.Text = "Casting Stock";
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbtnYear.Location = new System.Drawing.Point(714, 55);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 45;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // txtRejectedItems
            // 
            this.txtRejectedItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtRejectedItems.Enabled = false;
            this.txtRejectedItems.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtRejectedItems.Location = new System.Drawing.Point(193, 220);
            this.txtRejectedItems.Name = "txtRejectedItems";
            this.txtRejectedItems.Size = new System.Drawing.Size(90, 21);
            this.txtRejectedItems.TabIndex = 44;
            // 
            // txtSelectedQuantity
            // 
            this.txtSelectedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtSelectedQuantity.Enabled = false;
            this.txtSelectedQuantity.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSelectedQuantity.Location = new System.Drawing.Point(193, 195);
            this.txtSelectedQuantity.Name = "txtSelectedQuantity";
            this.txtSelectedQuantity.Size = new System.Drawing.Size(90, 21);
            this.txtSelectedQuantity.TabIndex = 43;
            // 
            // txtCastedMold
            // 
            this.txtCastedMold.BackColor = System.Drawing.SystemColors.Control;
            this.txtCastedMold.Enabled = false;
            this.txtCastedMold.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtCastedMold.Location = new System.Drawing.Point(292, 99);
            this.txtCastedMold.Name = "txtCastedMold";
            this.txtCastedMold.Size = new System.Drawing.Size(82, 21);
            this.txtCastedMold.TabIndex = 42;
            // 
            // txtFreeMold
            // 
            this.txtFreeMold.BackColor = System.Drawing.SystemColors.Control;
            this.txtFreeMold.Enabled = false;
            this.txtFreeMold.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtFreeMold.Location = new System.Drawing.Point(292, 51);
            this.txtFreeMold.Name = "txtFreeMold";
            this.txtFreeMold.Size = new System.Drawing.Size(82, 21);
            this.txtFreeMold.TabIndex = 41;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnRefresh.Location = new System.Drawing.Point(570, 188);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 24);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblFreeMold
            // 
            this.lblFreeMold.AutoSize = true;
            this.lblFreeMold.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblFreeMold.Location = new System.Drawing.Point(292, 28);
            this.lblFreeMold.Name = "lblFreeMold";
            this.lblFreeMold.Size = new System.Drawing.Size(71, 13);
            this.lblFreeMold.TabIndex = 36;
            this.lblFreeMold.Text = "Free Mold";
            // 
            // lblCastedMold
            // 
            this.lblCastedMold.AutoSize = true;
            this.lblCastedMold.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblCastedMold.Location = new System.Drawing.Point(292, 78);
            this.lblCastedMold.Name = "lblCastedMold";
            this.lblCastedMold.Size = new System.Drawing.Size(85, 13);
            this.lblCastedMold.TabIndex = 37;
            this.lblCastedMold.Text = "Casted Mold";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPrintReport.Location = new System.Drawing.Point(289, 220);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintReport.TabIndex = 18;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // lblUpdatedrejectedItems
            // 
            this.lblUpdatedrejectedItems.AutoSize = true;
            this.lblUpdatedrejectedItems.Location = new System.Drawing.Point(292, 160);
            this.lblUpdatedrejectedItems.Name = "lblUpdatedrejectedItems";
            this.lblUpdatedrejectedItems.Size = new System.Drawing.Size(274, 13);
            this.lblUpdatedrejectedItems.TabIndex = 29;
            this.lblUpdatedrejectedItems.Text = "Enter Updated Rejected Items (Quantity)";
            // 
            // txtUpdatedRejectedItems
            // 
            this.txtUpdatedRejectedItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedRejectedItems.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtUpdatedRejectedItems.Location = new System.Drawing.Point(570, 157);
            this.txtUpdatedRejectedItems.Name = "txtUpdatedRejectedItems";
            this.txtUpdatedRejectedItems.Size = new System.Drawing.Size(203, 21);
            this.txtUpdatedRejectedItems.TabIndex = 30;
            this.txtUpdatedRejectedItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdatedRejectedItems_MouseClick);
            this.txtUpdatedRejectedItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdatedRejectedItems_KeyPress);
            // 
            // txtUpdatedSelectedItems
            // 
            this.txtUpdatedSelectedItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatedSelectedItems.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtUpdatedSelectedItems.Location = new System.Drawing.Point(570, 132);
            this.txtUpdatedSelectedItems.Name = "txtUpdatedSelectedItems";
            this.txtUpdatedSelectedItems.Size = new System.Drawing.Size(203, 21);
            this.txtUpdatedSelectedItems.TabIndex = 28;
            this.txtUpdatedSelectedItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdatedSelectedItems_MouseClick);
            this.txtUpdatedSelectedItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdatedSelectedItems_KeyPress);
            // 
            // lblUpdatedSelectedItems
            // 
            this.lblUpdatedSelectedItems.AutoSize = true;
            this.lblUpdatedSelectedItems.Location = new System.Drawing.Point(292, 135);
            this.lblUpdatedSelectedItems.Name = "lblUpdatedSelectedItems";
            this.lblUpdatedSelectedItems.Size = new System.Drawing.Size(273, 13);
            this.lblUpdatedSelectedItems.TabIndex = 27;
            this.lblUpdatedSelectedItems.Text = "Enter Updated Selected Items (Quantity)";
            // 
            // txtCaster
            // 
            this.txtCaster.BackColor = System.Drawing.SystemColors.Control;
            this.txtCaster.Enabled = false;
            this.txtCaster.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtCaster.Location = new System.Drawing.Point(151, 51);
            this.txtCaster.Name = "txtCaster";
            this.txtCaster.Size = new System.Drawing.Size(132, 21);
            this.txtCaster.TabIndex = 3;
            // 
            // lblCasters
            // 
            this.lblCasters.AutoSize = true;
            this.lblCasters.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblCasters.Location = new System.Drawing.Point(12, 54);
            this.lblCasters.Name = "lblCasters";
            this.lblCasters.Size = new System.Drawing.Size(49, 13);
            this.lblCasters.TabIndex = 2;
            this.lblCasters.Text = "Caster";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.Control;
            this.txtSize.Enabled = false;
            this.txtSize.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSize.Location = new System.Drawing.Point(151, 123);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(132, 21);
            this.txtSize.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDate.Enabled = false;
            this.txtDate.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDate.Location = new System.Drawing.Point(151, 171);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 21);
            this.txtDate.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.Enabled = false;
            this.txtRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtRemarks.Location = new System.Drawing.Point(151, 147);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(132, 21);
            this.txtRemarks.TabIndex = 11;
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.SystemColors.Control;
            this.txtStyle.Enabled = false;
            this.txtStyle.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtStyle.Location = new System.Drawing.Point(151, 99);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(132, 21);
            this.txtStyle.TabIndex = 7;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtItem.Enabled = false;
            this.txtItem.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtItem.Location = new System.Drawing.Point(151, 75);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(132, 21);
            this.txtItem.TabIndex = 5;
            // 
            // txtChecker
            // 
            this.txtChecker.BackColor = System.Drawing.SystemColors.Control;
            this.txtChecker.Enabled = false;
            this.txtChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtChecker.Location = new System.Drawing.Point(151, 27);
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Size = new System.Drawing.Size(132, 21);
            this.txtChecker.TabIndex = 1;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRemarks.Location = new System.Drawing.Point(12, 150);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblDateUpdate.Location = new System.Drawing.Point(12, 174);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(37, 13);
            this.lblDateUpdate.TabIndex = 12;
            this.lblDateUpdate.Text = "Date";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblItem.Location = new System.Drawing.Point(12, 82);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblStyle.Location = new System.Drawing.Point(12, 108);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 6;
            this.lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSize.Location = new System.Drawing.Point(12, 126);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size";
            // 
            // lblCheckers
            // 
            this.lblCheckers.AutoSize = true;
            this.lblCheckers.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblCheckers.Location = new System.Drawing.Point(12, 30);
            this.lblCheckers.Name = "lblCheckers";
            this.lblCheckers.Size = new System.Drawing.Size(60, 13);
            this.lblCheckers.TabIndex = 0;
            this.lblCheckers.Text = "Checker";
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbtnMonth.Location = new System.Drawing.Point(636, 55);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 22;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbtnDay.Location = new System.Drawing.Point(570, 55);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 21;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblDate.Location = new System.Drawing.Point(482, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Select Date";
            // 
            // dtpGlazeHouse
            // 
            this.dtpGlazeHouse.Location = new System.Drawing.Point(570, 20);
            this.dtpGlazeHouse.Name = "dtpGlazeHouse";
            this.dtpGlazeHouse.Size = new System.Drawing.Size(200, 21);
            this.dtpGlazeHouse.TabIndex = 20;
            // 
            // chkbxChecker
            // 
            this.chkbxChecker.AutoSize = true;
            this.chkbxChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.chkbxChecker.Location = new System.Drawing.Point(641, 237);
            this.chkbxChecker.Name = "chkbxChecker";
            this.chkbxChecker.Size = new System.Drawing.Size(137, 17);
            this.chkbxChecker.TabIndex = 35;
            this.chkbxChecker.Text = "Show By Checker";
            this.chkbxChecker.UseVisualStyleBackColor = true;
            this.chkbxChecker.CheckedChanged += new System.EventHandler(this.chkbxChecker_CheckedChanged);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSelectedItems.Location = new System.Drawing.Point(12, 198);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(176, 13);
            this.lblSelectedItems.TabIndex = 14;
            this.lblSelectedItems.Text = "Selected Items (Quantity)";
            // 
            // gbxOilInspection
            // 
            this.gbxOilInspection.Controls.Add(this.dgvReport);
            this.gbxOilInspection.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOilInspection.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbxOilInspection.Location = new System.Drawing.Point(3, 264);
            this.gbxOilInspection.Name = "gbxOilInspection";
            this.gbxOilInspection.Size = new System.Drawing.Size(778, 249);
            this.gbxOilInspection.TabIndex = 1;
            this.gbxOilInspection.TabStop = false;
            this.gbxOilInspection.Text = "Oil Inspection Report";
            // 
            // checkerName
            // 
            this.checkerName.HeaderText = "Checker Name";
            this.checkerName.Name = "checkerName";
            this.checkerName.ReadOnly = true;
            // 
            // casterName
            // 
            this.casterName.HeaderText = "Caster Name";
            this.casterName.Name = "casterName";
            this.casterName.ReadOnly = true;
            // 
            // item_chk
            // 
            this.item_chk.HeaderText = "Item";
            this.item_chk.Name = "item_chk";
            this.item_chk.ReadOnly = true;
            // 
            // style_chk
            // 
            this.style_chk.HeaderText = "Style";
            this.style_chk.Name = "style_chk";
            this.style_chk.ReadOnly = true;
            // 
            // size_chk
            // 
            this.size_chk.HeaderText = "Size";
            this.size_chk.Name = "size_chk";
            this.size_chk.ReadOnly = true;
            // 
            // selectedQuantities
            // 
            this.selectedQuantities.HeaderText = "Selected Items (Quantity)";
            this.selectedQuantities.Name = "selectedQuantities";
            this.selectedQuantities.ReadOnly = true;
            this.selectedQuantities.Width = 70;
            // 
            // rejectedItemss
            // 
            this.rejectedItemss.HeaderText = "Rejected Items (Quantity)";
            this.rejectedItemss.Name = "rejectedItemss";
            this.rejectedItemss.ReadOnly = true;
            this.rejectedItemss.Width = 70;
            // 
            // remarkss
            // 
            this.remarkss.HeaderText = "Remarks";
            this.remarkss.Name = "remarkss";
            this.remarkss.ReadOnly = true;
            this.remarkss.Width = 80;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // frmOilInspectionShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxOilInspection);
            this.Controls.Add(this.gbxCasterCastingStock);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmOilInspectionShow";
            this.Text = "Update Oil Inspection Report ";
            this.Load += new System.EventHandler(this.frmOilInspectionShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxCasterCastingStock.ResumeLayout(false);
            this.gbxCasterCastingStock.PerformLayout();
            this.gbxOilInspection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbxCaster;
        private System.Windows.Forms.ComboBox cbxCaster;
        private System.Windows.Forms.Label lblRejectedQuantity;
        private System.Windows.Forms.Label lblCaster;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.ComboBox cbxChecker;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gbxCasterCastingStock;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpGlazeHouse;
        private System.Windows.Forms.CheckBox chkbxChecker;
        private System.Windows.Forms.TextBox txtCaster;
        private System.Windows.Forms.Label lblCasters;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtChecker;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDateUpdate;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCheckers;
        private System.Windows.Forms.Label lblUpdatedrejectedItems;
        private System.Windows.Forms.TextBox txtUpdatedRejectedItems;
        private System.Windows.Forms.TextBox txtUpdatedSelectedItems;
        private System.Windows.Forms.Label lblUpdatedSelectedItems;
        private System.Windows.Forms.GroupBox gbxOilInspection;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Label lblFreeMold;
        private System.Windows.Forms.Label lblCastedMold;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtCastedMold;
        private System.Windows.Forms.TextBox txtFreeMold;
        private System.Windows.Forms.TextBox txtRejectedItems;
        private System.Windows.Forms.TextBox txtSelectedQuantity;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn style_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedQuantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectedItemss;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkss;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}