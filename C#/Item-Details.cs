using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Item_Details : Form
    {
        Controller ControllerObj = new Controller();
        string username,Item_Type;
        int Item_ID,Item_idx;
        ListView LV;
        byte[] img;
        string[] store = new string [3];
        public Item_Details(string item_id, string item_type, Privileges p,string user,ListView ptr,int ItemIdx)
        {
            InitializeComponent();
            btnDone.Visible = false;
            username = user;
            Item_idx = ItemIdx;
            item_id = Converter(item_id); 
            item_type = Converter(item_type);
            Item_Type = item_type;
            Item_ID = Int32.Parse(item_id);
            LV = ptr;
            //txtAct1.BorderStyle = "";
            DataTable Item_Info = ControllerObj.Item_Info(Item_ID, item_type);

            // Loading the Image.
            img = (byte[])(Item_Info.Rows[0]["Poster"]);
            MemoryStream ms = new MemoryStream(img); //Convert from bytes to image
            Image IMG = Image.FromStream(ms); //Convert from bytes to image
            pictureBox1.Image = IMG;
            //---------------------------------------------
            // Filling the all common data.
            txtRate.Text = Item_Info.Rows[0]["Rate"].ToString();
            txtYear.Text = Item_Info.Rows[0]["Year"].ToString();
            lblPurchase.Text = Item_Info.Rows[0]["#Purchase"].ToString();
            txtitmName.Text = Item_Info.Rows[0]["Name"].ToString();
            txtPrice.Text = Item_Info.Rows[0]["Price"].ToString();
            //-------------------------------------------------------
            if (item_type == "Game")
            {
                label2.Text = "Studio:-";
                label7.Visible = false;
                txtDir.Visible = false;
                txtAct1.Text = Item_Info.Rows[0]["Studio"].ToString();
            }
            else if(item_type == "Song")
            {
                label2.Text = "Singer:-";
                label7.Visible = false;
                txtDir.Visible = false;
                txtAct1.Text = Item_Info.Rows[0]["Sname"].ToString();
            }
            else
            {
                txtDir.Text = Item_Info.Rows[0]["DirName"].ToString();
                txtAct1.Text = Item_Info.Rows[0]["AName"].ToString();
                if(Item_Info.Rows.Count > 1)
                {
                    txtAct2.Text = Item_Info.Rows[1]["AName"].ToString();
                }
                
            }
            txtUploader.Text = ControllerObj.Uploader_name(Item_ID);
            if (username == txtUploader.Text) Edit.Visible = true;
            else Edit.Visible = false;
            if (p == Privileges.Normal || (p == Privileges.Subscriber && username != txtUploader.Text)) btnRemove.Enabled = false;
            int res = ControllerObj.HaveThis(Item_ID, username);
            if (ControllerObj.HaveThis(Item_ID, username) != 0 || username == txtUploader.Text) btnBuy.Enabled = false;
            
        }

        private void Item_Details_Load(object sender, EventArgs e)
        {

            Edit_Mode(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPurchase_Click(object sender, EventArgs e)
        {

        }

        private void lblCast_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblDirector_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToFav_Click(object sender, EventArgs e)
        {
            if(ControllerObj.Add_Favorites(username, txtitmName.Text) != 0) MessageBox.Show("The Item is Added Successfully to your Favorites");
            else MessageBox.Show("This item is already exist in your favorites");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (ControllerObj.Buy_Item(username, txtitmName.Text) != 0)
            {
                MessageBox.Show("Done");
                btnBuy.Enabled = false;
            }
            else MessageBox.Show("You already have this item");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(txtReport.Text == "")
            {
                MessageBox.Show("Please Insert The report reason");
                return;
            }
            if(ControllerObj.Report(username, txtitmName.Text,txtReport.Text) != 0)
            {
                MessageBox.Show("Done");
                txtReport.Clear();
            }
            else MessageBox.Show("You already reported this item!");

        }
        private string Converter(string s) //strings that we get from the ListView is "ListView{blabla}", this function convert it to only "blabla".
        {
            string t = ""; bool add = false;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '{') { add = true; continue; }
                if (s[i] == '}') break;
                if (add) t += s[i];
            }
            return t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            store[0] = txtitmName.Text;
            store[1] = txtPrice.Text;
            store[2] = txtRate.Text;
            Edit_Mode(true);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAct2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUploader_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                dlg.Title = "Select item Poster";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = dlg.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            if (float.Parse(txtRate.Text.ToString()) > 10)
            {
                MessageBox.Show("Rate Must be less than 10!");
                return;
            }
            ControllerObj.Update_Item(txtitmName.Text, float.Parse(txtPrice.Text.ToString()), float.Parse(txtRate.Text.ToString()), Item_ID);
            //After All
            Edit_Mode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit_Mode(false);
            txtitmName.Text = store[0];
            txtPrice.Text = store[1];
            txtRate.Text = store[2];
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ControllerObj.Delete_Item(Item_ID) != 0)
            {
                MessageBox.Show("Done");

                LV.Items.RemoveAt(Item_idx);
                LV.Refresh();
                this.Close();

            }
            else MessageBox.Show("Failed");
        }
        private void Edit_Mode(bool ON)
        {
            if(ON)
            {
                txtitmName.ReadOnly = txtPrice.ReadOnly = txtRate.ReadOnly = false;
                btnDone.Visible = btnCancel.Visible = true;
                txtRate.BackColor = System.Drawing.SystemColors.Control;
                txtitmName.BackColor = System.Drawing.SystemColors.Control;
                txtPrice.BackColor = System.Drawing.SystemColors.Control;

                txtRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                txtitmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                txtitmName.ReadOnly = txtPrice.ReadOnly = txtRate.ReadOnly = true;
                btnDone.Visible  = btnCancel.Visible = false;
                txtRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
                txtitmName.BackColor = System.Drawing.SystemColors.ActiveCaption;
                txtPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
                txtAct1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtAct2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtitmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtUploader.BorderStyle = System.Windows.Forms.BorderStyle.None;
                txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        
    }
}
