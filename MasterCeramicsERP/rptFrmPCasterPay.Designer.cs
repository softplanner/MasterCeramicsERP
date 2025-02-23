namespace MasterCeramicsERP
{
    partial class rptFrmPCasterPay
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
            this.crvCasterPayment = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCasterPayment
            // 
            this.crvCasterPayment.ActiveViewIndex = -1;
            this.crvCasterPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCasterPayment.DisplayGroupTree = false;
            this.crvCasterPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCasterPayment.Location = new System.Drawing.Point(0, 0);
            this.crvCasterPayment.Name = "crvCasterPayment";
            this.crvCasterPayment.SelectionFormula = "";
            this.crvCasterPayment.Size = new System.Drawing.Size(784, 517);
            this.crvCasterPayment.TabIndex = 3;
            this.crvCasterPayment.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPCasterPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvCasterPayment);
            this.Name = "rptFrmPCasterPay";
            this.Text = "Caster Payment Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCasterPayment;
    }
}