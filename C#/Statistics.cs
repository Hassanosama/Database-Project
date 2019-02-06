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
    public partial class Statistics : Form
    {
        Controller ControllerObj = new Controller();
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            btnAll.Visible = false;
            dataGridView1.DataSource = ControllerObj.Get_Most_Sold();
            dataGridView1.Refresh();
        }

        private void btnUnSold_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  ControllerObj.Get_Not_Sold();
            dataGridView1.Refresh();
            btnAll.Visible = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControllerObj.Get_Most_Sold();
            dataGridView1.Refresh();
            btnAll.Visible = false;
        }
    }
}
