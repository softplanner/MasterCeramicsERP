namespace MasterCeramicsERP
{
    partial class rptFrmPersonProfile
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
            this.crvPersonProfile = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPersonProfile
            // 
            this.crvPersonProfile.ActiveViewIndex = -1;
            this.crvPersonProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPersonProfile.DisplayGroupTree = false;
            this.crvPersonProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPersonProfile.Location = new System.Drawing.Point(0, 0);
            this.crvPersonProfile.Name = "crvPersonProfile";
            this.crvPersonProfile.SelectionFormula = "";
            this.crvPersonProfile.Size = new System.Drawing.Size(784, 562);
            this.crvPersonProfile.TabIndex = 0;
            this.crvPersonProfile.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPersonProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.crvPersonProfile);
            this.Name = "rptFrmPersonProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPersonProfile;
    }
}