namespace MasterCeramicsERP
{
    partial class rptFrmUnglazeItemBreakage
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
            this.crvUnglazeItemBreakage = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvUnglazeItemBreakage
            // 
            this.crvUnglazeItemBreakage.ActiveViewIndex = -1;
            this.crvUnglazeItemBreakage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUnglazeItemBreakage.DisplayGroupTree = false;
            this.crvUnglazeItemBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUnglazeItemBreakage.Location = new System.Drawing.Point(0, 0);
            this.crvUnglazeItemBreakage.Name = "crvUnglazeItemBreakage";
            this.crvUnglazeItemBreakage.SelectionFormula = "";
            this.crvUnglazeItemBreakage.Size = new System.Drawing.Size(784, 517);
            this.crvUnglazeItemBreakage.TabIndex = 0;
            this.crvUnglazeItemBreakage.ViewTimeSelectionFormula = "";
            // 
            // rptFrmUnglazeItemBreakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvUnglazeItemBreakage);
            this.Name = "rptFrmUnglazeItemBreakage";
            this.Text = "Unglazed Item Breakage Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUnglazeItemBreakage;
    }
}