using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    class KillenBreakageDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addReport(KillenBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into KillenBreakage(Date,ItemID,StyleID,SizeID,ColorID,Quantity,Remarks,KillenID)values('" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "','"+obj.Remarks+"','"+obj.KillenID+"')", objSqlConnection);
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
        public void updateReport(KillenBreakage updatedObj, KillenBreakage beforeUpdateObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  KillenBreakage SET Date='" + updatedObj.Date + "',ItemID='" + updatedObj.ItemID + "',StyleID='" + updatedObj.StyleID + "',SizeID='" + updatedObj.SizeID + "',ColorID='" + updatedObj.ColorID + "',Quantity='" + updatedObj.Quantity + "',Remarks='"+updatedObj.Remarks+"',KillenID='"+updatedObj.KillenID+"' WHERE (Date='" + beforeUpdateObj.Date + "'and ItemID='" + beforeUpdateObj.ItemID + "'and StyleID='" + beforeUpdateObj.StyleID + "'and SizeID='" + beforeUpdateObj.SizeID + "'and ColorID='" + beforeUpdateObj.ColorID + "'and Quantity='" + beforeUpdateObj.Quantity + "'and Remarks='"+beforeUpdateObj.Remarks+"'and KillenID='"+beforeUpdateObj.KillenID+"')", objSqlConnection);
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
        public void deleteReport(KillenBreakage obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from KillenBreakage WHERE (Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and Quantity='" + obj.Quantity + "'and Remarks='" + obj.Remarks + "'and KillenID='"+obj.KillenID+"')", objSqlConnection);
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
        public List<KillenBreakage> getReportByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from KillenBreakage where Date = '" + date + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<KillenBreakage> list = new List<KillenBreakage>();
            while (dr.Read())
            {
                KillenBreakage k = new KillenBreakage();
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.KillenID= Convert.ToInt16(dr["KillenID"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks= Convert.ToString(dr["Remarks"]);

                list.Add(k);
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
        public List<KillenBreakage> getReportByDateAndkillen(DateTime date, Int16 killenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from KillenBreakage where Date = '" + date + "'and KillenID='" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<KillenBreakage> list = new List<KillenBreakage>();
            while (dr.Read())
            {
                KillenBreakage k = new KillenBreakage();
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.KillenID= Convert.ToInt16(dr["KillenID"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks= Convert.ToString(dr["Remarks"]);

                list.Add(k);
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
