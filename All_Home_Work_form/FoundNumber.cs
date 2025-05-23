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
    public partial class FoundNumber : Form
    {
        NumberBook m_numBook;
        control_number m_control;
        model m_model;
        public FoundNumber()
        {
            InitializeComponent();
            m_control = new control_number();
            m_model = new model();
        }

        private void Found_Click(object sender, EventArgs e)
        {
            if (NameBOX.Text == String.Empty && string.IsNullOrEmpty(NumberBox.Text))
            {
                MessageBox.Show("Name Or Number Is Empty", "You Can't Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_model.Name = NameBOX.Text;
            m_model.number = NumberBox.Text;
            if (m_control.found_number(ref m_model))
            {
                if (m_model.Name != string.Empty && m_model.number != string.Empty)
                {
                    Result.Text = "Name : " + m_model.Name + ", Phone : " + m_model.number;
                }
                else
                {
                    Result.Text = "Not Found !";
                }             
            }
        }
        private void ExitBt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_numBook = new NumberBook();
            m_numBook.ShowDialog();
        }
    }
}
