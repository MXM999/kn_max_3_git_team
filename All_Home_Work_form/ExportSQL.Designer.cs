namespace All_Home_Work_form
{
    partial class ExportSQL
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
            this.Export_file = new System.Windows.Forms.Button();
            this.NameFile = new System.Windows.Forms.TextBox();
            this.PathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Local = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Export_file
            // 
            this.Export_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_file.Location = new System.Drawing.Point(162, 173);
            this.Export_file.Name = "Export_file";
            this.Export_file.Size = new System.Drawing.Size(105, 48);
            this.Export_file.TabIndex = 0;
            this.Export_file.Text = "Export";
            this.Export_file.UseVisualStyleBackColor = true;
            this.Export_file.Click += new System.EventHandler(this.Export_file_Click);
            // 
            // NameFile
            // 
            this.NameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFile.Location = new System.Drawing.Point(127, 30);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(140, 29);
            this.NameFile.TabIndex = 1;
            this.NameFile.Text = "DB1";
            // 
            // PathFile
            // 
            this.PathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathFile.Location = new System.Drawing.Point(127, 106);
            this.PathFile.Name = "PathFile";
            this.PathFile.Size = new System.Drawing.Size(140, 29);
            this.PathFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name File ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path";
            // 
            // Local
            // 
            this.Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Local.Location = new System.Drawing.Point(19, 173);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(105, 48);
            this.Local.TabIndex = 5;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            this.Local.Click += new System.EventHandler(this.Local_Click);
            // 
            // ExportSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 232);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathFile);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.Export_file);
            this.Name = "ExportSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export_file;
        private System.Windows.Forms.TextBox NameFile;
        private System.Windows.Forms.TextBox PathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Local;
    }
}