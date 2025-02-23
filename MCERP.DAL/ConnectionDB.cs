using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace MCERP.DAL
{
    public class ConnectionDB
    {
        public SqlConnection getConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MasterCeramicsERPDB"].ConnectionString;
            //string connectionString = "Data Source=MuhammadJawad\\SQLEXPRESS;database=MCERPdatabase.mdf;uid=sa;pwd=@pakistan";
            //string connectionString = "Data Source=.\\MSSQLSERVER;AttachDbFilename=D:\\MasterCeramicERP\\Master Ceramics ERP beta1\\database\\MCERPdatabase.mdf;Integrated Security=True;User Instance=True";
            //string connectionString = "Data Source=192.168.5.101\\SQLEXPRESS;Network Library=dbmssocn;AttachDbFilename=D:\\MasterCeramicERP\\Master Ceramics ERP beta1\\database\\MCERPdatabase.mdf;Integrated Security=True;User Instance=True";
            return new SqlConnection(connectionString);
        }

    }
}
