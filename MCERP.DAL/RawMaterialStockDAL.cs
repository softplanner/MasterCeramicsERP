using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class RawMaterialStockDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addStock(Int16 materialID,float quantity)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into RawMaterialStock (RMID,Quantity)values('" + materialID + "','" + quantity + "','" + quantity+ "')", objSqlConnection);
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
        public void addStockObj(RawMaterialStock obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into RawMaterialStock (RMID,Quantity,AlarmAmount)values('" + obj.RMID + "','" + obj.Quantity + "','"+obj.AlarmAmount+"')", objSqlConnection);
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
        public void setAlarmAmount(float alarmAmount,Int16 materialID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into RawMaterialStock (RMID,AlarmAmount)values('" + materialID + "','" + alarmAmount+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateStock(Int16 materialID,float quantity)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE RawMaterialStock SET Quantity ='" +quantity+ "' WHERE (RMID='" + materialID+ "')", objSqlConnection);
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
        public void updateAlarmAmount(Int16 materialID,float alarmAmount)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE RawMaterialStock SET AlarmAmount='" + alarmAmount+ "' WHERE (RMID='" + materialID+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void deleteStock(Int16 materialID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from RawMaterialStock where (RMID= '" + materialID+ "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////

        }
        
        public float getStock(Int16 materialID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from RawMaterialStock where (RMID = '" + materialID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            float Quantity = 0;
            while (dr.Read())
            {
                Quantity = Convert.ToSingle(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return Quantity;
        }
        
        public float getAlarmAmount(Int16 materialID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select AlarmAmount from RawMaterialStock where RMID = '" + materialID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            float AlarmAmount= 0;
            while (dr.Read())
            {
                AlarmAmount = Convert.ToSingle(dr["AlarmAmount"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return AlarmAmount;
        }
        //----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
        public List<RawMaterialStock> getStockList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialStock", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterialStock> lst = new List<RawMaterialStock>();
            RawMaterialStock obj;
            while (dr.Read())
            {
                 obj= new RawMaterialStock();
                 obj.RMID = Convert.ToInt16(dr["RMID"]);
                 obj.Quantity= Convert.ToSingle(dr["Quantity"]);
                 obj.AlarmAmount = Convert.ToSingle(dr["AlarmAmount"]);
                 lst.Add(obj);
            }
            objSqlConnection.Close();
            lst.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return lst;
        }
        public bool checkForStockAlarm()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterialStock ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool check = false;
            while (dr.Read())
            {
                if (Convert.ToSingle(dr["Quantity"]) <= Convert.ToSingle(dr["AlarmAmount"]))
                {
                    check=true;
                    break;
                }
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return check;
        }
        //public void changeAlarmTime(int time)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("update StockReminder set Time='"+time+"'", objSqlConnection);

        //    objSqlConnection.Open();
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    //////////////////////////////////////
        //}
        //public void setAlarm(string alarm)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("update StockReminder set Alarm='" + alarm+ "'", objSqlConnection);
        //    objSqlConnection.Open();
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    //////////////////////////////////////
        //}
        //public string isAlarm()
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select Alarm from StockReminder", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    string check = "";
        //    while (dr.Read())
        //    {
        //        check = Convert.ToString(dr["Alarm"]);
        //    }
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return check;
        //}
        //----------------------------------------------------------------------------------------------------------
    }
}
