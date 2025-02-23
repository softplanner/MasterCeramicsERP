using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class BarmilDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addBarmil(Int16 weight)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into Barmil (Weight)values('" + weight + "')", objSqlConnection);
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
        public void updateBarmil(Barmil obj)
        {
           try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE Barmil SET Weight ='" + obj.Weight + "' WHERE (ID='" + obj.ID + "')", objSqlConnection);
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
        public void deleteBarmil(Int16 barmilID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("delete from Barmil where(ID='"+barmilID+"')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public Int16 getBarmilWeight(Int16 id)
        {
                Int16 BarmilWeight = 0;
                try
                {
                    ConnectionDB objConnectionDB = new ConnectionDB();
                    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                    SqlCommand objSqlCommand = new SqlCommand("select Weight from Barmil where (ID='" + id + "')", objSqlConnection);
                    SqlDataReader dr = null;
                    objSqlConnection.Open();
                    dr = objSqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        BarmilWeight = Convert.ToInt16(dr["Weight"]);
                    }
                    objSqlConnection.Close();
                    ///////////////////////////////////////---Release the resources
                    objSqlConnection.Dispose();
                    objSqlCommand.Dispose();
                    dr.Dispose();
                    //////////////////////////////////////
                    return BarmilWeight;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error accessing the database: " + e.Message);
                }
                return BarmilWeight;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsAlreadyExist(Int16 id)
        {
            bool b= false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Weight from Barmil where (ID='" + id + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    b = true;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return b;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsAlreadyExistInBarmilLoadInfo(Int16 id)
        {
            bool b = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select BarmilID from BarmilLoadInfo where (BarmilID='" + id + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    b = true;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return b;
        }
        //-------------------------------------------------------------------------------------------------------  

        //-------------------------------------------------------------------------------------------------------    

        public List<Barmil> getBarmilID(Int16 weight)
        {
            List<Barmil> BarmilList = new List<Barmil>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select ID from Barmil where (Weight='" + weight + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Barmil b = new Barmil();
                    b.ID = Convert.ToInt16(dr["ID"]);
                    b.Weight = Convert.ToInt16(dr["Weight"]);
                    BarmilList.Add(b);
                }
                objSqlConnection.Close();
                BarmilList.TrimExcess();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return BarmilList;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return BarmilList;
            
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public List<Barmil> getAllBarmilByWeight(Int16 weight)
        {
            List<Barmil> list = new List<Barmil>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from Barmil where (Weight='" + weight + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Barmil b = new Barmil();
                    b.ID = Convert.ToInt16(dr["ID"]);
                    b.Weight = Convert.ToInt16(dr["Weight"]);

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
        public DataSet getAllBarmilDataSet()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                da.SelectCommand = new SqlCommand("select * from Barmil ", objSqlConnection);
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
        public List<Barmil> getAllBarmilList()
        {
            List<Barmil> BarmilList = new List<Barmil>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from Barmil ", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Barmil b = new Barmil();
                    b.ID = Convert.ToInt16(dr["ID"]);
                    b.Weight = Convert.ToInt16(dr["Weight"]);
                    BarmilList.Add(b);
                }
                objSqlConnection.Close();
                BarmilList.TrimExcess();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return BarmilList;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return BarmilList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 isBarmilIdExist(Int16 barmilID)
        {
            Int16 a = 0;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select ID from Barmil where (ID ='" + barmilID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    a = 1;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return a;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return a;
        }
        //-------------------------------------------------------------------------------------------------------
   }
}
