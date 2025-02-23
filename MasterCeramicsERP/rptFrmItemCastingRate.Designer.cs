namespace MasterCeramicsERP
{
    partial class rptFrmItemCastingRate
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
            this.crvItemCastingRate = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvItemCastingRate
            // 
            this.crvItemCastingRate.ActiveViewIndex = -1;
            this.crvItemCastingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvItemCastingRate.DisplayGroupTree = false;
            this.crvItemCastingRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvItemCastingRate.Location = new System.Drawing.Point(0, 0);
            this.crvItemCastingRate.Name = "crvItemCastingRate";
            this.crvItemCastingRate.SelectionFormula = "";
            this.crvItemCastingRate.Size = new System.Drawing.Size(784, 517);
            this.crvItemCastingRate.TabIndex = 1;
            this.crvItemCastingRate.ViewTimeSelectionFormula = "";
            // 
            // rptFrmItemCastingRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvItemCastingRate);
            this.Name = "rptFrmItemCastingRate";
            this.Text = "Item Casting Rate List";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvItemCastingRate;
    }
}