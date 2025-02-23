using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class PerDayWageDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addPerDayWage(PerDayWage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into PerDayWage (WorkerID,Amount)values('" + obj.WorkerID + "','" + obj.Amount + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updatePerDayWage(PerDayWage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE PerDayWage SET Amount ='" + obj.Amount + "' WHERE (WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public void deletePerDayWage(int workerID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from PerDayWage where WorkerID = '" + workerID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public float getPerDayWage(int workerID)
        {
            float amount = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Amount from PerDayWage where (WorkerID='" + workerID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                amount = Convert.ToSingle(dr["Amount"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return amount;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------    

        public List<PerDayWage> getAllWageWorker()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from PerDayWage ", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<PerDayWage> list = new List<PerDayWage>();
            while (dr.Read())
            {
                PerDayWage p = new PerDayWage();
                p.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                p.Amount = Convert.ToSingle(dr["Amount"]);
                list.Add(p);
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
