using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace All_Home_Work_form
{
    public partial class ExportSQL : Form
    {
        string EXportFile;
        FileStream SqlFile;
        StreamWriter SQLwirte;
        public ExportSQL(string SQLExportTxt)
        {
            InitializeComponent();
            EXportFile = SQLExportTxt;
        }

        private void Export_file_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathFile.Text) || string.IsNullOrEmpty(NameFile.Text))
            {
                MessageBox.Show("File Name Or Path Is Empty", "You Can't Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlFile = new FileStream(PathFile.Text +"\\"+ NameFile.Text + ".txt", FileMode.OpenOrCreate);
            SQLwirte = new StreamWriter(SqlFile);
            SQLwirte.WriteLine(EXportFile);
            SQLwirte.Close();
            this.Close();
        }

        private void Local_Click(object sender, EventArgs e)
        {
            SqlFile = new FileStream(NameFile.Text + ".txt", FileMode.Create);
            SQLwirte = new StreamWriter(SqlFile);
            SQLwirte.WriteLine(EXportFile);
            SQLwirte.Close();
            this.Close();
        }
    }
}
