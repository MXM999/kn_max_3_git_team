namespace All_Home_Work_form
{
    partial class FoundNumber
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
            this.ExitBt = new System.Windows.Forms.Button();
            this.NumberLB = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.Found = new System.Windows.Forms.Button();
            this.NameLB = new System.Windows.Forms.Label();
            this.NameBOX = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitBt
            // 
            this.ExitBt.Location = new System.Drawing.Point(140, 244);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(88, 48);
            this.ExitBt.TabIndex = 15;
            this.ExitBt.Text = "Exit";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // NumberLB
            // 
            this.NumberLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLB.Location = new System.Drawing.Point(36, 166);
            this.NumberLB.Name = "NumberLB";
            this.NumberLB.Size = new System.Drawing.Size(100, 38);
            this.NumberLB.TabIndex = 14;
            this.NumberLB.Text = "Number";
            this.NumberLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(140, 166);
            this.NumberBox.Multiline = true;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(221, 38);
            this.NumberBox.TabIndex = 13;
            // 
            // Found
            // 
            this.Found.Location = new System.Drawing.Point(273, 244);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(88, 48);
            this.Found.TabIndex = 12;
            this.Found.Text = "Found";
            this.Found.UseVisualStyleBackColor = true;
            this.Found.Click += new System.EventHandler(this.Found_Click);
            // 
            // NameLB
            // 
            this.NameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.Location = new System.Drawing.Point(36, 58);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(100, 38);
            this.NameLB.TabIndex = 11;
            this.NameLB.Text = "Name";
            this.NameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameBOX
            // 
            this.NameBOX.Location = new System.Drawing.Point(140, 58);
            this.NameBOX.Multiline = true;
            this.NameBOX.Name = "NameBOX";
            this.NameBOX.Size = new System.Drawing.Size(221, 38);
            this.NameBOX.TabIndex = 10;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(140, 333);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(221, 38);
            this.Result.TabIndex = 16;
            // 
            // FoundNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 447);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.NumberLB);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.NameLB);
            this.Controls.Add(this.NameBOX);
            this.Name = "FoundNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Label NumberLB;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Button Found;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.TextBox NameBOX;
        private System.Windows.Forms.TextBox Result;
    }
}