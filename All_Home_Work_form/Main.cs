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
    public partial class mxm : Form
    {
        NumberBook m_numberBook ;
        DatacaseConntion m_ConDLG;
        createDataBase m_CreateDLG;
        control_number m_Contr;
        public mxm()
        {
            InitializeComponent();
        }

        private void Book_number_Click(object sender, EventArgs e)
        {
            m_Contr = new control_number();
            if (m_Contr.TestCon())
            {
                this.Hide();
                m_numberBook = new NumberBook();
                m_numberBook.Show();
            }
            else
            {
                MessageBox.Show("You are Not Conntion To server", "Error Conntion ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Regster_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_ConDLG = new DatacaseConntion();
            m_ConDLG.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            DialogResult end = MessageBox.Show("You Want Exit", "Make Suer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (end == DialogResult.OK)
            {
                Application.Exit();              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_CreateDLG = new createDataBase();
            m_CreateDLG.Show();
        }
    }
}
