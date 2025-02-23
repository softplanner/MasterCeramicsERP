using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class SaloryMonthOffDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDayReport(DateTime date)
        {
            PersonDAL personDAL = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='"+date.Day+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (WorkerID='" + workerID + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF where (year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "' and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Attendence", typeof(Int16));
            dt.Columns.Add("Extra Attendence", typeof(Int16));
            dt.Columns.Add("Total Attendence", typeof(Int16));
            dt.Columns.Add("Total Amount", typeof(int));
            dt.Columns.Add("S.T.L Deduction", typeof(float));
            dt.Columns.Add("A.L Deduction", typeof(float));
            dt.Columns.Add("Balance Amount", typeof(float));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToInt16(dr["Attendence"]);
                dataRow[2] = Convert.ToInt16(dr["ExtraAttendence"]);
                dataRow[3] = Convert.ToInt16(dr["TotalAttendence"]);
                dataRow[4] = Convert.ToInt32(dr["TotalAmount"]);
                dataRow[5] = Convert.ToSingle(dr["DeductShortTermLoan"]);
                dataRow[6] = Convert.ToSingle(dr["DeductAdvance"]);
                dataRow[7] = Convert.ToSingle(dr["BalanceAmount"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public void addReport(SaloryForTheMonthOFF obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into SaloryForTheMonthOFF (WorkerID,Attendence,ExtraAttendence,TotalAttendence,TotalAmount,BalanceAmount,DeductShortTermLoan,DeductAdvance,Date)values('" + obj.WorkerID + "','" + obj.Attendence + "','" + obj.ExtraAttendence + "','" + obj.TotalAttendence + "','" + obj.TotalAmount + "','" + obj.BalanceAmount + "','" + obj.DeductShortTermLoan + "','" + obj.DeductAdvance + "','" + obj.Date + "')", objSqlConnection);
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
        ////-------------------------------------------------------------------------------------------------------
        //public void updateReport(SaloryForTheMonthOFF obj)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("UPDATE SaloryForTheMonthOFF  SET BalanceAmount ='" + obj.BalanceAmount + "',DeductShortTermLoan='" + obj.DeductShortTermLoan + "',DeductAdvance='" + obj.DeductAdvance + "' WHERE (WorkerID='" + obj.WorkerID + "'and Date='" + obj.Date + "')", objSqlConnection);
        //    objSqlConnection.Open();
        //    objSqlCommand.ExecuteNonQuery();
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    //////////////////////////////////////
        //}
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteTransactionByObject(int workerID,DateTime date)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from SaloryForTheMonthOFF  where (WorkerID = '" + workerID + "' and Date='"+date+"')", objSqlConnection);
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
        public List<SaloryForTheMonthOFF> getTransactionDate(DateTime date)
        {
            List<SaloryForTheMonthOFF> list = new List<SaloryForTheMonthOFF>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF  where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    SaloryForTheMonthOFF c = new SaloryForTheMonthOFF();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.Attendence = Convert.ToInt16(dr["Attendence"]);
                    c.ExtraAttendence = Convert.ToInt16(dr["ExtraAttendence"]);
                    c.TotalAttendence = Convert.ToInt16(dr["TotalAttendence"]);
                    c.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);

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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<SaloryForTheMonthOFF> getTransactionDateAndWorker(int workerID,DateTime date)
        {
            List<SaloryForTheMonthOFF> list = new List<SaloryForTheMonthOFF>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF  where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    SaloryForTheMonthOFF c = new SaloryForTheMonthOFF();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.Attendence = Convert.ToInt16(dr["Attendence"]);
                    c.ExtraAttendence = Convert.ToInt16(dr["ExtraAttendence"]);
                    c.TotalAttendence = Convert.ToInt16(dr["TotalAttendence"]);
                    c.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);

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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<SaloryForTheMonthOFF> getTransactionMonth(DateTime date)
        {
            List<SaloryForTheMonthOFF> list = new List<SaloryForTheMonthOFF>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF  where (month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    SaloryForTheMonthOFF c = new SaloryForTheMonthOFF();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.Attendence = Convert.ToInt16(dr["Attendence"]);
                    c.ExtraAttendence = Convert.ToInt16(dr["ExtraAttendence"]);
                    c.TotalAttendence = Convert.ToInt16(dr["TotalAttendence"]);
                    c.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);

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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<SaloryForTheMonthOFF> getTransactionMonthAndWorker(int workerID,DateTime date)
        {
            List<SaloryForTheMonthOFF> list = new List<SaloryForTheMonthOFF>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF  where (WorkerID='"+workerID+"' and month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    SaloryForTheMonthOFF c = new SaloryForTheMonthOFF();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.Attendence = Convert.ToInt16(dr["Attendence"]);
                    c.ExtraAttendence = Convert.ToInt16(dr["ExtraAttendence"]);
                    c.TotalAttendence = Convert.ToInt16(dr["TotalAttendence"]);
                    c.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);

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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<SaloryForTheMonthOFF> getTransactionYear(DateTime date)
        {
            List<SaloryForTheMonthOFF> list = new List<SaloryForTheMonthOFF>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF  where (year(Date)='" + date.Year+ "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    SaloryForTheMonthOFF c = new SaloryForTheMonthOFF();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.Attendence = Convert.ToInt16(dr["Attendence"]);
                    c.ExtraAttendence = Convert.ToInt16(dr["ExtraAttendence"]);
                    c.TotalAttendence = Convert.ToInt16(dr["TotalAttendence"]);
                    c.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);

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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<SaloryForTheMonthOFF> getTransactionYearAndWorker(int workerID,DateTime date)
        {
            List<SaloryForTheMonthOFF> list = new List<SaloryForTheMonthOFF>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from SaloryForTheMonthOFF  where (WorkerID='"+workerID+"' and year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    SaloryForTheMonthOFF c = new SaloryForTheMonthOFF();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.Attendence = Convert.ToInt16(dr["Attendence"]);
                    c.ExtraAttendence = Convert.ToInt16(dr["ExtraAttendence"]);
                    c.TotalAttendence = Convert.ToInt16(dr["TotalAttendence"]);
                    c.TotalAmount = Convert.ToInt32(dr["TotalAmount"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);

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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
