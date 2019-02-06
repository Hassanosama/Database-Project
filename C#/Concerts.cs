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
    public partial class Concerts : Form
    {
        DataTable concertsList;
        Controller Control = new Controller();
        int My_ID;
        int priv;       // Owner

        public Concerts(int user_id,int p)
        {
            InitializeComponent();
            priv = p;
            My_ID = user_id;

            if (priv == 1)      // show the add concert part only to the owner
                AddConcert.Visible = true;
            else
                AddConcert.Visible = false;
        }

        private void Concerts_Load(object sender, EventArgs e)
        {
            concertsList = Control.Select_Concerts(1, My_ID);

            Concerts_Grid.DataSource = concertsList;
            Concerts_Grid.Refresh();

            Singers_Combo.DataSource = Control.Select_Singers(2);
            Singers_Combo.DisplayMember = "Name";
            Singers_Combo.Refresh();

            Dates_Combo.DataSource = Control.Select_Dates(Singers_Combo.Text);
            Dates_Combo.DisplayMember = "Time_Date";
            Dates_Combo.Refresh();
        }

        private void Singers_Combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Dates_Combo.DataSource = Control.Select_Dates(Singers_Combo.Text);
            Dates_Combo.DisplayMember = "Time_Date";
            Dates_Combo.Refresh();
        }

        private void AddConcert_Click_1(object sender, EventArgs e)
        {
            Add_Concert Add = new Add_Concert(My_ID);
            Add.Show();
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            if (myBookedCheckbox.Checked == true)
                Concerts_Grid.DataSource = Control.Select_Concerts(2, My_ID);
            else
                Concerts_Grid.DataSource = Control.Select_Concerts(1, My_ID);

            Concerts_Grid.Refresh();

            Dates_Combo.DataSource = Control.Select_Dates(Singers_Combo.Text);
            Dates_Combo.DisplayMember = "Time_Date";
            Dates_Combo.Refresh();

            Singers_Combo.DataSource = Control.Select_Singers(2);
            Singers_Combo.DisplayMember = "Name";
            Singers_Combo.Refresh();
        }

        private void Book_Button_Click_1(object sender, EventArgs e)
        {
            int val = Control.bookConcert(My_ID, Singers_Combo.Text, Dates_Combo.Text);
            if (val != 0)
                MessageBox.Show("You booked the concert succesfully!");
            else
                MessageBox.Show("Booking failed!");
        }

        private void myBookedCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (myBookedCheckbox.Checked == true)
                Concerts_Grid.DataSource = Control.Select_Concerts(2, My_ID);
            else
                Concerts_Grid.DataSource = Control.Select_Concerts(1, My_ID);

            Concerts_Grid.Refresh();
        }
    }
}
