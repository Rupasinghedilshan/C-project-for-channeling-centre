using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class login
    {
        public int ID { set; get; }
        public string Password { set; get; }
        public string UserType { set; get; }

        public int userlogin(int id)
        {
            this.ID = id;
            DB_Operations db = new DB_Operations();

            try
            {
                string sql = "SELECT * FROM NeerogaUsers WHERE UserID = " + ID + "";
                DataSet ds = db.exesearchQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    ID = Convert.ToInt32( ds.Tables[0].Rows[0][0].ToString());
                    Password = ds.Tables[0].Rows[0][2].ToString();
                    UserType = ds.Tables[0].Rows[0][3].ToString();

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
