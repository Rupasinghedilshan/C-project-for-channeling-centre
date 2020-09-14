using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class User
    {
        public int UserID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string UserType { set; get; }
        public int Age { set; get; }
        public string City { set; get; }
        public string Gender { set; get; }
        public int TP_No { set; get; }
        public string Category { set; get; }

        //Create an User=================
        public int Create()
        {
            DB_Operations db = new DB_Operations();
  
            try
            {
                string sql = "insert into NeerogaUsers values (" + UserID + ", '" + UserName + "','" + Password + "','" + UserType + "', " + Age + ", '" + City + "' , '" + Gender + "' , " + TP_No + " , '" + Category + "')";
                return db.exeQuery(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //update======
        public int update()
        {
            DB_Operations db = new DB_Operations();
            try
            {

                string sql = "UPDATE NeerogaUsers SET UserName = '" + UserName + "', Password = '" + Password + "',UserType = '" + UserType + "', Age = " + Age + ", City = '" + City + "' , Gender = '" + Gender + "' , TP_Number = " + TP_No + " ,Category = '" + Category + "' where UserID = " + UserID + " ";

                return db.exeQuery(sql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Delete===============
        public int delete()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "DELETE FROM NeerogaUsers WHERE UserID = " + UserID;
                return db.exeQuery(sql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Search
        public int search()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "SELECT * FROM NeerogaUsers WHERE UserID = " + UserID;
                DataSet ds = db.exesearchQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    UserID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    UserName = ds.Tables[0].Rows[0][1].ToString();
                    Password = ds.Tables[0].Rows[0][2].ToString();
                    UserType = ds.Tables[0].Rows[0][3].ToString();
                    Age = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
                    City = ds.Tables[0].Rows[0][5].ToString();
                    Gender = ds.Tables[0].Rows[0][6].ToString();
                    TP_No = Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString());
                    Category = ds.Tables[0].Rows[0][8].ToString();

                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Datatable
        public DataTable gettable()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "select * from NeerogaUsers";
                DataSet ds = db.exesearchQuery(sql);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0];
                }
                else
                {
                    return ds.Tables[0];

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

       }
    }

}
