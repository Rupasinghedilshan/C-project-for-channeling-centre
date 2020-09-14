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
    public class Appointments
    {
        public int AppointmentID { set; get; }
        public int PatientID { set; get; }
        public string Date { set; get; }
        public int DoctorID { set; get; }
        public string Time { set; get; }
        //public int AppointmentDoctorCategory { set; get; }

        public DataSet ds;

        //insert=======
        public int AddAppointment()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "insert into Appointments values (" + AppointmentID + ", " + PatientID + ",'" + Date + "'," + DoctorID + ", '" + Time + "')";
                return db.exeQuery(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //search==========
        public int search()
        {


            DB_Operations db = new DB_Operations();


            try
            {

                //string sql = "SELECT * FROM PatientDetails WHERE "  + DoctorID + " ";

                string sql = "SELECT Max(AppointmentID) from Appointments";
                ds = db.exesearchQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    AppointmentID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    
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

        //Appointment Search=====================
        public int appointmentView()
        {


            DB_Operations db = new DB_Operations();


            try
            {

                string sql = "SELECT * FROM Appointments WHERE  DoctorID ="+DoctorID+" AND Date = '"+Date+"'";

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
