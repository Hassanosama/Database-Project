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
    public partial class Most_Reported : Form
    {
        Controller ControllerObj = new Controller();
        public Most_Reported()
        {
            InitializeComponent();
            dataGridView1.DataSource = ControllerObj.Most_Reported();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
