using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DB_Operations
    {
        SqlConnection con = new SqlConnection("Server = DILSHAN-PC; Database = NeerogaChannelingCenter; Integrated Security = True;");

        public int exeQuery(string sql)
        {
            int x = 0;

            try
            {
                SqlCommand coman = new SqlCommand(sql, con);
                con.Open();
                x = coman.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
            return x;
        }


        //-SqlDataAdapter-
        public DataSet exesearchQuery(string sql)
        {

            try
            {
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                ad.Fill(ds);
                return ds;
                //coman.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }


        //public DataTable exeSQuery(string sql)
        //{ 
        
        //    try
        //    {
        //        con.Open();
        //        DataTable ds = new DataTable();
        //        SqlDataAdapter ad = new SqlDataAdapter(sql, con);
        //        ad.Fill(ds);
        //        return ds;
                

        //        //coman.Dispose();
        //    }

        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        }
    }

