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
    public class PatientRecords
    {
        public DataSet ds;

        public int AppointmentID { set; get; }
        public string Record { set; get; }


        public int AddRecord()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "insert into PatientRecords values (" + AppointmentID + ", '" + Record + "')";
                return db.exeQuery(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Seerch records
        public int RecordSearch()
        {

            DB_Operations db = new DB_Operations();


            try
            {
                string sql = "SELECT * FROM PatientRecords where AppointmentID = " + AppointmentID + " ";

                ds = db.exesearchQuery(sql);

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
    }
}
