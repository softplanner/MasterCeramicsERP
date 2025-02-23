namespace MasterCeramicsERP
{
    partial class rptFrmPLoan
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
            this.crvWorkerLoan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvWorkerLoan
            // 
            this.crvWorkerLoan.ActiveViewIndex = -1;
            this.crvWorkerLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvWorkerLoan.DisplayGroupTree = false;
            this.crvWorkerLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvWorkerLoan.Location = new System.Drawing.Point(0, 0);
            this.crvWorkerLoan.Name = "crvWorkerLoan";
            this.crvWorkerLoan.SelectionFormula = "";
            this.crvWorkerLoan.Size = new System.Drawing.Size(784, 517);
            this.crvWorkerLoan.TabIndex = 2;
            this.crvWorkerLoan.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvWorkerLoan);
            this.Name = "rptFrmPLoan";
            this.Text = "Worker Loan Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvWorkerLoan;
    }
}