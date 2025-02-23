using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class SlipPercentageDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addSlipPercentage(SlipPercentage obj) 
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into SlipPercentage (RMID,SlipPercent)values('" + obj.RMID + "','" + obj.SlipPercent + "')", objSqlConnection);
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
        public void deleteSlipPercent(Int16 rmid)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from SlipPercentage where(RMID = '" + rmid + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        public List<SlipPercentage> getSlipPercentageAllMaterial()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from SlipPercentage", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<SlipPercentage> slipList = new List<SlipPercentage>();
            while (dr.Read())
            {
                SlipPercentage sp = new SlipPercentage();
                sp.RMID = Convert.ToInt16(dr["RMID"]);
                sp.SlipPercent=Convert.ToSingle(Math.Round(Convert.ToSingle(dr["SlipPercent"])));
                slipList.Add(sp);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            slipList.TrimExcess();
            return slipList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<RawMaterial> getRawMaterialList()
        {
            RawMaterialDAL dal = new RawMaterialDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select RMID from SlipPercentage", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<RawMaterial> rmList = new List<RawMaterial>();
            RawMaterial obj;
            while (dr.Read())
            {
                obj = new RawMaterial();
                obj.ID= Convert.ToInt16(dr["RMID"]);
                obj.Name= dal.getMaterialName(obj.ID);
                rmList.Add(obj);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            rmList.TrimExcess();
            return rmList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getAllSlipMaterialDataset()
        {
            RawMaterialDAL dal = new RawMaterialDAL();
            List<short> id = new List<short>();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            ds.Tables.Add(dt);
            for (Int16 i = 0; i <=id.Count; i++)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = dal.getMaterialName(id[i]);
                ds.Tables[0].Rows.Add(dr);
            }
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<SlipPercentage> getSlipPercentageOfSlipMaterial()
        {
            
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from SlipPercentage", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<SlipPercentage> slipList = new List<SlipPercentage>();
            SlipPercentage sp;
            while (dr.Read())
            {
                sp = new SlipPercentage();
                sp.RMID = Convert.ToInt16(dr["RMID"]);
                sp.SlipPercent = Convert.ToSingle(Math.Round(Convert.ToSingle(dr["SlipPercent"]), 3));
                slipList.Add(sp);
        }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            slipList.TrimExcess();
            return slipList;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public float getPercentageByRawmaterialID(int rmid)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select SlipPercent from SlipPercentage where RMID= '" + rmid + "'", objSqlConnection);
            SqlDataReader dr = null;

            float sp = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                sp= Convert.ToSingle(Convert.ToSingle(dr["SlipPercent"]));
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return sp;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public SlipPercentage getPercentageByID(int rmid)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from SlipPercentage where RMID= '" + rmid + "'", objSqlConnection);
            SqlDataReader dr = null;

            SlipPercentage sp = new SlipPercentage();
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                sp.RMID = Convert.ToInt16(dr["RMID"]);
                sp.SlipPercent = Convert.ToSingle(Math.Round(Convert.ToSingle(dr["SlipPercent"]), 3));
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return sp;
        }
        //-------------------------------------------------------------------------------------------------------
 
        //-------------------------------------------------------------------------------------------------------
        public void updateRMSlipPercentage(SlipPercentage sp)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE SlipPercentage SET SlipPercent ='" + sp.SlipPercent + "' WHERE (RMID='" + sp.RMID + "')", objSqlConnection);
            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<string> getSlipMaterialName()
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from SlipMaterial", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<string> nameList = new List<string>();
        //    string name = null;
        //    while (dr.Read())
        //    {
        //        name = dr["Name"].ToString();
        //        nameList.Add(name);
        //    }
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Release the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    nameList.TrimExcess();
        //    return nameList;

        //}
        ////-------------------------------------------------------------------------------------------------------
        ////-------------------------------------------------------------------------------------------------------
        //public List<Int16> getSlipMaterialIDFromNameList()
        //{
        //    RawMaterialDAL dal = new RawMaterialDAL();
        //    List<string> name = new List<string>();
        //    List<Int16> idList = new List<Int16>();
        //    short id = 0;
        //    name = getSlipMaterialName();
        //    name.TrimExcess();
        //    for (Int16 i = 0; i < name.Count; i++)
        //    {
        //        id = dal.getMaterialID(name[i]);
        //        idList.Add(id);
        //    }
        //    return idList;
        //}
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<Int16> getSlipMaterialID()
        {
            List<Int16> idList = new List<Int16>();
            short id = 0;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select RMID from SlipPercentage", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                id= Convert.ToInt16(dr["RMID"]);
                idList.Add(id);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return idList;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public bool isMaterialExist(Int16 RMID)
        {
            bool check= false;
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select RMID from SlipPercentage where RMID='"+RMID+"'", objSqlConnection);
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
    }
}
