using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCERP.Entities;
using System.Data.SqlClient;
using System.Data;
namespace MCERP.DAL
{
    public class GlazeStockCompanyDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addStock(GlazeStockCompany obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GlazeStockCompany(ColorID,ItemID,StyleID,SizeID,Quantity)values('" + obj.ColorID + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "')", objSqlConnection);
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
        public void updateStock(GlazeStockCompany obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE GlazeStockCompany SET Quantity='"+obj.Quantity+"' where (ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='"+obj.ColorID+"')", objSqlConnection);
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
        public void deleteStock(GlazeStockCompany obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from GlazeStockCompany WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='"+obj.ColorID+"')", objSqlConnection);
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
        public List<GlazeStockCompany> getStockByItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeStockCompany where ItemID= '" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeStockCompany> list = new List<GlazeStockCompany>();
            while (dr.Read())
            {
                GlazeStockCompany u = new GlazeStockCompany();
                u.ItemID = Convert.ToInt16(dr["ItemID"]);
                u.StyleID = Convert.ToInt16(dr["StyleID"]);
                u.SizeID = Convert.ToInt16(dr["SizeID"]);
                u.ColorID= Convert.ToInt16(dr["ColorID"]);
                u.Quantity= Convert.ToInt16(dr["Quantity"]);
              
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
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeStockCompany> getAllStockList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeStockCompany ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeStockCompany> list = new List<GlazeStockCompany>();
            while (dr.Read())
            {
                GlazeStockCompany u = new GlazeStockCompany();
                u.ItemID = Convert.ToInt16(dr["ItemID"]);
                u.StyleID = Convert.ToInt16(dr["StyleID"]);
                u.SizeID = Convert.ToInt16(dr["SizeID"]);
                u.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeStockCompany> getStockByStyle(Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeStockCompany where StyleID= '" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeStockCompany> list = new List<GlazeStockCompany>();
            while (dr.Read())
            {
                GlazeStockCompany u = new GlazeStockCompany();
                u.ItemID = Convert.ToInt16(dr["ItemID"]);
                u.StyleID = Convert.ToInt16(dr["StyleID"]);
                u.SizeID = Convert.ToInt16(dr["SizeID"]);
                u.ColorID = Convert.ToInt16(dr["ColorID"]);
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
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeStockCompany> getStock()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeStockCompany", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeStockCompany> list = new List<GlazeStockCompany>();
            while (dr.Read())
            {
                GlazeStockCompany g = new GlazeStockCompany();
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
        public DataSet getStockReport()
        {
            ItemDAL item=new ItemDAL();
            DALItemStyle style=new DALItemStyle();
            ItemSizeDAL size=new ItemSizeDAL();
            ColorDAL color=new ColorDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeStockCompany", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GlazeStockCompany g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new GlazeStockCompany();
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow= ds.Tables[0].NewRow();

                dataRow[0] =item.getItemName(g.ItemID);
                dataRow[1] =style.getItemStyleName(g.StyleID);
                dataRow[2] =size.getItemSizeName(g.SizeID);
                dataRow[3] =color.getColorName(g.ColorID);
                dataRow[4] =g.Quantity;

                ds.Tables[0].Rows.Add(dataRow);
                
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataTable getStockReportDataTable()
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeStockCompany", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GlazeStockCompany g;
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            while (dr.Read())
            {
                g = new GlazeStockCompany();
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = dt.NewRow();

                dataRow[0] = item.getItemName(g.ItemID);
                dataRow[1] = style.getItemStyleName(g.StyleID);
                dataRow[2] = size.getItemSizeName(g.SizeID);
                dataRow[3] = color.getColorName(g.ColorID);
                dataRow[4] = g.Quantity;

                dt.Rows.Add(dataRow);

            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return dt;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getStockReportDataset()
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from GlazeStockCompany ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public int getStockByItemStyleSizeColor(Int16 itemID, Int16 styleID, Int16 sizeID,Int16 colorID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeStockCompany where (ItemID='" + itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and ColorID='"+colorID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            int quantity = 0;
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
        public int getStockByObject(GlazeStockCompany g)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeStockCompany where (ItemID='" + g.ItemID + "' and StyleID='" + g.StyleID + "' and SizeID='" + g.SizeID + "' and ColorID='" + g.ColorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            int quantity = 0;
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
        public int checkIsItemExist(Int16 itemID, Int16 styleID, Int16 sizeID, Int16 colorID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeStockCompany where (ItemID='" + itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and ColorID='" + colorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            int quantity = 0;
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
        public bool checkIsItemExistByObject(GlazeStockCompany g)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeStockCompany where (ItemID='" + g.ItemID+ "' and StyleID='" + g.StyleID + "' and SizeID='" + g.SizeID + "' and ColorID='" + g.ColorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool quantity = false;
            while (dr.Read())
            {
                quantity = true;
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
    }
}
