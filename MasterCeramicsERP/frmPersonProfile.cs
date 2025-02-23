using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MCERP.DAL;
using MCERP.Entities;

namespace MasterCeramicsERP
{
    public partial class frmPersonProfile : Form
    {
        
        //PersonDAL dalPerson = new PersonDAL();
        //AddressDAL dalAddress = new AddressDAL();
        //ContactDAL dalContacts = new ContactDAL();
        //PersonJobsDAL dalJobs = new PersonJobsDAL();

        public frmPersonProfile()
        {
            InitializeComponent();
        }
        public void showPersonProfile(int personID)
        {
            PersonDAL dalPerson = new PersonDAL();
            AddressDAL dalAddress = new AddressDAL();
            ContactDAL dalContacts = new ContactDAL();
            PersonJobsDAL dalJobs = new PersonJobsDAL();

            Person person = new Person();
            person = dalPerson.getPersonByID(personID);
            showPersonInfo(person);
            //-----
            List<string> job = new List<string>();
            job = dalJobs.getPersonJobs(personID);
            showPersonJobs(job);
            //-----
            List<string> address = new List<string>();
            address = dalAddress.getAddressForPersonProfile(personID);
            showPersonAddress(address);
            //-----
            //-----
            List<string> contacts = new List<string>();
            contacts = dalContacts.getContactsForPersonProfile(personID);
            showPersonContacts(contacts);
            //-----
        }
        private void showPersonInfo(Person p)
        {
            lblPersonIDInfo.Text = "MSW-"+p.ID;
            lblNameInfo.Text = p.Name;
            lblGenderInfo.Text = p.Contact;
            lblCategoryInfo.Text = p.Category;
            txtDescription.Text = p.Address;
        }
        private void showPersonJobs(List<string> j)
        {
            
            for ( int i = 0; i < j.Count;i++ )
            {
                txtJob.Text += j[i]+"\r\n";
            }
        }
        private void showPersonAddress(List<string> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                txtAddress.Text += a[i];
            }
        }
        private void showPersonContacts(List<string> c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                txtContacts.Text += c[i];
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Job", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Contact", typeof(string));

            ds.Tables.Add(dt);

            dataRow = ds.Tables[0].NewRow();
            dataRow[0] = lblPersonIDInfo.Text;
            dataRow[1] = lblNameInfo.Text;
            dataRow[2] = lblGenderInfo.Text;
            dataRow[3] = lblCategoryInfo.Text;
            dataRow[4] = txtDescription.Text;
            dataRow[5] = txtJob.Text;
            dataRow[6] = txtAddress.Text;
            dataRow[7] = txtContacts.Text;

            ds.Tables[0].Rows.Add(dataRow);
            
            rptFrmPersonProfile report=new rptFrmPersonProfile();
            report.showProfile(ds);
            report.Show();
        }
    }
}
