using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
   public class SlipStockDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addSlipToStock(SlipStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into SlipStock (Quantity)values('" + obj.Quantity+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void decreaseSlipStock(float quantity)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE SlipStock SET Quantity ='" + quantity + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------    
       //assign the defaulrt values to the table fields
        //-------------------------------------------------------------------------------------------------------
        public void updateSlipStock(float quantity)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SlipStockDAL DALslipStock=new SlipStockDAL();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE SlipStock SET Quantity ='" + quantity + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    

        public SlipStock getSlipStock()
        {
            SlipStock slipStock=new SlipStock();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from  SlipStock", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                slipStock.Quantity = Convert.ToInt32(dr["Quantity"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return slipStock;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------    

        public float getSlipInStock()
        {
            float slip=0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from  SlipStock", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                slip = Convert.ToSingle(dr["Quantity"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return slip;
        }
        //-------------------------------------------------------------------------------------------------------  
    }
}
