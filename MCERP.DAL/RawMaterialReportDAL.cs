using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class RawMaterialReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addReport(RawMaterialReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into RawMaterialReport(RMID,SupplierID,Quantity,Date,UnitRate)values('" + obj.RMID + "','" + obj.SupplierID + "','" + obj.Quantity + "','" + obj.Date + "','"+obj.UnitRate+"')", objSqlConnection);
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
        public bool isReportExist(RawMaterialReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (Date='" + obj.Date + "' and SupplierID='"+obj.SupplierID+"' and RMID='"+obj.RMID+"' and UnitRate='"+obj.UnitRate+"')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool list= false;
            while (dr.Read())
            {
                list=true;
            }
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
        public float getCurrentReportInfo(RawMaterialReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from RawMaterialReport where (Date='" + obj.Date + "' and SupplierID='" + obj.SupplierID + "' and RMID='" + obj.RMID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            float list = 0;
            while (dr.Read())
            {
                list= Convert.ToSingle(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateReport(RawMaterialReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE RawMaterialReport SET UnitRate='"+obj.UnitRate+"',Quantity='" + obj.Quantity+ "' WHERE (RMID='" + obj.RMID + "' and Date='"+obj.Date+"' and SupplierID='"+obj.SupplierID+"')", objSqlConnection);
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
        public void updateCurrentReport(RawMaterialReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE RawMaterialReport SET Quantity='" + obj.Quantity + "' WHERE (RMID='" + obj.RMID + "' and Date='" + obj.Date + "' and SupplierID='" + obj.SupplierID + "' and UnitRate='"+obj.UnitRate+"')", objSqlConnection);
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
        public void deleteTransaction(RawMaterialReport obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from RawMaterialReport where (RMID = '" + obj.RMID + "'and SupplierID='" + obj.SupplierID + "'and Quantity='" + obj.Quantity + "'and day(Date)='" + obj.Date.Day + "' and month(Date)='"+obj.Date.Month+"' and year(Date)='"+obj.Date.Year+"' and UnitRate='"+obj.UnitRate+"')", objSqlConnection);
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
        public List<RawMaterialReport> getReportByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterialReport> list = new List<RawMaterialReport>();
            while (dr.Read())
            {
                RawMaterialReport r = new RawMaterialReport();
                r.RMID = Convert.ToInt16(dr["RMID"]);
                r.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                r.Quantity = Convert.ToSingle(dr["Quantity"]);
                r.UnitRate= Convert.ToSingle(dr["UnitRate"]);
                r.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(r);
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
        public DataSet getdailyReport(DateTime date)
        {
            PersonDAL personDAL = new PersonDAL();
            RawMaterialDAL rmDAL = new RawMaterialDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (day(Date)='" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            RawMaterialReport o ;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Raw Material", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("Quantity(Kg)", typeof(int));
            dt.Columns.Add("Unit Rate(per Kg)", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o= new RawMaterialReport();
                o.RMID = Convert.ToInt16(dr["RMID"]);
                o.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                o.Quantity = Convert.ToSingle(dr["Quantity"]);
                o.UnitRate = Convert.ToSingle(dr["UnitRate"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
               
                dataRow = ds.Tables[0].NewRow();
                dataRow[1] = personDAL.getPersonName(o.SupplierID);
                dataRow[0] = rmDAL.getMaterialName(o.RMID);
                dataRow[2] = o.Quantity;
                dataRow[3] = o.UnitRate;
                dataRow[4] = o.Date;

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReport(DateTime d)
        {
            PersonDAL personDAL = new PersonDAL();
            RawMaterialDAL rmDAL = new RawMaterialDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (month(Date)='" + d.Month + "' and year(Date)='"+d.Year+"')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            RawMaterialReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Raw Material", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("Quantity(Kg)", typeof(int));
            dt.Columns.Add("Unit Rate(per Kg)", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new RawMaterialReport();
                o.RMID = Convert.ToInt16(dr["RMID"]);
                o.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                o.Quantity = Convert.ToSingle(dr["Quantity"]);
                o.UnitRate = Convert.ToSingle(dr["UnitRate"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
              
                dataRow = ds.Tables[0].NewRow();
                dataRow[1] = personDAL.getPersonName(o.SupplierID);
                dataRow[0] = rmDAL.getMaterialName(o.RMID);
                dataRow[2] = o.Quantity;
                dataRow[3] = o.UnitRate;
                dataRow[4] = o.Date;

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getYearlyReportDataSet(DateTime d)
        {
            PersonDAL personDAL = new PersonDAL();
            RawMaterialDAL rmDAL = new RawMaterialDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (year(Date)='" + d.Year + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            RawMaterialReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Raw Material", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("Quantity(Kg)", typeof(int));
            dt.Columns.Add("Unit Rate(per Kg)", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new RawMaterialReport();
                o.RMID = Convert.ToInt16(dr["RMID"]);
                o.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                o.Quantity = Convert.ToSingle(dr["Quantity"]);
                o.UnitRate = Convert.ToSingle(dr["UnitRate"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[1] = personDAL.getPersonName(o.SupplierID);
                dataRow[0] = rmDAL.getMaterialName(o.RMID);
                dataRow[2] = o.Quantity;
                dataRow[3] = o.UnitRate;
                dataRow[4] = o.Date;

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<RawMaterialReport> getReportByMonth(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (month(Date)='" + d.Month+ "' and year(Date)='"+d.Year+"')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterialReport> list = new List<RawMaterialReport>();
            while (dr.Read())
            {
                RawMaterialReport r = new RawMaterialReport();
                r.RMID = Convert.ToInt16(dr["RMID"]);
                r.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                r.Quantity = Convert.ToSingle(dr["Quantity"]);
                r.UnitRate = Convert.ToSingle(dr["UnitRate"]);
                r.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(r);
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
        public List<RawMaterialReport> getReportByYear(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (year(Date)='" + d.Year + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterialReport> list = new List<RawMaterialReport>();
            while (dr.Read())
            {
                RawMaterialReport r = new RawMaterialReport();
                r.RMID = Convert.ToInt16(dr["RMID"]);
                r.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                r.Quantity = Convert.ToSingle(dr["Quantity"]);
                r.UnitRate = Convert.ToSingle(dr["UnitRate"]);
                r.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(r);
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
        public List<RawMaterialReport> getReportByDateAndSupplier(DateTime date, int SupplierID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialReport where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and SupplierID='" + SupplierID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterialReport> list = new List<RawMaterialReport>();
            while (dr.Read())
            {
                RawMaterialReport r = new RawMaterialReport();
                r.RMID = Convert.ToInt16(dr["RMID"]);
                r.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                r.Quantity = Convert.ToSingle(dr["Quantity"]);
                r.UnitRate = Convert.ToSingle(dr["UnitRate"]);
                r.Date = Convert.ToDateTime(dr["Date"]);
                list.Add(r);
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
