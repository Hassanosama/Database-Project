using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class New_Account : Form
    {
        Controller ControllerObj = new Controller();
        public New_Account()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void New_Account_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("The Password is not identical!");
                txtPass.Clear();
                txtConfirm.Clear();
                return;
            }
            int p=0;
            if (RBnormal.Checked == true) p = 3;
            else if (RBsub.Checked == true) p = 2;
            else
            {
                MessageBox.Show("Please Select What you want to register as.");
                return;
            }
            if( ControllerObj.Add_New_Acc(txtUserName.Text, txtPass.Text, p) != 0 )
            {
                MessageBox.Show("You have successfully registerd");
            }
            else
            {
                MessageBox.Show("Sorry this username is already exist");
            }
        }
    }
}
