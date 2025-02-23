using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class PersonExtraInfoDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addReport(PersonExtraInfo obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into PersonExtraInfo(PersonID,NIC,EMail,ThumbImage,Image,DateOfBirth)values('" + obj.PersonID + "','" + obj.NIC + "','" + obj.EMail + "','" + obj.ThumImage+ "','" + obj.Image + "','" + obj.DateOfBirth + "')", objSqlConnection);
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
        public void updatePerson(PersonExtraInfo upPersonIDdObj, PersonExtraInfo beforeUpPersonIDObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPPersonID  PersonExtraInfo SET PersonID='" + upPersonIDdObj.PersonID + "',NIC='" + upPersonIDdObj.NIC + "',EMail='" + upPersonIDdObj.EMail + "',ThumbImage='" + upPersonIDdObj.ThumImage+ "',Image='" + upPersonIDdObj.Image + "',DateOfBirth='" + upPersonIDdObj.DateOfBirth + "' WHERE (PersonID='" + beforeUpPersonIDObj.PersonID + "'and NIC='" + beforeUpPersonIDObj.NIC + "'and EMail='" + beforeUpPersonIDObj.EMail + "'and ThumbImage='" + beforeUpPersonIDObj.ThumImage+ "'and Image='" + beforeUpPersonIDObj.Image + "'and DateOfBirth='" + beforeUpPersonIDObj.DateOfBirth + "')", objSqlConnection);
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
        public void deleteReport(PersonExtraInfo obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from PersonExtraInfo WHERE (PersonID='" + obj.PersonID + "'and NIC='" + obj.NIC + "'and EMail='" + obj.EMail + "'and ThumbImage='" + obj.ThumImage+ "'and Image='" + obj.Image + "'and DateOfBirth='" + obj.DateOfBirth + "')", objSqlConnection);
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
        public PersonExtraInfo getPersonByPersonID(int personID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from PersonExtraInfo where PersonID = '" + personID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            PersonExtraInfo p = new PersonExtraInfo();
            while (dr.Read())
            {
                p.PersonID = Convert.ToInt32(dr["PersonID"]);
                p.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                p.NIC = Convert.ToString(dr["NIC"]);
                p.EMail = Convert.ToString(dr["EMail"]);
            }
                //m.ThumbImage = Convert.(dr["ThumbImage"]);
                //m.Image = Convert.ToInt16(dr["Image"]);
            objSqlConnection.Close();
             ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return p;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public PersonExtraInfo getPersonByNIC(string nic)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from PersonExtraInfo where NIC = '" + nic+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            PersonExtraInfo p = new PersonExtraInfo();
            while (dr.Read())
            {
                p.PersonID = Convert.ToInt32(dr["PersonID"]);
                p.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                p.NIC = Convert.ToString(dr["NIC"]);
                p.EMail = Convert.ToString(dr["EMail"]);
            }
            //m.ThumbImage = Convert.(dr["ThumbImage"]);
            //m.Image = Convert.ToInt16(dr["Image"]);
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return p;
        }
        //-------------------------------------------------------------------------------------------------------
        //get persom by thumb image
        //get person by date of birth
        //-------------------------------------------------------------------------------------------------------
        public List<PersonExtraInfo> getReportByDateOfBirth(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from PersonExtraInfo where (DateOfBirth='" + date+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<PersonExtraInfo> list = new List<PersonExtraInfo>();
            while (dr.Read())
            {
                PersonExtraInfo p = new PersonExtraInfo();
                p.PersonID = Convert.ToInt32(dr["PersonID"]);
                p.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                p.NIC = Convert.ToString(dr["NIC"]);
                p.EMail = Convert.ToString(dr["EMail"]);

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
        //-------------------------------------------------------------------------------------------------------
    }
}
