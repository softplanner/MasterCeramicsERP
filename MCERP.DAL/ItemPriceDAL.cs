using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ItemPriceDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addItemPrice(ItemPrice obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into ItemPrice(Item,Style,Size,Color,Price)values('" + obj.ItemID+ "','" + obj.StyleID+ "','" + obj.SizeID+ "','"+obj.ColorID+"','"+obj.Price+"')", objSqlConnection);
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
        public void updatePrice(ItemPrice obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE ItemPrice SET Price='" + obj.Price+ "' WHERE (Item='" + obj.ItemID+ "' and Style='"+obj.StyleID+"' and Size='"+obj.ColorID+"')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------    
        ////-------------------------------------------------------------------------------------------------------
        //public void deleteItem(ItemPrice obj)
        //{

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("Delete from ItemPrice where Item = '" +  + "')", objSqlConnection);
        //    objSqlConnection.Open();
        //    objSqlCommand.ExecuteNonQuery();
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    //////////////////////////////////////
        //}
        ////-------------------------------------------------------------------------------------------------------
    }
}
