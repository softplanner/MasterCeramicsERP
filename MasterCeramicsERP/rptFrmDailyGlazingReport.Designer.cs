namespace MasterCeramicsERP
{
    partial class rptFrmDailyGlazingReport
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
            this.crvDailyGlazingReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDailyGlazingReport
            // 
            this.crvDailyGlazingReport.ActiveViewIndex = -1;
            this.crvDailyGlazingReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDailyGlazingReport.DisplayGroupTree = false;
            this.crvDailyGlazingReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDailyGlazingReport.Location = new System.Drawing.Point(0, 0);
            this.crvDailyGlazingReport.Name = "crvDailyGlazingReport";
            this.crvDailyGlazingReport.SelectionFormula = "";
            this.crvDailyGlazingReport.Size = new System.Drawing.Size(784, 517);
            this.crvDailyGlazingReport.TabIndex = 0;
            this.crvDailyGlazingReport.ViewTimeSelectionFormula = "";
            // 
            // rptFrmDailyGlazingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvDailyGlazingReport);
            this.Name = "rptFrmDailyGlazingReport";
            this.Text = "Daily Glazing Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDailyGlazingReport;
    }
}