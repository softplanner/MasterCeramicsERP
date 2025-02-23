using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCERP.Entities;
using System.Data;
using System.Data.SqlClient;
namespace MCERP.DAL
{
    public class RemarksDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getRemarks()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select Remark from Remarks ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addRemarks(string remarks)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into Remarks (Remark)values('" + remarks + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateRemarks(string oldRemarks,string newRemarks)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE Remarks SET Remark ='" + newRemarks + "' WHERE (Remark='" + oldRemarks + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }

        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public void deleteRemarks(string remarks)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from Remarks where (Remark='" + remarks + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public bool IsRemarksAlreadyExist(string remarks)
        {
            bool id = false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Remark from Remarks where Remark='" + remarks + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return id;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
