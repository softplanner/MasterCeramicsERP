using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ItemSizeDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool isItemSizeExist(String sizeName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  ItemSize where (Name='" + sizeName + "')", objSqlConnection);
            SqlDataReader dr = null;

            bool a = false;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                a = true;
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return a;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 isItemSizeExistByName(String sizeName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  ItemSize where (Name='" + sizeName + "')", objSqlConnection);
            SqlDataReader dr = null;

            Int16 a = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                a = 1;
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return a;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 isItemSizeExistByID(int ItemSizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  ItemSize where (ID='" + ItemSizeID + "')", objSqlConnection);
            SqlDataReader dr = null;

            Int16 a = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                a = 1;
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return a;
        }
        //-------------------------------------------------------------------------------------------------------

        public void addNewItemSize(String sizeName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into ItemSize (Name)values('" + sizeName + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            //dr.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------
        public void updateItemSize(ItemSize itemSize)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE ItemSize SET Name ='" + itemSize.Name + "' WHERE (ID='" + itemSize.ID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------
        public void deleteItemSize(Int16 sizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from ItemSize where ID = '" + sizeID + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public string getItemSizeName(Int16 id)
        {
            string ItemSizeName = null;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  ItemSize where ID='" + id + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                ItemSizeName = Convert.ToString(dr["Name"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return ItemSizeName;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------    
        public Int16 getSizeID(string ItemSizeName)
        {
            Int16 id = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  ItemSize where Name='" + ItemSizeName + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt16(dr["ID"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return id;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllItemSize()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from ItemSize ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteItemSize(int ItemSizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from ItemSize where ID = '" + ItemSizeID + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<ItemSize> getItemSizeList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ItemSize ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ItemSize> itemSizeList = new List<ItemSize>();
            while (dr.Read())
            {
                ItemSize itemSize = new ItemSize();
                itemSize.ID = Convert.ToInt16(dr["ID"]);
                itemSize.Name = Convert.ToString(dr["Name"]);
                itemSizeList.Add(itemSize);
            }
            objSqlConnection.Close();
            itemSizeList.TrimExcess();
            return itemSizeList;

        }
        //-------------------------------------------------------------------------------------------------------
    }
}



