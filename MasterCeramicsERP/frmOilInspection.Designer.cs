namespace MasterCeramicsERP
{
    partial class frmOilInspection
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.item_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedQuantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectedItemss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaster = new System.Windows.Forms.DataGridView();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSelectedQuantity = new System.Windows.Forms.TextBox();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.lblRejectedQuantity = new System.Windows.Forms.Label();
            this.gbxCasterCastingStock = new System.Windows.Forms.GroupBox();
            this.lblSelectJobChecker = new System.Windows.Forms.Label();
            this.cbxJobChecker = new System.Windows.Forms.ComboBox();
            this.lblChecker = new System.Windows.Forms.Label();
            this.cbxChecker = new System.Windows.Forms.ComboBox();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.chkbxAddRemarks = new System.Windows.Forms.CheckBox();
            this.lblSelectRemarks = new System.Windows.Forms.Label();
            this.cbxRemarks = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRejectedItems = new System.Windows.Forms.TextBox();
            this.gbxOilInspection = new System.Windows.Forms.GroupBox();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaster)).BeginInit();
            this.gbxCasterCastingStock.SuspendLayout();
            this.gbxOilInspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_chk,
            this.style_chk,
            this.size_chk,
            this.selectedQuantities,
            this.rejectedItemss,
            this.remarkss});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.DarkViolet;
            this.dgvReport.Location = new System.Drawing.Point(3, 14);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(776, 221);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // item_chk
            // 
            this.item_chk.HeaderText = "Item";
            this.item_chk.Name = "item_chk";
            this.item_chk.ReadOnly = true;
            this.item_chk.Width = 140;
            // 
            // style_chk
            // 
            this.style_chk.HeaderText = "Style";
            this.style_chk.Name = "style_chk";
            this.style_chk.ReadOnly = true;
            this.style_chk.Width = 140;
            // 
            // size_chk
            // 
            this.size_chk.HeaderText = "Size";
            this.size_chk.Name = "size_chk";
            this.size_chk.ReadOnly = true;
            this.size_chk.Width = 120;
            // 
            // selectedQuantities
            // 
            this.selectedQuantities.HeaderText = "Selected Items ";
            this.selectedQuantities.Name = "selectedQuantities";
            this.selectedQuantities.ReadOnly = true;
            // 
            // rejectedItemss
            // 
            this.rejectedItemss.HeaderText = "Rejected Items ";
            this.rejectedItemss.Name = "rejectedItemss";
            this.rejectedItemss.ReadOnly = true;
            // 
            // remarkss
            // 
            this.remarkss.HeaderText = "Remarks";
            this.remarkss.Name = "remarkss";
            this.remarkss.ReadOnly = true;
            this.remarkss.Width = 150;
            // 
            // dgvCaster
            // 
            this.dgvCaster.AllowUserToAddRows = false;
            this.dgvCaster.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.style,
            this.size,
            this.quantity});
            this.dgvCaster.GridColor = System.Drawing.Color.DarkViolet;
            this.dgvCaster.Location = new System.Drawing.Point(7, 19);
            this.dgvCaster.Name = "dgvCaster";
            this.dgvCaster.ReadOnly = true;
            this.dgvCaster.Size = new System.Drawing.Size(418, 247);
            this.dgvCaster.TabIndex = 0;
            this.dgvCaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaster_CellClick);
            // 
            // btnAddDB
            // 
            this.btnAddDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAddDB.Location = new System.Drawing.Point(604, 243);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(79, 23);
            this.btnAddDB.TabIndex = 17;
            this.btnAddDB.Text = "Save ";
            this.btnAddDB.UseVisualStyleBackColor = false;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnRefresh.Location = new System.Drawing.Point(690, 243);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.Location = new System.Drawing.Point(434, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSelectedQuantity
            // 
            this.txtSelectedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtSelectedQuantity.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtSelectedQuantity.Location = new System.Drawing.Point(580, 108);
            this.txtSelectedQuantity.Name = "txtSelectedQuantity";
            this.txtSelectedQuantity.Size = new System.Drawing.Size(188, 18);
            this.txtSelectedQuantity.TabIndex = 6;
            this.txtSelectedQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSelectedQuantity_MouseClick);
            this.txtSelectedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSelectedQuantity_KeyPress);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItems.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSelectedItems.Location = new System.Drawing.Point(430, 111);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(145, 13);
            this.lblSelectedItems.TabIndex = 5;
            this.lblSelectedItems.Text = "Enter selected item\'s";
            // 
            // lblRejectedQuantity
            // 
            this.lblRejectedQuantity.AutoSize = true;
            this.lblRejectedQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedQuantity.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRejectedQuantity.Location = new System.Drawing.Point(429, 134);
            this.lblRejectedQuantity.Name = "lblRejectedQuantity";
            this.lblRejectedQuantity.Size = new System.Drawing.Size(145, 13);
            this.lblRejectedQuantity.TabIndex = 7;
            this.lblRejectedQuantity.Text = "Enter rejected item\'s";
            // 
            // gbxCasterCastingStock
            // 
            this.gbxCasterCastingStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxCasterCastingStock.Controls.Add(this.lblSelectJobChecker);
            this.gbxCasterCastingStock.Controls.Add(this.cbxJobChecker);
            this.gbxCasterCastingStock.Controls.Add(this.lblChecker);
            this.gbxCasterCastingStock.Controls.Add(this.cbxChecker);
            this.gbxCasterCastingStock.Controls.Add(this.lblSelectJob);
            this.gbxCasterCastingStock.Controls.Add(this.cbxSelectJob);
            this.gbxCasterCastingStock.Controls.Add(this.cbxWorker);
            this.gbxCasterCastingStock.Controls.Add(this.lblWorker);
            this.gbxCasterCastingStock.Controls.Add(this.btnAddDB);
            this.gbxCasterCastingStock.Controls.Add(this.lblRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.txtRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.btnRefresh);
            this.gbxCasterCastingStock.Controls.Add(this.chkbxAddRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.dgvCaster);
            this.gbxCasterCastingStock.Controls.Add(this.lblSelectRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.cbxRemarks);
            this.gbxCasterCastingStock.Controls.Add(this.btnDelete);
            this.gbxCasterCastingStock.Controls.Add(this.btnAdd);
            this.gbxCasterCastingStock.Controls.Add(this.lblRejectedQuantity);
            this.gbxCasterCastingStock.Controls.Add(this.txtRejectedItems);
            this.gbxCasterCastingStock.Controls.Add(this.txtSelectedQuantity);
            this.gbxCasterCastingStock.Controls.Add(this.lblSelectedItems);
            this.gbxCasterCastingStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCasterCastingStock.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbxCasterCastingStock.Location = new System.Drawing.Point(4, 2);
            this.gbxCasterCastingStock.Name = "gbxCasterCastingStock";
            this.gbxCasterCastingStock.Size = new System.Drawing.Size(775, 272);
            this.gbxCasterCastingStock.TabIndex = 0;
            this.gbxCasterCastingStock.TabStop = false;
            this.gbxCasterCastingStock.Text = "Casted Mold Stock";
            // 
            // lblSelectJobChecker
            // 
            this.lblSelectJobChecker.AutoSize = true;
            this.lblSelectJobChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJobChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSelectJobChecker.Location = new System.Drawing.Point(434, 22);
            this.lblSelectJobChecker.Name = "lblSelectJobChecker";
            this.lblSelectJobChecker.Size = new System.Drawing.Size(137, 13);
            this.lblSelectJobChecker.TabIndex = 32;
            this.lblSelectJobChecker.Text = "Job for oil inspector";
            // 
            // cbxJobChecker
            // 
            this.cbxJobChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJobChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxJobChecker.FormattingEnabled = true;
            this.cbxJobChecker.Location = new System.Drawing.Point(434, 37);
            this.cbxJobChecker.Name = "cbxJobChecker";
            this.cbxJobChecker.Size = new System.Drawing.Size(164, 21);
            this.cbxJobChecker.TabIndex = 33;
            this.cbxJobChecker.SelectionChangeCommitted += new System.EventHandler(this.cbxJobChecker_SelectionChangeCommitted);
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblChecker.Location = new System.Drawing.Point(604, 21);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(91, 13);
            this.lblChecker.TabIndex = 30;
            this.lblChecker.Text = "Oil Inspector";
            // 
            // cbxChecker
            // 
            this.cbxChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChecker.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxChecker.FormattingEnabled = true;
            this.cbxChecker.Location = new System.Drawing.Point(607, 37);
            this.cbxChecker.Name = "cbxChecker";
            this.cbxChecker.Size = new System.Drawing.Size(164, 21);
            this.cbxChecker.TabIndex = 31;
            this.cbxChecker.SelectionChangeCommitted += new System.EventHandler(this.cbxChecker_SelectionChangeCommitted);
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSelectJob.Location = new System.Drawing.Point(434, 61);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(97, 13);
            this.lblSelectJob.TabIndex = 24;
            this.lblSelectJob.Text = "Job for caster";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(434, 78);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(164, 21);
            this.cbxSelectJob.TabIndex = 25;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(607, 78);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(164, 21);
            this.cbxWorker.TabIndex = 2;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblWorker.Location = new System.Drawing.Point(604, 61);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 13);
            this.lblWorker.TabIndex = 1;
            this.lblWorker.Text = "Caster";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblRemarks.Location = new System.Drawing.Point(431, 207);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 13);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtRemarks.Location = new System.Drawing.Point(580, 207);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(188, 33);
            this.txtRemarks.TabIndex = 13;
            this.txtRemarks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRemarks_MouseClick);
            // 
            // chkbxAddRemarks
            // 
            this.chkbxAddRemarks.AutoSize = true;
            this.chkbxAddRemarks.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxAddRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.chkbxAddRemarks.Location = new System.Drawing.Point(580, 190);
            this.chkbxAddRemarks.Name = "chkbxAddRemarks";
            this.chkbxAddRemarks.Size = new System.Drawing.Size(90, 16);
            this.chkbxAddRemarks.TabIndex = 12;
            this.chkbxAddRemarks.Text = "Add Remarks";
            this.chkbxAddRemarks.UseVisualStyleBackColor = true;
            this.chkbxAddRemarks.CheckedChanged += new System.EventHandler(this.chkbxAddRemarks_CheckedChanged);
            // 
            // lblSelectRemarks
            // 
            this.lblSelectRemarks.AutoSize = true;
            this.lblSelectRemarks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblSelectRemarks.Location = new System.Drawing.Point(430, 160);
            this.lblSelectRemarks.Name = "lblSelectRemarks";
            this.lblSelectRemarks.Size = new System.Drawing.Size(108, 13);
            this.lblSelectRemarks.TabIndex = 9;
            this.lblSelectRemarks.Text = "Select Remarks";
            // 
            // cbxRemarks
            // 
            this.cbxRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemarks.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbxRemarks.FormattingEnabled = true;
            this.cbxRemarks.Location = new System.Drawing.Point(580, 157);
            this.cbxRemarks.Name = "cbxRemarks";
            this.cbxRemarks.Size = new System.Drawing.Size(188, 20);
            this.cbxRemarks.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.Location = new System.Drawing.Point(519, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRejectedItems
            // 
            this.txtRejectedItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtRejectedItems.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtRejectedItems.Location = new System.Drawing.Point(580, 134);
            this.txtRejectedItems.Name = "txtRejectedItems";
            this.txtRejectedItems.Size = new System.Drawing.Size(188, 18);
            this.txtRejectedItems.TabIndex = 8;
            this.txtRejectedItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRejectedItems_MouseClick);
            this.txtRejectedItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRejectedItems_KeyPress);
            // 
            // gbxOilInspection
            // 
            this.gbxOilInspection.Controls.Add(this.dgvReport);
            this.gbxOilInspection.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOilInspection.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbxOilInspection.Location = new System.Drawing.Point(0, 279);
            this.gbxOilInspection.Name = "gbxOilInspection";
            this.gbxOilInspection.Size = new System.Drawing.Size(782, 238);
            this.gbxOilInspection.TabIndex = 1;
            this.gbxOilInspection.TabStop = false;
            this.gbxOilInspection.Text = "Oil Inspection Report";
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
            // quantity
            // 
            this.quantity.HeaderText = "Casted Mold Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // frmOilInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gbxOilInspection);
            this.Controls.Add(this.gbxCasterCastingStock);
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmOilInspection";
            this.Text = "Add Oil Inspection Report";
            this.Load += new System.EventHandler(this.frmOilInspection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaster)).EndInit();
            this.gbxCasterCastingStock.ResumeLayout(false);
            this.gbxCasterCastingStock.PerformLayout();
            this.gbxOilInspection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridView dgvCaster;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSelectedQuantity;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.Label lblRejectedQuantity;
        private System.Windows.Forms.GroupBox gbxCasterCastingStock;
        private System.Windows.Forms.CheckBox chkbxAddRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cbxRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblSelectRemarks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRejectedItems;
        private System.Windows.Forms.GroupBox gbxOilInspection;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn style_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedQuantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectedItemss;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkss;
        private System.Windows.Forms.Label lblSelectJobChecker;
        private System.Windows.Forms.ComboBox cbxJobChecker;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.ComboBox cbxChecker;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}