namespace MasterCeramicsERP
{
    partial class rptFrmMoldStockCompany
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
            this.crvMoldStockCompany = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMoldStockCompany
            // 
            this.crvMoldStockCompany.ActiveViewIndex = -1;
            this.crvMoldStockCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMoldStockCompany.DisplayGroupTree = false;
            this.crvMoldStockCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMoldStockCompany.Location = new System.Drawing.Point(0, 0);
            this.crvMoldStockCompany.Name = "crvMoldStockCompany";
            this.crvMoldStockCompany.SelectionFormula = "";
            this.crvMoldStockCompany.Size = new System.Drawing.Size(784, 517);
            this.crvMoldStockCompany.TabIndex = 0;
            this.crvMoldStockCompany.ViewTimeSelectionFormula = "";
            // 
            // rptFrmMoldStockCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvMoldStockCompany);
            this.Name = "rptFrmMoldStockCompany";
            this.Text = "Company Mold Stock Report";
            this.Load += new System.EventHandler(this.rptFrmMoldStockCompany_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMoldStockCompany;
    }
}