namespace MasterCeramicsERP
{
    partial class frmGreenWareItemCheckingShow
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
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtCastedQuantity = new System.Windows.Forms.TextBox();
            this.txtFreeQuantity = new System.Windows.Forms.TextBox();
            this.lblCastedQuantity = new System.Windows.Forms.Label();
            this.lblFreeQuantity = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.txtChecker = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCaster = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.lblChecker = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCaster = new System.Windows.Forms.Label();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.chkbxUpdate = new System.Windows.Forms.CheckBox();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpGlazeHouse = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbxReport = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.casterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_chk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.gbxReport.SuspendLayout();
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
            this.casterName,
            this.checkerName,
            this.item_chk,
            this.style_chk,
            this.size_chk,
            this.chkQuantity,
            this.date});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvReport.Location = new System.Drawing.Point(3, 14);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(779, 258);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUpdate.Controls.Add(this.txtCastedQuantity);
            this.gbxUpdate.Controls.Add(this.txtFreeQuantity);
            this.gbxUpdate.Controls.Add(this.lblCastedQuantity);
            this.gbxUpdate.Controls.Add(this.lblFreeQuantity);
            this.gbxUpdate.Controls.Add(this.txtSize);
            this.gbxUpdate.Controls.Add(this.txtDate);
            this.gbxUpdate.Controls.Add(this.txtStyle);
            this.gbxUpdate.Controls.Add(this.txtChecker);
            this.gbxUpdate.Controls.Add(this.txtItem);
            this.gbxUpdate.Controls.Add(this.txtCaster);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.lblChecker);
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtQuantity);
            this.gbxUpdate.Controls.Add(this.lblDateUpdate);
            this.gbxUpdate.Controls.Add(this.lblItem);
            this.gbxUpdate.Controls.Add(this.lblStyle);
            this.gbxUpdate.Controls.Add(this.lblSize);
            this.gbxUpdate.Controls.Add(this.lblQuantity);
            this.gbxUpdate.Controls.Add(this.lblCaster);
            this.gbxUpdate.Controls.Add(this.txtUpdateQuantity);
            this.gbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxUpdate.Location = new System.Drawing.Point(0, 7);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(570, 228);
            this.gbxUpdate.TabIndex = 0;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // txtCastedQuantity
            // 
            this.txtCastedQuantity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCastedQuantity.Enabled = false;
            this.txtCastedQuantity.Location = new System.Drawing.Point(430, 102);
            this.txtCastedQuantity.Name = "txtCastedQuantity";
            this.txtCastedQuantity.Size = new System.Drawing.Size(132, 21);
            this.txtCastedQuantity.TabIndex = 19;
            this.txtCastedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCastedQuantity_KeyPress);
            // 
            // txtFreeQuantity
            // 
            this.txtFreeQuantity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtFreeQuantity.Enabled = false;
            this.txtFreeQuantity.Location = new System.Drawing.Point(430, 49);
            this.txtFreeQuantity.Name = "txtFreeQuantity";
            this.txtFreeQuantity.Size = new System.Drawing.Size(132, 21);
            this.txtFreeQuantity.TabIndex = 17;
            this.txtFreeQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreeQuantity_KeyPress);
            // 
            // lblCastedQuantity
            // 
            this.lblCastedQuantity.AutoSize = true;
            this.lblCastedQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCastedQuantity.Location = new System.Drawing.Point(427, 78);
            this.lblCastedQuantity.Name = "lblCastedQuantity";
            this.lblCastedQuantity.Size = new System.Drawing.Size(105, 13);
            this.lblCastedQuantity.TabIndex = 18;
            this.lblCastedQuantity.Text = "Casted Quanity";
            // 
            // lblFreeQuantity
            // 
            this.lblFreeQuantity.AutoSize = true;
            this.lblFreeQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFreeQuantity.Location = new System.Drawing.Point(427, 28);
            this.lblFreeQuantity.Name = "lblFreeQuantity";
            this.lblFreeQuantity.Size = new System.Drawing.Size(96, 13);
            this.lblFreeQuantity.TabIndex = 16;
            this.lblFreeQuantity.Text = "Free Quantity";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(169, 118);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(255, 21);
            this.txtSize.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(169, 142);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(255, 21);
            this.txtDate.TabIndex = 11;
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtStyle.Enabled = false;
            this.txtStyle.Location = new System.Drawing.Point(169, 94);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(255, 21);
            this.txtStyle.TabIndex = 7;
            // 
            // txtChecker
            // 
            this.txtChecker.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtChecker.Enabled = false;
            this.txtChecker.Location = new System.Drawing.Point(169, 46);
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Size = new System.Drawing.Size(255, 21);
            this.txtChecker.TabIndex = 3;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(169, 70);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(255, 21);
            this.txtItem.TabIndex = 5;
            // 
            // txtCaster
            // 
            this.txtCaster.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCaster.Enabled = false;
            this.txtCaster.Location = new System.Drawing.Point(169, 22);
            this.txtCaster.Name = "txtCaster";
            this.txtCaster.Size = new System.Drawing.Size(255, 21);
            this.txtCaster.TabIndex = 1;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(6, 195);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(157, 13);
            this.lblUpdateQuantity.TabIndex = 14;
            this.lblUpdateQuantity.Text = "Enter updated quantity";
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblChecker.Location = new System.Drawing.Point(6, 49);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(60, 13);
            this.lblChecker.TabIndex = 2;
            this.lblChecker.Text = "Checker";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Location = new System.Drawing.Point(430, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Location = new System.Drawing.Point(430, 166);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(169, 166);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(255, 21);
            this.txtQuantity.TabIndex = 13;
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDateUpdate.Location = new System.Drawing.Point(6, 145);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(37, 13);
            this.lblDateUpdate.TabIndex = 10;
            this.lblDateUpdate.Text = "Date";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblItem.Location = new System.Drawing.Point(6, 73);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 13);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStyle.Location = new System.Drawing.Point(6, 97);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(40, 13);
            this.lblStyle.TabIndex = 6;
            this.lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSize.Location = new System.Drawing.Point(6, 121);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 13);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblQuantity.Location = new System.Drawing.Point(6, 169);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCaster
            // 
            this.lblCaster.AutoSize = true;
            this.lblCaster.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCaster.Location = new System.Drawing.Point(6, 28);
            this.lblCaster.Name = "lblCaster";
            this.lblCaster.Size = new System.Drawing.Size(49, 13);
            this.lblCaster.TabIndex = 0;
            this.lblCaster.Text = "Caster";
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateQuantity.Location = new System.Drawing.Point(169, 192);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(255, 21);
            this.txtUpdateQuantity.TabIndex = 15;
            this.txtUpdateQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdateQuantity_MouseClick);
            // 
            // chkbxUpdate
            // 
            this.chkbxUpdate.AutoSize = true;
            this.chkbxUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkbxUpdate.Location = new System.Drawing.Point(576, 223);
            this.chkbxUpdate.Name = "chkbxUpdate";
            this.chkbxUpdate.Size = new System.Drawing.Size(132, 17);
            this.chkbxUpdate.TabIndex = 7;
            this.chkbxUpdate.Text = "Enable Updation";
            this.chkbxUpdate.UseVisualStyleBackColor = true;
            this.chkbxUpdate.CheckedChanged += new System.EventHandler(this.chkbxUpdate_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnMonth.Location = new System.Drawing.Point(576, 91);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(64, 17);
            this.rbtnMonth.TabIndex = 4;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnDay.Location = new System.Drawing.Point(576, 66);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(50, 17);
            this.rbtnDay.TabIndex = 3;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDate.Location = new System.Drawing.Point(576, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Select Date";
            // 
            // dtpGlazeHouse
            // 
            this.dtpGlazeHouse.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.dtpGlazeHouse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGlazeHouse.Location = new System.Drawing.Point(576, 34);
            this.dtpGlazeHouse.Name = "dtpGlazeHouse";
            this.dtpGlazeHouse.Size = new System.Drawing.Size(200, 21);
            this.dtpGlazeHouse.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnShow.Location = new System.Drawing.Point(685, 123);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(97, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbxReport
            // 
            this.gbxReport.Controls.Add(this.dgvReport);
            this.gbxReport.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReport.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxReport.Location = new System.Drawing.Point(0, 241);
            this.gbxReport.Name = "gbxReport";
            this.gbxReport.Size = new System.Drawing.Size(785, 275);
            this.gbxReport.TabIndex = 8;
            this.gbxReport.TabStop = false;
            this.gbxReport.Text = "Greenware Item Checking Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPrint.Location = new System.Drawing.Point(685, 153);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnYear.Location = new System.Drawing.Point(576, 114);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(55, 17);
            this.rbtnYear.TabIndex = 9;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // casterName
            // 
            this.casterName.HeaderText = "Caster Name";
            this.casterName.Name = "casterName";
            this.casterName.ReadOnly = true;
            this.casterName.Width = 150;
            // 
            // checkerName
            // 
            this.checkerName.HeaderText = "Checker Name";
            this.checkerName.Name = "checkerName";
            this.checkerName.ReadOnly = true;
            this.checkerName.Width = 150;
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
            // chkQuantity
            // 
            this.chkQuantity.HeaderText = "Checked Quantity ";
            this.chkQuantity.Name = "chkQuantity";
            this.chkQuantity.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // frmGreenWareItemCheckingShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbxReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpGlazeHouse);
            this.Controls.Add(this.chkbxUpdate);
            this.Controls.Add(this.gbxUpdate);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmGreenWareItemCheckingShow";
            this.Text = "Update Caster Item Checking Report";
            this.Load += new System.EventHandler(this.frmGreenWareItemCheckingShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.TextBox txtChecker;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCaster;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDateUpdate;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCaster;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.CheckBox chkbxUpdate;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpGlazeHouse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gbxReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtCastedQuantity;
        private System.Windows.Forms.TextBox txtFreeQuantity;
        private System.Windows.Forms.Label lblCastedQuantity;
        private System.Windows.Forms.Label lblFreeQuantity;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn style_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}