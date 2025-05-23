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
    public partial class AddNewNumber : Form
    {
        NumberBook m_numBook;
        control_number m_control;
        model m_model;
        public AddNewNumber()
        {
            InitializeComponent();
            m_model = new model();
            m_control = new control_number();
        }

        private void ADDBt_Click(object sender, EventArgs e)
        {
            if (NameBOX.Text == String.Empty || string.IsNullOrEmpty( NumberBox.Text))
            {
                MessageBox.Show("Name Or Number Is Empty" , "You Can't Add" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }           
            m_model.Name = NameBOX.Text;
            m_model.number = NumberBox.Text;        
            m_control.add_number(m_model);
        }
        private void ExitBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_numBook = new NumberBook();
            m_numBook.ShowDialog();
        }
    }
}
