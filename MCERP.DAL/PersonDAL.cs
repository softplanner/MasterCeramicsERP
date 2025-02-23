using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class PersonDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public int addPerson(Person obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into Person(Name,Contact,Address,Category,Salary)values('" + obj.Name + "','" + obj.Contact + "','" + obj.Address + "','" + obj.Category + "','"+obj.Salary+"'); SELECT SCOPE_IDENTITY();", objSqlConnection);
            objSqlConnection.Open();
            int id = Convert.ToInt32(objSqlCommand.ExecuteScalar());
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
            return id;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updatePerson(Person obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  Person SET Name='" + obj.Name + "',Address='" + obj.Address+ "',Contact='" + obj.Contact+ "',Salary='"+obj.Salary+"'  WHERE (ID ='" + obj.ID + "')", objSqlConnection);
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
        public void deletePerson(int personID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from Person WHERE (ID ='" + personID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////

        }
        //-------------------------------------------------------------------------------------------------------
        public string getPersonName(int id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from Person where (ID='" + id + "')", objSqlConnection);
            string name = null;
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
        public int countPerson()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from Person ", objSqlConnection);
            int counter = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                counter=Convert.ToInt16(dr["ID"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return counter;
        }
        //------------------------------------------------------------------------------------------------------- 
        //------------------------------------------------------------------------------------------------------- 
        public int getPersonID(string name)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from Person where (Name='" + name + "')", objSqlConnection);
            int id = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr["ID"]);
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
        public string getPersonCategory(int id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Category from Person where (ID='" + id + "')", objSqlConnection);
            string str = null;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                str = Convert.ToString(dr["Category"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return str;
        }
        //------------------------------------------------------------------------------------------------------- 
        //------------------------------------------------------------------------------------------------------- 
        public bool isPersonExist(int id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Name from Person where (ID='" + id + "')", objSqlConnection);
            bool check=false;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                check = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return check;
        }
        //------------------------------------------------------------------------------------------------------- 
        //------------------------------------------------------------------------------------------------------- 
        public Person getPersonByID(int id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  Person where (ID='" + id + "')", objSqlConnection);
            Person p=new Person();
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                p.ID = Convert.ToInt32(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);
                p.Contact = Convert.ToString(dr["Contact"]);
                p.Address = Convert.ToString(dr["Address"]); 
                p.Category= Convert.ToString(dr["Category"]);
                p.Salary = Convert.ToInt32(dr["Salary"]);
                ////p.Job = Convert.ToString(dr["Job"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return p;
        }
        //-------------------------------------------------------------------------------------------------------  
        //------------------------------------------------------------------------------------------------------- 
        public List<Person> getPersonByName(string name)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  Person where (Name='" + name + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Person> list = new List<Person>();
            while (dr.Read())
            {
                Person p = new Person();

                p.ID = Convert.ToInt32(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);
                p.Category = Convert.ToString(dr["Category"]);
                p.Contact = Convert.ToString(dr["Contact"]);
                p.Address = Convert.ToString(dr["Address"]);
                p.Salary = Convert.ToInt32(dr["Salary"]);
                ////p.Job = Convert.ToString(dr["Job"]);

                list.Add(p);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------  
        //------------------------------------------------------------------------------------------------------- 
        public List<Person> getAllPerson()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  Person ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Person> list = new List<Person>();
            while (dr.Read())
            {
                Person p = new Person();

                p.ID = Convert.ToInt32(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);
                p.Contact = Convert.ToString(dr["Contact"]);
                p.Address = Convert.ToString(dr["Address"]); 
                p.Category = Convert.ToString(dr["Category"]);
                p.Salary = Convert.ToInt32(dr["Salary"]);
                //p.Job = Convert.ToString(dr["Job"]);

                list.Add(p);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------  
        //------------------------------------------------------------------------------------------------------- 
        public List<Person> getPersonIDNameByCategory(string category)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID,Name from  Person where (Category='"+category+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Person> list = new List<Person>();
            while (dr.Read())
            {
                Person p = new Person();

                p.ID = Convert.ToInt32(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);

                list.Add(p);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------- 
        public List<Person> getAllPersonIDandName()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID,Name from  Person ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Person> list = new List<Person>();
            while (dr.Read())
            {
                Person p = new Person();

                p.ID = Convert.ToInt32(dr["ID"]);
                p.Name = Convert.ToString(dr["Name"]);
               
                list.Add(p);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------  
        
        //------------------------------------------------------------------------------------------------------- 
        public List<string> getPersonIDList(string name)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  Person where (Name='" + name + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                string p =null;
                //p.ID = Convert.ToString(dr["ID"]);
                list.Add(p);
            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------  
        //-------------------------------------------------------------------------------------------------------
        public List<string> getAllPersonByType(string personType)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID,Name from Person where (Type = '" + personType + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<string> list = new List<string>();
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<string> getPersonByJob(int jobTitle)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            //SqlCommand objSqlCommand = new SqlCommand("select PersonID from PersonJobs where (JobTitle= '" + jobTitle + "')", objSqlConnection);
            SqlCommand objSqlCommand = new SqlCommand("select Person.Name from PersonJobs inner join Person on PersonJobs.PersonID=Person.ID where (PersonJobs.JobTitle= '" + jobTitle + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<string> list = new List<string>();

            string name = null;
            while (dr.Read())
            {
                name = Convert.ToString(dr["Name"]);
                list.Add(name);
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
        public List<Person> getPersonByJobs(string jobTitle)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select PersonID from PersonJobs where (JobTitle= '" + jobTitle + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<Person> list = new List<Person>();
            Person p;
            while (dr.Read())
            {
                p = new Person();
                p.ID = Convert.ToInt32(dr["PersonID"]);
                p.Name= getPersonName(p.ID);
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
        public DataSet getPersonByJobDataset(Int16 jobTitle)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            //select Name from Jobs inner join PersonJobs on Jobs.ID=PersonJobs.JobTitle where PersonJobs.PersonID=1;
            da.SelectCommand = new SqlCommand("select ID,Name from Person inner join PersonJobs on Person.ID=PersonJobs.PersonID where (PersonJobs.JobTitle='"+jobTitle+"')", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;

            //List<int> lst = new List<int>();
            //lst = getPersonIDListByJob(personJob);
            //lst.TrimExcess();
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("ID", typeof(Int32));
            //ds.Tables.Add(dt);
            //DataRow dr;
            //for (Int16 i = 0; i <lst.Count; i++)
            //{
            //    dr = ds.Tables[0].NewRow();
            //    dr[0] = getPersonName(lst[i]);
            //    dr[1] = lst[i];
            //    ds.Tables[0].Rows.Add(dr);
            //}
            ////////////////////////////////////////
            //return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSubDealerByDealerDataset(int dealerID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            //select Name from Jobs inner join PersonJobs on Jobs.ID=PersonJobs.JobTitle where PersonJobs.PersonID=1;
            da.SelectCommand = new SqlCommand("select ID,Name from Person inner join DealerCustomer on Person.ID=DealerCustomer.DealerCustomerID where DealerCustomer.DealerID='"+dealerID +"'", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;

            //List<int> lst = new List<int>();
            //lst = getPersonIDListByJob(personJob);
            //lst.TrimExcess();
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("ID", typeof(Int32));
            //ds.Tables.Add(dt);
            //DataRow dr;
            //for (Int16 i = 0; i <lst.Count; i++)
            //{
            //    dr = ds.Tables[0].NewRow();
            //    dr[0] = getPersonName(lst[i]);
            //    dr[1] = lst[i];
            //    ds.Tables[0].Rows.Add(dr);
            //}
            ////////////////////////////////////////
            //return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getPersonByJobDataset(string personJob)
        //{
        //    List<int> lst = new List<int>();
        //    List<string> lsts = new List<string>();
        //    lst = getPersonIDListByJob(personJob);
        //    lst.TrimExcess();
        //    for (Int16 i = 0; i < lst.Count; i++)
        //    {
        //        lsts.Add(getPersonName(lst[i]));
        //    }
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Name", typeof(string));
        //    ds.Tables.Add(dt);
        //    DataRow dr;
        //    for (Int16 i = 0; i < lsts.Count; i++)
        //    {
        //        dr = ds.Tables[0].NewRow();
        //        dr[0] = lsts[i];
        //        ds.Tables[0].Rows.Add(dr);
        //    }
        //    //////////////////////////////////////
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<int> getPersonIDListByJob(string jobName)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select PersonID from PersonJobs where (JobTitle='" + jobName + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<int> list = new List<int>();
             int id = 0;
            while (dr.Read())
            {
                id = Convert.ToInt32(dr["PersonID"]);
                list.Add(id);
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
        public DataSet getPersonDataSet()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select Name from Person ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getPersonByNameAndCategory(string personNameLike,string category)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            //--------------------------------------------
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("SELECT Person.ID, Person.Name, Person.Category, Person.Address, Person.Contact,Person.Salary,Jobs.Name AS Job FROM Person INNER JOIN PersonJobs ON Person.ID = PersonJobs.PersonID INNER JOIN Jobs ON PersonJobs.JobTitle = Jobs.ID where (Person.Name Like '%" + personNameLike + "%') and Person.Category='" + category + "' ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
