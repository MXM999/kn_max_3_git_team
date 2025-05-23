using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace All_Home_Work_form
{
    public partial class createDataBase : Form
    {
        SqlConnection Conn;
        SqlCommand Command;
        ExportSQL EXP;
        mxm m_win;
        public createDataBase()
        {
            InitializeComponent();
        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            string connection_string_new = @"Data source = .\" + ServerName.Text + ";Database =master; User Id = " + UserName.Text + "; Password = " + Paseword.Text + ";";
            Conn = new SqlConnection(connection_string_new);
            string Create_qur = "CREATE DATABASE " + DatabaseName.Text;
            Command = new SqlCommand(Create_qur, Conn);
            try
            {
                Conn.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "DB Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conn.Close();
                string NewSQLDB = @"Data source = .\ " + ServerName.Text + " ; Database = " + DatabaseName.Text + " ; User Id = " + UserName.Text + " ; Password = " + Paseword.Text + " ;";
                Conn = new SqlConnection(NewSQLDB);
                string Create_Table = @"CREATE TABLE NUMBERS 
                                       (
                                       ID INT PRIMARY KEY IDENTITY(1, 1),
                                       FULL_NAME VARCHAR(255) NOT NULL,
                                       PHONE VARCHAR(200) NOT NULL
                                       )";
                Command = new SqlCommand(Create_Table, Conn);
                Conn.Open();
                Command.ExecuteNonQuery();
                Conn.Close();
                EXP = new ExportSQL(NewSQLDB);
                EXP.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_win = new mxm();
            m_win.Show();
        }
    }
}
