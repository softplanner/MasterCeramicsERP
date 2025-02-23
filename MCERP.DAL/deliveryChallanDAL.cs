using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class deliveryChallanDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsGatePassExist(string gatePass)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select GatePass from deliveryChallan where (GatePass= '" + gatePass + "')", objSqlConnection);
            bool a = false;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                a = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return a;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getReportByGatePass(string gPass)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (GatePass= '" + gPass+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyReport()
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (Date = '" + DateTime.Today + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyReportByDealer(int dealerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (DealerID='" + dealerID + "' and Date = '" + DateTime.Today + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDayReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDayReportByDealer(DateTime date, int dealerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (DealerID='" + dealerID + "' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and month(Date)='"+date.Month+"' and year(Date)='"+date.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReportByDealer(DateTime date, int dealerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (DealerID='" + dealerID + "' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReportByCustomer(DateTime date, int customerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (DealerCustomerID='" + customerID + "' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            //dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                //dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToString(dr["GatePass"]);
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToDateTime(dr["Date"]);
                dataRow[8] = catDal.getCategoryName(Convert.ToInt16(dr["CategoryID"]));

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addOrder(deliveryChallan obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into deliveryChallan(GatePass,Date,ItemID,StyleID,SizeID,ColorID,Quantity,DealerID,CategoryID)values('"+obj.GatePass+"','" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "','" + obj.DealerID + "','"+obj.CategoryID+"')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void updateOrder(deliveryChallan obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE deliveryChallan SET ItemID='" + obj.ItemID + "',StyleID='" + obj.StyleID + "',SizeID='" + obj.SizeID + "',ColorID='" + obj.ColorID + "',Quantity='" + obj.Quantity + "' WHERE (Date='" + obj.Date + "'and DealerID='" + obj.DealerID + "' and GatePass='"+obj.GatePass+"')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteOrder(deliveryChallan obj)
        {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from deliveryChallan WHERE (year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "' and Quantity='" + obj.Quantity + "' and GatePass='"+obj.GatePass+"')", objSqlConnection);
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
        public void deleteWholeChallan(string gatepass)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from deliveryChallan WHERE (GatePass='" + gatepass + "')", objSqlConnection);
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
        public bool checkIsOrderExist(deliveryChallan obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from deliveryChallan WHERE (year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "' and DealerID='" + obj.DealerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);
            SqlDataReader dr = null;
            bool c = false;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                c = true;
            }
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Close();
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public string getGatePass(deliveryChallan obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select GatePass from deliveryChallan WHERE (year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "' and DealerID='" + obj.DealerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "' )", objSqlConnection);
            SqlDataReader dr = null;
            string gp = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                gp = Convert.ToString(dr["GatePass"]);
            }
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Close();
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
            return gp;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getQuantityOfExistingOrder(deliveryChallan obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from deliveryChallan WHERE (year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "' and DealerID='" + obj.DealerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "' and GatePass='" + obj.GatePass + "')", objSqlConnection);
            SqlDataReader dr = null;
            Int16 c = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                c = Convert.ToInt16(dr["Quantity"]);
            }
            ///////////////////////////////////////---Release the resources
            objSqlConnection.Close();
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            //////////////////////////////////////
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportByDate(DateTime date)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    //o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportListByGatePass(string gPass)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (GatePass='" + gPass + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.CategoryID = Convert.ToInt16(dr["CategoryID"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportByDateAndDealer(int dealerID,DateTime date)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and DealerID='" + dealerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    //o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        
        
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportByMonth(DateTime date)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    //o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportByMonthAndDealer(DateTime date, int dealerID)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (month(Date)='" + date.Month + "'and year(Date)='" + date.Year + "' and DealerID='" + dealerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    //o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportByYear(DateTime date)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    //o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<deliveryChallan> getReportByYearAndDealer(DateTime date, int dealerID)
        {
            List<deliveryChallan> list = new List<deliveryChallan>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from deliveryChallan where (DealerID='" + dealerID + "'and year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    deliveryChallan o = new deliveryChallan();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    //o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    list.Add(o);
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
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addNewBill(DataTable dt)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlBulkCopy bulkCopy = new SqlBulkCopy(objSqlConnection,SqlBulkCopyOptions.TableLock |SqlBulkCopyOptions.FireTriggers |SqlBulkCopyOptions.UseInternalTransaction,null);

                // set the destination table name
                bulkCopy.DestinationTableName = "Bills" ;
                objSqlConnection.Open();

                // write the data in the "dataTable"
                bulkCopy.WriteToServer(dt);
                objSqlConnection.Close();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        public void addBillDetail(BillDetail bt)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into BillDetail(DealerID,BillNo,Date,Total)values('" + bt.DealerID + "','" + bt.BillNo + "','" + bt.Date + "','"+bt.Total+"')", objSqlConnection);
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
        public DataSet viewBillDetail(string myQuery)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand(myQuery, objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteBill(string billno)
        {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from BillDetail where (BillNo = '" + billno + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlCommand = new SqlCommand("Delete from Bills where (BillNo = '" + billno + "')", objSqlConnection);
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet viewBill(string billNo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("SELECT Item, Style, Size, Color, Quantity, UnitPrice, TotalPrice , Category FROM Bills where BillNo='"+billNo+"' ", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getReportByBillNo(string billNo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            da.SelectCommand = new SqlCommand("select * from Bills where BillNo='"+billNo+"'", objSqlConnection);
            ds.Clear();
            da.Fill(ds);
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
