namespace MasterCeramicsERP
{
    partial class rptFrmMoldCastingReport
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
            this.crvMoldCasingReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMoldCasingReport
            // 
            this.crvMoldCasingReport.ActiveViewIndex = -1;
            this.crvMoldCasingReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMoldCasingReport.DisplayGroupTree = false;
            this.crvMoldCasingReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMoldCasingReport.Location = new System.Drawing.Point(0, 0);
            this.crvMoldCasingReport.Name = "crvMoldCasingReport";
            this.crvMoldCasingReport.SelectionFormula = "";
            this.crvMoldCasingReport.Size = new System.Drawing.Size(784, 517);
            this.crvMoldCasingReport.TabIndex = 0;
            this.crvMoldCasingReport.ViewTimeSelectionFormula = "";
            // 
            // rptFrmMoldCastingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvMoldCasingReport);
            this.Name = "rptFrmMoldCastingReport";
            this.Text = "Mold Casting Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMoldCasingReport;
    }
}