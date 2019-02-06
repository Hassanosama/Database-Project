namespace DBapplication
{
    partial class Concerts
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
            this.refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Book_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Singers_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dates_Combo = new System.Windows.Forms.ComboBox();
            this.myBookedCheckbox = new System.Windows.Forms.CheckBox();
            this.Concerts_Grid = new System.Windows.Forms.DataGridView();
            this.AddConcert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Concerts_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.BackgroundImage = global::DBapplication.Properties.Resources.refresh;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(592, 139);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(22, 21);
            this.refresh.TabIndex = 15;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Book_Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Singers_Combo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dates_Combo);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 65);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book concert";
            // 
            // Book_Button
            // 
            this.Book_Button.Location = new System.Drawing.Point(481, 27);
            this.Book_Button.Name = "Book_Button";
            this.Book_Button.Size = new System.Drawing.Size(87, 23);
            this.Book_Button.TabIndex = 10;
            this.Book_Button.Text = "Book concert";
            this.Book_Button.UseVisualStyleBackColor = true;
            this.Book_Button.Click += new System.EventHandler(this.Book_Button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date:";
            // 
            // Singers_Combo
            // 
            this.Singers_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Singers_Combo.FormattingEnabled = true;
            this.Singers_Combo.Location = new System.Drawing.Point(77, 27);
            this.Singers_Combo.Name = "Singers_Combo";
            this.Singers_Combo.Size = new System.Drawing.Size(121, 21);
            this.Singers_Combo.TabIndex = 6;
            this.Singers_Combo.SelectedIndexChanged += new System.EventHandler(this.Singers_Combo_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Singer:";
            // 
            // Dates_Combo
            // 
            this.Dates_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dates_Combo.FormattingEnabled = true;
            this.Dates_Combo.Location = new System.Drawing.Point(304, 27);
            this.Dates_Combo.Name = "Dates_Combo";
            this.Dates_Combo.Size = new System.Drawing.Size(121, 21);
            this.Dates_Combo.TabIndex = 7;
            // 
            // myBookedCheckbox
            // 
            this.myBookedCheckbox.AutoSize = true;
            this.myBookedCheckbox.Location = new System.Drawing.Point(12, 141);
            this.myBookedCheckbox.Name = "myBookedCheckbox";
            this.myBookedCheckbox.Size = new System.Drawing.Size(155, 17);
            this.myBookedCheckbox.TabIndex = 13;
            this.myBookedCheckbox.Text = "Show my booked concerts.";
            this.myBookedCheckbox.UseVisualStyleBackColor = true;
            this.myBookedCheckbox.CheckedChanged += new System.EventHandler(this.myBookedCheckbox_CheckedChanged_1);
            // 
            // Concerts_Grid
            // 
            this.Concerts_Grid.AllowUserToAddRows = false;
            this.Concerts_Grid.AllowUserToDeleteRows = false;
            this.Concerts_Grid.AllowUserToResizeRows = false;
            this.Concerts_Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Concerts_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Concerts_Grid.Location = new System.Drawing.Point(12, 12);
            this.Concerts_Grid.Name = "Concerts_Grid";
            this.Concerts_Grid.Size = new System.Drawing.Size(602, 123);
            this.Concerts_Grid.TabIndex = 12;
            // 
            // AddConcert
            // 
            this.AddConcert.Location = new System.Drawing.Point(493, 139);
            this.AddConcert.Name = "AddConcert";
            this.AddConcert.Size = new System.Drawing.Size(87, 23);
            this.AddConcert.TabIndex = 11;
            this.AddConcert.Text = "Add concert..";
            this.AddConcert.UseVisualStyleBackColor = true;
            this.AddConcert.Click += new System.EventHandler(this.AddConcert_Click_1);
            // 
            // Concerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 253);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.myBookedCheckbox);
            this.Controls.Add(this.Concerts_Grid);
            this.Controls.Add(this.AddConcert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Concerts";
            this.Text = "Concerts";
            this.Load += new System.EventHandler(this.Concerts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Concerts_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Book_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Singers_Combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Dates_Combo;
        private System.Windows.Forms.CheckBox myBookedCheckbox;
        private System.Windows.Forms.DataGridView Concerts_Grid;
        private System.Windows.Forms.Button AddConcert;
    }
}