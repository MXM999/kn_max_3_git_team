using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_Home_Work_form
{
    public partial class NumberBook : Form
    {
        mxm win;
        AddNewNumber m_addnumber;
        FoundNumber m_found;
        ShowAllNumber m_ShowGrid;
        EditNumber m_Edit;
        DeleteNumber m_delete;
        public NumberBook()
        {
            InitializeComponent();
            string[] DB_conntion = baseSrtingConntion.SQLConntionString_base.Split(' ');
            DBNow.Text += DB_conntion[8];
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_addnumber = new AddNewNumber();
            m_addnumber.Show();
        }
        private void FoundBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_found = new FoundNumber();
            m_found.Show();
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            win = new mxm();
            win.Show();
        }

        private void ShowBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_ShowGrid = new ShowAllNumber();
            m_ShowGrid.Show();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_Edit = new EditNumber();
            m_Edit.Show();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_delete = new DeleteNumber();
            m_delete.Show();
        }
    }
}
