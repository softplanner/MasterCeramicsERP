using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ItemCategoryDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getCategories()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from ItemCategory ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
