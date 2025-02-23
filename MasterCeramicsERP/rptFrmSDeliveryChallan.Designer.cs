namespace MasterCeramicsERP
{
    partial class rptFrmSDeliveryChallan
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
            this.crvDeliveryChallan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDeliveryChallan
            // 
            this.crvDeliveryChallan.ActiveViewIndex = -1;
            this.crvDeliveryChallan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDeliveryChallan.DisplayGroupTree = false;
            this.crvDeliveryChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDeliveryChallan.Location = new System.Drawing.Point(0, 0);
            this.crvDeliveryChallan.Name = "crvDeliveryChallan";
            this.crvDeliveryChallan.SelectionFormula = "";
            this.crvDeliveryChallan.Size = new System.Drawing.Size(784, 517);
            this.crvDeliveryChallan.TabIndex = 5;
            this.crvDeliveryChallan.ViewTimeSelectionFormula = "";
            // 
            // rptFrmSDeliveryChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvDeliveryChallan);
            this.Name = "rptFrmSDeliveryChallan";
            this.Text = "Delivery Challan Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDeliveryChallan;
    }
}