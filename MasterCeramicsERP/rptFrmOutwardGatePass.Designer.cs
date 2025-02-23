namespace MasterCeramicsERP
{
    partial class rptFrmOutwardGatePass
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
            this.crvOutwardGatePass = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvOutwardGatePass
            // 
            this.crvOutwardGatePass.ActiveViewIndex = -1;
            this.crvOutwardGatePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOutwardGatePass.DisplayGroupTree = false;
            this.crvOutwardGatePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOutwardGatePass.Location = new System.Drawing.Point(0, 0);
            this.crvOutwardGatePass.Name = "crvOutwardGatePass";
            this.crvOutwardGatePass.SelectionFormula = "";
            this.crvOutwardGatePass.Size = new System.Drawing.Size(784, 517);
            this.crvOutwardGatePass.TabIndex = 0;
            this.crvOutwardGatePass.ViewTimeSelectionFormula = "";
            // 
            // rptFrmOutwardGatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvOutwardGatePass);
            this.Name = "rptFrmOutwardGatePass";
            this.Text = "Outward GatePass";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOutwardGatePass;
    }
}