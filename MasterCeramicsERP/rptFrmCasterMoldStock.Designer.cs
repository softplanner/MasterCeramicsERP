namespace MasterCeramicsERP
{
    partial class rptFrmCasterMoldStock
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
            this.crvCasterMoldStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCasterMoldStock
            // 
            this.crvCasterMoldStock.ActiveViewIndex = -1;
            this.crvCasterMoldStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCasterMoldStock.DisplayGroupTree = false;
            this.crvCasterMoldStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCasterMoldStock.Location = new System.Drawing.Point(0, 0);
            this.crvCasterMoldStock.Name = "crvCasterMoldStock";
            this.crvCasterMoldStock.SelectionFormula = "";
            this.crvCasterMoldStock.Size = new System.Drawing.Size(784, 517);
            this.crvCasterMoldStock.TabIndex = 0;
            this.crvCasterMoldStock.ViewTimeSelectionFormula = "";
            // 
            // rptFrmCasterMoldStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvCasterMoldStock);
            this.Name = "rptFrmCasterMoldStock";
            this.Text = "Caster Mold Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCasterMoldStock;
    }
}