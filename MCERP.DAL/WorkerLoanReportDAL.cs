using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class WorkerLoanReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDayReport(DateTime date)
        {
            PersonDAL personDAL = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getSelectedDayReportByWorker(DateTime date,int workerID)
        {
            PersonDAL personDAL = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getDailyReport()
        {
            PersonDAL personDAL = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getDailyReportByWorker(int workerID)
        {
            PersonDAL personDAL = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (WorkerID='" + workerID + "' and year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getYearlyReportByWorker(DateTime date,int workerID)
        {
            PersonDAL personDAL = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date) = '" + date.Year + "' and WorkerID='"+workerID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Loan Type", typeof(string));
            dt.Columns.Add("Amount", typeof(Int32));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["LoanType"]);
                dataRow[2] = Convert.ToInt32(dr["Amount"]);
                dataRow[3] = Convert.ToDateTime(dr["Date"]);

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
        public void addReport(WorkerLoanReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into WorkerLoanReport (WorkerID,LoanType,Amount,Date)values('" + obj.WorkerID + "','" + obj.LoanType + "','" + obj.Amount + "','"+obj.Date+"')", objSqlConnection);
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
        public void updateReport(WorkerLoanReport obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("update WorkerLoanReport SET Amount ='" + obj.Amount+ "' WHERE (WorkerID='" + obj.WorkerID + "' and LoanType='"+obj.LoanType+"' and Date='"+obj.Date+"')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteReport(WorkerLoanReport obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("delete from WorkerLoanReport where (WorkerID='" + obj.WorkerID + "' and LoanType='" + obj.LoanType + "' and Date='" + obj.Date + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<WorkerLoanReport> getReportByDate(DateTime date)
        {
            List<WorkerLoanReport> list = new List<WorkerLoanReport>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
                //SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (Date = '" + date + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    WorkerLoanReport g = new WorkerLoanReport();
                    g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    g.Date = Convert.ToDateTime(dr["Date"]);
                    g.LoanType = Convert.ToString(dr["LoanType"]);
                    g.Amount = Convert.ToInt32(dr["Amount"]);
                    list.Add(g);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<WorkerLoanReport> getReportByDateAndWorker(int workerID,DateTime date)
        {
            List<WorkerLoanReport> list = new List<WorkerLoanReport>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
                //SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (Date = '" + date + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    WorkerLoanReport g = new WorkerLoanReport();
                    g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    g.Date = Convert.ToDateTime(dr["Date"]);
                    g.LoanType = Convert.ToString(dr["LoanType"]);
                    g.Amount = Convert.ToInt32(dr["Amount"]);
                    list.Add(g);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<WorkerLoanReport> getReportByMonth(DateTime date)
        {
            List<WorkerLoanReport> list = new List<WorkerLoanReport>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (month(Date) = '" + date.Month + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    WorkerLoanReport g = new WorkerLoanReport();
                    g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    g.Date = Convert.ToDateTime(dr["Date"]);
                    g.LoanType = Convert.ToString(dr["LoanType"]);
                    g.Amount = Convert.ToInt32(dr["Amount"]);
                    list.Add(g);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<WorkerLoanReport> getReportByMonthAndWorker(int workerID,DateTime date)
        {
            List<WorkerLoanReport> list = new List<WorkerLoanReport>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (WorkerID='"+workerID+"' and month(Date) = '" + date.Month + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    WorkerLoanReport g = new WorkerLoanReport();
                    g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    g.Date = Convert.ToDateTime(dr["Date"]);
                    g.LoanType = Convert.ToString(dr["LoanType"]);
                    g.Amount = Convert.ToInt32(dr["Amount"]);
                    list.Add(g);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<WorkerLoanReport> getReportByYear(DateTime date)
        {
            List<WorkerLoanReport> list = new List<WorkerLoanReport>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (year(Date) = '" + date.Year+ "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    WorkerLoanReport g = new WorkerLoanReport();
                    g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    g.Date = Convert.ToDateTime(dr["Date"]);
                    g.LoanType = Convert.ToString(dr["LoanType"]);
                    g.Amount = Convert.ToInt32(dr["Amount"]);
                    list.Add(g);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<WorkerLoanReport> getReportByYearAndWorker(int workerID, DateTime date)
        {
            List<WorkerLoanReport> list = new List<WorkerLoanReport>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from WorkerLoanReport where (WorkerID='" + workerID + "' and year(Date) = '" + date.Year + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    WorkerLoanReport g = new WorkerLoanReport();
                    g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    g.Date = Convert.ToDateTime(dr["Date"]);
                    g.LoanType = Convert.ToString(dr["LoanType"]);
                    g.Amount = Convert.ToInt32(dr["Amount"]);
                    list.Add(g);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
