namespace MasterCeramicsERP
{
    partial class salesViewDelChalGP
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
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteComplete = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewOrderInfo = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.gbxCustomerOrder = new System.Windows.Forms.GroupBox();
            this.lblTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.gbxCustomerOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 200;
            // 
            // gp
            // 
            this.gp.HeaderText = "Gate Pass";
            this.gp.Name = "gp";
            this.gp.ReadOnly = true;
            this.gp.Width = 60;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrint.Location = new System.Drawing.Point(679, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 23);
            this.btnPrint.TabIndex = 107;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 60;
            // 
            // Dealer
            // 
            this.Dealer.HeaderText = "Dealer";
            this.Dealer.Name = "Dealer";
            this.Dealer.ReadOnly = true;
            // 
            // btnDeleteComplete
            // 
            this.btnDeleteComplete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComplete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteComplete.Location = new System.Drawing.Point(421, 34);
            this.btnDeleteComplete.Name = "btnDeleteComplete";
            this.btnDeleteComplete.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteComplete.TabIndex = 106;
            this.btnDeleteComplete.Text = "Delete Challan";
            this.btnDeleteComplete.UseVisualStyleBackColor = true;
            this.btnDeleteComplete.Click += new System.EventHandler(this.btnDeleteChallan_Click);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 90;
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dealer,
            this.item,
            this.style,
            this.size,
            this.color,
            this.quantity,
            this.gp,
            this.date});
            this.dgvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderInfo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrderInfo.Location = new System.Drawing.Point(4, 14);
            this.dgvOrderInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.Size = new System.Drawing.Size(766, 431);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellClick);
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            this.style.Width = 80;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 70;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(289, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewOrderInfo
            // 
            this.btnViewOrderInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewOrderInfo.Location = new System.Drawing.Point(197, 34);
            this.btnViewOrderInfo.Name = "btnViewOrderInfo";
            this.btnViewOrderInfo.Size = new System.Drawing.Size(86, 23);
            this.btnViewOrderInfo.TabIndex = 102;
            this.btnViewOrderInfo.Text = "View Order";
            this.btnViewOrderInfo.UseVisualStyleBackColor = true;
            this.btnViewOrderInfo.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.SystemColors.Control;
            this.txtTemp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTemp.Location = new System.Drawing.Point(12, 36);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(179, 21);
            this.txtTemp.TabIndex = 99;
            // 
            // gbxCustomerOrder
            // 
            this.gbxCustomerOrder.Controls.Add(this.dgvOrderInfo);
            this.gbxCustomerOrder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxCustomerOrder.Location = new System.Drawing.Point(5, 63);
            this.gbxCustomerOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Name = "gbxCustomerOrder";
            this.gbxCustomerOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCustomerOrder.Size = new System.Drawing.Size(774, 448);
            this.gbxCustomerOrder.TabIndex = 97;
            this.gbxCustomerOrder.TabStop = false;
            this.gbxCustomerOrder.Text = "View  Order Info";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTemp.Location = new System.Drawing.Point(9, 13);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(177, 13);
            this.lblTemp.TabIndex = 98;
            this.lblTemp.Text = "Enter Gate Pass Number ::";
            // 
            // salesViewDelChalGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDeleteComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewOrderInfo);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.gbxCustomerOrder);
            this.Controls.Add(this.lblTemp);
            this.Name = "salesViewDelChalGP";
            this.Text = "salesViewDelChalGP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.gbxCustomerOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dealer;
        private System.Windows.Forms.Button btnDeleteComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewOrderInfo;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.GroupBox gbxCustomerOrder;
        private System.Windows.Forms.Label lblTemp;
    }
}