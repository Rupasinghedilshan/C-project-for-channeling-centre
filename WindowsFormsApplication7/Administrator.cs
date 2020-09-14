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

namespace WindowsFormsApplication7
{
    public partial class Administrator : Form
    {
        User user;
        

        public Administrator()
        {
            InitializeComponent();
            user = new User();

            datagridViewUsers.DataSource = user.gettable();

            panelViewUsers.Visible = false; //HIDE Panel view users
            
        }

        public void Clear()

        {
            txtID.Text = "";
            txtUname.Text = "";
            txtPW.Text = "";
            txtAge.Text = "";
            cmbUserType.Text = "";
            txtAddress.Text = "";
            txtTP.Text = "";
            cmbCategory.Text = "";
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            panelManage.Visible = false;
            panelViewUsers.Visible = false;
            panelreport.Visible = false;
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = false;
            panelManage.Visible = true;
            panelViewUsers.Visible = false;
            panelreport.Visible = false;

            
            
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        //Add====================
        string Gender = "";
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {   
            ///
            if (txtID.Text == "")
            {
                label34.Visible = true;

            }
            else
            {
                label34.Visible = false;
            }
            ///
            if (txtUname.Text == "")
            {
                label35.Visible = true;

            }
            else
            {
                label35.Visible = false;
            }
            ///
            if (txtPW.Text == "")
            {
                label36.Visible = true;

            }
            else
            {
                label36.Visible = false;
            }
            ///
            if (txtAge.Text == "")
            {
                label38.Visible = true;

            }
            else
            {
                label38.Visible = false;
            }
            ///
            if (txtAddress.Text == "")
            {
                label39.Visible = true;

            }
            else
            {
                label39.Visible = false;
            }
            ///
            if (radioBtnFemale.Checked == false || radioBtnMale.Checked == false)
            {
                label40.Visible = true;
            }
            else
            {
                label40.Visible = false;
            }
            ///
            if (txtTP.Text == "")
            {
                label41.Visible = true;

            }
            else
            {
                label41.Visible = false;
            }

            if(txtID.Text == "" &&
            txtUname.Text == "" &&
            txtPW.Text == "" &&
            txtAge.Text == "" &&
            txtAddress.Text == "" &&
            txtTP.Text == "" )
            {
                MessageBox.Show("Not Created!!!");
            }
            else{

                try
                {
                    user.UserID = Convert.ToInt32(txtID.Text);
                    user.UserName = txtUname.Text;
                    user.Password = txtPW.Text;
                    user.UserType = Convert.ToString(cmbUserType.SelectedItem);
                    user.Age = Convert.ToInt32(txtAge.Text);
                    user.City = txtAddress.Text;

                    if (radioBtnMale.Checked)
                    {
                        //Gender = "Male";
                        Gender = rdoMale.Text;
                    }

                    else
                    {
                        //Gender = "Female";
                        Gender = rdoFemale.Text;
                    }
                    user.Gender = Gender;
                    user.TP_No = Convert.ToInt32(txtTP.Text);
                    user.Category = Convert.ToString(cmbCategory.SelectedItem);

                    if (user.Create() > 0)
                    {
                        MessageBox.Show("User create successfully!!!");
                    }

                    else
                    {
                        MessageBox.Show("Not Created!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            


          //  this.neerogaTableAdapter1.Fill(this.neerogaChannelingCenterDataSet1.NeerogaUsers);
            this.neerogaUsersTableAdapter.Fill(this.neerogaChannelingCenterDataSet4.NeerogaUsers);

        }

        private void checkBoxG1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panelManage_Paint(object sender, PaintEventArgs e)
        {

        }

        //update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            ///
            if (txtUSER.Text == "")
            {
                label27.Visible = true;

            }
            else
            {
                label27.Visible = false;
            }

            ///
            if (txtUID.Text == "")
            {
                label28.Visible = true;

            }
            else
            {
                label28.Visible = false;
            }

            ///
            if (txtPass.Text == "")
            {
                label29.Visible = true;

            }
            else
            {
                label29.Visible = false;
            }
            ///
            if (txtAgebox.Text == "")
            {
                label30.Visible = true;

            }
            else
            {
                label30.Visible = false;
            }
            ///
            if (txtAddresss.Text == "")
            {
                label31.Visible = true;

            }
            else
            {
                label31.Visible = false;
            }
            ///
            if (rdoFemale.Checked == false || rdoMale.Checked == false)
            {
                label32.Visible = true;
            }
            else
            {
                label32.Visible = false;
            }
            ///
            if (txtMobile.Text == "")
            {
                label33.Visible = true;

            }
            else
            {
                label33.Visible = false;
            }

            if (txtUID.Text == "" &&
            txtUSER.Text == "" &&
            txtPass.Text == "" &&
            txtAgebox.Text == "" &&
            txtAddresss.Text == "" &&
            txtMobile.Text == "")
            {
                MessageBox.Show("Not updated!!!");
            }

            else
            {

                try
                {
                    user.UserID = Convert.ToInt32(txtUID.Text);
                    user.UserName = txtUSER.Text;
                    user.Password = txtPass.Text;
                    //user.UserType = Convert.ToString(cmbType.SelectedItem);
                    user.UserType = cmbType.Text;
                    user.Age = Convert.ToInt32(txtAgebox.Text);
                    user.City = txtAddresss.Text;
                    user.TP_No = Convert.ToInt32(txtMobile.Text);
                    user.Category = Convert.ToString(cmbCat.SelectedItem);


                    if (radioBtnMale.Checked)
                    {
                        Gender = rdoMale.Text;
                    }

                    else
                    {
                        Gender = rdoFemale.Text;
                    }
                    user.Gender = Gender;


                    if (user.update() > 0)
                    {
                        MessageBox.Show("Succesfully updated!!!");
                    }

                    else
                    {
                        MessageBox.Show("Not updated!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        //delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ///
            if (txtUID.Text == "")
            {
                label28.Visible = true;

            }
            else
            {
                label28.Visible = false;
            }

            if (txtUID.Text == "") { }

            else
            {

                try
                {
                    user.UserID = Convert.ToInt32(txtUID.Text);

                    if (user.delete() > 0)
                    {
                        MessageBox.Show("Deleted!!!");
                    }

                    else
                    {
                        MessageBox.Show("Not Deleted!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NeerogaChannelingCenterDataSet_Patient.PatientDetails' table. You can move, or remove it, as needed.
            this.PatientDetailsTableAdapter.Fill(this.NeerogaChannelingCenterDataSet_Patient.PatientDetails);
            panelreport.Visible = false;

            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet4.NeerogaUsers' table. You can move, or remove it, as needed.
            this.neerogaUsersTableAdapter.Fill(this.neerogaChannelingCenterDataSet4.NeerogaUsers);
            // TODO: This line of code loads data into the 'neerogaChannelingCenterDataSet1.Neeroga' table. You can move, or remove it, as needed.
     //       this.neerogaTableAdapter1.Fill(this.neerogaChannelingCenterDataSet1.NeerogaUsers);
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;

            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            

            lblD.Text = DateTime.Now.ToLongDateString();
            lblT.Text = DateTime.Now.ToLongTimeString();

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        //-========search
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUID.Text = cmbtxtName.SelectedValue.ToString();

            try
            {
                user.UserID = Convert.ToInt32(txtUID.Text.ToString());

                if (user.search() > 0)
                {
                    txtUSER.Text = user.UserName;
                    txtID.Text = user.UserID.ToString();
                    txtAgebox.Text = user.Age.ToString();
                    txtAddresss.Text = user.City;
                    txtMobile.Text = user.TP_No.ToString();
                    txtPass.Text = user.Password;
                    cmbType.Text = user.UserType;
                    cmbCat.Text = user.Category;

                    if (user.Gender == "Male")
                    {
                        rdoMale.Checked = true;
                    }

                    if (user.Gender == "Female")
                    {
                        rdoFemale.Checked = true;
                    }
                    
                }
                //else
                //{
                //    MessageBox.Show("Not Found!!!");
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = false;
            panelManage.Visible = false;
            panelViewUsers.Visible = true;
            panelreport.Visible = false;

            datagridViewUsers.DataSource = user.gettable();
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {


            txtUID.Text = " ";
            txtUSER.Text = " ";
            txtAgebox.Text = "";
            txtAddresss.Text = "";
            txtMobile.Text = "";
            txtPass.Text = "";
            cmbType.Text = "";
            cmbCat.Text = "";


        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserType.Text.Equals("Consultant"))
            {

                cmbCategory.Enabled = true;

            }
            else {
                cmbCategory.Enabled = false;

            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text.Equals("Consultant"))
            {

                cmbCat.Enabled = true;

            }
            else
            {
                cmbCat.Enabled = false;

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panelreport.Visible = true;
        }
    }
}
