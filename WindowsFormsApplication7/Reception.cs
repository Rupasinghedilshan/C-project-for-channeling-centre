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
    public partial class Reception : Form
    {
        patient Patient;

        Appointments appoint;

        string selectedmode;
        string ID;
        
        public Reception()
        {
            InitializeComponent();
            Patient = new patient();
            appoint = new Appointments();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            //validations

            if (txtPName.Text == "")
            {
                label002.Visible = true;
            }
            else
            {
                label002.Visible = false;
            }

            if (txtPMobile.Text == "")
            {
                label003.Visible = true;
            }
            else
            {
                label003.Visible = false;
            }

            if (txtPAge.Text == "")
            {
                label004.Visible = true;
            }
            else
            {
                label004.Visible = false;
            }

            if (
            txtPName.Text == "" &&
            txtPMobile.Text == "" &&
            txtPAge.Text == "")
            {

            }
            else
            {

                try
                {
                    Patient.PatientID = Convert.ToInt32(txtPID.Text);
                    Patient.PatientName = txtPName.Text;
                    Patient.PatientContact = txtPMobile.Text;
                    Patient.PatientAge = Convert.ToInt32(txtPAge.Text);

                    //user.Gender = Gender;

                    if (Patient.Add() > 0)
                    {
                        MessageBox.Show("Patient added successfully!!!");

                        Patient.geneatePID();
                        txtPID.Text = (Patient.PatientID + 1).ToString();
                    }

                    else
                    {
                        MessageBox.Show("Not Added!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNo = dataGridView1.CurrentCell.RowIndex;
            int columnNo = dataGridView1.CurrentCell.ColumnIndex;

            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
        }

        private void cmbSearchP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reception_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet_PatientDetails.PatientDetails' table. You can move, or remove it, as needed.
            this.patientDetailsTableAdapter.Fill(this.neerogaChannelingCenterDataSet_PatientDetails.PatientDetails);
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet1.Neeroga' table. You can move, or remove it, as needed.


            label16.Visible = false;
            //label17.Visible = false;
            label18.Visible = false;
            //label19.Visible = false;

            //label001.Visible = false;
            label002.Visible = false;
            label003.Visible = false;
            label004.Visible = false;

            appoint.search();
            txtAppointID.Text=( appoint.AppointmentID + 1).ToString();

            panelPatientHandling.Visible = false;
            panelPatientAdding.Visible = false;
            panelAppointments.Visible = false;

            //GENERATE Patient id
            Patient.geneatePID();
            txtPID.Text = (Patient.PatientID + 1).ToString();

            lblD.Text = DateTime.Now.ToLongDateString();
            lblT.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            panelPatientHandling.Visible = true;
            panelPatientAdding.Visible = false;
            panelAppointments.Visible = false;

        }

        private void txtPsearch_OnValueChanged(object sender, EventArgs e)
        {
            

        }

        private void txtCmbP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCmbP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string y = txtCmbP.SelectedItem.ToString();

            if (y=="Patient ID"){
                selectedmode = "PatientID";
            }

            if (y=="Patient Name"){
                selectedmode = "PatientName";

            }

            if (y=="Patient Contact"){
                selectedmode = "PatientContact";
            }

            if (y=="Patient Age"){
                selectedmode = "PatientAge";
            }

        }

        private void txtPatientSearch_OnValueChanged(object sender, EventArgs e)
        {
            ID = txtPatientSearch.Text.ToString();

            Patient.cname = selectedmode;
            Patient.sname = ID;
         //   MessageBox.Show(Patient.cname + Patient.sname);

            
            if (txtPatientSearch.Text == "") { }
            else
            {
                if (Patient.search() > 0)
                {
                    
                    dataGridView2.DataSource = Patient.ds.Tables[0];

                }
                else {
                   
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPatientReg_Click(object sender, EventArgs e)
        {
            panelPatientAdding.Visible = true;
            panelPatientHandling.Visible = false;
            panelAppointments.Visible = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAppoint_Click(object sender, EventArgs e)
        {
            panelAppointments.Visible = true;
            panelPatientAdding.Visible = false;
            panelPatientHandling.Visible = false;
        }

        private void btnSubmitAppoi_Click(object sender, EventArgs e)
        {   
            //validations
            if (txtPatientID.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }


            if (txtDocID.Text == "")
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }


            if (txtDocID.Text == "" &&
                txtPatientID.Text == "" &&
                bunifuDatepickerAppoint.Text == "")
            {
                MessageBox.Show("Not Created!! Something error!");
            }

            else
            {
                //------------
                try
                {
                    appoint.AppointmentID = Convert.ToInt32(txtAppointID.Text);
                    appoint.DoctorID = Convert.ToInt32(txtDocID.Text);
                    appoint.PatientID = Convert.ToInt32(txtPatientID.Text);
                    appoint.Date = bunifuDatepickerAppoint.Text;
                    appoint.Time = comboBoxTime.SelectedItem.ToString();


                    if (appoint.AddAppointment() > 0)
                    {
                        MessageBox.Show("Appointment added successfully!!!");

                        appoint.search();
                        txtAppointID.Text = (appoint.AppointmentID + 1).ToString();
                    }

                    else
                    {
                        MessageBox.Show("Not Added!! Something error!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            DoctorAvailability docAvail = new DoctorAvailability();
            docAvail.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AppointmentsView app = new AppointmentsView();
            app.Show();
            
            //this.Dispose = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtAppointID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Payments paym = new Payments();
            paym.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtPID.Text = "";
            txtPName.Text = "";
            txtPMobile.Text = "";
            txtPAge.Text = "";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panelAppointments.Visible = true;
            panelPatientAdding.Visible = false;
            panelPatientHandling.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panelPatientAdding.Visible = true;
            panelPatientHandling.Visible = false;
            panelAppointments.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panelPatientHandling.Visible = true;
            panelPatientAdding.Visible = false;
            panelAppointments.Visible = false;
        }
    }
}
