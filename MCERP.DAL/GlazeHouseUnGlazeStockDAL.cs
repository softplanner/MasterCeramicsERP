using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class GlazeHouseUnGlazeStockDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addStock(GlazeHouseUnGlazeStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GlazeHouseUnGlazeStock(GlazeHouseID,ItemID,StyleID,SizeID,Quantity)values('" + obj.GlazeHouseID + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "')", objSqlConnection);
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
        public void updateStock(GlazeHouseUnGlazeStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  GlazeHouseUnGlazeStock SET Quantity='" + obj.Quantity + "' where (GlazeHouseID ='" + obj.GlazeHouseID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);
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
        public void deleteStock(GlazeHouseUnGlazeStock obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from GlazeHouseUnGlazeStock WHERE (GlazeHouseID='" + obj.GlazeHouseID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "')", objSqlConnection);
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
        public Int16 getStockByObject(GlazeHouseUnGlazeStock obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeHouseUnGlazeStock WHERE (GlazeHouseID='" + obj.GlazeHouseID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "')", objSqlConnection);
            objSqlConnection.Open();
            SqlDataReader dr = null;
            Int16 q = 0;
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                q = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return q;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeHouseUnGlazeStock> getStockByItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseUnGlazeStock where ItemID= '" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseUnGlazeStock> list = new List<GlazeHouseUnGlazeStock>();
            while (dr.Read())
            {
                GlazeHouseUnGlazeStock g = new GlazeHouseUnGlazeStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeHouseUnGlazeStock> getStockByStyle(Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseUnGlazeStock where StyleID= '" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseUnGlazeStock> list = new List<GlazeHouseUnGlazeStock>();
            while (dr.Read())
            {
                GlazeHouseUnGlazeStock g = new GlazeHouseUnGlazeStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeHouseUnGlazeStock> getStock()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseUnGlazeStock", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseUnGlazeStock> list = new List<GlazeHouseUnGlazeStock>();
            while (dr.Read())
            {
                GlazeHouseUnGlazeStock u = new GlazeHouseUnGlazeStock();
                u.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                u.ItemID = Convert.ToInt16(dr["ItemID"]);
                u.StyleID = Convert.ToInt16(dr["StyleID"]);
                u.SizeID = Convert.ToInt16(dr["SizeID"]);
                u.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(u);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
