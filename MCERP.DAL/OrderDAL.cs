using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class OrderDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addOrder(Order obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into Order(DealerID,DealerCustomerID,Date)values('" + obj.DealerID+ "','" + obj.DealerCustomerID+ "','" + obj.Date + "')", objSqlConnection);
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
        public void updateOrder(Order obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE Order SET DealerID='" + obj.DealerID+ "',DealerCustomerID='"+obj.DealerCustomerID+"',Date='"+obj.Date+"' WHERE (OrderID='" + obj.OrderID+ "')", objSqlConnection);
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
        public void deleteOrder(Int64 orderID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from Order where OrderID = '" + orderID+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public Order getOrderByOrderID(int orderID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Order where (OrderID='" + orderID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Order o = new Order();
            while (dr.Read())
            {
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.DealerID = Convert.ToInt32(dr["DealerID"]);
                o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return o;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Order> getOrderByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Order where Date='"+date+"'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Order> list = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.DealerID = Convert.ToInt32(dr["DealerID"]);
                o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Order> getOrderByDealer(int dealerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Order where DealerID='"+dealerID+"'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Order> list = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.DealerID = Convert.ToInt32(dr["DealerID"]);
                o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Order> getOrderByDealerCustomer(int dealerCustomerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Order where DealerCustomerID='"+dealerCustomerID+"'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Order> list = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.DealerID = Convert.ToInt32(dr["DealerID"]);
                o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Order> getOrderByDealerAndDate(int dealerID,DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Order where DealerID='"+dealerID+"'and Date='"+date+"'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Order> list = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.DealerID = Convert.ToInt32(dr["DealerID"]);
                o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Order> getOrderByDealerCustomerAndDate(int dealerCustomerID,DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Order where DealerCustomerID='"+dealerCustomerID+"'and Date='"+date+"'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Order> list = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.DealerID = Convert.ToInt32(dr["DealerID"]);
                o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
