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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmMainSales obj = new frmMainSales();
            obj.Show();
            obj.BringToFront();
        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            BackupDatabase obj = new BackupDatabase();
            obj.Show();
            obj.BringToFront();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            Administrator obj = new Administrator();
            obj.Show();
            obj.BringToFront();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmMain obj = new frmMain();
            obj.Show();
            obj.BringToFront();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmMainPayroll obj = new frmMainPayroll();
            obj.Show();
            obj.BringToFront();
        }
    }
}
