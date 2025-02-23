using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class PersonTypeDAL
    {
         //-------------------------------------------------------------------------------------------------------
        public void addPersonType(string PersonTypeName)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into PersonType (Name)values('" + PersonTypeName + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updatePersonType(PersonType obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE PersonType SET Name ='" +obj.Name + "' WHERE (ID='" + obj.ID + "')", objSqlConnection);
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
        public void deletePersonType(Int16 PersonTypeID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from PersonType where ID = '" + PersonTypeID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------    

        public string getPersonTypeName(int id)
        {
            string name=null;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from PersonType where (ID='" + id+ "')", objSqlConnection);
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
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------    

        public Int16 getPersonTypeID(string name)
        {
            Int16 id = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from PersonType where (Name='" + name + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt16(dr["ID"]);
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

        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getAllPersonType()
        //{
        //    SqlDataAdapter da=new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    da.SelectCommand = new SqlCommand("select * from PersonType ", objSqlConnection);
        //    ds.Clear();
        //    da.Fill(ds);
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    //////////////////////////////////////
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllPersonType()
        {
            string[] types=new string[6];
            types[0] = PersonTypes.Administrator.ToString();
            types[1] = PersonTypes.Caster.ToString();
            types[2] = PersonTypes.Manager.ToString();
            types[3] = PersonTypes.Supervisor.ToString();
            types[4] = PersonTypes.Worker.ToString();
            types[5] = PersonTypes.SprayMan.ToString();


            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            ds.Tables.Add(dt);
            for (Int16 i = 0; i <= 5; i++)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = types[i];
                ds.Tables[0].Rows.Add(dr);
            }
            ///////////////////////////////////////---Release the resources
            //DataTable dt = new DataTable();
            //DataRow dr;
            //dt.Columns.Add(new System.Data.DataColumn("Colimn1", typeof(String)));
            //dt.Columns.Add(new System.Data.DataColumn("Column2", typeof(String)));
            //dt.Columns.Add(new System.Data.DataColumn("Column3", typeof(String)));
            //dr = dt.NewRow(); //CREATES A NEW ROW IN A COLUMN
            //dr[0] = "ANY VALUE HERE";
            //dr[1] = "ANY VALUE HERE";
            //dr[2] = "ANY VALUE HERE";
            //dt.Rows.Add(dr);
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<PersonType> getAllPersonTypeList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from PersonType ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<PersonType> PersonTypeList = new List<PersonType>();
            while (dr.Read())
            {
                PersonType b = new PersonType();
                b.ID = Convert.ToInt16(dr["ID"]);
                b.Name = Convert.ToString(dr["Name"]);
                PersonTypeList.Add(b);
            }
            objSqlConnection.Close();
            PersonTypeList.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return PersonTypeList;
        }
        //-------------------------------------------------------------------------------------------------------
      }
    }

