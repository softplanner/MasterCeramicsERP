namespace MasterCeramicsERP
{
    partial class salesFrmEmptyBill
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
            this.crvCreateBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCreateBill
            // 
            this.crvCreateBill.ActiveViewIndex = -1;
            this.crvCreateBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCreateBill.DisplayGroupTree = false;
            this.crvCreateBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCreateBill.Location = new System.Drawing.Point(0, 0);
            this.crvCreateBill.Name = "crvCreateBill";
            this.crvCreateBill.SelectionFormula = "";
            this.crvCreateBill.Size = new System.Drawing.Size(784, 517);
            this.crvCreateBill.TabIndex = 3;
            this.crvCreateBill.ViewTimeSelectionFormula = "";
            this.crvCreateBill.Load += new System.EventHandler(this.crvCreateBill_Load);
            // 
            // salesFrmEmptyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvCreateBill);
            this.Name = "salesFrmEmptyBill";
            this.Text = "Empty Bill";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCreateBill;
    }
}