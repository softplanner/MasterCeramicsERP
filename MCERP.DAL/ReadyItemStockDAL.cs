using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ReadyItemStockDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addStock(ReadyItemStock  obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into ReadyItemStock (Category,ItemID,StyleID,SizeID,Quantity,ColorID)values('"+obj.Category+"','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','"+obj.ColorID+"')", objSqlConnection);
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
        public void updateStockByDualObjects(ReadyItemStock  updatedObj, ReadyItemStock  beforeUpdateObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE ReadyItemStock SET Category='"+updatedObj.Category+"',ItemID='" + updatedObj.ItemID + "',StyleID='" + updatedObj.StyleID + "',SizeID='" + updatedObj.SizeID + "',Quantity='" + updatedObj.Quantity + "',ColorID='"+updatedObj.ColorID+"' WHERE (Category='"+beforeUpdateObj.Category+"' and ItemID='" + beforeUpdateObj.ItemID + "' and StyleID='" + beforeUpdateObj.StyleID + "'and SizeID='" + beforeUpdateObj.SizeID + "' and Quantity='" + beforeUpdateObj.Quantity + "' and ColorID='"+beforeUpdateObj.ColorID+"')", objSqlConnection);
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
        public void updateStock(ReadyItemStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE ReadyItemStock SET Quantity='" + obj.Quantity + "' WHERE (Category='" + obj.Category + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);
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
        public void deleteStock(ReadyItemStock  obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from ReadyItemStock WHERE (Category='"+obj.Category+"' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='"+obj.ColorID+"')", objSqlConnection);
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
        public List<ReadyItemStock > getStockByItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ReadyItemStock where (ItemID= '" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ReadyItemStock > list = new List<ReadyItemStock >();
            while (dr.Read())
            {
                ReadyItemStock  r = new ReadyItemStock ();
                r.ItemID = Convert.ToInt16(dr["ItemID"]);
                r.StyleID = Convert.ToInt16(dr["StyleID"]);
                r.SizeID = Convert.ToInt16(dr["SizeID"]);
                r.Quantity = Convert.ToInt16(dr["Quantity"]);
                r.ColorID = Convert.ToInt16(dr["ColorID"]);
                r.Category = Convert.ToInt16(dr["Category"]);

                list.Add(r);
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
        public List<ReadyItemStock > getStockByStyle(Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ReadyItemStock where (StyleID= '" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ReadyItemStock > list = new List<ReadyItemStock >();
            while (dr.Read())
            {
                ReadyItemStock r = new ReadyItemStock();
                r.ItemID = Convert.ToInt16(dr["ItemID"]);
                r.StyleID = Convert.ToInt16(dr["StyleID"]);
                r.SizeID = Convert.ToInt16(dr["SizeID"]);
                r.Quantity = Convert.ToInt16(dr["Quantity"]);
                r.ColorID = Convert.ToInt16(dr["ColorID"]);
                r.Category = Convert.ToInt16(dr["Category"]);

                list.Add(r);
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
        public List<ReadyItemStock> getStockByCategory(Int16 itemCategoryID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ReadyItemStock where (Category= '" + itemCategoryID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ReadyItemStock> list = new List<ReadyItemStock>();
            while (dr.Read())
            {
                ReadyItemStock r = new ReadyItemStock();
                r.ItemID = Convert.ToInt16(dr["ItemID"]);
                r.StyleID = Convert.ToInt16(dr["StyleID"]);
                r.SizeID = Convert.ToInt16(dr["SizeID"]);
                r.Quantity = Convert.ToInt16(dr["Quantity"]);
                r.ColorID = Convert.ToInt16(dr["ColorID"]);
                r.Category = Convert.ToInt16(dr["Category"]);

                list.Add(r);
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
        public List<ReadyItemStock> getStock()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ReadyItemStock", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ReadyItemStock> list = new List<ReadyItemStock>();
            while (dr.Read())
            {
                ReadyItemStock r = new ReadyItemStock();
                r.ItemID = Convert.ToInt16(dr["ItemID"]);
                r.StyleID = Convert.ToInt16(dr["StyleID"]);
                r.SizeID = Convert.ToInt16(dr["SizeID"]);
                r.Quantity = Convert.ToInt16(dr["Quantity"]);
                r.ColorID = Convert.ToInt16(dr["ColorID"]);
                r.Category = Convert.ToInt16(dr["Category"]);

                list.Add(r);
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
            ColorDAL color = new ColorDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ReadyItemStock", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ReadyItemStock> list = new List<ReadyItemStock>();
            ReadyItemStock g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new ReadyItemStock();
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Category = Convert.ToInt16(dr["Category"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
               
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = item.getItemName(g.ItemID);
                dataRow[1] = style.getItemStyleName(g.StyleID);
                dataRow[2] = size.getItemSizeName(g.SizeID);
                dataRow[3] = color.getColorName(g.ColorID);
                dataRow[4] = categoryDAL.getKillenItemCategoryName(g.Category);
                dataRow[5] = g.Quantity;
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
        //-------------------------------------------------------------------------------------------------------
        public Int16 getStockByItemStyleSizeCategoryColorCategory(Int16 itemID,Int16 styleID,Int16 sizeID,Int16 colorID,Int16 categoryID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from ReadyItemStock where (ItemID= '" + itemID + "' and Category='" + categoryID+ "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and ColorID='" + colorID + "')", objSqlConnection);

            Int16 quan = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                quan= Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quan;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 checkISitemExist(Int16 itemID, Int16 styleID, Int16 sizeID, Int16 colorID,Int16 categoryID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from ReadyItemStock where (ItemID= '" + itemID + "' and Category='" + categoryID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and ColorID='" + colorID + "')", objSqlConnection);
            Int16 quan = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                quan = 1;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quan;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool checkISitemExistByObject(ReadyItemStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from ReadyItemStock where (ItemID= '" + obj.ItemID + "' and Category='" + obj.Category + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);
            bool quan = false;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                quan = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quan;
        }
        //-------------------------------------------------------------------------------------------------------

        public void updateStockInBulk(DataTable dt)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand();
            objSqlConnection.Open();
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                objSqlCommand = new SqlCommand("UPDATE ReadyItemStock SET Quantity='" + dt.Rows[i]["Quantity"] + "' WHERE (Category='" + dt.Rows[i]["Category"] + "' and ItemID='" + dt.Rows[i]["ItemID"] + "' and StyleID='" + dt.Rows[i]["StyleID"] + "'and SizeID='" + dt.Rows[i]["SizeID"] + "' and ColorID='" + dt.Rows[i]["ColorID"] + "')", objSqlConnection);
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
            }
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////

            //ConnectionDB objConnectionDB = new ConnectionDB();
            //SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            //SqlBulkCopy bulkCopy = new SqlBulkCopy(objSqlConnection,SqlBulkCopyOptions.TableLock |SqlBulkCopyOptions.FireTriggers |SqlBulkCopyOptions.UseInternalTransaction,null);

            //// set the destination table name
            //bulkCopy.DestinationTableName = "ReadyItemStock";
            //objSqlConnection.Open();
            //// write the data in the "dataTable"
            //bulkCopy.WriteToServer(dt);
            //objSqlConnection.Close();
        }
    }
}
