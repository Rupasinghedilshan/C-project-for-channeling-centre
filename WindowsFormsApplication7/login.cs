using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;

namespace WindowsFormsApplication7
{   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                       

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            login log = new login();

            if (log.userlogin(Convert.ToInt32(txtUSERid.Text.ToString())) > 0)
            {

                if (log.ID == Convert.ToInt32(txtUSERid.Text.ToString()) && log.Password == txtUPass.Text)
                {

                    if (log.UserType == "Administrator")
                    {
                        MessageBox.Show("Administrator, Welcome to the Neeroga Health Care!!");
                        Administrator admin = new Administrator();
                        admin.Show();
                        //bunifuFlatButton1.Visible = false;

                        this.Hide();
                    }

                    else if (log.UserType == "Reception")
                    {
                        MessageBox.Show("Receptionist, Welcome to the Neeroga Health Care!!");
                        Reception recep = new Reception();
                        recep.Show();
                        this.Hide();
                    }

                    else if (log.UserType == "Consultant")
                    {
                        MessageBox.Show("Consultant, Welcome to the Neeroga Health Care!");
                        Consultant cons = new Consultant();
                        cons.DoctorID = Convert.ToInt32(txtUSERid.Text.ToString());
                        cons.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username and password");
                }
            }

            
         }
            
            
        

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneldrag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneldrag2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panelRght_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
    }
}
