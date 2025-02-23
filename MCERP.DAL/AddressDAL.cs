using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class AddressDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addAddress(Address obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into Address(PersonID,AddressType,StreetAddress,CityID,ZipCode)values('" + obj.PersonID + "','" + obj.AddressType + "','" + obj.StreetAddress + "','" + obj.CityID + "','" + obj.ZipCode + "')", objSqlConnection);
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
                Console.WriteLine("Database error ... " + e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateAddress(Address obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE  Address SET  AddressType='" + obj.AddressType + "',StreetAddress='" + obj.StreetAddress + "',CityID='" + obj.CityID + "',ZipCode='" + obj.ZipCode + "' WHERE (ID ='" + obj.ID + "')", objSqlConnection);
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
        public void deleteAddress(Int64 addressID)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from Address WHERE (ID ='" +addressID + "')", objSqlConnection);
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
        public List<Address> getAddresesListByPerson(Int32 PersonID)
        {
            List<Address> addressList = new List<Address>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from Address where (PersonID = '" + PersonID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Address a = new Address();
                    a.ID = Convert.ToInt32(dr["ID"]);
                    a.PersonID = Convert.ToInt32(dr["PersonID"]);
                    a.AddressType = Convert.ToString(dr["AddressType"]);
                    a.StreetAddress = Convert.ToString(dr["StreetAddress"]);
                    a.CityID = Convert.ToInt16(dr["CityID"]);
                    a.ZipCode = Convert.ToString(dr["ZipCode"]);

                    addressList.Add(a);
                }
                objSqlConnection.Close();
                addressList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                return addressList;
                //////////////////////////////////////
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return addressList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool isPersonExist(int personID)
        {
            bool a = false;
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select PersonID from  address where (PersonID='" + personID + "')", objSqlConnection);
                SqlDataReader dr = null;
               
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    a = true;
                }
                objSqlConnection.Close();
                objSqlCommand.Dispose();
                dr.Dispose();
                return a;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
            return a;
        }
        //-------------------------------------------------------------------------------------------------------
        public List<Address> searchAddresesByCityID(Int64 CityID)
        {
            List<Address> addressList = new List<Address>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from Address where (CityID = '" + CityID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Address a = new Address();
                    a.PersonID = Convert.ToInt32(dr["PersonID"]);
                    a.ID = Convert.ToInt64(dr["AddressID"]);
                    a.AddressType = Convert.ToString(dr["AddressType"]);
                    a.StreetAddress = Convert.ToString(dr["StreetAddress"]);
                    a.ZipCode = Convert.ToString(dr["ZipCode"]);

                    addressList.Add(a);
                }
                objSqlConnection.Close();
                addressList.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return addressList;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error accessing the database: " + e.Message);
            }
                return addressList;
        }
        //-------------------------------------------------------------------------------------------------------
        public List<string> getAddressForPersonProfile(int personID)
        {
            short provinceID=0;
            CityDAL dalCity = new CityDAL();
            ProvinceDAL dalProvince = new ProvinceDAL();
            CountryDAL dalCountry = new CountryDAL();
            List<string> addressList = new List<string>();
            string obj;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select AddressType,StreetAddress,CityID,ZipCode from Address where (PersonID = '" + personID+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                obj = null;
                obj = "Address Type -- " + Convert.ToString(dr["AddressType"]) + "\r\n";
                obj += "Address -- " + Convert.ToString(dr["StreetAddress"]) + "\r\n";
                obj += "City -- " + dalCity.getCityName(Convert.ToInt16(dr["CityID"])) + "\r\n";
                provinceID = dalCity.getProvinceID(Convert.ToInt16(dr["CityID"]));
                obj += "Province -- " + dalProvince.getProvinceName(provinceID) + "\r\n";
                obj += "Country -- " + dalCountry.getCountryName(dalProvince.getCountryIDByProvinceID(provinceID)) + "\r\n";
                obj += "Zip Code -- "+Convert.ToString(dr["ZipCode"]) + "\r\n\n";

                addressList.Add(obj);
            }
            objSqlConnection.Close();
            addressList.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return addressList;
        }
    }
}
