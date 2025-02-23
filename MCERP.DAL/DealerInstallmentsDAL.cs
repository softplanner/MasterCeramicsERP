using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
   public class DealerInstallmentsDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addDealerInstallment(DealerInstallment obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into DealerInstallments(DealerID,Date,AmountType,AmountSubmitTo,Amount,CurrencyTypeID,SubmitTo)values('" + obj.DealerID+ "','" + obj.Date+ "','" + obj.AmountType+ "','" + obj.AmountSubmitTo+ "','" + obj.Amount + "','" + obj.CurrencyID+ "','" + obj.SubmitTo+ "')", objSqlConnection);
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
        public void updateDealerInstallment(DealerInstallment updatedObj, DealerInstallment beforeUpdateObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  DealerInstallments SET DealerID ='" + updatedObj.DealerID+ "',Date='" + updatedObj.Date+ "',AmountType='" + updatedObj.AmountType+ "',AmountSubmitTo='" + updatedObj.AmountSubmitTo+ "',Amount='" + updatedObj.Amount + "',CurrencyTypeID='" + updatedObj.CurrencyID+ "',SubmitTo='" + updatedObj.SubmitTo+ "' WHERE (DealerID='" + beforeUpdateObj.DealerID+ "'and AmountType='" + beforeUpdateObj.AmountType+ "'and Date='" + beforeUpdateObj.Date + "'and Amount='" + beforeUpdateObj.Amount + "'and AmountSubmitTo='" + beforeUpdateObj.AmountSubmitTo+ "'and CurrencyTypeID='" + beforeUpdateObj.CurrencyID+ "'and SubmitTo='"+beforeUpdateObj.SubmitTo+"')", objSqlConnection);
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
        public void deleteDealerInstallment(DealerInstallment obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from DealerInstallments WHERE (DealerID='" + obj.DealerID + "'and AmountType='" + obj.AmountType + "'and Date='" + obj.Date + "'and Amount='" + obj.Amount + "'and AmountSubmitTo='" + obj.AmountSubmitTo + "'and CurrencyTypeID='" + obj.CurrencyID + "'and SubmitTo='" + obj.SubmitTo + "')", objSqlConnection);
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
        public List<DealerInstallment> getWagesReportByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DealerInstallments where Date = '" + date + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DealerInstallment> list = new List<DealerInstallment>();
            while (dr.Read())
            {
                DealerInstallment d = new DealerInstallment();
                d.DealerID = Convert.ToInt32(dr["DealerID"]);
                d.AmountType= Convert.ToString(dr["AmountType"]);
                d.Date = Convert.ToDateTime(dr["Date"]);
                d.AmountSubmitTo = Convert.ToString(dr["AmountSubmitTo"]);
                d.Amount = Convert.ToSingle(dr["Amount"]);
                d.CurrencyID = Convert.ToInt16(dr["CurrencyID"]);
                d.SubmitTo = Convert.ToString(dr["SubmitTo"]);

                list.Add(d);
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
        //-------------------------------------------------------------------------------------------------------
        public List<DealerInstallment> getInstallmentReportByDateAndDealer(DateTime date, Int32 dealerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DealerInstallments where Date = '" + date + "'and DealerID='" + dealerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DealerInstallment> list = new List<DealerInstallment>();
            while (dr.Read())
            {
                DealerInstallment d = new DealerInstallment();
                d.DealerID = Convert.ToInt32(dr["DealerID"]);
                d.AmountType = Convert.ToString(dr["AmountType"]);
                d.Date = Convert.ToDateTime(dr["Date"]);
                d.AmountSubmitTo = Convert.ToString(dr["AmountSubmitTo"]);
                d.Amount = Convert.ToSingle(dr["Amount"]);
                d.CurrencyID = Convert.ToInt16(dr["CurrencyID"]);
                d.SubmitTo = Convert.ToString(dr["SubmitTo"]);

                list.Add(d);
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
