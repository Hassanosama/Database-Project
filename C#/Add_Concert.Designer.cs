namespace DBapplication
{
    partial class Add_Concert
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
            this.Date_Time = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Available_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SingersCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Date_Time
            // 
            this.Date_Time.Location = new System.Drawing.Point(125, 154);
            this.Date_Time.Name = "Date_Time";
            this.Date_Time.Size = new System.Drawing.Size(100, 20);
            this.Date_Time.TabIndex = 27;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(173, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Add concert";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date and time:";
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(125, 128);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(100, 20);
            this.Phone_txt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone:";
            // 
            // Available_txt
            // 
            this.Available_txt.Location = new System.Drawing.Point(125, 102);
            this.Available_txt.Name = "Available_txt";
            this.Available_txt.Size = new System.Drawing.Size(100, 20);
            this.Available_txt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Available seats:";
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(125, 76);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(100, 20);
            this.Price_txt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ticket price:";
            // 
            // Location_txt
            // 
            this.Location_txt.Location = new System.Drawing.Point(125, 50);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(100, 20);
            this.Location_txt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Singer:";
            // 
            // SingersCombobox
            // 
            this.SingersCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SingersCombobox.Location = new System.Drawing.Point(125, 23);
            this.SingersCombobox.Name = "SingersCombobox";
            this.SingersCombobox.Size = new System.Drawing.Size(121, 21);
            this.SingersCombobox.TabIndex = 15;
            // 
            // Add_Concert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.Date_Time);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Available_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SingersCombobox);
            this.Name = "Add_Concert";
            this.Text = "Add_Concert";
            this.Load += new System.EventHandler(this.Add_Concert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Date_Time;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Available_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SingersCombobox;
    }
}