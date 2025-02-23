namespace MasterCeramicsERP
{
    partial class rptFrmViewAttendence
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
            this.crvViewAttendence = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvViewAttendence
            // 
            this.crvViewAttendence.ActiveViewIndex = -1;
            this.crvViewAttendence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crvViewAttendence.DisplayGroupTree = false;
            this.crvViewAttendence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvViewAttendence.Location = new System.Drawing.Point(0, 0);
            this.crvViewAttendence.Name = "crvViewAttendence";
            this.crvViewAttendence.SelectionFormula = "";
            this.crvViewAttendence.Size = new System.Drawing.Size(784, 517);
            this.crvViewAttendence.TabIndex = 1;
            this.crvViewAttendence.ViewTimeSelectionFormula = "";
            // 
            // rptFrmViewAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvViewAttendence);
            this.Name = "rptFrmViewAttendence";
            this.Text = "Attendence Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvViewAttendence;
    }
}