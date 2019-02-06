namespace DBapplication
{
    partial class Cinemas
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
            this.comboBoxMovies = new System.Windows.Forms.ComboBox();
            this.comboBoxCinemas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMovies
            // 
            this.comboBoxMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMovies.FormattingEnabled = true;
            this.comboBoxMovies.Location = new System.Drawing.Point(176, 33);
            this.comboBoxMovies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMovies.Name = "comboBoxMovies";
            this.comboBoxMovies.Size = new System.Drawing.Size(140, 24);
            this.comboBoxMovies.TabIndex = 0;
            // 
            // comboBoxCinemas
            // 
            this.comboBoxCinemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinemas.FormattingEnabled = true;
            this.comboBoxCinemas.Location = new System.Drawing.Point(14, 33);
            this.comboBoxCinemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCinemas.Name = "comboBoxCinemas";
            this.comboBoxCinemas.Size = new System.Drawing.Size(140, 24);
            this.comboBoxCinemas.TabIndex = 1;
            this.comboBoxCinemas.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinemas_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cinema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movies:";
            // 
            // Cinemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCinemas);
            this.Controls.Add(this.comboBoxMovies);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cinemas";
            this.Text = "Cinemas";
            this.Load += new System.EventHandler(this.Cinemas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMovies;
        private System.Windows.Forms.ComboBox comboBoxCinemas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}