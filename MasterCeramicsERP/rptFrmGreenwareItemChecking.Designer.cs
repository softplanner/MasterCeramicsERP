namespace MasterCeramicsERP
{
    partial class rptFrmGreenwareItemChecking
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
            this.crvGreenwareItemChecking = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvGreenwareItemChecking
            // 
            this.crvGreenwareItemChecking.ActiveViewIndex = -1;
            this.crvGreenwareItemChecking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvGreenwareItemChecking.DisplayGroupTree = false;
            this.crvGreenwareItemChecking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvGreenwareItemChecking.Location = new System.Drawing.Point(0, 0);
            this.crvGreenwareItemChecking.Name = "crvGreenwareItemChecking";
            this.crvGreenwareItemChecking.SelectionFormula = "";
            this.crvGreenwareItemChecking.Size = new System.Drawing.Size(784, 517);
            this.crvGreenwareItemChecking.TabIndex = 0;
            this.crvGreenwareItemChecking.ViewTimeSelectionFormula = "";
            // 
            // rptFrmGreenwareItemChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvGreenwareItemChecking);
            this.Name = "rptFrmGreenwareItemChecking";
            this.Text = "Greenware Item Checking Report ";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvGreenwareItemChecking;
    }
}