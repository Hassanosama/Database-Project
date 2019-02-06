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
    public partial class Reports : Form
    {
        Controller ControllerObj = new Controller();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControllerObj.Get_Reports();
            dataGridView1.Refresh();
            btnBackToREp.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ControllerObj.Get_Users();
            dataGridView1.Refresh();
            btnBackToREp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnBackToREp.Visible = false;
            dataGridView1.DataSource = ControllerObj.Get_Reports();
            dataGridView1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnBackToREp.Visible = false;
            if (ControllerObj.Delete_User(textBox1.Text.ToString()) != 0) MessageBox.Show("Done!\n" + textBox1.Text.ToString() + " is now blocked!");
            else MessageBox.Show("Failed");
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (subradio.Checked)
                dataGridView1.DataSource = ControllerObj.Filter_Users(2);
            if (normradio.Checked)
                dataGridView1.DataSource = ControllerObj.Filter_Users(3);
        }
    }
}
