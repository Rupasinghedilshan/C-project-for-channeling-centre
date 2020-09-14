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
    

    public partial class Consultant : Form
    {
        public int DoctorID { set; get; }

        PatientRecords Rec;
        Availability avail;

        public Consultant()
        {


            InitializeComponent();
            avail = new Availability();
            Rec = new PatientRecords();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAvUpdate_Click(object sender, EventArgs e)
        {

            avail.Monday = comboBox1.SelectedItem.ToString();
            avail.Tuesday = comboBox2.SelectedItem.ToString();
            avail.Wednesday = comboBox3.SelectedItem.ToString();
            avail.Thursday = comboBox4.SelectedItem.ToString();
            avail.Friday = comboBox5.SelectedItem.ToString();
            avail.Saturday = comboBox6.SelectedItem.ToString();
            avail.Sunday = comboBox7.SelectedItem.ToString();

            avail.DoctorID = DoctorID;

                if (avail.search() > 0)
                {

                    avail.update();


                    MessageBox.Show("Availability Successfully added!!!");

                }
                else
                {

                    avail.Add();

                    MessageBox.Show("Successfully Updated!!!");

                }
            
        }

        private void Consultant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet5.PatientRecords' table. You can move, or remove it, as needed.
            this.patientRecordsTableAdapter.Fill(this.neerogaChannelingCenterDataSet5.PatientRecords);
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet1.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.neerogaChannelingCenterDataSet1.Appointments);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;

            panel3.Visible = false;
            panel1.Visible = false;

            lblD.Text = DateTime.Now.ToLongDateString();
            lblT.Text = DateTime.Now.ToLongTimeString();

            label18.Visible = false;
            tabControl1.Visible = false;
        }

        private void btnAvailabilityUpdate_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            tabControl1.Visible = false;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            //panel3.Visible = true;
            //panel1.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AppointmentsView app = new AppointmentsView();
            app.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            panel3.Visible = true;
            panel1.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txtRecord.Text == "")
            {
                label18.Visible = true;

            }
            else
            {
                label18.Visible = false;
            }

            if (txtRecord.Text == "") { }

            else
            {

                try
                {
                    Rec.AppointmentID = Convert.ToInt32(cmbA.SelectedValue.ToString());
                    Rec.Record = txtRecord.Text;

                    if (Rec.AddRecord() > 0)
                    {
                        MessageBox.Show("Record added successfully!!!");
                    }

                    else
                    {
                        MessageBox.Show("Not Added!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet1.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.neerogaChannelingCenterDataSet1.Appointments);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec.AppointmentID = Convert.ToInt32(comboBoxRec.SelectedValue.ToString());

            Rec.RecordSearch();

            dataGridViewRec.DataSource = Rec.ds.Tables[0];
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
