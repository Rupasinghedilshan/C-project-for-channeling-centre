using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class Payment
    {
        public int PaymentID { set; get; }
        public int PatientID { set; get; }
        public int AppointmentID { set; get; }
        public string Date { set; get; }
        public int TotalAmount { set; get; }
        public int PaidAmount { set; get; }
        public int Balance { set; get; }

        public DataSet ds;

        public int Pay()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "insert into Payments values (" + PaymentID + ", " + PatientID + "," + AppointmentID + ",'" + Date + "' , " + TotalAmount + ", " + PaidAmount + " , " + Balance + ")";
                return db.exeQuery(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int generatePID()
        {


            DB_Operations db = new DB_Operations();


            try
            {

                //string sql = "SELECT * FROM PatientDetails WHERE "  + DoctorID + " ";

                string sql = "SELECT Max(PaymentID) from Payments";
                ds = db.exesearchQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    PaymentID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

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
