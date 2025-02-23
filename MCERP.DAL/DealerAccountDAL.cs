using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class DealerAccountDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addTransaction(DealerAccount obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into DealerAccount (DealerID,BalanceAmount)values('" + obj.DealerID + "','"+obj.BalanceAmount+"')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateDealerAccount(DealerAccount obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE DealerAccount SET BalanceAmount ='" + obj.BalanceAmount + "' WHERE (DealerID='" + obj.DealerID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }

        ////-------------------------------------------------------------------------------------------------------    

        //public List<DealerAccount> getDealerAccountName(int id)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select Name from DealerAccount where (ID='" + id + "')", objSqlConnection);
        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<DealerAccount> DealerAccountList = new List<DealerAccount>();
        //    while (dr.Read())
        //    {
        //        DealerAccount b = new DealerAccount();
        //        b.ID = Convert.ToInt16(dr["ID"]);
        //        b.Name = Convert.ToString(dr["Name"]);
        //        DealerAccountList.Add(b);
        //    }
        //    objSqlConnection.Close();
        //    DealerAccountList.TrimExcess();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return DealerAccountList;
        //}
        ////-------------------------------------------------------------------------------------------------------  
        ////-------------------------------------------------------------------------------------------------------    

        //public int getDealerAccountID(string name)
        //{
        //    int id = 0;
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select ID from DealerAccount where (Name='" + name + "')", objSqlConnection);
        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    dr.Read();
        //    id = Convert.ToInt32(dr["ID"]);
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return id;
        //}
        ////-------------------------------------------------------------------------------------------------------  

        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getAllDealerAccount()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    da.SelectCommand = new SqlCommand("select * from DealerAccount ", objSqlConnection);
        //    ds.Clear();
        //    da.Fill(ds);
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    //////////////////////////////////////
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<DealerAccount> getAllDealerAccount()
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from DealerAccount ", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<DealerAccount> DealerAccountList = new List<DealerAccount>();
        //    while (dr.Read())
        //    {
        //        DealerAccount b = new DealerAccount();
        //        b.ID = Convert.ToInt16(dr["ID"]);
        //        b.Name = Convert.ToString(dr["Name"]);
        //        DealerAccountList.Add(b);
        //    }
        //    objSqlConnection.Close();
        //    DealerAccountList.TrimExcess();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return DealerAccountList;
        //}
        ////-------------------------------------------------------------------------------------------------------
    }
}
