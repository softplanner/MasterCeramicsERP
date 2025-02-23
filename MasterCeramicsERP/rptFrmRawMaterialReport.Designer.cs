namespace MasterCeramicsERP
{
    partial class rptFrmRawMaterialReport
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
            this.crvRawMaterialReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRawMaterialReport
            // 
            this.crvRawMaterialReport.ActiveViewIndex = -1;
            this.crvRawMaterialReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRawMaterialReport.DisplayGroupTree = false;
            this.crvRawMaterialReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRawMaterialReport.Location = new System.Drawing.Point(0, 0);
            this.crvRawMaterialReport.Name = "crvRawMaterialReport";
            this.crvRawMaterialReport.SelectionFormula = "";
            this.crvRawMaterialReport.Size = new System.Drawing.Size(784, 517);
            this.crvRawMaterialReport.TabIndex = 0;
            this.crvRawMaterialReport.ViewTimeSelectionFormula = "";
            // 
            // rptFrmRawMaterialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvRawMaterialReport);
            this.Name = "rptFrmRawMaterialReport";
            this.Text = "Raw Material Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRawMaterialReport;
    }
}