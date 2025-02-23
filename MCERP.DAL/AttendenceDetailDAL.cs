using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class AttendenceDetailDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsWorkerExist(int workerID)
        {
            bool c = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select WorkerID from AttendenceDetail where (WorkerID = '" + workerID + "')", objSqlConnection);
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
        public int countExtraAttendence(int workerID,DateTime date)
        {
            int c = 0;
            string attendenceStatus = "true";
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select ExtraAttendence from AttendenceDetail where (WorkerID = '" + workerID + "' and ExtraAttendence='"+attendenceStatus+"' and month(Date)='"+date.Month+"')", objSqlConnection);
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
        public string checkIsExtraAttendenceMarked(int workerID,DateTime date)
        {
            string c = "false";
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select ExtraAttendence from AttendenceDetail where (WorkerID = '" + workerID + "' and year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c = Convert.ToString(dr["ExtraAttendence"]);
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
        public void markExtraAttendence(AttendenceDetail obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into AttendenceDetail(WorkerID,Date,ExtraAttendence)values('" + obj.WorkerID + "','" + obj.Date + "','" + obj.ExtraAttendence + "')", objSqlConnection);
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
        public void unMarkedExtraAttendence(AttendenceDetail obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("delete from AttendenceDetail where (WorkerID='" + obj.WorkerID + "' and year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "')", objSqlConnection);
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
    }
}
