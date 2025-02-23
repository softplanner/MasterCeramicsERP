using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ItemDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public Int16 isItemExistByName(String itemName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  Item where (Name='" + itemName + "')", objSqlConnection);
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
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 isItemExistByID(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  Item where (ID='" + itemID + "')", objSqlConnection);
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
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool isItemsExistsByID(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  Item where (ID='" + itemID + "')", objSqlConnection);
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
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool isItemsExistsByName(string name)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  Item where (Name='" + name+ "')", objSqlConnection);
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
        ////-------------------------------------------------------------------------------------------------------

        public void addNewItem(String itemName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into Item (Name)values('" + itemName + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            //dr.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------
        public void updateItem(Item item)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE Item SET Name ='" + item.Name + "' WHERE (ID='" + item.ID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public string getItemName(Int16 itemID)
        {
            string itemName = null;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  Item where ID='" + itemID + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                itemName = Convert.ToString(dr["Name"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return itemName;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------    

        public Int16 getItemID(string itemName)
        {
            Int16 id = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  Item where Name='" + itemName + "'", objSqlConnection);
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
        public DataSet getAllItem()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from Item ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from Item where ID = '" + itemID + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Item> getItemList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Item ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Item> itemList = new List<Item>();
            while (dr.Read())
            {
                Item item = new Item();
                item.ID = Convert.ToInt16(dr["ID"]);
                item.Name = Convert.ToString(dr["Name"]);
                itemList.Add(item);
            }
            objSqlConnection.Close();
            itemList.TrimExcess();
            return itemList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<string> getItemsList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from Item ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<string> itemList = new List<string>();
            string name = null;
            while (dr.Read())
            {
                name = Convert.ToString(dr["Name"]);
                itemList.Add(name);
            }
            objSqlConnection.Close();
            itemList.TrimExcess();
            return itemList;

        }
        //-------------------------------------------------------------------------------------------------------
    }
}


