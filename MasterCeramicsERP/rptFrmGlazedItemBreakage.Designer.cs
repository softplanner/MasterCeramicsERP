namespace MasterCeramicsERP
{
    partial class rptFrmGlazedItemBreakage
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
            this.crvGlazedItemBreakage = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvGlazedItemBreakage
            // 
            this.crvGlazedItemBreakage.ActiveViewIndex = -1;
            this.crvGlazedItemBreakage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvGlazedItemBreakage.DisplayGroupTree = false;
            this.crvGlazedItemBreakage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvGlazedItemBreakage.Location = new System.Drawing.Point(0, 0);
            this.crvGlazedItemBreakage.Name = "crvGlazedItemBreakage";
            this.crvGlazedItemBreakage.SelectionFormula = "";
            this.crvGlazedItemBreakage.Size = new System.Drawing.Size(784, 517);
            this.crvGlazedItemBreakage.TabIndex = 0;
            this.crvGlazedItemBreakage.ViewTimeSelectionFormula = "";
            // 
            // rptFrmGlazedItemBreakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvGlazedItemBreakage);
            this.Name = "rptFrmGlazedItemBreakage";
            this.Text = "Glazed Item Breakage Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvGlazedItemBreakage;
    }
}