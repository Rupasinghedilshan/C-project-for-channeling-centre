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
    public class Availability
    {
        public DataSet ds;

        public int DoctorID { set; get; }
        public string Monday { set; get; }
        public string Tuesday { set; get; }
        public string Wednesday { set; get; }
        public string Thursday { set; get; }
        public string Friday { set; get; }
        public string Saturday { set; get; }
        public string Sunday { set; get; }
        public string Time { set; get; }

        //Add
        public int Add()
        {
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "insert into Doctor_Availability values ( " + DoctorID + ",'" + Monday + "','" + Tuesday + "' ,'" + Wednesday + "' ,'" + Thursday + "' ,'" + Friday + "' ,'" + Saturday + "' ,'" + Sunday + "')";
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

                string sql = "SELECT * FROM Doctor_Availability WHERE  UserID = " + DoctorID + " ";


                ds = db.exesearchQuery(sql);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    //PatientID = ds.Tables[0].Rows[0][0].ToString();
                    //PatientName = ds.Tables[0].Rows[0][1].ToString();
                    //PatientContact = ds.Tables[0].Rows[0][2].ToString();
                    //PatientAge = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());

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


        //update

        public int update()
        {
            DB_Operations db = new DB_Operations();
            try
            {

                string sql = "UPDATE Doctor_Availability SET Monday = '" + Monday + "',Tuesday = '" + Tuesday + "', Wednesday = '" + Wednesday + "', Thursday = '" + Thursday + "' , Friday = '" + Friday + "' , Saturday = '" + Saturday + "' ,Sunday = '" + Sunday + "' where UserID = " + DoctorID + " ";

                return db.exeQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Search Availabiity

        public int Doctor_AvailabilitySearch()
        {

            DB_Operations db = new DB_Operations();


            try
            {

                string sql = "SELECT * FROM Doctor_Availability where UserID = " + DoctorID + " ";

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

