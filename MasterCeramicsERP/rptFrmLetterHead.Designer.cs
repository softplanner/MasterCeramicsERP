namespace MasterCeramicsERP
{
    partial class rptFrmLetterHead
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
            this.crvLetterHead = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.salesCompanyLetterHead1 = new MasterCeramicsERP.salesCompanyLetterHead();
            this.SuspendLayout();
            // 
            // crvLetterHead
            // 
            this.crvLetterHead.ActiveViewIndex = -1;
            this.crvLetterHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLetterHead.DisplayGroupTree = false;
            this.crvLetterHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLetterHead.Location = new System.Drawing.Point(0, 0);
            this.crvLetterHead.Name = "crvLetterHead";
            this.crvLetterHead.SelectionFormula = "";
            this.crvLetterHead.Size = new System.Drawing.Size(784, 517);
            this.crvLetterHead.TabIndex = 0;
            this.crvLetterHead.ViewTimeSelectionFormula = "";
            // 
            // rptFrmLetterHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvLetterHead);
            this.Name = "rptFrmLetterHead";
            this.Text = "Letter Head";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvLetterHead;
        private salesCompanyLetterHead salesCompanyLetterHead1;
    }
}