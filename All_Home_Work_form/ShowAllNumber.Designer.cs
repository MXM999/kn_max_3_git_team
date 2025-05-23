namespace All_Home_Work_form
{
    partial class ShowAllNumber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NumberGrid = new System.Windows.Forms.DataGridView();
            this.Show_bt = new System.Windows.Forms.Button();
            this.Exit_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberGrid
            // 
            this.NumberGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.NumberGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.NumberGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NumberGrid.BackgroundColor = System.Drawing.Color.White;
            this.NumberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.NumberGrid.GridColor = System.Drawing.Color.Black;
            this.NumberGrid.Location = new System.Drawing.Point(3, 31);
            this.NumberGrid.Name = "NumberGrid";
            this.NumberGrid.Size = new System.Drawing.Size(795, 324);
            this.NumberGrid.TabIndex = 0;
            // 
            // Show_bt
            // 
            this.Show_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_bt.Location = new System.Drawing.Point(225, 385);
            this.Show_bt.Name = "Show_bt";
            this.Show_bt.Size = new System.Drawing.Size(189, 53);
            this.Show_bt.TabIndex = 1;
            this.Show_bt.Text = "Show All Data";
            this.Show_bt.UseVisualStyleBackColor = true;
            this.Show_bt.Click += new System.EventHandler(this.Show_bt_Click);
            // 
            // Exit_bt
            // 
            this.Exit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_bt.Location = new System.Drawing.Point(12, 385);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(189, 53);
            this.Exit_bt.TabIndex = 2;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.UseVisualStyleBackColor = true;
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // ShowAllNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Show_bt);
            this.Controls.Add(this.NumberGrid);
            this.Name = "ShowAllNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllNumber";
            ((System.ComponentModel.ISupportInitialize)(this.NumberGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NumberGrid;
        private System.Windows.Forms.Button Show_bt;
        private System.Windows.Forms.Button Exit_bt;
    }
}