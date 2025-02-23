using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class GatePassDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addGatePass(GatePass obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GatePass (OrderID,Date)values('" + obj.OrderID+ "','"+obj.Date+"')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateGatePass(GatePass obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE GatePass SET OrderID='" + obj.OrderID+ "',Date='"+obj.Date+"' WHERE (GatePassID='" + obj.GatePassID+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }

        //-------------------------------------------------------------------------------------------------------    
        public GatePass getGatePassByOrderID(Int64 orderID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GatePass where (OrderID='" + orderID+ "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GatePass obj = new GatePass();
            while (dr.Read())
            {
                
                obj.GatePassID = Convert.ToInt64(dr["GatePassID"]);
                obj.OrderID = Convert.ToInt64(dr["OrderID"]);
                obj.Date = Convert.ToDateTime(dr["Date"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return obj;
        }
        //-------------------------------------------------------------------------------------------------------  
        ////-------------------------------------------------------------------------------------------------------    
        //public GatePass getGatePassByOrderID(Int64 gatePassID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from GatePass where (GatePassID='" + gatePassID+ "')", objSqlConnection);
        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    dr.Read();
        //        GatePass obj = new GatePass();
        //        obj.GatePassID = Convert.ToInt64(dr["GatePassID"]);
        //        obj.OrderID = Convert.ToInt64(dr["OrderID"]);
        //        obj.Date = Convert.ToDateTime(dr["Date"]);
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return obj;
        //}
        ////-------------------------------------------------------------------------------------------------------  

        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getAllGatePass()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    da.SelectCommand = new SqlCommand("select * from GatePass ", objSqlConnection);
        //    ds.Clear();
        //    da.Fill(ds);
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    //////////////////////////////////////
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<GatePass> getAllGatePassByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GatePass where (Date='"+date+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GatePass> list = new List<GatePass>();
            while (dr.Read())
            {
                GatePass obj = new GatePass();
                obj.GatePassID = Convert.ToInt64(dr["GatePassID"]);
                obj.OrderID = Convert.ToInt64(dr["OrderID"]);
                obj.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(obj);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
