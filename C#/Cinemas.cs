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
    public partial class Cinemas : Form
    {
        Controller cobj = new Controller();
        string UserName;
        int i = 0;
        public Cinemas(string User)
        {
            InitializeComponent();
            UserName = User;
        }
        private void Cinemas_Load(object sender, EventArgs e)
        {
            comboBoxCinemas.DataSource = cobj.shows();
            comboBoxCinemas.DisplayMember = "Name";
            comboBoxCinemas.ValueMember = "Name";

            string m = comboBoxCinemas.SelectedValue.ToString();
            comboBoxMovies.DataSource = cobj.showmovies(m);
            comboBoxMovies.DisplayMember = "Name";
            comboBoxMovies.ValueMember = "Name";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cobj.Book(UserName, comboBoxCinemas.SelectedValue.ToString(), comboBoxMovies.SelectedValue.ToString()) != 0)
            {
                MessageBox.Show("Done : Movie Booked");

            }
            else
                MessageBox.Show("Movie already Booked");
        }

        private void comboBoxCinemas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (i<2)
            {
                i++;
                return;
            }
            string m = comboBoxCinemas.SelectedValue.ToString();
            comboBoxMovies.DataSource = cobj.showmovies(m);
            comboBoxMovies.DisplayMember = "Name";
            comboBoxMovies.ValueMember = "Name";
        }
    }
}