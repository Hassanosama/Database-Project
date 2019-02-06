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
    public partial class Upload : Form
    {
        Controller ControllerObj = new Controller();
        string Username;
        ListView LV;
        public Upload(string user,ListView ptr)
        {
            InitializeComponent();
            Username = user;
            LV = ptr;
        }

        private void Upload_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Movie");
            comboBox1.Items.Add("Song");
            comboBox1.Items.Add("Series");
            comboBox1.Items.Add("Game");
            comboBox1.SelectedIndex = 0;
            GBnewACT.Enabled = groupBox2.Enabled = GBnewSinger.Enabled = false;
            Fill_Commbo();
            SInfo.Location = new System.Drawing.Point(142,171);
            GInfo.Location = new System.Drawing.Point(142, 171);
            SongInfo.Location = new System.Drawing.Point(142, 171);
            
            this.Size = new System.Drawing.Size(548, 562);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                dlg.Title = "Select item Poster";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = dlg.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: //Movie
                    SongInfo.Visible = false;
                    MInfo.Visible = true;
                    SInfo.Visible = false;
                    GInfo.Visible = false;
                    break;
                case 1: //Song
                    SongInfo.Visible = true;
                    MInfo.Visible = false;
                    SInfo.Visible = false;
                    GInfo.Visible = false; ;
                    break;
                case 2: //Series
                    SongInfo.Visible = false;
                    MInfo.Visible = false;
                    SInfo.Visible = true;
                    GInfo.Visible = false;
                    break;
                case 3: //Game
                    SongInfo.Visible = false;
                    MInfo.Visible = false;
                    SInfo.Visible = false;
                    GInfo.Visible = true;
                    break;
            }
            Fill_Commbo();
            Hide_Appear();
            chkAction.Checked = chkAdventure.Checked = chkComedy.Checked = chkCrime.Checked = chkDrama.Checked = chkFantasy.Checked = chkHip_hop.Checked = chkSurvival.Checked = chkThriller.Checked = chkWar.Checked = false;
            chkHistory.Checked = chkHorror.Checked = chkMystery.Checked = chkPop.Checked = chkRap.Checked = chkRock.Checked = chkRomantic.Checked = chkScience_Fiction.Checked = chkSport.Checked = chkStealth.Checked = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //
            if (txtName.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtYear.Text.Trim() == "" || txtRate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            //

            if (comboBox1.Text == "Movie" && txtMDuration.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            if (comboBox1.Text == "Song" && (txtSduration.Text.Trim() == "" || txtSalbum.Text.Trim() == ""))
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            if (comboBox1.Text == "Game" && (txtGstudio.Text.Trim() == ""))
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            if (comboBox1.Text == "Series" && (txtSSseasons.Text.Trim() == ""))
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }


            if (float.Parse(txtRate.Text.ToString()) > 10 || float.Parse(txtRate.Text.ToString()) < 0)
            {
                MessageBox.Show("Rate Must between 0 and 10!");
                return;
            }
            int ItemID = 0;
            int ItemType = 0;
            if (!validation()) return;
            byte[] img = null;
            if (pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Please Choose an Image for your item!");
                return;
            }
            FileStream fs = new FileStream(pictureBox1.ImageLocation.ToString(),FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            
            switch (comboBox1.SelectedIndex)
            {
                case 0: //Movie
                    ItemID = ControllerObj.Upload_Movie(txtName.Text,float.Parse(txtPrice.Text),Int32.Parse(txtYear.Text),float.Parse(txtRate.Text),Username,img,float.Parse(txtMDuration.Text),CBdir1.SelectedValue.ToString(),CBact1.SelectedValue.ToString(),CBact2.SelectedValue.ToString());
                    ItemType = 1;

                    break;
                case 1: //Song
                    ItemID = ControllerObj.Upload_Song(txtName.Text, float.Parse(txtPrice.Text), Int32.Parse(txtYear.Text), float.Parse(txtRate.Text), Username, img, float.Parse(txtSduration.Text), CBsingers.SelectedValue.ToString(), txtSalbum.Text);
                    ItemType = 4;

                    break;
                case 2: //Series
                    ItemID = ControllerObj.Upload_Series(txtName.Text, float.Parse(txtPrice.Text), Int32.Parse(txtYear.Text), float.Parse(txtRate.Text), Username, img,Int32.Parse(txtSSseasons.Text), CBdir2.SelectedValue.ToString(),CBsAc1.SelectedValue.ToString(),CBsAc2.SelectedValue.ToString());
                    ItemType = 2;
                    break;
                case 3: //Game
                    ItemID = ControllerObj.Upload_Game(txtName.Text, float.Parse(txtPrice.Text), Int32.Parse(txtYear.Text), float.Parse(txtRate.Text), Username, img,txtGstudio.Text);
                    ItemType = 3;
                    break;
            }
            if (ItemID != 0)
            {
                if(chkAction.Checked == true) ControllerObj.Insert_Genre(ItemID, chkAction.Text, ItemType);
                if(chkAdventure.Checked == true) ControllerObj.Insert_Genre(ItemID, chkAdventure.Text, ItemType);
                if(chkComedy.Checked == true) ControllerObj.Insert_Genre(ItemID, chkComedy.Text, ItemType);
                if(chkCrime.Checked == true) ControllerObj.Insert_Genre(ItemID, chkCrime.Text, ItemType);
                if(chkDrama.Checked == true) ControllerObj.Insert_Genre(ItemID, chkDrama.Text, ItemType);
                if(chkFantasy.Checked == true) ControllerObj.Insert_Genre(ItemID, chkFantasy.Text, ItemType);
                if(chkHip_hop.Checked == true) ControllerObj.Insert_Genre(ItemID, chkHip_hop.Text, ItemType);
                if(chkHistory.Checked == true) ControllerObj.Insert_Genre(ItemID, chkHistory.Text, ItemType);
                if(chkHorror.Checked == true) ControllerObj.Insert_Genre(ItemID, chkHorror.Text, ItemType);
                if(chkMystery.Checked == true) ControllerObj.Insert_Genre(ItemID, chkMystery.Text, ItemType);
                if(chkPop.Checked == true) ControllerObj.Insert_Genre(ItemID, chkPop.Text, ItemType);
                if(chkRap.Checked == true) ControllerObj.Insert_Genre(ItemID, chkRap.Text, ItemType);
                if(chkRock.Checked == true) ControllerObj.Insert_Genre(ItemID, chkRock.Text, ItemType);
                if(chkRomantic.Checked == true) ControllerObj.Insert_Genre(ItemID, chkRomantic.Text, ItemType);
                if(chkScience_Fiction.Checked == true) ControllerObj.Insert_Genre(ItemID, chkScience_Fiction.Text, ItemType);
                if(chkSport.Checked == true) ControllerObj.Insert_Genre(ItemID, chkSport.Text, ItemType);
                if(chkStealth.Checked == true) ControllerObj.Insert_Genre(ItemID, chkStealth.Text, ItemType);
                if(chkSurvival.Checked == true) ControllerObj.Insert_Genre(ItemID, chkSurvival.Text, ItemType);
                if(chkThriller.Checked == true) ControllerObj.Insert_Genre(ItemID, chkThriller.Text, ItemType);
                if(chkWar.Checked == true) ControllerObj.Insert_Genre(ItemID, chkWar.Text, ItemType);
                MessageBox.Show("Done");
                LV.Refresh();
                this.Close();
            }
            else
                MessageBox.Show("Faild");

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void GBnewdirector_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkRomantic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCrime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMystery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkArtist_CheckedChanged(object sender, EventArgs e)
        {
            GBnewACT.Enabled = chkArtist.Checked;
        }

        private void btnAddAct_Click(object sender, EventArgs e)
        {
            if (RBActor.Checked == true)
            {
                if(ControllerObj.Add_Celeb(txtActFname.Text + " " + txtActLName.Text,Int32.Parse(txtActAge.Text),0) != 0) MessageBox.Show("Done");   //the sql will contains if-else //0->Actor
                else MessageBox.Show("Failed");
            }
            else if (RBDir.Checked == true)
            {
                if (ControllerObj.Add_Celeb(txtActFname.Text + " " + txtActLName.Text, Int32.Parse(txtActAge.Text), 1) != 0) MessageBox.Show("Done");   //the sql will contains if-else //1->Director
                else MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Please choose Actor or Director!");
                return;
            }
            Fill_Commbo();
            Refresh_All();
        }
        private void Refresh_All()
        {
            CBdir1.Refresh();
            CBdir2.Refresh();
            CBsingers.Refresh();
            CBact1.Refresh();
            CBact2.Refresh();
        }

        private void btnAddSinger_Click(object sender, EventArgs e)
        {
            if(ControllerObj.Add_Celeb(txtSingerFname.Text + " " + txtSingerLname.Text,Int32.Parse(txtSingerAge.Text),2) != 0) MessageBox.Show("Done");   //2->singer
            else MessageBox.Show("Failed");
            Fill_Commbo();
            Refresh_All();
        }
        private void Hide_Appear()
        {
            chkPop.Enabled = chkRap.Enabled = chkRock.Enabled = chkHip_hop.Enabled = SongInfo.Visible;
            chkWar.Enabled = chkSurvival.Enabled = chkSport.Enabled = chkStealth.Enabled = chkMystery.Enabled = chkAdventure.Enabled = GInfo.Visible;
            chkThriller.Enabled = chkComedy.Enabled = chkRomantic.Enabled = chkDrama.Enabled = chkFantasy.Enabled = chkScience_Fiction.Enabled = chkCrime.Enabled = MInfo.Visible | SInfo.Visible;
            if (SongInfo.Visible == true) chkAction.Enabled = chkHistory.Enabled = chkHorror.Enabled = false;
            else chkAction.Enabled = chkHistory.Enabled = chkHorror.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RBsActor.Checked == true)
            {
                if (ControllerObj.Add_Celeb(txtSactFname.Text + " " + txtSLname.Text, Int32.Parse(txtSage.Text), 0) != 0) MessageBox.Show("Done");   //the sql will contains if-else //0->Actor
                else MessageBox.Show("Failed");
            }
            else if (RBsDir.Checked == true)
            {
                if (ControllerObj.Add_Celeb(txtSactFname.Text + " " + txtSLname.Text, Int32.Parse(txtSage.Text), 1) != 0) MessageBox.Show("Done");   //the sql will contains if-else //1->Director
                else MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Please choose Actor or Director!");
                return;
            }
            Refresh_All();
        }

        private void chkSinger_CheckedChanged(object sender, EventArgs e)
        {
            GBnewSinger.Enabled = chkSinger.Checked;
        }

        private void SInfo_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = checkBox1.Checked;
        }
        private void Fill_Commbo()
        {
            CBdir1.DataSource = ControllerObj.Get_Celebs(1);
            CBdir2.DataSource = ControllerObj.Get_Celebs(1);
            CBsingers.DataSource = ControllerObj.Get_Celebs(2);
            CBact1.DataSource = ControllerObj.Get_Celebs(0);
            CBact2.DataSource = ControllerObj.Get_Celebs(0);
            CBsAc1.DataSource = ControllerObj.Get_Celebs(0);
            CBsAc2.DataSource = ControllerObj.Get_Celebs(0);

            CBdir1.DisplayMember = "Name";
            CBdir2.DisplayMember = "Name";
            CBsingers.DisplayMember = "Name";
            CBact1.DisplayMember = "Name";
            CBact2.DisplayMember = "Name";
            CBsAc1.DisplayMember = "Name";
            CBsAc2.DisplayMember = "Name";

            CBdir1.ValueMember = "Name";
            CBdir2.ValueMember = "Name";
            CBsingers.ValueMember = "Name";
            CBact1.ValueMember = "Name";
            CBact2.ValueMember = "Name";
            CBsAc1.ValueMember = "Name";
            CBsAc2.ValueMember = "Name";
        }
        private bool validation()
        {
            if(!chkAction.Checked&&!chkAdventure.Checked&&!chkComedy.Checked&&!chkCrime.Checked&&!chkDrama.Checked&&!chkFantasy.Checked&&!chkHip_hop.Checked&&!chkHistory.Checked&&!chkHorror.Checked&&!chkMystery.Checked &&!chkPop.Checked&&!chkRap.Checked &&!chkRock.Checked&&!chkRomantic.Checked&&!chkScience_Fiction.Checked&&!chkSport.Checked &&!chkStealth.Checked &&!chkSurvival.Checked&&!chkThriller.Checked&&!chkWar.Checked)
            {
                MessageBox.Show("Please Choose At least one Genre.");
                return false;
            }
            return true;
        }

        private void btnSadd_Click(object sender, EventArgs e)
        {
            if (RBsActor.Checked == true)
            {
                if (ControllerObj.Add_Celeb(txtSactFname.Text + " " + txtSLname.Text, Int32.Parse(txtSage.Text), 0) != 0) MessageBox.Show("Done");   //the sql will contains if-else //0->Actor
                else MessageBox.Show("Failed");
            }
            else if (RBsDir.Checked == true)
            {
                if (ControllerObj.Add_Celeb(txtSactFname.Text + " " + txtSLname.Text, Int32.Parse(txtSage.Text), 1) != 0) MessageBox.Show("Done");  //the sql will contains if-else //1->Director
                else MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Please choose Actor or Director!");
                return;
            }
            Fill_Commbo();
            Refresh_All();
        }

        private void txtMDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtActAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtSingerAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtSduration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtSage_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtSSseasons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar == '.') e.Handled = true;
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
