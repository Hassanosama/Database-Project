namespace DBapplication
{
    partial class Provided_Functionalities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provided_Functionalities));
            this.listView1 = new System.Windows.Forms.ListView();
            this.postercol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnMyItems = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMyFav = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btnuploads = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnViewStatis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnUnsold = new System.Windows.Forms.Button();
            this.btnReported = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.postercol,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(13, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 606);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // postercol
            // 
            this.postercol.Text = "Poster";
            this.postercol.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 91;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(80, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(7, 23);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 23);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(453, 530);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(142, 46);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMyItems
            // 
            this.btnMyItems.Location = new System.Drawing.Point(453, 312);
            this.btnMyItems.Name = "btnMyItems";
            this.btnMyItems.Size = new System.Drawing.Size(142, 47);
            this.btnMyItems.TabIndex = 5;
            this.btnMyItems.Text = "My Items";
            this.btnMyItems.UseVisualStyleBackColor = true;
            this.btnMyItems.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 635);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnMyFav
            // 
            this.btnMyFav.Location = new System.Drawing.Point(453, 365);
            this.btnMyFav.Name = "btnMyFav";
            this.btnMyFav.Size = new System.Drawing.Size(142, 46);
            this.btnMyFav.TabIndex = 7;
            this.btnMyFav.Text = "My Favorits";
            this.btnMyFav.UseVisualStyleBackColor = true;
            this.btnMyFav.Click += new System.EventHandler(this.btnMyFav_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.Genre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(453, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(10, 112);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(120, 24);
            this.Type.TabIndex = 9;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Genre
            // 
            this.Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(10, 82);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(121, 24);
            this.Genre.TabIndex = 8;
            this.Genre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter Results:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(454, 582);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 47);
            this.button6.TabIndex = 5;
            this.button6.Text = "Update Profile";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnuploads
            // 
            this.btnuploads.Location = new System.Drawing.Point(453, 417);
            this.btnuploads.Name = "btnuploads";
            this.btnuploads.Size = new System.Drawing.Size(142, 47);
            this.btnuploads.TabIndex = 5;
            this.btnuploads.Text = "My Uploads";
            this.btnuploads.UseVisualStyleBackColor = true;
            this.btnuploads.Click += new System.EventHandler(this.btnuploads_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Welcome.Location = new System.Drawing.Point(9, 7);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(97, 23);
            this.Welcome.TabIndex = 9;
            this.Welcome.Text = "Welcome";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblusername.Location = new System.Drawing.Point(102, 7);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(121, 23);
            this.lblusername.TabIndex = 9;
            this.lblusername.Text = "User_name";
            // 
            // btnViewReports
            // 
            this.btnViewReports.Location = new System.Drawing.Point(453, 204);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(142, 47);
            this.btnViewReports.TabIndex = 5;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnViewStatis
            // 
            this.btnViewStatis.Location = new System.Drawing.Point(453, 259);
            this.btnViewStatis.Name = "btnViewStatis";
            this.btnViewStatis.Size = new System.Drawing.Size(142, 47);
            this.btnViewStatis.TabIndex = 5;
            this.btnViewStatis.Text = "View Statistics";
            this.btnViewStatis.UseVisualStyleBackColor = true;
            this.btnViewStatis.Click += new System.EventHandler(this.btnViewStatis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(335, 10);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(111, 22);
            this.btnStore.TabIndex = 11;
            this.btnStore.Text = "Back to Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(371, 647);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 25);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUnsold
            // 
            this.btnUnsold.Location = new System.Drawing.Point(12, 647);
            this.btnUnsold.Name = "btnUnsold";
            this.btnUnsold.Size = new System.Drawing.Size(147, 23);
            this.btnUnsold.TabIndex = 13;
            this.btnUnsold.Text = "Show Unsold Only";
            this.btnUnsold.UseVisualStyleBackColor = true;
            this.btnUnsold.Click += new System.EventHandler(this.btnUnsold_Click);
            // 
            // btnReported
            // 
            this.btnReported.Location = new System.Drawing.Point(165, 647);
            this.btnReported.Name = "btnReported";
            this.btnReported.Size = new System.Drawing.Size(147, 23);
            this.btnReported.TabIndex = 14;
            this.btnReported.Text = "Most Reported Items";
            this.btnReported.UseVisualStyleBackColor = true;
            this.btnReported.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Book A Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(453, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Concerts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Provided_Functionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 724);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReported);
            this.Controls.Add(this.btnUnsold);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMyFav);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnuploads);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnViewStatis);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnMyItems);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Provided_Functionalities";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Provided_Functionalities_FormClosed);
            this.Load += new System.EventHandler(this.Provided_Functionalities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader postercol;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnMyItems;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMyFav;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnuploads;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnViewStatis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUnsold;
        private System.Windows.Forms.Button btnReported;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}