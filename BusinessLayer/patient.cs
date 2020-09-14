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
    public class patient
    {
        public int PatientID { set; get; }
        public string PatientName { set; get; }
        public string PatientContact { set; get; }
        public int PatientAge { set; get; }

        public string cname;
        public string sname;

        public  DataSet ds;

        //Add Patient=================
        public int Add()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "insert into PatientDetails values (" + PatientID + ", '" + PatientName + "','" + PatientContact + "'," + PatientAge + ")";
                return db.exeQuery(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


     

        //SEARCH CODE
        public int search()
        {

            
            DB_Operations db = new DB_Operations(); 


            try
            {

                string sql = "SELECT * FROM PatientDetails WHERE "+cname+" LIKE '%"+sname+"%' ";

                
               ds= db.exesearchQuery(sql);


                if (ds.Tables[0].Rows.Count > 0)
                {


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


        //patientId generate
        public int geneatePID()
        {


            DB_Operations db = new DB_Operations();


            try
            {

                //string sql = "SELECT * FROM PatientDetails WHERE "  + DoctorID + " ";

                string sql = "SELECT Max(PatientID) from PatientDetails";
                ds = db.exesearchQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    PatientID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

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
    }
}

