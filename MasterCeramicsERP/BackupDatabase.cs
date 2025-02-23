using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Configuration;

namespace MasterCeramicsERP
{
    public partial class BackupDatabase : Form
    {
        private static Server srvSql;
        // Create a new backup operation
        Backup bkpDatabase = new Backup();
        public BackupDatabase()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            loadServers();
        }
        private void loadServers()
        {
            try
            {
                // Create a DataTable where we enumerate the available servers
                DataTable dtServers = SmoApplication.EnumAvailableSqlServers(true);
                // If there are any servers at all
                if (dtServers.Rows.Count > 0)
                {
                    // Loop through each server in the DataTable
                    foreach (DataRow drServer in dtServers.Rows)
                    {
                        // Add the name to the combobox
                        cbxServer.Items.Add(drServer["Name"]);
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Connection Error..."+exp.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbxDatabase.Items.Clear();
            cbxServer.Items.Clear();
            loadServers();
        }

        public void connectToSQL()
        {
            try
            {
                // If a server was selected at all from the combobox
                if (cbxServer.SelectedItem != null && cbxServer.SelectedItem.ToString() != "")
                {
                    // Create a new connection to the selected server name
                    ServerConnection srvConn = new ServerConnection(cbxServer.SelectedItem.ToString());
                    // Log in using SQL authentication instead of Windows authentication
                    srvConn.LoginSecure = false;//you may set false/true for the Windows/SQL Serever Authentication
                    // Give the login username
                    srvConn.Login = txtUsername.Text;
                    // Give the login password
                    srvConn.Password = txtPassword.Text;
                    // Create a new SQL Server object using the connection we created
                    srvSql = new Server(srvConn);
                    // Loop through the databases list
                    foreach (Database dbServer in srvSql.Databases)
                    {
                        // Add database to combobox
                        cbxDatabase.Items.Add(dbServer.Name);
                    }
                }
                else
                {
                    // A server was not selected, show an error message
                    MessageBox.Show("Please select a server first", "Server Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Connection Error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectToSQL();
        }
        private void CreateBackup()
        {
            try
            {
                // If there was a SQL connection created
                if (srvSql != null)
                {
                    saveBackupDialog.Filter = "SQL Server database backup files|*.bak";
                    saveBackupDialog.Title = "Database Backup";

                    /* Wiring up events for progress monitoring */
                    ///* SqlBackup method starts to take back up
                    // * You can also use SqlBackupAsync method to perform the backup 
                    // * operation asynchronously */
                    //
                    // If the user has chosen a path where to save the backup file
                    if (saveBackupDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Set the backup type to a database backup
                        bkpDatabase.Action = BackupActionType.Database;
                        // Set the database that we want to perform a backup on
                        bkpDatabase.Database = cbxDatabase.Text;
                        // Set the backup device to a file
                        bkpDatabase.Devices.AddDevice(saveBackupDialog.FileName, DeviceType.File);
                        bkpDatabase.BackupSetName = "MasterCEramicsDatabaseBackup";
                        bkpDatabase.BackupSetDescription = "MasterCEramicsDatabaseBackup - Full Backup";
                        //-----------------
                        // Perform the backup
                        bkpDatabase.Initialize = false;
                        //bkpDatabase.PercentComplete += CompletionStatusInPercent;
                        //bkpDatabase.Complete += Backup_Completed;
                        bkpDatabase.SqlBackup(srvSql);
                        MessageBox.Show("Backup created successfully...", "Backup Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    // There was no connection established; probably the Connect button was not clicked
                    MessageBox.Show("A connection to a SQL server was not established.", "Not Connected to Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Connection Error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync(bkpDatabase);
            CreateBackup();
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // If there was a SQL connection created
                if (srvSql != null && cbxDatabase.Text!="")
                {
                    // Get the application configuration file. 
                    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); 
                     
                    // Create a connection string element and 
                    // save it to the configuration file. 
                     
                    // Create a connection string element.
                    ConnectionStringSettings csSettings =
                    new ConnectionStringSettings("MasterCeramicsERPDB","Data Source='"+cbxServer.Text+"';database='"+cbxDatabase.Text+"'; uid='"+txtUsername.Text+"'; pwd='"+txtPassword.Text+"'", "System.Data.SqlClient"); 
                     
                    // Get the connection strings section. 
                    ConnectionStringsSection csSection = 
                        config.ConnectionStrings;

                    // clear connection string. 
                    csSection.ConnectionStrings.Clear(); 

                    // Add the new element. 
                    csSection.ConnectionStrings.Add(csSettings); 
                     
                    // Save the configuration file. 
                    config.Save(ConfigurationSaveMode.Modified);
                    MessageBox.Show("Configuration setting has been changed...", "Connection Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // There was no connection established; probably the Connect button was not clicked
                    MessageBox.Show("Connection with SQL server was not established or no database selected...", "Server/Database connection error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Connection Error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    connectToSQL();
                    MessageBox.Show("Connected Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //=-----------------------------------------------------------------
    }
}
