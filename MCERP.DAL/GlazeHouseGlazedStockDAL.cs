using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class GlazeHouseGlazedStockDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addStock(GlazeHouseGlazedStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GlazeHouseGlazeStock(GlazeHouseID,SprayManID,ItemID,StyleID,SizeID,ColorID,Quantity)values('" + obj.GlazeHouseID + "','" + obj.SprayManID + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "')", objSqlConnection);
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
        public void updateStock(GlazeHouseGlazedStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  GlazeHouseGlazeStock SET Quantity='" + obj.Quantity + "' WHERE (GlazeHouseID='" + obj.GlazeHouseID + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "')", objSqlConnection);
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
        public void deleteStock(GlazeHouseGlazedStock obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from GlazeHouseGlazeStock WHERE (GlazeHouseID='" + obj.GlazeHouseID + "'and SprayManID='" + obj.SprayManID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and Quantity='" + obj.Quantity + "')", objSqlConnection);
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
        public Int16 getStock(GlazeHouseGlazedStock obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Select Quantity From GlazeHouseGlazeStock WHERE (GlazeHouseID='" + obj.GlazeHouseID + "'and SprayManID='" + obj.SprayManID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 q = 0;
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
        public bool checkIsItemAlreadyExist(GlazeHouseGlazedStock obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Select Quantity From GlazeHouseGlazeStock WHERE (GlazeHouseID='" + obj.GlazeHouseID + "'and SprayManID='" + obj.SprayManID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool q=false;
            while (dr.Read())
            {
                q = true;
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
        public List<GlazeHouseGlazedStock> getStockByItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseGlazeStock where ItemID= '" + itemID+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseGlazedStock> list = new List<GlazeHouseGlazedStock>();
            while (dr.Read())
            {
                GlazeHouseGlazedStock g = new GlazeHouseGlazedStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        public List<GlazeHouseGlazedStock> getAllStock()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseGlazeStock ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseGlazedStock> list = new List<GlazeHouseGlazedStock>();
            while (dr.Read())
            {
                GlazeHouseGlazedStock g = new GlazeHouseGlazedStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        public List<GlazeHouseGlazedStock> getStockByStyle(Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseGlazeStock where StyleID= '" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseGlazedStock> list = new List<GlazeHouseGlazedStock>();
            while (dr.Read())
            {
                GlazeHouseGlazedStock g = new GlazeHouseGlazedStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        public List<GlazeHouseGlazedStock> getStockByItemAndSprayMan(Int16 itemID, int sprayManID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseGlazeStock where ItemID= '" + itemID+ "'and SprayManID='" + sprayManID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseGlazedStock> list = new List<GlazeHouseGlazedStock>();
            while (dr.Read())
            {
                GlazeHouseGlazedStock g = new GlazeHouseGlazedStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        public List<GlazeHouseGlazedStock> getStockByStyleAndSprayMan(Int16 styleID, int sprayManID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseGlazeStock where StyleID = '" + styleID+ "'and SprayManID='" + sprayManID+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseGlazedStock> list = new List<GlazeHouseGlazedStock>();
            while (dr.Read())
            {
                GlazeHouseGlazedStock g = new GlazeHouseGlazedStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        public List<GlazeHouseGlazedStock> getStockByGlazeHouse(Int16 glazeHouseID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseGlazeStock where (GlazeHouseID='" +glazeHouseID+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseGlazedStock> list = new List<GlazeHouseGlazedStock>();
            while (dr.Read())
            {
                GlazeHouseGlazedStock g = new GlazeHouseGlazedStock();
                g.GlazeHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        
    }
}
