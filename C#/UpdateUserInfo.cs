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
    public partial class Update_Window : Form
    {
        Controller ControllerObj;
        string Username;
        public Update_Window(string username)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            Username = username;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtNew.Text.ToString() != txtCon.Text.ToString())
            {
                MessageBox.Show("The new Password is not identical with the confirm password!");
                return;
            }
            int res = ControllerObj.Change_Password(Username, txtOld.Text.ToString(), txtNew.Text.ToString());
            if (res != 0) MessageBox.Show("The Password successfully Updated.");
            else MessageBox.Show("Old Password is not valid");
            txtCon.Clear();
            txtNew.Clear();
            txtOld.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Update_Window_Load(object sender, EventArgs e)
        {

        }
    }
}
