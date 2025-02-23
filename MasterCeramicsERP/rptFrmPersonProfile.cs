using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterCeramicsERP
{
    public partial class rptFrmPersonProfile : Form
    {
        public rptFrmPersonProfile()
        {
            InitializeComponent();
        }
        public void showProfile(DataSet profileDataset)
        {
            try
            {
                rptPersonProfile report = new rptPersonProfile();
                report.SetDataSource(profileDataset.Tables[0]);
                crvPersonProfile.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
