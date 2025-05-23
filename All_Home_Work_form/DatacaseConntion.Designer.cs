namespace All_Home_Work_form
{
    partial class DatacaseConntion
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
            this.ServerName = new System.Windows.Forms.TextBox();
            this.textServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Paseword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.ConnectionBt = new System.Windows.Forms.Button();
            this.Improt = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ImoprtDBtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServerName
            // 
            this.ServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerName.Location = new System.Drawing.Point(164, 24);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(165, 27);
            this.ServerName.TabIndex = 0;
            // 
            // textServer
            // 
            this.textServer.AutoSize = true;
            this.textServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServer.Location = new System.Drawing.Point(12, 27);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(121, 24);
            this.textServer.TabIndex = 1;
            this.textServer.Text = "Server Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DataBase Name";
            // 
            // DatabaseName
            // 
            this.DatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseName.Location = new System.Drawing.Point(164, 80);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(165, 27);
            this.DatabaseName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // Paseword
            // 
            this.Paseword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paseword.Location = new System.Drawing.Point(164, 192);
            this.Paseword.Name = "Paseword";
            this.Paseword.Size = new System.Drawing.Size(165, 27);
            this.Paseword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(164, 136);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(165, 27);
            this.UserName.TabIndex = 4;
            // 
            // ConnectionBt
            // 
            this.ConnectionBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionBt.Location = new System.Drawing.Point(16, 284);
            this.ConnectionBt.Name = "ConnectionBt";
            this.ConnectionBt.Size = new System.Drawing.Size(313, 76);
            this.ConnectionBt.TabIndex = 8;
            this.ConnectionBt.Text = "Connection ";
            this.ConnectionBt.UseVisualStyleBackColor = true;
            this.ConnectionBt.Click += new System.EventHandler(this.ConnectionBt_Click);
            // 
            // Improt
            // 
            this.Improt.Location = new System.Drawing.Point(185, 366);
            this.Improt.Name = "Improt";
            this.Improt.Size = new System.Drawing.Size(144, 47);
            this.Improt.TabIndex = 9;
            this.Improt.Text = "Import Local";
            this.Improt.UseVisualStyleBackColor = true;
            this.Improt.Click += new System.EventHandler(this.Improt_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(16, 366);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(144, 47);
            this.Export.TabIndex = 10;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Import Local DB";
            // 
            // ImoprtDBtext
            // 
            this.ImoprtDBtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImoprtDBtext.Location = new System.Drawing.Point(164, 248);
            this.ImoprtDBtext.Name = "ImoprtDBtext";
            this.ImoprtDBtext.Size = new System.Drawing.Size(165, 27);
            this.ImoprtDBtext.TabIndex = 11;
            this.ImoprtDBtext.Text = "DB1";
            // 
            // DatacaseConntion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImoprtDBtext);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Improt);
            this.Controls.Add(this.ConnectionBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Paseword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.ServerName);
            this.Name = "DatacaseConntion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatacaseConntion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label textServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Paseword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button ConnectionBt;
        private System.Windows.Forms.Button Improt;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImoprtDBtext;
    }
}