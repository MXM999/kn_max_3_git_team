using System;
using System.Data.SqlClient;
using System.Data;

namespace All_Home_Work_form
{
    internal class control_number : baseSrtingConntion
    {
                       
        SqlConnection con;
        SqlCommand cmda;
        SqlDataReader reader;
        SqlDataAdapter DaGrid;
        DataTable DT;
      
        public bool TestCon()
        {
          if (SQLConntionString_base == null)
            {
                return false;
            }
          return true;
        }
        public void openCon()
        {
            con = new SqlConnection(SQLConntionString_base);
            con.Open();
        }
        public void CloseCon()
        {
            con.Close();
        }
        public void add_number(model data_ui)
        {  
            openCon();           
            string qur = "INSERT INTO NUMBERS VALUES ('" +data_ui.Name+"' , '" +data_ui.number+ "')";
            cmda = new SqlCommand(qur, con);
            cmda.ExecuteNonQuery();
            CloseCon();
        }

        public bool found_number( ref model data_read_To_UI)
        {
            openCon();
            string qur = "SELECT * FROM NUMBERS WHERE FULL_NAME = @name OR PHONE = @phone";
            cmda = new SqlCommand(qur, con);
            cmda.Parameters.AddWithValue("@name", data_read_To_UI.Name);
            cmda.Parameters.AddWithValue("@phone", data_read_To_UI.number);
            reader = cmda.ExecuteReader();
            if (reader.Read())
            {
                data_read_To_UI.Name = reader.GetSqlValue(1).ToString();
                data_read_To_UI.number = reader.GetSqlValue(2).ToString();
            }
            else
            {
                data_read_To_UI.Name = null;
                data_read_To_UI.number = null;
            }
            CloseCon();
            return true;
        }

        public DataTable ShowAllGrid()
        {
            openCon();
            string qur = "SELECT FULL_NAME , PHONE FROM NUMBERS";
            DaGrid = new SqlDataAdapter(qur, con);
            DT = new DataTable();
            DaGrid.Fill(DT);
            CloseCon();
            return DT;
        }
        public DataTable ShowAllGrid(string filter)
        {
            openCon();
            string qur = "SELECT FULL_NAME , PHONE FROM NUMBERS WHERE FULL_NAME = @Filt";
            DaGrid = new SqlDataAdapter(qur, con);
            DaGrid.SelectCommand.Parameters.AddWithValue("@Filt", filter);
            DT = new DataTable();
            DaGrid.Fill(DT);
            CloseCon();
            return DT;
        }
        public void Edit(model data_read_from_UI , string send_name , string send_number)
        {
            openCon();
            string qur = @"UPDATE NUMBERS
                           SET FULL_NAME = @name , PHONE = @phone
                           WHERE FULL_NAME = @sendName AND PHONE = @sendNumber";
            cmda = new SqlCommand(qur, con);
            cmda.Parameters.AddWithValue("@name", data_read_from_UI.Name);
            cmda.Parameters.AddWithValue("@phone", data_read_from_UI.number);
            cmda.Parameters.AddWithValue("@sendName", send_name);
            cmda.Parameters.AddWithValue("@sendNumber", send_number);
            cmda.ExecuteNonQuery();
            CloseCon();
        }
        public void delete (model data_read_from_UI)
        {
            openCon();
            string qur = "DELETE FROM NUMBERS WHERE FULL_NAME = @name AND PHONE = @phone";
            cmda = new SqlCommand(qur, con);
            cmda.Parameters.AddWithValue("@name", data_read_from_UI.Name);
            cmda.Parameters.AddWithValue("@phone", data_read_from_UI.number);
            cmda.ExecuteNonQuery();
            CloseCon();
        }
     
    }
}
