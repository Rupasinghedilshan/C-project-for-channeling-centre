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
    public partial class Payments : Form
    {
        Payment payment;
        public Payments()
        {
            InitializeComponent();
            payment = new Payment();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (txtTAmount.Text == "")
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }

            if (txtPaid.Text == "")
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }

            if (txtPaymentID.Text == "" &&
                txtTAmount.Text == "" &&
                txtPaid.Text == "")
            {
                MessageBox.Show("Not Added!!");
            }

            else
            {

                try
                {
                    payment.PaymentID = Convert.ToInt32(txtPaymentID.Text);
                    payment.PatientID = Convert.ToInt32(comboBox1.SelectedValue);
                    //payment.PatientID = Convert.ToInt32(((DataRowView)cmbPatientID.SelectedValue)["PatientID"]);
                    payment.AppointmentID = Convert.ToInt32(comboBox2.SelectedValue);
                    //payment.AppointmentID = Convert.ToInt32(((DataRowView)cmbAppointmentID.SelectedValue)["PatientID"]);

                    //payment.PatientID = Convert.ToInt32(textBox1.Text);
                    //payment.AppointmentID = Convert.ToInt32(textBox2.Text);

                    payment.Date = dateTimePicker1.Text;
                    payment.TotalAmount = Convert.ToInt32(txtTAmount.Text);
                    payment.PaidAmount = Convert.ToInt32(txtPaid.Text);
                    payment.Balance = Convert.ToInt32(txtBalance.Text);


                    if (payment.Pay() > 0)
                    {
                        MessageBox.Show("Payment successfully added!!!");

                        payment.generatePID();
                        txtPaymentID.Text = (payment.PaymentID + 1).ToString();
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

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet_ApppointmentsNeeroga.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter1.Fill(this.neerogaChannelingCenterDataSet_ApppointmentsNeeroga.Appointments);
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet_Appointment.Appointments' table. You can move, or remove it, as needed.
            //this.appointmentsTableAdapter.Fill(this.neerogaChannelingCenterDataSet_Appointment.Appointments);
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet_Patient.PatientDetails' table. You can move, or remove it, as needed.
            this.patientDetailsTableAdapter.Fill(this.neerogaChannelingCenterDataSet_Patient.PatientDetails);

            payment.generatePID();
            txtPaymentID.Text = (payment.PaymentID + 1).ToString();

            label10.Visible = false;
            label11.Visible = false;
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtTAmount.Text);
            int b = Convert.ToInt32(txtPaid.Text);

            txtBalance.Text = (b - a).ToString();
            
        }

        private void txtPayID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtPaymentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
