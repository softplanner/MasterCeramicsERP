namespace MasterCeramicsERP
{
    partial class rptFrmUnglazeItemStock
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
            this.crvUnglazedItemStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvUnglazedItemStock
            // 
            this.crvUnglazedItemStock.ActiveViewIndex = -1;
            this.crvUnglazedItemStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUnglazedItemStock.DisplayGroupTree = false;
            this.crvUnglazedItemStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUnglazedItemStock.Location = new System.Drawing.Point(0, 0);
            this.crvUnglazedItemStock.Name = "crvUnglazedItemStock";
            this.crvUnglazedItemStock.SelectionFormula = "";
            this.crvUnglazedItemStock.Size = new System.Drawing.Size(784, 517);
            this.crvUnglazedItemStock.TabIndex = 0;
            this.crvUnglazedItemStock.ViewTimeSelectionFormula = "";
            // 
            // rptFrmUnglazeItemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvUnglazedItemStock);
            this.Name = "rptFrmUnglazeItemStock";
            this.Text = "Unglazed Item Stock Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUnglazedItemStock;
    }
}