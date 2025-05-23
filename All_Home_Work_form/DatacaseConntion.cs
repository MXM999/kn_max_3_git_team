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
using System.IO;

namespace All_Home_Work_form
{
    public partial class DatacaseConntion : Form
    {
        private string SQLCON;
        ExportSQL m_exp;
        SqlConnection conSt;
        mxm win;
        public DatacaseConntion()
        {
            InitializeComponent();
        }

        private void ConnectionBt_Click(object sender, EventArgs e)
        {
            try
            {
                SQLCON = @"Data source = .\ " + ServerName.Text + " ; Database = " + DatabaseName.Text + " ; User Id = " + UserName.Text + " ; Password = " + Paseword.Text + " ;";
                conSt = new SqlConnection(SQLCON);
                conSt.Open();
                MessageBox.Show(conSt.State.ToString());
                conSt.Close();
                baseSrtingConntion.SQLConntionString_base = SQLCON;
                this.Close();
                win = new mxm();
                win.Show();
            }
            catch (SqlException)
            {

                MessageBox.Show("Not Found The Server or database", "Can't Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Improt_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader BaseDB = File.OpenText(ImoprtDBtext.Text + ".txt");
                string impSql = BaseDB.ReadLine();
                string[] data_form_file = impSql.Split(' ');
                ServerName.Text = data_form_file[4];
                DatabaseName.Text = data_form_file[8];
                UserName.Text = data_form_file[13];
                Paseword.Text = data_form_file[17];
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Not Found The txt", "You Can't Imoprt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Export_Click(object sender, EventArgs e)
        {
            SQLCON = @"Data source = .\ " + ServerName.Text + " ; Database = " + DatabaseName.Text + " ; User Id = " + UserName.Text + " ; Password = " + Paseword.Text + " ;";
            m_exp = new ExportSQL(SQLCON);
            m_exp.Show();          
        }

       
    }
}
