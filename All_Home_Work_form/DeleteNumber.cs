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
    public partial class DeleteNumber : Form
    {
        DataTable DT_Grid_Search;
        control_number m_control;
        NumberBook m_numBook;
        model m_model;
        public DeleteNumber()
        {
            InitializeComponent();
            m_control = new control_number();
            DT_Grid_Search = new DataTable();
            m_model = new model();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            DT_Grid_Search = m_control.ShowAllGrid(seacrh_textBox.Text);
            SerachGrid.DataSource = DT_Grid_Search;
        }
        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Delete_name.Text) || string.IsNullOrEmpty(Delete_number.Text))
            {
                MessageBox.Show("Name Or Number Is Empty", "You Can't Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_model.Name = Delete_name.Text;
            m_model.number = Delete_number.Text;
            m_control.delete(m_model);
            DT_Grid_Search = m_control.ShowAllGrid(seacrh_textBox.Text);
            SerachGrid.DataSource = DT_Grid_Search;
        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_numBook = new NumberBook();
            m_numBook.ShowDialog();
        }
    }
}
