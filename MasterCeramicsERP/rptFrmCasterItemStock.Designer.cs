namespace MasterCeramicsERP
{
    partial class rptFrmCasterItemStock
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
            this.crvCasterItemStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCasterItemStock
            // 
            this.crvCasterItemStock.ActiveViewIndex = -1;
            this.crvCasterItemStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCasterItemStock.DisplayGroupTree = false;
            this.crvCasterItemStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCasterItemStock.Location = new System.Drawing.Point(0, 0);
            this.crvCasterItemStock.Name = "crvCasterItemStock";
            this.crvCasterItemStock.SelectionFormula = "";
            this.crvCasterItemStock.Size = new System.Drawing.Size(784, 517);
            this.crvCasterItemStock.TabIndex = 0;
            this.crvCasterItemStock.ViewTimeSelectionFormula = "";
            // 
            // rptFrmCasterItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvCasterItemStock);
            this.Name = "rptFrmCasterItemStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caster unglaze item\'s stock";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCasterItemStock;
    }
}