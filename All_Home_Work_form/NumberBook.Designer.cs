namespace All_Home_Work_form
{
    partial class NumberBook
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
            this.AddBt = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.ShowBt = new System.Windows.Forms.Button();
            this.FoundBt = new System.Windows.Forms.Button();
            this.BackBt = new System.Windows.Forms.Button();
            this.DBNow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(151, 54);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(236, 86);
            this.AddBt.TabIndex = 0;
            this.AddBt.Text = "Add New Number";
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(151, 175);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(236, 86);
            this.EditBt.TabIndex = 1;
            this.EditBt.Text = "Edit Number";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(151, 300);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(236, 86);
            this.DeleteBt.TabIndex = 2;
            this.DeleteBt.Text = "Delete Number";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // ShowBt
            // 
            this.ShowBt.Location = new System.Drawing.Point(406, 54);
            this.ShowBt.Name = "ShowBt";
            this.ShowBt.Size = new System.Drawing.Size(236, 86);
            this.ShowBt.TabIndex = 3;
            this.ShowBt.Text = "Show All Number";
            this.ShowBt.UseVisualStyleBackColor = true;
            this.ShowBt.Click += new System.EventHandler(this.ShowBt_Click);
            // 
            // FoundBt
            // 
            this.FoundBt.Location = new System.Drawing.Point(406, 175);
            this.FoundBt.Name = "FoundBt";
            this.FoundBt.Size = new System.Drawing.Size(236, 86);
            this.FoundBt.TabIndex = 4;
            this.FoundBt.Text = "Found Number";
            this.FoundBt.UseVisualStyleBackColor = true;
            this.FoundBt.Click += new System.EventHandler(this.FoundBt_Click);
            // 
            // BackBt
            // 
            this.BackBt.Location = new System.Drawing.Point(406, 300);
            this.BackBt.Name = "BackBt";
            this.BackBt.Size = new System.Drawing.Size(236, 86);
            this.BackBt.TabIndex = 5;
            this.BackBt.Text = "Back ";
            this.BackBt.UseVisualStyleBackColor = true;
            this.BackBt.Click += new System.EventHandler(this.BackBt_Click);
            // 
            // DBNow
            // 
            this.DBNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBNow.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DBNow.Location = new System.Drawing.Point(12, 12);
            this.DBNow.Name = "DBNow";
            this.DBNow.ReadOnly = true;
            this.DBNow.Size = new System.Drawing.Size(233, 26);
            this.DBNow.TabIndex = 6;
            this.DBNow.Text = "DB : ";
            // 
            // NumberBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBNow);
            this.Controls.Add(this.BackBt);
            this.Controls.Add(this.FoundBt);
            this.Controls.Add(this.ShowBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.AddBt);
            this.Name = "NumberBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumberBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button ShowBt;
        private System.Windows.Forms.Button FoundBt;
        private System.Windows.Forms.Button BackBt;
        private System.Windows.Forms.TextBox DBNow;
    }
}