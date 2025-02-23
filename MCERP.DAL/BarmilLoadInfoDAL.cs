using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class BarmilLoadInfoDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addRecord(BarmilLoadInfo obj)
        {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into BarmilLoadInfo(PersonID,BarmilID,LoadDate,Status,UnloadDate)values('" + obj.PersonID + "','" + obj.BarmilID + "','" + obj.LoadDate + "','" + obj.Status + "','" + obj.UnloadDate + "')", objSqlConnection);
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
        public void addNewAsOffStatus(Int16 bid,string status)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into BarmilLoadInfo(BarmilID,Status)values('" + bid+ "','" + status+ "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteBallMillRecord(Int16 bid)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("delete from BarmilLoadInfo where (BarmilID='"+bid+"')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlCommand = new SqlCommand("delete from Barmil where (ID='" + bid + "')", objSqlConnection);
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void loadBarmil(BarmilLoadInfo obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into BarmilLoadInfo(PersonID,BarmilID,LoadDate,Status)values('" + obj.PersonID + "','" + obj.BarmilID + "','" + obj.UnloadDate + "','" + obj.Status + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void unLoadBarmil(Int16 barmilID)
        {
            try
            {
                string status = "OFF";
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("update BarmilLoadInfo set status='" + status + "',UnloadDate='" + DateTime.Today + "' where (BarmilID='" + barmilID + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        public string getBarmilStatusByBarmilID(int barmilID)
        {
            string status = null;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Status from BarmilLoadInfo where (BarmilID='" + barmilID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    status = Convert.ToString(dr["Status"]);
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return status;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return status;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    

        public bool isBallMillExist(Int16 barmilID)
        {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select BarmilID from BarmilLoadInfo where (BarmilID='" + barmilID + "')", objSqlConnection);
                SqlDataReader dr = null;
                bool id = false;
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
        //-------------------------------------------------------------------------------------------------------    

        public Int16 checkBarmil(Int16 barmilID)
        {
            Int16 id = 0;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select BarmilID from BarmilLoadInfo where (BarmilID='" + barmilID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    id = 1;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return id;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public List<BarmilLoadInfo> getBarmilStatusByPersonID(int id)
        {
            List<BarmilLoadInfo> list = new List<BarmilLoadInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from BarmilLoadInfo where (PersonID='" + id + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    BarmilLoadInfo b = new BarmilLoadInfo();
                    b.PersonID = Convert.ToInt32(dr["PersonID"]);
                    b.BarmilID = Convert.ToInt16(dr["BarmilID"]);
                    b.LoadDate = Convert.ToDateTime(dr["LoadDate"]);
                    b.UnloadDate = Convert.ToDateTime(dr["UnloadDate"]);
                    b.Status = Convert.ToString(dr["Status"]);
                    list.Add(b);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateBarmil(BarmilLoadInfo obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE BarmilLoadInfo SET Status ='" + obj.Status + "',PersonID='" + obj.PersonID + "',LoadDate='" + obj.LoadDate + "',UnloadDate='" + obj.UnloadDate + "' WHERE (BarmilID='" + obj.BarmilID + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------    
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllLoadBarmilDataSet()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                da.SelectCommand = new SqlCommand("select * from BarmilLoadInfo", objSqlConnection);
                ds.Clear();
                da.Fill(ds);
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                //////////////////////////////////////
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllBarmilLoadInfoDataSet()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                da.SelectCommand = new SqlCommand("select * from BarmilLoadInfo ", objSqlConnection);
                ds.Clear();
                da.Fill(ds);
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                //////////////////////////////////////
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<BarmilLoadInfo> getAllBarmilLoadInfoList()
        {
            List<BarmilLoadInfo> list = new List<BarmilLoadInfo>();
                ConnectionDB objConnectionDB;
                SqlConnection objSqlConnection;

                objConnectionDB = new ConnectionDB();
                objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from BarmilLoadInfo", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    BarmilLoadInfo b = new BarmilLoadInfo();
                    b.PersonID = Convert.ToInt32(dr["PersonID"]);
                    b.BarmilID = Convert.ToInt16(dr["BarmilID"]);
                    b.LoadDate = Convert.ToDateTime(dr["LoadDate"]);
                    b.UnloadDate = Convert.ToDateTime(dr["UnloadDate"]);
                    b.Status = Convert.ToString(dr["Status"]);
                    list.Add(b);
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
