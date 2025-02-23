using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ProvinceDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addProvince(Province obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into Province (CountryID,Name)values('" + obj.CountryID + "','" + obj.Name + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateProvince(Province obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE Province SET CountryID ='" + obj.CountryID + "',Name='" + obj.Name + "' WHERE (ID='" + obj.ID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void deleteProvince(Int16 provinceID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from Province where (ID='" + provinceID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////

        }
        //-------------------------------------------------------------------------------------------------------
        public List<Province> getAllProvinceList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Province ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Province> list = new List<Province>();
            Province p;
            while (dr.Read())
            {
                p = new Province();
                p.CountryID = Convert.ToInt16(dr["CountryID"]);
                p.ID = Convert.ToInt16(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);
                list.Add(p);
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
        //------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Province> getAllProvinceListByCountry(Int16 countryID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Province where CountryID='"+countryID+"'", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Province> list = new List<Province>();
            Province p;
            while (dr.Read())
            {
                p = new Province();
                p.CountryID = Convert.ToInt16(dr["CountryID"]);
                p.ID = Convert.ToInt16(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);
                list.Add(p);
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
        //------------------------------------------------------------------------------------------------
        
        //------------------------------------------------------------------------------------------------
        public Int16 getCountryOftheProvince(Int16 provinceID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select CountryID from Province where (ID='" + provinceID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 countryID = 0;

            while (dr.Read())
            {
                countryID = Convert.ToInt16(dr["CountryID"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return countryID;
        }
        //----------------------------------------------------------------------------------------------------------
        public string getProvinceName(Int16 provinceID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from Province where (ID='" + provinceID+ "')", objSqlConnection);
            string s = null;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();

            while (dr.Read())
            {
                s = Convert.ToString(dr["Name"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return s;
        }
        //------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
        public Int16 getProvinceIDByCountryIDAndProvinceName(Int16 countryID,string provinceName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from Province where (CountryID= '" + countryID+ "' and Name='"+provinceName+"')", objSqlConnection);
            Int16 id = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt16(dr["ID"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return id;
        }
        //------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------
        public Int16 getCountryIDByProvinceID(Int16 provinceID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select CountryID from Province where (ID= '" + provinceID + "')", objSqlConnection);
            Int16 id = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt16(dr["CountryID"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return id;
        }
        //------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllProvince()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select Name from Province ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllProvinceByCountryID(Int16 countryID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select Name from Province where CountryID='"+countryID+"'", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public bool IsAlreadyExist(string provinceName,Int16 countryID)
        {
            bool id = false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from Province where (Name='" + provinceName + "' and CountryID='"+countryID+"')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return id;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public bool IsCityDependsUponThisProvince(Int16 provinceID)
        {
            bool id = false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from City where ProvinceID='" + provinceID + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return id;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
