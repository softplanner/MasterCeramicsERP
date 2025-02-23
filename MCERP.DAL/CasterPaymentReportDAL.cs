using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class CasterPaymentReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addReport(CasterPayment obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into CasterPaymentReport(WorkerID,BalanceAmount,DeductShortTermLoan,DeductAdvance,Date,ItemID,StyleID,SizeID,Quantity,Rate)values('" + obj.WorkerID + "','" + obj.BalanceAmount + "','" + obj.DeductShortTermLoan + "','" + obj.DeductAdvance + "','" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.Rate + "')", objSqlConnection);
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
        public void deletePaymentTransaction(int workerID,DateTime date)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from CasterPaymentReport where (WorkerID = '" + workerID + "'and Date='" + date + "')", objSqlConnection);
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
        public DataSet getSelectedDateCasterPaymentReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(Int16));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("A.L Deduction", typeof(int));
            dt.Columns.Add("Bal.Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Rate"]);
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[7] = Convert.ToInt32(dr["DeductAdvance"]);
                dataRow[8] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[9] = Convert.ToDateTime(dr["Date"]);
                
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
        public DataSet getSelectedDateReportByCaster(DateTime date,int casterID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "' and WorkerID='"+casterID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(Int16));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("A.L Deduction", typeof(int));
            dt.Columns.Add("Bal.Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Rate"]);
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[7] = Convert.ToInt32(dr["DeductAdvance"]);
                dataRow[8] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[9] = Convert.ToDateTime(dr["Date"]);

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
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(Int16));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("A.L Deduction", typeof(int));
            dt.Columns.Add("Bal.Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Rate"]);
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[7] = Convert.ToInt32(dr["DeductAdvance"]);
                dataRow[8] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[9] = Convert.ToDateTime(dr["Date"]);

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
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(Int16));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("S.T.L Deduction", typeof(int));
            dt.Columns.Add("A.L Deduction", typeof(int));
            dt.Columns.Add("Bal.Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Rate"]);
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[7] = Convert.ToInt32(dr["DeductAdvance"]);
                dataRow[8] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[9] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getMonthlyReportByCaster(DateTime date, int casterID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(Int16));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("S.T.L Ded", typeof(int));
            dt.Columns.Add("A.L Ded", typeof(int));
            dt.Columns.Add("Bal.Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Rate"]);
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[7] = Convert.ToInt32(dr["DeductAdvance"]);
                dataRow[8] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[9] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getYearlyReportByCaster(DateTime date, int casterID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Rate", typeof(Int16));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("S.T.L Ded", typeof(int));
            dt.Columns.Add("A.L Ded", typeof(int));
            dt.Columns.Add("Bal.Amount", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Rate"]);
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToInt32(dr["DeductShortTermLoan"]);
                dataRow[7] = Convert.ToInt32(dr["DeductAdvance"]);
                dataRow[8] = Convert.ToInt32(dr["BalanceAmount"]);
                dataRow[9] = Convert.ToDateTime(dr["Date"]);

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
        public List<CasterPayment> getReportByDate(DateTime date)
        {
            List<CasterPayment> list = new List<CasterPayment>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CasterPayment c = new CasterPayment();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);
                    c.Rate = Convert.ToInt16(dr["Rate"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);

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
        public List<CasterPayment> getReportByDateAndWorker(int workerID,DateTime date)
        {
            List<CasterPayment> list = new List<CasterPayment>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CasterPayment c = new CasterPayment();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);
                    c.Rate = Convert.ToInt16(dr["Rate"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);

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
        public List<CasterPayment> getReportByMonth(DateTime date)
        {
            List<CasterPayment> list = new List<CasterPayment>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CasterPayment c = new CasterPayment();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);
                    c.Rate = Convert.ToInt16(dr["Rate"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);

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
        public List<CasterPayment> getReportByMonthAndWorker(int workerID,DateTime date)
        {
            List<CasterPayment> list = new List<CasterPayment>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (WorkerID = '" + workerID + "' and month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CasterPayment c = new CasterPayment();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);
                    c.Rate = Convert.ToInt16(dr["Rate"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);

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
        public List<CasterPayment> getReportByYear(DateTime date)
        {
            List<CasterPayment> list = new List<CasterPayment>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (year(Date) = '" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CasterPayment c = new CasterPayment();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);
                    c.Rate = Convert.ToInt16(dr["Rate"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);

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
        public List<CasterPayment> getReportByYearAndWorker(int workerID,DateTime date)
        {
            List<CasterPayment> list = new List<CasterPayment>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where (WorkerID='"+workerID+"' and year(Date) = '" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    CasterPayment c = new CasterPayment();
                    c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    c.BalanceAmount = Convert.ToInt32(dr["BalanceAmount"]);
                    c.DeductShortTermLoan = Convert.ToInt32(dr["DeductShortTermLoan"]);
                    c.DeductAdvance = Convert.ToInt32(dr["DeductAdvance"]);
                    c.Date = Convert.ToDateTime(dr["Date"]);
                    c.Quantity = Convert.ToInt16(dr["Quantity"]);
                    c.Rate = Convert.ToInt16(dr["Rate"]);
                    c.ItemID = Convert.ToInt16(dr["ItemID"]);
                    c.StyleID = Convert.ToInt16(dr["StyleID"]);
                    c.SizeID = Convert.ToInt16(dr["SizeID"]);

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
