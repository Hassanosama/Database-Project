using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace DBapplication
{
    public partial class Provided_Functionalities : Form
    {

        private Privileges _privilege;
        Controller ControllerObj = new Controller();
        Login ptr;
        int closed = 0;
        string [] typs = new string[5];
        int  statistics = 0;  //0->means no , 1-> exist now, 2-> was exist then we should delete it's column.
        bool InStat = false;
        public Provided_Functionalities(Login log,string User__name,Privileges privilege = Privileges.Normal)
        {
            InitializeComponent();
            lblusername.Text = User__name;
            this._privilege = privilege;
            if (_privilege != Privileges.Admin)
            {
                btnViewReports.Visible = false;
                btnViewStatis.Visible = false;
                if (_privilege == Privileges.Normal) btnuploads.Enabled = false;
            }
            else
            {
                btnViewReports.Visible = true;
                btnViewStatis.Visible = true;
                pictureBox1.Visible = false;
            }
            ptr = log;
            typs[1] = "Movie";
            typs[2] = "Series";
            typs[3] = "Game";
            typs[4] = "Song";

        }
        private void Provided_Functionalities_Load(object sender, EventArgs e)
        {
            btnStore.Visible = false;
            btnUpload.Visible = false;
            btnUnsold.Visible = false;
            btnReported.Visible = false;
            // Fill Types.
            Type.Items.Add("All");
            Type.Items.Add("Movies");
            Type.Items.Add("Series");
            Type.Items.Add("Games");
            Type.Items.Add("Song");

            Type.SelectedIndex = 0;
            DataTable dt = ControllerObj.SearchForItems(txtsearch.Text, Type.SelectedIndex, Genre.SelectedItem.ToString());
            Fill_Table(dt);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (statistics != 2)
            {
                ControllerObj.Add_To_History(lblusername.Text, listView1.SelectedItems[0].SubItems[1].ToString());
                Item_Details details = new Item_Details(listView1.SelectedItems[0].SubItems[3].ToString(), listView1.SelectedItems[0].SubItems[2].ToString(), _privilege, lblusername.Text, listView1, listView1.SelectedIndices[0]);
                details.Show();
            }
            else
            {
                ControllerObj.Add_To_History(lblusername.Text, listView1.SelectedItems[0].SubItems[1].ToString());
                Item_Details details = new Item_Details(listView1.SelectedItems[0].SubItems[4].ToString(), listView1.SelectedItems[0].SubItems[2].ToString(), _privilege, lblusername.Text, listView1, listView1.SelectedIndices[0]);
                details.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (statistics == 2)
            {
                listView1.Columns.RemoveAt(3);
                statistics = 0;
            }
            btnStore.Visible = true;
            btnUpload.Visible = false;
            groupBox1.Enabled = false;
            btnUnsold.Visible = false;
            btnReported.Visible = false;
            DataTable dt = ControllerObj.User_History(lblusername.Text);
            Fill_Table(dt);    
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            closed = -1;
            this.Close();
            ptr.Show();
        }

        private void Provided_Functionalities_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ptr.Close();
            //ControllerObj.TerminateConnection();
           // ptr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (statistics == 2)
            {
                listView1.Columns.RemoveAt(3);
                statistics = 0;
            }
            btnStore.Visible = true;
            btnUpload.Visible = false;
            groupBox1.Enabled = false;
            btnUnsold.Visible = false;
            btnReported.Visible = false;
            DataTable dt = ControllerObj.User_Purchase(lblusername.Text);
            Fill_Table(dt);
        }

        private void btnMyFav_Click(object sender, EventArgs e)
        {
            if (statistics == 2)
            {
                listView1.Columns.RemoveAt(3);
                statistics = 0;
            }
            btnStore.Visible = true;
            btnUpload.Visible = false;
            groupBox1.Enabled = false;
            btnUnsold.Visible = false;
            btnReported.Visible = false;
            DataTable dt = ControllerObj.User_Favorits(lblusername.Text);
            Fill_Table(dt);
        }

        private void btnuploads_Click(object sender, EventArgs e)
        {
            if (statistics == 2)
            {
                listView1.Columns.RemoveAt(3);
                statistics = 0;
            }
            btnStore.Visible = true;
            btnUpload.Visible = true;
            groupBox1.Enabled = false;
            btnUnsold.Visible = false;
            btnReported.Visible = false;
            DataTable dt = ControllerObj.User_uploads(lblusername.Text);
            Fill_Table(dt);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            if (statistics == 2)
            {
                listView1.Columns.RemoveAt(3);
                statistics = 0;
            }
            btnStore.Visible = false;
            groupBox1.Enabled = true;
            btnUnsold.Visible = false;
            btnUpload.Visible = false;
            btnReported.Visible = false;
            Type.SelectedIndex = 0;
            DataTable dt = ControllerObj.SearchForItems(txtsearch.Text, Type.SelectedIndex, Genre.SelectedItem.ToString());
            Fill_Table(dt);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Provided_Functionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closed == -1) { closed++; return; }
            closed++;
            if (closed == 2) return;
            ptr.Close();
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Update_Window uw = new Update_Window(lblusername.Text.ToString());
            uw.Show();
        }

        private void btnViewStatis_Click(object sender, EventArgs e)
        {
            btnUpload.Visible = false;
            btnUnsold.Visible = true;
            btnStore.Visible = true;
            btnReported.Visible = true;
            statistics = 1;
            DataTable dt = ControllerObj.Get_Most_Sold();
            Fill_Table(dt);
            statistics = 2;
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload up = new Upload(lblusername.Text,listView1);
            up.Show();
            listView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre.Items.Clear();
            if (Type.SelectedIndex < 3) // 4->song
            {
                Genre.Items.Add("All");
                Genre.Items.Add("Comedy");
                Genre.Items.Add("Drama");
                Genre.Items.Add("Fantasy");
                Genre.Items.Add("Thriller");
                Genre.Items.Add("Science-Fiction");
                Genre.Items.Add("Crime");
                Genre.Items.Add("Mystery");
                Genre.Items.Add("Action");
            }                                     //I must do all If conditions as i want to check both not only one.
            if (Type.SelectedIndex == 3 || Type.SelectedIndex == 0) //Games
            {
                if (Type.SelectedIndex != 0) Genre.Items.Add("All");
                Genre.Items.Add("Adventure");
                Genre.Items.Add("Action");
                Genre.Items.Add("Stealth");
                Genre.Items.Add("Sport");
                Genre.Items.Add("Horror");
                Genre.Items.Add("Survival");
                Genre.Items.Add("War");
                Genre.Items.Add("History");

            }
            if (Type.SelectedIndex == 4 || Type.SelectedIndex == 0) //songs
            {
                if (Type.SelectedIndex != 0) Genre.Items.Add("All");
                Genre.Items.Add("Pop");
                Genre.Items.Add("Hip-hop");
                Genre.Items.Add("Rock");
                Genre.Items.Add("Rap");
            }
           
                Genre.SelectedIndex = 0;
        }
        private Image ConvertToImage(byte [] img)
        { 
            MemoryStream ms = new MemoryStream(img); //Convert from bytes to image
            Image IMG = Image.FromStream(ms); //Convert from bytes to image
            ms.Close();
            return IMG;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.SearchForItems(txtsearch.Text,Type.SelectedIndex,Genre.SelectedItem.ToString());
            Fill_Table(dt);
        }
        private void Fill_Table(DataTable dt)
        {
            listView1.Items.Clear();
            imageList1.Images.Clear();
            if (statistics == 1)
            {
                listView1.Columns.Add("#Purchase", -2);
            }
            else if(statistics == 2)
            {
                listView1.Columns.Remove(listView1.Columns[3]);
                statistics = 0;
            }

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                imageList1.Images.Add(ConvertToImage((byte[])(dt.Rows[i]["Poster"]))); //Adding the Image to the Image list
                ListViewItem itm = new ListViewItem();
                itm.ImageIndex = i; //Linking the item with the image.

                listView1.Items.Add(itm);
                listView1.Items[i].SubItems.Add(dt.Rows[i]["Name"].ToString());
                listView1.Items[i].SubItems.Add(typs[Int32.Parse(dt.Rows[i]["Type"].ToString())]);

                if (statistics == 1 || statistics == -1)
                {
                    listView1.Items[i].SubItems.Add(dt.Rows[i]["#Purchase"].ToString());
                }
                listView1.Items[i].SubItems.Add(dt.Rows[i]["ID"].ToString());
            }
            if (statistics == 1 || statistics == -1) statistics = 2;
        }

        private void btnUnsold_Click(object sender, EventArgs e)
        {
            btnUpload.Visible = false;
            btnUnsold.Visible = true;
            btnStore.Visible = true;
            statistics = -1;
            DataTable dt = ControllerObj.Get_Not_Sold();
            Fill_Table(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnUpload.Visible = false;
            btnUnsold.Visible = true;
            Most_Reported mr = new Most_Reported();
            mr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cinemas c = new Cinemas(lblusername.Text.ToString());
            c.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Concerts c = new Concerts(ControllerObj.Get_ID(lblusername.Text.ToString()),(int)_privilege);
            c.Show();
        }
    }
}


