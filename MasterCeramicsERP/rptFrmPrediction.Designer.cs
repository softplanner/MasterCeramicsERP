namespace MasterCeramicsERP
{
    partial class rptFrmPrediction
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
            this.crvPrediction = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPrediction
            // 
            this.crvPrediction.ActiveViewIndex = -1;
            this.crvPrediction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPrediction.DisplayGroupTree = false;
            this.crvPrediction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPrediction.Location = new System.Drawing.Point(0, 0);
            this.crvPrediction.Name = "crvPrediction";
            this.crvPrediction.SelectionFormula = "";
            this.crvPrediction.Size = new System.Drawing.Size(784, 517);
            this.crvPrediction.TabIndex = 0;
            this.crvPrediction.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvPrediction);
            this.Name = "rptFrmPrediction";
            this.Text = "rptFrmPrediction";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPrediction;
    }
}