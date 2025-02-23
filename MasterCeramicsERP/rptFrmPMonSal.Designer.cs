namespace MasterCeramicsERP
{
    partial class rptFrmPMonSal
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
            this.crvMonthlySal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMonthlySal
            // 
            this.crvMonthlySal.ActiveViewIndex = -1;
            this.crvMonthlySal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMonthlySal.DisplayGroupTree = false;
            this.crvMonthlySal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMonthlySal.Location = new System.Drawing.Point(0, 0);
            this.crvMonthlySal.Name = "crvMonthlySal";
            this.crvMonthlySal.SelectionFormula = "";
            this.crvMonthlySal.Size = new System.Drawing.Size(784, 517);
            this.crvMonthlySal.TabIndex = 3;
            this.crvMonthlySal.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPMonSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvMonthlySal);
            this.Name = "rptFrmPMonSal";
            this.Text = "Monthly Salary Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMonthlySal;
    }
}