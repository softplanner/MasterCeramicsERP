namespace MasterCeramicsERP
{
    partial class frmGreenWareItemChecking
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
            this.dgvGreenWare = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxGreenWare = new System.Windows.Forms.GroupBox();
            this.gbxCasterStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.ItemRemainingItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleRemainingItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRemainingItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.cbxSelectJob = new System.Windows.Forms.ComboBox();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblSelectJobChecker = new System.Windows.Forms.Label();
            this.cbxJobChecker = new System.Windows.Forms.ComboBox();
            this.cbxChecker = new System.Windows.Forms.ComboBox();
            this.lblChecker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGreenWare)).BeginInit();
            this.gbxGreenWare.SuspendLayout();
            this.gbxCasterStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGreenWare
            // 
            this.dgvGreenWare.AllowUserToAddRows = false;
            this.dgvGreenWare.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGreenWare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGreenWare.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGreenWare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGreenWare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.style,
            this.size,
            this.checkedQuantity});
            this.dgvGreenWare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGreenWare.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvGreenWare.Location = new System.Drawing.Point(3, 14);
            this.dgvGreenWare.Name = "dgvGreenWare";
            this.dgvGreenWare.ReadOnly = true;
            this.dgvGreenWare.Size = new System.Drawing.Size(780, 249);
            this.dgvGreenWare.TabIndex = 0;
            this.dgvGreenWare.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGreenWare_CellClick);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 200;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 190;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 180;
            // 
            // checkedQuantity
            // 
            this.checkedQuantity.HeaderText = "Checked Quantity";
            this.checkedQuantity.Name = "checkedQuantity";
            this.checkedQuantity.ReadOnly = true;
            this.checkedQuantity.Width = 180;
            // 
            // btnAddDB
            // 
            this.btnAddDB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDB.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddDB.Location = new System.Drawing.Point(557, 225);
            this.btnAddDB.Name = "btnAddDB";
            this.btnAddDB.Size = new System.Drawing.Size(107, 20);
            this.btnAddDB.TabIndex = 5;
            this.btnAddDB.Text = "Save ";
            this.btnAddDB.UseVisualStyleBackColor = true;
            this.btnAddDB.Click += new System.EventHandler(this.btnAddDB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Location = new System.Drawing.Point(670, 225);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 20);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(214, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Location = new System.Drawing.Point(327, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 20);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxGreenWare
            // 
            this.gbxGreenWare.Controls.Add(this.dgvGreenWare);
            this.gbxGreenWare.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGreenWare.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxGreenWare.Location = new System.Drawing.Point(-1, 247);
            this.gbxGreenWare.Name = "gbxGreenWare";
            this.gbxGreenWare.Size = new System.Drawing.Size(786, 266);
            this.gbxGreenWare.TabIndex = 9;
            this.gbxGreenWare.TabStop = false;
            this.gbxGreenWare.Text = "Greenware Item Checking";
            // 
            // gbxCasterStock
            // 
            this.gbxCasterStock.BackColor = System.Drawing.SystemColors.Control;
            this.gbxCasterStock.Controls.Add(this.dgvStock);
            this.gbxCasterStock.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCasterStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbxCasterStock.Location = new System.Drawing.Point(211, -2);
            this.gbxCasterStock.Name = "gbxCasterStock";
            this.gbxCasterStock.Size = new System.Drawing.Size(569, 222);
            this.gbxCasterStock.TabIndex = 0;
            this.gbxCasterStock.TabStop = false;
            this.gbxCasterStock.Text = "Caster Mold Stock";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemRemainingItem,
            this.styleRemainingItem,
            this.sizeRemainingItem,
            this.quantities});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvStock.Location = new System.Drawing.Point(3, 14);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(563, 205);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // ItemRemainingItem
            // 
            this.ItemRemainingItem.HeaderText = "Item";
            this.ItemRemainingItem.Name = "ItemRemainingItem";
            this.ItemRemainingItem.ReadOnly = true;
            this.ItemRemainingItem.Width = 140;
            // 
            // styleRemainingItem
            // 
            this.styleRemainingItem.HeaderText = "Style";
            this.styleRemainingItem.Name = "styleRemainingItem";
            this.styleRemainingItem.ReadOnly = true;
            this.styleRemainingItem.Width = 130;
            // 
            // sizeRemainingItem
            // 
            this.sizeRemainingItem.HeaderText = "Size";
            this.sizeRemainingItem.Name = "sizeRemainingItem";
            this.sizeRemainingItem.ReadOnly = true;
            this.sizeRemainingItem.Width = 130;
            // 
            // quantities
            // 
            this.quantities.HeaderText = "Quantity";
            this.quantities.Name = "quantities";
            this.quantities.ReadOnly = true;
            this.quantities.Width = 140;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(7, 222);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(198, 21);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblQuantity.Location = new System.Drawing.Point(7, 204);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectJob.Location = new System.Drawing.Point(4, 9);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(177, 13);
            this.lblSelectJob.TabIndex = 22;
            this.lblSelectJob.Text = "Select category for caster";
            // 
            // cbxSelectJob
            // 
            this.cbxSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectJob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectJob.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxSelectJob.FormattingEnabled = true;
            this.cbxSelectJob.Location = new System.Drawing.Point(4, 25);
            this.cbxSelectJob.Name = "cbxSelectJob";
            this.cbxSelectJob.Size = new System.Drawing.Size(201, 21);
            this.cbxSelectJob.TabIndex = 23;
            this.cbxSelectJob.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectJob_SelectionChangeCommitted);
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(4, 72);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(201, 21);
            this.cbxWorker.TabIndex = 21;
            this.cbxWorker.SelectionChangeCommitted += new System.EventHandler(this.cbxWorker_SelectionChangeCommitted);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWorker.Location = new System.Drawing.Point(4, 56);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(92, 13);
            this.lblWorker.TabIndex = 20;
            this.lblWorker.Text = "Select caster";
            // 
            // lblSelectJobChecker
            // 
            this.lblSelectJobChecker.AutoSize = true;
            this.lblSelectJobChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectJobChecker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectJobChecker.Location = new System.Drawing.Point(7, 107);
            this.lblSelectJobChecker.Name = "lblSelectJobChecker";
            this.lblSelectJobChecker.Size = new System.Drawing.Size(188, 13);
            this.lblSelectJobChecker.TabIndex = 26;
            this.lblSelectJobChecker.Text = "Select category for checker";
            // 
            // cbxJobChecker
            // 
            this.cbxJobChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJobChecker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxJobChecker.FormattingEnabled = true;
            this.cbxJobChecker.Location = new System.Drawing.Point(7, 123);
            this.cbxJobChecker.Name = "cbxJobChecker";
            this.cbxJobChecker.Size = new System.Drawing.Size(201, 21);
            this.cbxJobChecker.TabIndex = 27;
            this.cbxJobChecker.SelectionChangeCommitted += new System.EventHandler(this.cbxJobChecker_SelectionChangeCommitted);
            // 
            // cbxChecker
            // 
            this.cbxChecker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChecker.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbxChecker.FormattingEnabled = true;
            this.cbxChecker.Location = new System.Drawing.Point(7, 174);
            this.cbxChecker.Name = "cbxChecker";
            this.cbxChecker.Size = new System.Drawing.Size(201, 21);
            this.cbxChecker.TabIndex = 25;
            this.cbxChecker.SelectionChangeCommitted += new System.EventHandler(this.cbxChecker_SelectionChangeCommitted);
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecker.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblChecker.Location = new System.Drawing.Point(7, 158);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(103, 13);
            this.lblChecker.TabIndex = 24;
            this.lblChecker.Text = "Select checker";
            // 
            // frmGreenWareItemChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblSelectJobChecker);
            this.Controls.Add(this.cbxJobChecker);
            this.Controls.Add(this.cbxChecker);
            this.Controls.Add(this.lblChecker);
            this.Controls.Add(this.lblSelectJob);
            this.Controls.Add(this.cbxSelectJob);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.gbxCasterStock);
            this.Controls.Add(this.gbxGreenWare);
            this.Controls.Add(this.btnAddDB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.MaximumSize = new System.Drawing.Size(800, 555);
            this.MinimumSize = new System.Drawing.Size(800, 555);
            this.Name = "frmGreenWareItemChecking";
            this.Text = "Add Caster Item Checking Report";
            this.Load += new System.EventHandler(this.frmGreenWareItemChecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGreenWare)).EndInit();
            this.gbxGreenWare.ResumeLayout(false);
            this.gbxCasterStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGreenWare;
        private System.Windows.Forms.Button btnAddDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxGreenWare;
        private System.Windows.Forms.GroupBox gbxCasterStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.ComboBox cbxSelectJob;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblSelectJobChecker;
        private System.Windows.Forms.ComboBox cbxJobChecker;
        private System.Windows.Forms.ComboBox cbxChecker;
        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemainingItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleRemainingItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRemainingItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantities;
    }
}