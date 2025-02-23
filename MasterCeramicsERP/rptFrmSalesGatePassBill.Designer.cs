namespace MasterCeramicsERP
{
    partial class rptFrmSalesGatePassBill
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
            this.crvKillenFeed = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvKillenFeed
            // 
            this.crvKillenFeed.ActiveViewIndex = -1;
            this.crvKillenFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvKillenFeed.DisplayGroupTree = false;
            this.crvKillenFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvKillenFeed.Location = new System.Drawing.Point(0, 0);
            this.crvKillenFeed.Name = "crvKillenFeed";
            this.crvKillenFeed.SelectionFormula = "";
            this.crvKillenFeed.Size = new System.Drawing.Size(784, 517);
            this.crvKillenFeed.TabIndex = 1;
            this.crvKillenFeed.ViewTimeSelectionFormula = "";
            // 
            // rptFrmSalesGatePassBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvKillenFeed);
            this.Name = "rptFrmSalesGatePassBill";
            this.Text = "Gate-Pass Bill\'s";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvKillenFeed;
    }
}