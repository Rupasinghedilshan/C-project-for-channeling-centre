using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{   
    public partial class AppointmentsView : Form
    {
        Appointments appoint;

        public AppointmentsView()
        {
            InitializeComponent();
            appoint = new Appointments();
        }

        private void AppointmentsView_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            appoint.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

            appoint.DoctorID = 4;

            appoint.appointmentView();

           
            

            dataGridAppointmentsView.DataSource = appoint.ds.Tables[0];

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
