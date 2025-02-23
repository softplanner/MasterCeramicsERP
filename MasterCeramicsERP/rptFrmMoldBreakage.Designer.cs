namespace MasterCeramicsERP
{
    partial class rptFrmMoldBreakage
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
            this.crvMoldBreakage = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMoldBreakage
            // 
            this.crvMoldBreakage.ActiveViewIndex = -1;
            this.crvMoldBreakage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMoldBreakage.DisplayGroupTree = false;
            this.crvMoldBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMoldBreakage.Location = new System.Drawing.Point(0, 0);
            this.crvMoldBreakage.Name = "crvMoldBreakage";
            this.crvMoldBreakage.SelectionFormula = "";
            this.crvMoldBreakage.Size = new System.Drawing.Size(784, 517);
            this.crvMoldBreakage.TabIndex = 0;
            this.crvMoldBreakage.ViewTimeSelectionFormula = "";
            // 
            // rptFrmMoldBreakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvMoldBreakage);
            this.Name = "rptFrmMoldBreakage";
            this.Text = "Mold Breakage Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMoldBreakage;
    }
}