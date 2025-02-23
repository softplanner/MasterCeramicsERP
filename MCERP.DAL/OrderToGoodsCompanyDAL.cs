using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class OrderToGoodsCompanyToGoodsCompany
    {
        //-------------------------------------------------------------------------------------------------------
        public void addOrderToGoodsCompany(OrderToGoodsCompany obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into OrderToGoodsCompany(OrderID,CompanyID,BiltyNo,Date)values('"+obj.OrderID+"','" + obj.CompanyID+ "','" + obj.BiltyNo+ "','" + obj.Date + "')", objSqlConnection);
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
        public void updateOrderToGoodsCompany(OrderToGoodsCompany Updatedobj,OrderToGoodsCompany beforeUpdateObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE OrderToGoodsCompany SET OrderID='"+Updatedobj.OrderID+"',CompanyID='" + Updatedobj.CompanyID+ "',BiltyNo='"+Updatedobj.BiltyNo+"',Date='"+Updatedobj.Date+"' WHERE (OrderID='" + beforeUpdateObj.OrderID+ "'and CompanyID='"+beforeUpdateObj.CompanyID+"'and BiltyNo='"+beforeUpdateObj.BiltyNo+"'and Date='"+beforeUpdateObj.Date+"')", objSqlConnection);
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
        public void deleteOrderToGoodsCompany(OrderToGoodsCompany obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from OrderToGoodsCompany where (OrderID = '" + obj.OrderID+ "'and CompanyID='"+obj.CompanyID+"'and BiltyNo='"+obj.BiltyNo+"'and Date='"+obj.Date+"')", objSqlConnection);
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
        public OrderToGoodsCompany getOrderByOrderID(int orderID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderToGoodsCompany where (OrderID='" + orderID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OrderToGoodsCompany o = new OrderToGoodsCompany();
            while (dr.Read())
            {
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.CompanyID = Convert.ToInt16(dr["CompanyID"]);
                o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
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
        public OrderToGoodsCompany getOrderByBiltyNo(string biltyNo)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderToGoodsCompany where (BiltyNo='" + biltyNo+ "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OrderToGoodsCompany o = new OrderToGoodsCompany();
            while (dr.Read())
            {
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.CompanyID = Convert.ToInt16(dr["CompanyID"]);
                o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
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
        public List<OrderToGoodsCompany> getOrderByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderToGoodsCompany where (Date='" + date+ "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OrderToGoodsCompany> list=new List<OrderToGoodsCompany>();
            while(dr.Read())
            {
                OrderToGoodsCompany o = new OrderToGoodsCompany();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.CompanyID= Convert.ToInt16(dr["CompanyID"]);
                o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            list.TrimExcess();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderToGoodsCompany> getOrderByDateAndCompany(DateTime date,Int16 companyID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderToGoodsCompany where (Date='" + date+ "'and CompanyID='"+companyID+"')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OrderToGoodsCompany> list=new List<OrderToGoodsCompany>();
            while(dr.Read())
            {
                OrderToGoodsCompany o = new OrderToGoodsCompany();
                o.OrderID = Convert.ToInt64(dr["OrderID"]);
                o.CompanyID= Convert.ToInt16(dr["CompanyID"]);
                o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(o);
            }
            list.TrimExcess();
            objSqlConnection.Close();
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
