using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ItemWeightDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public float getItemWeight(Int16 itemID,Int16 styleID,Int16 sizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Weight from  ItemWeight where (ItemID='" + itemID + "' and StyleID='" + styleID + "'and SizeID='" + sizeID + "')", objSqlConnection);
            SqlDataReader dr = null;
            float weight = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                weight = Convert.ToSingle(dr["Weight"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return weight;
        }
        //-------------------------------------------------------------------------------------------------------
        public float getItemWeightByName(string item, string style, string size)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("SELECT ItemWeight.Weight FROM ItemWeight INNER JOIN Item ON ItemWeight.ItemID = Item.ID INNER JOIN ItemStyle ON ItemWeight.StyleID = ItemStyle.ID INNER JOIN ItemSize ON ItemWeight.SizeID = ItemSize.ID where (Item.Name='" + item + "' and ItemStyle.Name='" + style + "'and ItemSize.Name='" + size + "')", objSqlConnection);
            SqlDataReader dr = null;
            float weight = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                weight = Convert.ToSingle(dr["Weight"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return weight;
        }

        //---------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool isAlreadyExist(ItemWeight itemWeight)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Weight from  ItemWeight where (ItemID='" + itemWeight.ItemID + "' and StyleID='" + itemWeight.StyleID + "'and SizeID='" + itemWeight.SizeID + "')", objSqlConnection);
            SqlDataReader dr = null;
            bool check = false;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                check = true;
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return check;
        }
        //---------------------------------------------------------------------------------------------------------
         //-------------------------------------------------------------------------------------------------------
        public bool isAlreadyExistCheckForUpdation(ItemWeight itemWeight)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Weight from  ItemWeight where (ItemID='" + itemWeight.ItemID + "' and StyleID='" + itemWeight.StyleID + "'and SizeID='" + itemWeight.SizeID + "' and Weight='"+itemWeight.Weight+"')", objSqlConnection);
            SqlDataReader dr = null;
            bool check = false;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                check = true;
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return check;
        }
        //---------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addItemWeight(ItemWeight obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into ItemWeight (ItemID,StyleID,SizeID,Weight) values ('" + obj.ItemID + "' , '" + obj.StyleID + "' , '" + obj.SizeID + "' ,'"+obj.Weight+"')", objSqlConnection);
             objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
        }
        //---------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public float getItemWeights(ItemWeight itemWeight)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Weight from  ItemWeight where (ItemID='" + itemWeight.ItemID + "' and StyleID='" + itemWeight.StyleID + "'and SizeID='" + itemWeight.SizeID + "')", objSqlConnection);
            SqlDataReader dr = null;
            float weight = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                weight = Convert.ToSingle(dr["Weight"]);
            }
            objSqlConnection.Close();
            objSqlCommand.Dispose();
            dr.Dispose();
            return weight;
        }
        //---------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<ItemWeight> getItemWeightListByItemID(Int16 id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ItemWeight where ItemID = '" + id + "'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ItemWeight> itemWeightList = new List<ItemWeight>();
            while (dr.Read())
            {
                ItemWeight itemWeight = new ItemWeight();
                itemWeight.ItemID = Convert.ToInt16(dr["ItemID"]);
                itemWeight.StyleID = Convert.ToInt16(dr["StyleID"]);
                itemWeight.SizeID = Convert.ToInt16(dr["SizeID"]);
                itemWeight.Weight = Convert.ToDouble(dr["Weight"]);
                itemWeightList.Add(itemWeight);
            }
            objSqlConnection.Close();
            itemWeightList.TrimExcess();
            return itemWeightList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<ItemWeight> getItemWeightList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ItemWeight ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ItemWeight> itemWeightList = new List<ItemWeight>();
            while (dr.Read())
            {
                ItemWeight itemWeight = new ItemWeight();
                itemWeight.ItemID = Convert.ToInt16(dr["ItemID"]);
                itemWeight.StyleID = Convert.ToInt16(dr["StyleID"]);
                itemWeight.SizeID = Convert.ToInt16(dr["SizeID"]);
                itemWeight.Weight = Convert.ToDouble(dr["Weight"]);
                itemWeightList.Add(itemWeight);
            }
            objSqlConnection.Close();
            itemWeightList.TrimExcess();
            return itemWeightList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<ItemWeight> getItemWeightListByItemStyleID(Int16 id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ItemWeight where StyleID = '" + id + "'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ItemWeight> itemWeightList = new List<ItemWeight>();
            while (dr.Read())
            {
                ItemWeight itemWeight = new ItemWeight();
                itemWeight.ItemID = Convert.ToInt16(dr["ItemID"]);
                itemWeight.StyleID = Convert.ToInt16(dr["StyleID"]);
                itemWeight.SizeID = Convert.ToInt16(dr["SizeID"]);
                itemWeight.Weight = Convert.ToDouble(dr["Weight"]);
                itemWeightList.Add(itemWeight);
            }
            objSqlConnection.Close();
            itemWeightList.TrimExcess();
            return itemWeightList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<ItemWeight> getItemWeightListByItemSizID(Int16 id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from ItemWeight where SizeID = '" + id + "'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<ItemWeight> itemWeightList = new List<ItemWeight>();
            while (dr.Read())
            {
                ItemWeight itemWeight = new ItemWeight();
                itemWeight.ItemID = Convert.ToInt16(dr["ItemID"]);
                itemWeight.StyleID = Convert.ToInt16(dr["StyleID"]);
                itemWeight.SizeID = Convert.ToInt16(dr["SizeID"]);
                itemWeight.Weight = Convert.ToDouble(dr["Weight"]);
                itemWeightList.Add(itemWeight);
            }
            objSqlConnection.Close();
            itemWeightList.TrimExcess();
            return itemWeightList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteWeight(ItemWeight obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from ItemWeight WHERE (ItemID ='" + obj.ItemID + "' and StyleID='"+obj.StyleID+"' and SizeID='"+obj.SizeID+"' and Weight='"+obj.Weight+"')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateItemWeight(ItemWeight updatedObj, ItemWeight beforeUpdateObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE ItemWeight SET ItemID='" + updatedObj.ItemID + "',StyleID='" + updatedObj.StyleID + "',SizeID='" + updatedObj.SizeID + "',Weight='"+updatedObj.Weight+"' WHERE (ItemID='" + beforeUpdateObj.ItemID + "'and StyleID='" + beforeUpdateObj.StyleID + "'and SizeID='" + beforeUpdateObj.SizeID + "'and Weight='" + beforeUpdateObj.Weight+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------

        //////-------------------------------------------------------------------------------------------------------
        ////public int isAnyTableDependToAuthor(int authorID)
        ////{
        ////    ConnectionDB objConnectionDB = new ConnectionDB();
        ////    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        ////    SqlCommand objSqlCommand = new SqlCommand("select AuthorID from  Book where AuthorID='" + authorID + "'", objSqlConnection);
        ////    SqlDataReader dr = null;
        ////    int a = 0;
        ////    objSqlConnection.Open();
        ////    dr = objSqlCommand.ExecuteReader();
        ////    while (dr.Read())
        ////    {
        ////        a = 1;
        ////    }
        ////    objSqlConnection.Close();
        ////    return a;
        ////}
        ////////-------------------------------------------------------------------------------------------------------

        ////-------------------------------------------------------------------------------------------------------    

        //public string getItemWeightName(int ItemWeightID)
        //{
        //    string ItemWeightName = null;
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select Name from  ItemWeight where ItemWeightID='" + ItemWeightID + "'", objSqlConnection);
        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        ItemWeightName = Convert.ToString(dr["Name"]);
        //    }
        //    objSqlConnection.Close();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    return ItemWeightName;
        //}
        ////-------------------------------------------------------------------------------------------------------  


        ////-------------------------------------------------------------------------------------------------------    

        //public int getItemWeightID(string ItemWeightName)
        //{
        //    int id = 0;
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from  ItemWeight where Name='" + ItemWeightName + "'", objSqlConnection);
        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        id = Convert.ToInt32(dr["ItemWeightID"]);
        //    }
        //    objSqlConnection.Close();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    return id;
        //}
        ////-------------------------------------------------------------------------------------------------------  

        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getAllItemWeight()
        //{
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataSet ds = new DataSet();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    da.SelectCommand = new SqlCommand("select * from ItemWeight ", objSqlConnection);
        //    ds.Clear();
        //    da.Fill(ds);
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------

        ////-------------------------------------------------------------------------------------------------------
        //public void deleteItemWeight(int ItemWeightID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("Delete from ItemWeight where ItemWeightID = '" + ItemWeightID + "'", objSqlConnection);
        //    objSqlConnection.Open();
        //    objSqlCommand.ExecuteNonQuery();
        //    objSqlConnection.Close();
        //    objSqlCommand.Dispose();
        //}
        ////-------------------------------------------------------------------------------------------------------


    }
}


