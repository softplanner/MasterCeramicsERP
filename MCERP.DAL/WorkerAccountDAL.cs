using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class WorkerAccountDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addPayment(CasterPayment obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into CasterPaymentReport(WorkerID,BalanceAmount,DeductShortTermLoan,DeductAdvance,Date)values('" + obj.WorkerID + "','" + obj.BalanceAmount + "','" + obj.DeductShortTermLoan + "','" + obj.DeductAdvance + "','" + obj.Date + "')", objSqlConnection);
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
        public void updatePayment(CasterPayment obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE CasterPaymentReport SET BalanceAmount ='" + obj.BalanceAmount + "',DeductShortTermLoan='" + obj.DeductShortTermLoan + "',DeductAdvance='" + obj.DeductAdvance + "' WHERE (WorkerID='" + obj.WorkerID + "'and Date='" + obj.Date + "')", objSqlConnection);
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
        public void deletePaymentTransaction(int workerID, DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from CasterPaymentReport where WorkerID = '" + workerID + "'and Date='" + date + "')", objSqlConnection);
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
        public List<CasterPayment> getTransactionByWorkerID(int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from CasterPaymentReport where WorkerID = '" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<CasterPayment> list = new List<CasterPayment>();
            while (dr.Read())
            {
                CasterPayment c = new CasterPayment();
                c.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                c.BalanceAmount = Convert.ToInt32(dr["BalanceAmoount"]);
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
        //-------------------------------------------------------------------------------------------------------
    }
}
