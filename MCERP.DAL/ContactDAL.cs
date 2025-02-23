using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class ContactDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addContact(Contact obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into Contact(PersonID,ContactType,Number)values('" + obj.PersonID + "','" + obj.ContactType + "','" + obj.Number + "')", objSqlConnection);
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
        public void updateContact(Contact obj,string number)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE Contact SET ContactType ='" + obj.ContactType + "', Number='" + obj.Number + "' WHERE (Number='" + number + "' and PersonID='"+obj.PersonID+"')", objSqlConnection);
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
        public void deleteContact(Contact obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from Contact where (PersonID = '" + obj.PersonID + "'and Number ='"+obj.Number+"')", objSqlConnection);
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
        public bool isPersonExist(int personID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select PersonID from Contact where (PersonID='" + personID + "')", objSqlConnection);
            SqlDataReader dr = null;

            bool a = false;
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
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool isPersonContactExist(Contact obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select PersonID from Contact where (ContactType='" + obj.ContactType + "' and Number='"+obj.Number+"' and PersonID='"+obj.PersonID+"')", objSqlConnection);
            SqlDataReader dr = null;

            bool a = false;
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
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Contact> getContactsListByPerson(Int32 personID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from Contact where (PersonID = '" + personID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Contact> addressList = new List<Contact>();
            while (dr.Read())
            {
                Contact c = new Contact();
                c.PersonID = Convert.ToInt32(dr["PersonID"]);
                c.ContactType = Convert.ToString(dr["ContactType"]);
                c.Number = Convert.ToString(dr["Number"]);

                addressList.Add(c);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<string> getContactsForPersonProfile(Int32 personID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ContactType,Number from Contact where (PersonID = '" + personID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<string> contactList = new List<string>();
            string obj ;
            while (dr.Read())
            {
                obj = null;
                //c.PersonID = Convert.ToInt32(dr["PersonID"]);
                obj = "Contact Type -- " + Convert.ToString(dr["ContactType"]) + "\r\n";
                obj += "Number -- " + Convert.ToString(dr["Number"]) + "\r\n\n";

                contactList.Add(obj);
            }
            objSqlConnection.Close();
            contactList.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return contactList;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
