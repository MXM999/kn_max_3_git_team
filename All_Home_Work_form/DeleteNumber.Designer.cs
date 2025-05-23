namespace All_Home_Work_form
{
    partial class DeleteNumber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.Delete_number = new System.Windows.Forms.TextBox();
            this.Delete_name = new System.Windows.Forms.TextBox();
            this.seacrh_textBox = new System.Windows.Forms.TextBox();
            this.Exit_bt = new System.Windows.Forms.Button();
            this.search_bt = new System.Windows.Forms.Button();
            this.SerachGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SerachGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBt
            // 
            this.DeleteBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBt.Location = new System.Drawing.Point(495, 376);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(298, 53);
            this.DeleteBt.TabIndex = 16;
            this.DeleteBt.Text = "Delete";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // Delete_number
            // 
            this.Delete_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_number.Location = new System.Drawing.Point(495, 324);
            this.Delete_number.Name = "Delete_number";
            this.Delete_number.Size = new System.Drawing.Size(298, 29);
            this.Delete_number.TabIndex = 15;
            // 
            // Delete_name
            // 
            this.Delete_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_name.Location = new System.Drawing.Point(495, 263);
            this.Delete_name.Name = "Delete_name";
            this.Delete_name.Size = new System.Drawing.Size(298, 29);
            this.Delete_name.TabIndex = 14;
            // 
            // seacrh_textBox
            // 
            this.seacrh_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seacrh_textBox.Location = new System.Drawing.Point(495, 22);
            this.seacrh_textBox.Name = "seacrh_textBox";
            this.seacrh_textBox.Size = new System.Drawing.Size(298, 29);
            this.seacrh_textBox.TabIndex = 13;
            // 
            // Exit_bt
            // 
            this.Exit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_bt.Location = new System.Drawing.Point(17, 376);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(189, 53);
            this.Exit_bt.TabIndex = 12;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.UseVisualStyleBackColor = true;
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // search_bt
            // 
            this.search_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bt.Location = new System.Drawing.Point(495, 66);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(298, 53);
            this.search_bt.TabIndex = 11;
            this.search_bt.Text = "Search";
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // SerachGrid
            // 
            this.SerachGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.SerachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SerachGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SerachGrid.BackgroundColor = System.Drawing.Color.White;
            this.SerachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SerachGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SerachGrid.GridColor = System.Drawing.Color.Black;
            this.SerachGrid.Location = new System.Drawing.Point(8, 22);
            this.SerachGrid.Name = "SerachGrid";
            this.SerachGrid.Size = new System.Drawing.Size(481, 242);
            this.SerachGrid.TabIndex = 10;
            // 
            // DeleteNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.Delete_number);
            this.Controls.Add(this.Delete_name);
            this.Controls.Add(this.seacrh_textBox);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.SerachGrid);
            this.Name = "DeleteNumber";
            this.Text = "DeleteNumber";
            ((System.ComponentModel.ISupportInitialize)(this.SerachGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.TextBox Delete_number;
        private System.Windows.Forms.TextBox Delete_name;
        private System.Windows.Forms.TextBox seacrh_textBox;
        private System.Windows.Forms.Button Exit_bt;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.DataGridView SerachGrid;
    }
}