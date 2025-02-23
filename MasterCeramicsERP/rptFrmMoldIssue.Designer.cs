namespace MasterCeramicsERP
{
    partial class rptFrmMoldIssue
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
            this.crvMoldIssue = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMoldIssue
            // 
            this.crvMoldIssue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.crvMoldIssue.ActiveViewIndex = -1;
            this.crvMoldIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMoldIssue.DisplayGroupTree = false;
            this.crvMoldIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMoldIssue.Location = new System.Drawing.Point(0, 0);
            this.crvMoldIssue.Name = "crvMoldIssue";
            this.crvMoldIssue.SelectionFormula = "";
            this.crvMoldIssue.Size = new System.Drawing.Size(784, 517);
            this.crvMoldIssue.TabIndex = 0;
            this.crvMoldIssue.ViewTimeSelectionFormula = "";
            // 
            // rptFrmMoldIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvMoldIssue);
            this.Name = "rptFrmMoldIssue";
            this.Text = "Mold Issue Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMoldIssue;
    }
}