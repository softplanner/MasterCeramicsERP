using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class CheckedUnGlazeItemsDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addCheckedUnGlazeItems(CheckedUnGlazeItems obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into CheckedUnGlazeItems(WorkerID,CheckerID,ItemID,StyleID,SizeID,Quantity,Date)values('" + obj.WorkerID + "','" + obj.CheckerID + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.Date + "')", objSqlConnection);
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
        public void updateCheckedUnGlazeItems(CheckedUnGlazeItems obj,int workerID)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE CheckedUnGlazeItems SET WorkerID ='" + obj.WorkerID + "',CheckerID='" + obj.CheckerID + "',ItemID='" + obj.ItemID + "',StyleID='" + obj.StyleID + "',SizeID='" + obj.SizeID + "',Quantity='" + obj.Quantity + "',Date='" + obj.Date + "' WHERE (WorkerID='" + workerID + "')", objSqlConnection);
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
        public void deleteCheckedUnGlazeItems(CheckedUnGlazeItems obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from CheckedUnGlazeItems where WorkerID = '" + obj.WorkerID + "'and CheckerID='" + obj.CheckerID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "'and Date='" + obj.Date + "')", objSqlConnection);
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
        public List<CheckedUnGlazeItems> getCheckedUnGlazeItemsAllByWorkerID(Int32 workerID)
        {
            List<CheckedUnGlazeItems> list = new List<CheckedUnGlazeItems>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CheckedUnGlazeItems where WorkerID = '" + workerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CheckedUnGlazeItems c = new CheckedUnGlazeItems();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(c);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<CheckedUnGlazeItems> getCheckedUnGlazeItemsAllByCheckerID(Int32 checkerID)
        {
            List<CheckedUnGlazeItems> list = new List<CheckedUnGlazeItems>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CheckedUnGlazeItems where CheckerID = '" + checkerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CheckedUnGlazeItems c = new CheckedUnGlazeItems();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(c);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<CheckedUnGlazeItems> getCheckedUnGlazeItemsByDate(DateTime date)
        {
            List<CheckedUnGlazeItems> list = new List<CheckedUnGlazeItems>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CheckedUnGlazeItems where Date = '" + date + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CheckedUnGlazeItems c = new CheckedUnGlazeItems();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(c);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
