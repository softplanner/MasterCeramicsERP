﻿namespace MasterCeramicsERP
{
    partial class rptFrmPostOrderView
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
            this.crvPostOrderView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPostOrderView
            // 
            this.crvPostOrderView.ActiveViewIndex = -1;
            this.crvPostOrderView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPostOrderView.DisplayGroupTree = false;
            this.crvPostOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPostOrderView.Location = new System.Drawing.Point(0, 0);
            this.crvPostOrderView.Name = "crvPostOrderView";
            this.crvPostOrderView.SelectionFormula = "";
            this.crvPostOrderView.Size = new System.Drawing.Size(784, 517);
            this.crvPostOrderView.TabIndex = 4;
            this.crvPostOrderView.ViewTimeSelectionFormula = "";
            // 
            // rptFrmPostOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.crvPostOrderView);
            this.Name = "rptFrmPostOrderView";
            this.Text = "View Posted Order\'s";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPostOrderView;
    }
}