namespace All_Home_Work_form
{
    partial class mxm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mxm));
            this.Book_number = new System.Windows.Forms.Button();
            this.Regster_Student = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Book_number
            // 
            this.Book_number.BackgroundImage = global::All_Home_Work_form.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.Book_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Book_number.FlatAppearance.BorderSize = 0;
            this.Book_number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_number.ForeColor = System.Drawing.Color.Transparent;
            this.Book_number.Location = new System.Drawing.Point(271, 69);
            this.Book_number.Name = "Book_number";
            this.Book_number.Size = new System.Drawing.Size(380, 78);
            this.Book_number.TabIndex = 0;
            this.Book_number.Text = "Book New";
            this.Book_number.UseVisualStyleBackColor = true;
            this.Book_number.Click += new System.EventHandler(this.Book_number_Click);
            // 
            // Regster_Student
            // 
            this.Regster_Student.BackgroundImage = global::All_Home_Work_form.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.Regster_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regster_Student.FlatAppearance.BorderSize = 0;
            this.Regster_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regster_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regster_Student.ForeColor = System.Drawing.Color.Transparent;
            this.Regster_Student.Location = new System.Drawing.Point(271, 217);
            this.Regster_Student.Name = "Regster_Student";
            this.Regster_Student.Size = new System.Drawing.Size(380, 78);
            this.Regster_Student.TabIndex = 1;
            this.Regster_Student.Text = "Connetion Server";
            this.Regster_Student.UseVisualStyleBackColor = true;
            this.Regster_Student.Click += new System.EventHandler(this.Regster_Student_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::All_Home_Work_form.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(271, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::All_Home_Work_form.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create New DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mxm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::All_Home_Work_form.Properties.Resources.minimalism_green_geometry_abstract_wallpaper_62b6cc95ffd553a96532e4ea22810f60;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Regster_Student);
            this.Controls.Add(this.Book_number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mxm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Book_number;
        private System.Windows.Forms.Button Regster_Student;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

