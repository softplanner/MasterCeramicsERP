using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class MoldStockWorkerDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getStockReport(int workerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL person = new PersonDAL();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where (WorkerID='"+workerID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            MoldStockWorker g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Uncast Quantity", typeof(Int16));
            dt.Columns.Add("Casted Quantity", typeof(Int16));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new MoldStockWorker();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);

                list.Add(g);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = person.getPersonName(g.WorkerID);
                dataRow[1] = item.getItemName(g.ItemID);
                dataRow[2] = style.getItemStyleName(g.StyleID);
                dataRow[3] = size.getItemSizeName(g.SizeID);
                dataRow[4] = g.Quantity;
                dataRow[5] = g.CastQuantity;
                ds.Tables[0].Rows.Add(dataRow);

            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addStock(MoldStockWorker obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into MoldStockWorker(CastQuantity,WorkerID,ItemID,StyleID,SizeID,Quantity)values('"+obj.CastQuantity+"','" + obj.WorkerID + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "')", objSqlConnection);
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
        public void updateStock(MoldStockWorker obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  MoldStockWorker SET Quantity='" + obj.Quantity + "' WHERE (WorkerID='" + obj.WorkerID + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "')", objSqlConnection);
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
        public void updateStockByCasting(MoldStockWorker obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  MoldStockWorker SET CastQuantity ='"+obj.CastQuantity+"',Quantity='" + obj.Quantity + "' WHERE (WorkerID='" + obj.WorkerID + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "')", objSqlConnection);
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
        public void deleteStock(MoldStockWorker obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldStockWorker WHERE (WorkerID='" + obj.WorkerID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "' and CastQuantity='"+obj.CastQuantity+"')", objSqlConnection);
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
        public void anotherDeleteStock(MoldStockWorker obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldStockWorker WHERE (WorkerID='" + obj.WorkerID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID +"')", objSqlConnection);
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
        public List<MoldStockWorker> getStockByItem(Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where ItemID= '" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();

                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public List<MoldStockWorker> getStockByWorker(int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where (WorkerID= '" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();

                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public List<MoldStockWorker> getCastStockByWorker(int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where (WorkerID= '" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();

                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public List<MoldStockWorker> getStockByStyle(Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where StyleID= '" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public List<MoldStockWorker> getStockByItemAndWorker(Int16 itemID, int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where ItemID= '" + itemID + "'and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public List<MoldStockWorker> getStockByStyleAndWorker(Int16 styleID, int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where StyleID = '" + styleID + "'and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public List<MoldStockWorker> getStockByCaster(int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldStockWorker where (WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldStockWorker> list = new List<MoldStockWorker>();
            while (dr.Read())
            {
                MoldStockWorker m = new MoldStockWorker();
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.CastQuantity = Convert.ToInt16(dr["CastQuantity"]);
                list.Add(m);
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
        public Int16 checkIsMoldExist(Int16 itemID, Int16 styleID, Int16 sizeID,int casterID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldStockWorker where(ItemID= '" + itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and WorkerID='"+casterID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = 1;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getFreeStock(MoldStockWorker m)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldStockWorker where (ItemID= '" + m.ItemID + "' and StyleID='" + m.StyleID + "' and SizeID='" + m.SizeID + "' and WorkerID='" + m.WorkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getFreeStockByCasterItemStyleAndSize(int casterID,Int16 itemID,Int16 styleID,Int16 sizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldStockWorker where (ItemID= '" +itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getCastedStockByCasterItemStyleAndSize(int casterID, Int16 itemID, Int16 styleID, Int16 sizeID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select CastQuantity from MoldStockWorker where (ItemID= '" + itemID + "' and StyleID='" + styleID + "' and SizeID='" + sizeID + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = Convert.ToInt16(dr["CastQuantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getCastedStock(MoldStockWorker m)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select CastQuantity from MoldStockWorker where (ItemID= '" + m.ItemID + "' and StyleID='" + m.StyleID + "' and SizeID='" + m.SizeID + "' and WorkerID='" + m.WorkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = Convert.ToInt16(dr["CastQuantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
