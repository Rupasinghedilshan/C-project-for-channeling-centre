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
    public partial class DoctorAvailability : Form
    {
        Availability avail;
        public DoctorAvailability()
        {
            InitializeComponent();
            avail = new Availability();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchDocAvailibily_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.selectedValue.ToString());
            avail.DoctorID = Convert.ToInt32(comboBox1.SelectedValue.ToString());

            avail.Doctor_AvailabilitySearch();

            dataGridViewDocAvailability.DataSource = avail.ds.Tables[0];
        }

        private void DoctorAvailability_Load(object sender,EventArgs e)
        {
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet3.Doctor_Availability' table. You can move, or remove it, as needed.
            this.doctor_AvailabilityTableAdapter.Fill(this.neerogaChannelingCenterDataSet3.Doctor_Availability);

        }

        private void bunifuTileButtonClose_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
