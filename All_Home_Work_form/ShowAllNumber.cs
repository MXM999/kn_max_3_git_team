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
    public partial class ShowAllNumber : Form
    {
        control_number m_control;
        DataTable DT_Grid;
        NumberBook m_numBook;
        public ShowAllNumber()
        {
            InitializeComponent();
            m_control = new control_number();
            DT_Grid = new DataTable();
        }
        private void Show_bt_Click(object sender, EventArgs e)
        {
            DT_Grid = m_control.ShowAllGrid();
            NumberGrid.DataSource = DT_Grid;
        }
        private void Exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
            m_numBook = new NumberBook();
            m_numBook.ShowDialog();
        }
    }
}
