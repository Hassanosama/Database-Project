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
    public partial class Add_Concert : Form
    {
        Controller Control = new Controller();
        int My_ID;
        public Add_Concert(int user_id)
        {
            InitializeComponent();
            My_ID = user_id;
            SingersCombobox.DataSource = Control.Select_Singers(1);
            SingersCombobox.DisplayMember = "Name";
        }

        private void Add_Concert_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Location_txt.Text.Trim() == "" || Price_txt.Text.Trim() == "" || Available_txt.Text.Trim() == "" || Phone_txt.Text.Trim() == "" || Date_Time.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all the fields.");
                return;
            }

            int result;
            if (int.TryParse(Price_txt.Text, out result) == false)
            {
                MessageBox.Show("Please enter integer to price.");
                return;
            }

            if (int.TryParse(Available_txt.Text, out result) == false)
            {
                MessageBox.Show("Please enter integer to available seats.");
                return;
            }

            if (int.TryParse(Phone_txt.Text, out result) == false)
            {
                MessageBox.Show("Please enter integer to phone.");
                return;
            }

            Control.addConcert(int.Parse(Price_txt.Text), int.Parse(Available_txt.Text), Date_Time.Text, Location_txt.Text, int.Parse(Phone_txt.Text), SingersCombobox.Text);
            MessageBox.Show("Concert added succesfully!");
            this.Close();
        }

    }
}
