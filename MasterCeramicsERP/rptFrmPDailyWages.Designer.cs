namespace MasterCeramicsERP
{
    partial class rptFrmPDailyWages
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
            this.crvDailyWages = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDailyWages
            // 
            this.crvDailyWages.ActiveViewIndex = -1;
            this.crvDailyWages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDailyWages.DisplayGroupTree = false;
            this.crvDailyWages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDailyWages.Location = new System.Drawing.Point(0, 0);
            this.crvDailyWages.Name = "crvDailyWages";
            this.crvDailyWages.SelectionFormula = "";
            this.crvDailyWages.Size = new System.Drawing.Size(784, 517);
            this.crvDailyWages.TabIndex = 4;
            this.crvDailyWages.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPDailyWages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvDailyWages);
            this.Name = "rptFrmPDailyWages";
            this.Text = "Daily Wages Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDailyWages;
    }
}