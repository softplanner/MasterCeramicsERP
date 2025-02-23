using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class MoldStockCompanyDAL
    {
        
        //-------------------------------------------------------------------------------------------------------
        public void addStock(MoldStockCompany obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into MoldStockCompany(ItemID,StyleID,SizeID,Quantity)values('"+ obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        public void updateStock(MoldStockCompany obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE MoldStockCompany SET Quantity='" + obj.Quantity + "' where (ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);
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
        public void deleteStock(MoldStockCompany obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldStockCompany WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "')", objSqlConnection);
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
        public List<MoldStockCompany> getStockByItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockCompany where ItemID= '" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockCompany> list = new List<MoldStockCompany>();
            while (dr.Read())
            {
                MoldStockCompany m = new MoldStockCompany();
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(m);
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
        public List<MoldStockCompany> getStockByStyle(Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * fromMoldStockCompany where StyleID= '" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockCompany> list = new List<MoldStockCompany>();
            while (dr.Read())
            {
                MoldStockCompany m = new MoldStockCompany();
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(m);
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
        public Int16 getStockByItemStyleSize(Int16 itemID, Int16 styleID, Int16 sizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldStockCompany where (ItemID= '" + itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 checkIsMoldExist(Int16 itemID, Int16 styleID, Int16 sizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldStockCompany where (ItemID= '" + itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = 1;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<MoldStockCompany> getStock()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockCompany", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockCompany> list = new List<MoldStockCompany>();
            while (dr.Read())
            {
                MoldStockCompany m = new MoldStockCompany();
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(m);
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
        public DataSet getStockReport()
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockCompany", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockCompany> list = new List<MoldStockCompany>();
            MoldStockCompany g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new MoldStockCompany();
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = item.getItemName(g.ItemID);
                dataRow[1] = style.getItemStyleName(g.StyleID);
                dataRow[2] = size.getItemSizeName(g.SizeID);
                dataRow[3] = g.Quantity;
                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
