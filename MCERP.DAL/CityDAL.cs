using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class CityDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addCity(City obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into City(ProvinceID,Name)values('" + obj.ProvinceID + "','" + obj.Name + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllCitiesByProvince(Int16 provinceID)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                da.SelectCommand = new SqlCommand("select Name from City where ProvinceID='" + provinceID + "'", objSqlConnection);
                ds.Clear();
                da.Fill(ds);
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                //////////////////////////////////////
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateCity(City obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE City SET ProvinceID='" + obj.ProvinceID + "',Name='" + obj.Name + "' WHERE (CityID='" + obj.CityID + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteCity(Int16 cityID)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from City where (CityID = '" + cityID + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------- 
        public Int16 getCityID(string name)
        {
            Int16 id = 0;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select CityID from City where (Name='" + name + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt16(dr["CityID"]);
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return id;
        }
        //------------------------------------------------------------------------------------------------------- 
        //------------------------------------------------------------------------------------------------------- 
        public Int16 getProvinceID(short cityID)
        {
            Int16 id = 0;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select ProvinceID from City where (CityID='" + cityID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt16(dr["ProvinceID"]);
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return id;
        }
        //------------------------------------------------------------------------------------------------------- 
        //------------------------------------------------------------------------------------------------------- 
        public string getCityName(Int16 cityID)
        {
            string name = null;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Name from City where (CityID='" + cityID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    name = Convert.ToString(dr["Name"]);
                }
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return name;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return name;
        }
        //------------------------------------------------------------------------------------------------------- 
        //-------------------------------------------------------------------------------------------------------
        public List<City> getCitiesListByProvince(Int16 provinceID)
        {
            List<City> list = new List<City>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from City where (ProvinceID='" + provinceID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    City c = new City();
                    c.CityID = Convert.ToInt16(dr["CityID"]);
                    c.ProvinceID = Convert.ToInt16(dr["ProvinceID"]);
                    c.Name = Convert.ToString(dr["Name"]);

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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<City> getCitiesBy()
        {
            List<City> list = new List<City>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from City ", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                City c;
                while (dr.Read())
                {
                    c = new City();
                    c.CityID = Convert.ToInt16(dr["CityID"]);
                    c.ProvinceID = Convert.ToInt16(dr["ProvinceID"]);
                    c.Name = Convert.ToString(dr["Name"]);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<City> getCitiesListByProvinceID(Int16 provinceID)
        {
            List<City> list = new List<City>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from City where (ProvinceID = '" + provinceID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    City c = new City();
                    c.CityID = Convert.ToInt16(dr["CityID"]);
                    c.CountryID = Convert.ToInt16(dr["CountryID"]);
                    c.ProvinceID = Convert.ToInt16(dr["ProvinceID"]);
                    c.Name = Convert.ToString(dr["Name"]);

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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<string> getCitiesByProvinceID(Int16 provinceID)
        {
            List<string> list = new List<string>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select Name from City where (ProvinceID = '" + provinceID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    string s = null;
                    s = Convert.ToString(dr["Name"]);

                    list.Add(s);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        public City getInfoAboutCityByID(Int16 cityID)
        {
            City c=new City();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from City where (CityID='" + cityID + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c.CityID = Convert.ToInt16(dr["CityID"]);
                }
                c.ProvinceID = Convert.ToInt16(dr["ProvinceID"]);
                c.Name = Convert.ToString(dr["Name"]);
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return c;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public City getInfoAboutCityByName(string name)
        {
            City c = new City();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from City where (Name='" + name + "')", objSqlConnection);
                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    c.CityID = Convert.ToInt16(dr["CityID"]);
                }
                c.CountryID = Convert.ToInt16(dr["CountryID"]);
                c.ProvinceID = Convert.ToInt16(dr["ProvinceID"]);
                c.Name = Convert.ToString(dr["Name"]);
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return c;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public bool IsAlreadyExist(string cityName, Int16 provinceID)
        {
            bool id = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select CityID from City where (Name='" + cityName + "' and ProvinceID='" + provinceID + "')", objSqlConnection);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return id;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------    
        public bool IsAddressDependsUponThisCity(Int16 cityID)
        {
            bool id = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select ID from Address where CityID='" + cityID + "'", objSqlConnection);
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
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return id;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
