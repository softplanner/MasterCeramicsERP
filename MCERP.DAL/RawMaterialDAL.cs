using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using MCERP.Entities;

namespace MCERP.DAL
{
   public class RawMaterialDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addRawMaterial(string name)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into RawMaterial (Name)values('" + name+ "')", objSqlConnection);
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
        public void addRawMaterialAsSlipMaterial(Int16 id)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into RawMaterial (Name)values('" + id + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public void updateRawMaterial(RawMaterial obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE RawMaterial SET Name ='" + obj.Name + "' WHERE (ID='" + obj.ID + "')", objSqlConnection);
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
        public void deleteRawMaterial(Int16 materialID)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from RawMaterial where (ID ='" + materialID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllRawMaterialDataSet()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from RawMaterial ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<RawMaterial> getAllRawMaterialList()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterial ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterial> RawMaterialList = new List<RawMaterial>();
            while (dr.Read())
            {
                RawMaterial r = new RawMaterial();
                r.ID = Convert.ToInt16(dr["ID"]);
                r.Name = Convert.ToString(dr["Name"]);
                RawMaterialList.Add(r);
            }
            objSqlConnection.Close();
            RawMaterialList.TrimExcess();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return RawMaterialList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public string getMaterialName(Int16 materialID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from RawMaterial where ID= '" + materialID + "'", objSqlConnection);
            SqlDataReader dr = null;
            string name = null;
            RawMaterial rm=new RawMaterial();
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

        public Int16 getMaterialID(string materialName)
        {
            Int16 id = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from  RawMaterial where Name='" + materialName + "'", objSqlConnection);
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
        //-------------------------------------------------------------------------------------------------------    
        public bool IsAlreadyExist(string materialName)
        {
            bool id=false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select ID from  RawMaterial where Name='" + materialName + "'", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id=true;
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
        public bool IsSlipPercentageDependsUpon(Int16 rawMaterialID)
        {
            bool id = false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select SlipPercent from SlipPercentage where RMID='" + rawMaterialID + "'", objSqlConnection);
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
        public bool IsMaterialInStock(Int16 rawMaterialID)
        {
            bool id = false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from RawMaterialStock where RMID='" + rawMaterialID + "'", objSqlConnection);
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
