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
    public partial class EditNumber : Form
    {
        DataTable DT_Grid_Search;
        control_number m_control;
        NumberBook m_numBook;
        model m_model;
        public EditNumber()
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
        private void Edit_bt_new_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Edit_name_new.Text) || string.IsNullOrEmpty(Edit_number_new.Text))
            {
                MessageBox.Show("The New Name Or Number Is Empty", "You Can't Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(OldNamebox.Text) || string.IsNullOrEmpty(OldNumberBox.Text))
            {
                MessageBox.Show("The Old Name Or Number Is Empty", "You Can't Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_model.Name = Edit_name_new.Text;
            m_model.number = Edit_number_new.Text;
            m_control.Edit(m_model , OldNamebox.Text , OldNumberBox.Text);
            DT_Grid_Search = m_control.ShowAllGrid(Edit_name_new.Text);
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
