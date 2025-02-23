using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class AttendenceAccountDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getYearlyAttendenceReportByWorker(DateTime date,int wid)
        {
            PersonDAL pdal = new PersonDAL();
            AttendenceDetailDAL dal = new AttendenceDetailDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (WorkerID='"+wid+"' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Extra Attendence", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = pdal.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["Status"]);
                dataRow[2] = dal.checkIsExtraAttendenceMarked(Convert.ToInt32(dr["WorkerID"]), Convert.ToDateTime(dr["Date"]));
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
        public DataSet getMonthlyAttendenceReportByWorker(DateTime date,int wid)
        {
            PersonDAL pdal = new PersonDAL();
            AttendenceDetailDAL dal = new AttendenceDetailDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (month(Date) = '" + date.Month + "' and year(Date)='" + date.Year + "' and WorkerID='"+wid+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Extra Attendence", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = pdal.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["Status"]);
                dataRow[2] = dal.checkIsExtraAttendenceMarked(Convert.ToInt32(dr["WorkerID"]), Convert.ToDateTime(dr["Date"]));
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
        public DataSet getMonthlyAttendenceReport(DateTime date)
        {
            PersonDAL pdal = new PersonDAL();
            AttendenceDetailDAL dal = new AttendenceDetailDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (month(Date) = '" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Extra Attendence", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = pdal.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["Status"]);
                dataRow[2] = dal.checkIsExtraAttendenceMarked(Convert.ToInt32(dr["WorkerID"]), Convert.ToDateTime(dr["Date"]));
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
        public DataSet getDailyAttendenceReport()
        {
            PersonDAL pdal = new PersonDAL();
            AttendenceDetailDAL dal = new AttendenceDetailDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (year(Date) = '" + DateTime.Today.Year+ "' and month(Date)='"+DateTime.Today.Month+"' and day(Date)='"+DateTime.Today.Day+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Extra Attendence", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = pdal.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["Status"]);
                dataRow[2] = dal.checkIsExtraAttendenceMarked(Convert.ToInt32(dr["WorkerID"]), Convert.ToDateTime(dr["Date"]));
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
        public DataSet getSelectedDateAttendenceReport(DateTime date)
        {
            PersonDAL pdal = new PersonDAL();
            AttendenceDetailDAL dal = new AttendenceDetailDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (year(Date) = '" +date.Year +"' and month(Date) = '" +date.Month +"' and day(Date) = '" +date.Day +"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Extra Attendence", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = pdal.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["Status"]);
                dataRow[2] = dal.checkIsExtraAttendenceMarked(Convert.ToInt32(dr["WorkerID"]), Convert.ToDateTime(dr["Date"]));
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
        public DataSet getSelectedDateAttendenceReportByWorker(DateTime date,int wid)
        {
            PersonDAL pdal = new PersonDAL();
            AttendenceDetailDAL dal = new AttendenceDetailDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (WorkerID='"+wid+"' and year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Worker", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Extra Attendence", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = pdal.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = Convert.ToString(dr["Status"]);
                dataRow[2] = dal.checkIsExtraAttendenceMarked(Convert.ToInt32(dr["WorkerID"]), Convert.ToDateTime(dr["Date"]));
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
        public void addWorkerToAttendenceRegister(AttendenceAccount obj)
        {
            try
            {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into AttendenceAccount(WorkerID,Date,Status)values('" + obj.WorkerID + "','" + obj.Date + "','" + obj.Status + "')", objSqlConnection);
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
        public void markAttendence(AttendenceAccount obj)
        {
            try
            {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE AttendenceAccount SET Status ='" + obj.Status + "' WHERE (year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "' and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public void updateAttendence(AttendenceAccount obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE AttendenceAccount SET Status ='" + obj.Status + "',Date='" + obj.Date  + "' WHERE (WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public List<AttendenceAccount> getAttendenceListByDate(DateTime date)
        {
            List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    AttendenceAccount aa = new AttendenceAccount();
                    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    aa.Date = Convert.ToDateTime(dr["Date"]);
                    aa.Status = Convert.ToString(dr["Status"]);

                    attendenceList.Add(aa);
                }
                objSqlConnection.Close();
                attendenceList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return attendenceList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<AttendenceAccount> getAttendenceListByMonth(DateTime date)
        {
            List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    AttendenceAccount aa = new AttendenceAccount();
                    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    aa.Date = Convert.ToDateTime(dr["Date"]);
                    aa.Status = Convert.ToString(dr["Status"]);

                    attendenceList.Add(aa);
                }
                objSqlConnection.Close();
                attendenceList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return attendenceList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<AttendenceAccount> getAttendenceListByYear(DateTime date)
        {
            List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    AttendenceAccount aa = new AttendenceAccount();
                    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    aa.Date = Convert.ToDateTime(dr["Date"]);
                    aa.Status = Convert.ToString(dr["Status"]);

                    attendenceList.Add(aa);
                }
                objSqlConnection.Close();
                attendenceList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return attendenceList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<AttendenceAccount> getAttendenceListByDateAndWorker(DateTime date,int workerID)
        {
            List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (WorkerID = '" + workerID + "' and year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    AttendenceAccount aa = new AttendenceAccount();
                    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    aa.Date = Convert.ToDateTime(dr["Date"]);
                    aa.Status = Convert.ToString(dr["Status"]);

                    attendenceList.Add(aa);
                }
                objSqlConnection.Close();
                attendenceList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return attendenceList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<AttendenceAccount> getAttendenceListByMonthAndWorker(DateTime date, int workerID)
        {
            List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (WorkerID = '" + workerID + "' and month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    AttendenceAccount aa = new AttendenceAccount();
                    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    aa.Date = Convert.ToDateTime(dr["Date"]);
                    aa.Status = Convert.ToString(dr["Status"]);

                    attendenceList.Add(aa);
                }
                objSqlConnection.Close();
                attendenceList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return attendenceList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<AttendenceAccount> getAttendenceListByYearAndWorker(DateTime date, int workerID)
        {
            List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where (WorkerID = '" + workerID + "' and year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    AttendenceAccount aa = new AttendenceAccount();
                    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                    aa.Date = Convert.ToDateTime(dr["Date"]);
                    aa.Status = Convert.ToString(dr["Status"]);

                    attendenceList.Add(aa);
                }
                objSqlConnection.Close();
                attendenceList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return attendenceList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsWorkerExist(int workerID)
        {
            bool c = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select WorkerID from AttendenceAccount where (WorkerID = '" + workerID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c = true;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return c;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool checkStatusExistByWorkerAndDate(int workerID,DateTime date)
        {
            bool c = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Status from AttendenceAccount where (WorkerID = '" + workerID + "' and year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c = true;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return c;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public int countWorkerAttendenceCurrentMonth(int workerID,DateTime date)
        {
            int c = 0;
            string attendenceStatus = "Present";
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Status from AttendenceAccount where (WorkerID = '" + workerID + "' and Status='"+attendenceStatus+"' and  month(Date)='" + date.Month + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c++;
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return c;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public string getStatus(int workerID,DateTime date)
        {
            string c = "Absent";
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Status from AttendenceAccount where (WorkerID = '" + workerID + "' and year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c = Convert.ToString(dr["Status"]);
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return c;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public AttendenceAccount getAttendenceByWorkerID(Int32 workerID,DateTime date)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where WorkerID = '" + workerID + "'and )", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    AttendenceAccount aa = new AttendenceAccount();
                
        //    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
        //    aa.AttendenceDate = Convert.ToDateTime(dr["Date"]);
        //    aa.Status = Convert.ToString(dr["Status"]);

        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return aa;

        //}
        ////-------------------------------------------------------------------------------------------------------
        //public List<AttendenceAccount> getAttendenceByWorkerName(string FName,string LName)
        //{
        //    PersonDAL personDAL = new PersonDAL();
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    List<int> personIDs = new List<int>();
        //    SqlCommand objSqlCommand=new SqlCommand();
        //    personIDs.TrimExcess();
        //    SqlDataReader dr = null;
        //    List<AttendenceAccount> attendenceList = new List<AttendenceAccount>();
        //    objSqlConnection.Open();
        //    for (int i = 0; i <= personIDs.Count;i++ )
        //    {
        //        objSqlCommand= new SqlCommand("select * from AttendenceAccount where WorkerID = '" + i + "'", objSqlConnection);
        //        dr = objSqlCommand.ExecuteReader();
        //        dr.Read();
        //        AttendenceAccount aa = new AttendenceAccount();
        //        aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
        //        aa.AttendenceDate = Convert.ToDateTime(dr["Date"]);
        //        aa.Status = Convert.ToString(dr["Status"]);
        //    }
        //    //int id=personDAL.getPersonID(FName,LName);
            //SqlCommand objSqlCommand = new SqlCommand("select * from AttendenceAccount where WorkerID = '" + id + "'", objSqlConnection);
            //SqlCommand objSqlCommand = new SqlCommand();
            
            
            
            //while (dr.Read())
            //{
            //    AttendenceAccount aa = new AttendenceAccount();
            //    aa.WorkerID = Convert.ToInt32(dr["WorkerID"]);
            //    aa.AttendenceDate = Convert.ToDateTime(dr["Date"]);
            //    aa.Status = Convert.ToString(dr["Status"]);
                
            //    attendenceList.Add(aa);
            //}
            //objSqlConnection.Close();
            //attendenceList.TrimExcess();
            /////////////////////////////////////////---Reallocate the resources
            //objSqlConnection.Dispose();
            //objSqlCommand.Dispose();
            //dr.Dispose();
            ////////////////////////////////////////
            //return attendenceList;

        //}
        //-------------------------------------------------------------------------------------------------------
        
    }
}
