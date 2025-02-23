using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class DALItemStyle
    {
        //-------------------------------------------------------------------------------------------------------
        public bool isItemsStyleExists(String styleName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  ItemStyle where (Name='" + styleName + "')", objSqlConnection);
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
        public Int16 isItemStyleExistByItemName(String styleName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  ItemStyle where (Name='" + styleName + "')", objSqlConnection);
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
        public Int16 isItemStyleExistByItemID(Int16 ID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  ItemStyle where (ID='" + ID + "')", objSqlConnection);
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
        public void addNewItemStyle(String styleName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into ItemStyle (Name)values('" + styleName + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            //dr.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateItemStyle(ItemStyle itemStyle)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE ItemStyle SET Name ='" + itemStyle.Name + "' WHERE (ID='" + itemStyle.ID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteItemStyle(Int16 ID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from ItemStyle where ID = '" + ID + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public string getItemStyleName(int id)
        {
            string name = null;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from  ItemStyle where ID='" + id + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                name = Convert.ToString(dr["Name"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return name;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------    
        public Int16 getStyleID(string name)
        {
            Int16 id = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  ItemStyle where Name='" + name + "'", objSqlConnection);
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
        public DataSet getAllItemStyle()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from ItemStyle ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteItemStyle(int id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from ItemStyle where ID = '" + id + "'", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            objSqlCommand.Dispose();
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<ItemStyle> getItemStyleList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ItemStyle ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ItemStyle> itemStyleList = new List<ItemStyle>();
            while (dr.Read())
            {
                ItemStyle itemStyle = new ItemStyle();
                itemStyle.ID = Convert.ToInt16(dr["ID"]);
                itemStyle.Name = Convert.ToString(dr["Name"]);
                itemStyleList.Add(itemStyle);
            }
            objSqlConnection.Close();
            itemStyleList.TrimExcess();
            return itemStyleList;

        }
        //-------------------------------------------------------------------------------------------------------
   }
}


