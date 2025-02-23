using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class DailyWagesReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDateReport(DateTime date)
        {
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Per Day", typeof(int));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("Balance Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt32(dr["PerDayWage"]);
                dataRow[3] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[4] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[5] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReport(DateTime date)
        {
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Per Day", typeof(int));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("Balance Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt32(dr["PerDayWage"]);
                dataRow[3] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[4] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[5] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getYearlyReport(DateTime date)
        {
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Per Day", typeof(int));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("Balance Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt32(dr["PerDayWage"]);
                dataRow[3] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[4] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[5] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDateReportByWorker(DateTime date,int workerID)
        {
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Per Day", typeof(int));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("Balance Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt32(dr["PerDayWage"]);
                dataRow[3] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[4] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[5] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReportByWorker(DateTime date,int workerID)
        {
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Per Day", typeof(int));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("Balance Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt32(dr["PerDayWage"]);
                dataRow[3] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[4] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[5] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getYearlyReportByWorker(DateTime date, int workerID)
        {
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (WorkerID='" + workerID + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Per Day", typeof(int));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("Balance Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt32(dr["PerDayWage"]);
                dataRow[3] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[4] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[5] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addWagesReport(DailyWagesReport obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into DailyWagesReport(WorkerID,Date,Attendence,PerDayWage,TotalAmount,DeductShortTermLoan,BalanceAmount)values('" + obj.WorkerID + "','" + obj.Date + "','" + obj.Attendence + "','" + obj.PerDayWage + "','" + obj.TotalAmount + "','" + obj.DeductShortTermLoan + "','" + obj.BalanceAmount + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
            //    //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateWagesReport(DailyWagesReport obj, DailyWagesReport beforeUpdateObj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE  DailyWagesReport SET (PerDayWage='" + obj.PerDayWage + "',Attendence='" + obj.Attendence + "',TotalAmount='" + obj.TotalAmount + "',DeductShortTermLoan='" + obj.DeductShortTermLoan + "',BalanceAmount='" + obj.BalanceAmount + "' WHERE (WorkerID='" + obj.WorkerID + "'and Date='" + obj.Date + "')", objSqlConnection);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteWagesReport(int workerID,DateTime date)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from DailyWagesReport WHERE (WorkerID ='" + workerID + "'and Date='" + date + "')", objSqlConnection);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyWagesReport> getWagesReportByDate(DateTime date)
        {
            List<DailyWagesReport> list = new List<DailyWagesReport>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year+ "' and month(Date)='"+date.Month+"' and day(Date)='"+date.Day+"')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DailyWagesReport w = new DailyWagesReport();
                    w.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    w.Attendence = Convert.ToInt16(dr["Attendence"]);
                    w.Date = Convert.ToDateTime(dr["Date"]);
                    w.PerDayWage = Convert.ToInt32(dr["PerDayWage"]);
                    w.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    w.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    w.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);

                    list.Add(w);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyWagesReport> getWagesReportByDateAndWorker(DateTime date, Int32 workerID)
        {
            List<DailyWagesReport> list = new List<DailyWagesReport>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month+ "'and day(Date)='"+date.Day+"' and WorkerID='" + workerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DailyWagesReport w = new DailyWagesReport();
                    w.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    w.Attendence = Convert.ToInt16(dr["Attendence"]);
                    w.Date = Convert.ToDateTime(dr["Date"]);
                    w.PerDayWage = Convert.ToInt32(dr["PerDayWage"]);
                    w.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    w.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    w.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);

                    list.Add(w);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyWagesReport> getWagesReportByMonth(DateTime date)
        {
            List<DailyWagesReport> list = new List<DailyWagesReport>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (month(Date) = '" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DailyWagesReport w = new DailyWagesReport();
                    w.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    w.Attendence = Convert.ToInt16(dr["Attendence"]);
                    w.Date = Convert.ToDateTime(dr["Date"]);
                    w.PerDayWage = Convert.ToInt32(dr["PerDayWage"]);
                    w.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    w.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    w.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);

                    list.Add(w);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyWagesReport> getWagesReportByMonthAndWorker(DateTime date, Int32 workerID)
        {
            List<DailyWagesReport> list = new List<DailyWagesReport>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (month(Date) = '" + date.Month + "'and WorkerID='" + workerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DailyWagesReport w = new DailyWagesReport();
                    w.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    w.Attendence = Convert.ToInt16(dr["Attendence"]);
                    w.Date = Convert.ToDateTime(dr["Date"]);
                    w.PerDayWage = Convert.ToInt32(dr["PerDayWage"]);
                    w.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    w.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    w.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);

                    list.Add(w);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyWagesReport> getWagesReportByYear(DateTime date)
        {
            List<DailyWagesReport> list = new List<DailyWagesReport>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DailyWagesReport w = new DailyWagesReport();
                    w.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    w.Attendence = Convert.ToInt16(dr["Attendence"]);
                    w.Date = Convert.ToDateTime(dr["Date"]);
                    w.PerDayWage = Convert.ToInt32(dr["PerDayWage"]);
                    w.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    w.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    w.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);

                    list.Add(w);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyWagesReport> getWagesReportByYearAndWorker(DateTime date, Int32 workerID)
        {
            List<DailyWagesReport> list = new List<DailyWagesReport>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where (year(Date) = '" + date.Year + "'and WorkerID='" + workerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    DailyWagesReport w = new DailyWagesReport();
                    w.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    w.Attendence = Convert.ToInt16(dr["Attendence"]);
                    w.Date = Convert.ToDateTime(dr["Date"]);
                    w.PerDayWage = Convert.ToInt32(dr["PerDayWage"]);
                    w.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    w.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    w.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);

                    list.Add(w);
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
                Console.WriteLine("Error Accessing Database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<DailyWagesReport> getWagesReportByDateAndSprayMan(DateTime date, int sprayManID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where Date = '" + date + "'and SprayManID='" + sprayManID + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<DailyWagesReport> list = new List<DailyWagesReport>();
        //    while (dr.Read())
        //    {
        //        DailyWagesReport g = new DailyWagesReport();
        //        g.WagedHouseID = Convert.ToInt16(dr["WorkerID"]);
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(g);
        //    }
        //    objSqlConnection.Close();
        //    list.TrimExcess();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return list;
        //}
        ////-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<DailyWagesReport> getWagesReportByDateAndColor(DateTime date, Int16 colorID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where Date = '" + date + "'and ColorID='" + colorID + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<DailyWagesReport> list = new List<DailyWagesReport>();
        //    while (dr.Read())
        //    {
        //        DailyWagesReport g = new DailyWagesReport();
        //        g.WagedHouseID = Convert.ToInt16(dr["WorkerID"]);
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(g);
        //    }
        //    objSqlConnection.Close();
        //    list.TrimExcess();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return list;
        //}
        ////-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<DailyWagesReport> getWagesReportByDateAndItem(DateTime date, Int16 itemID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<DailyWagesReport> list = new List<DailyWagesReport>();
        //    while (dr.Read())
        //    {
        //        DailyWagesReport g = new DailyWagesReport();
        //        g.WagedHouseID = Convert.ToInt16(dr["WorkerID"]);
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(g);
        //    }
        //    objSqlConnection.Close();
        //    list.TrimExcess();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return list;
        //}
        ////-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<DailyWagesReport> getWagesReportByDateAndStyle(DateTime date, Int16 styleID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from DailyWagesReport where Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<DailyWagesReport> list = new List<DailyWagesReport>();
        //    while (dr.Read())
        //    {
        //        DailyWagesReport g = new DailyWagesReport();
        //        g.WagedHouseID = Convert.ToInt16(dr["WorkerID"]);
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(g);
        //    }
        //    objSqlConnection.Close();
        //    list.TrimExcess();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return list;
        //}
        ////-------------------------------------------------------------------------------------------------------
    }
}
