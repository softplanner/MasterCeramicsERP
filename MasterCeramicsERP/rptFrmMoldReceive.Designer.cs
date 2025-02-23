namespace MasterCeramicsERP
{
    partial class rptFrmMoldReceive
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
            this.crvMoldReceive = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMoldReceive
            // 
            this.crvMoldReceive.ActiveViewIndex = -1;
            this.crvMoldReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMoldReceive.DisplayGroupTree = false;
            this.crvMoldReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMoldReceive.Location = new System.Drawing.Point(0, 0);
            this.crvMoldReceive.Name = "crvMoldReceive";
            this.crvMoldReceive.SelectionFormula = "";
            this.crvMoldReceive.Size = new System.Drawing.Size(784, 517);
            this.crvMoldReceive.TabIndex = 0;
            this.crvMoldReceive.ViewTimeSelectionFormula = "";
            // 
            // rptFrmMoldReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvMoldReceive);
            this.Name = "rptFrmMoldReceive";
            this.Text = "Mold Receive Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMoldReceive;
    }
}