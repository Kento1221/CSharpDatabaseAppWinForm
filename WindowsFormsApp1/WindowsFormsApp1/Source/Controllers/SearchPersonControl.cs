using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Source.Controllers
{
    public partial class SearchPersonControl : UserControl
    {
        private string[] ps_parameters = { "@pracownicy_id", "@name", "@surname", "@city", "@sex" };

        private DataTable dt_dataTable;
        private DataTable dt_dataTableCopy;

        public SearchPersonControl()
        {
            InitializeComponent();
        }

        private void LoadAll_Click(object sender, EventArgs e)
        {
            using (CConnection cc_connection = new CConnection())
            {
                string s_query = "SELECT PRACOWNICY_ID as ID, NAME as Name, SURNAME as Surname, CITY as City, SEX as Sex FROM pracownicy";
                MySqlCommand command = new MySqlCommand(s_query, cc_connection.MySqlConnection);
                PullAll(cc_connection, command);
            }//using (CConnection cc_connection = new CConnection())
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (CConnection cc_connection = new CConnection())
            {
                string s_query = "SELECT PRACOWNICY_ID as ID, NAME as Name, SURNAME as Surname, CITY as City, SEX as Sex FROM pracownicy WHERE (@pracownicy_id = \"\" OR PRACOWNICY_ID = @pracownicy_id) AND " +
                    "(@name = \"\" OR NAME = @name) AND " +
                    "(@surname = \"\" OR SURNAME = @surname) AND " +
                    "(@city = \"\" OR CITY = @city) AND " +
                    "(@sex IS NULL OR SEX = @sex);";
                MySqlCommand command = new MySqlCommand(s_query, cc_connection.MySqlConnection);
                command = GenerateParams(command);
                foreach (MySqlParameter parameter in command.Parameters)
                {
                    if (parameter.Value != (object)"" && parameter.Value != null)
                        PullAll(cc_connection, command);
                }//foreach (MySqlParameter parameter in command.Parameters)
            }//using (CConnection cc_connection = new CConnection())
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IDBox.Clear();
            NameBox.Clear();
            SurnameBox.Clear();
            CityBox.Clear();
            MaleRadio.Checked = false;
            FemaleRadio.Checked = false;
        }

        private void PullAll(CConnection connection, MySqlCommand command)
        {
            if (dt_dataTable != null)
            {
                dt_dataTable = null;
                dt_dataTableCopy = null;
            }

            connection.vOpenConnection();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                dt_dataTable = new DataTable();
                adapter.Fill(dt_dataTable);
                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = dt_dataTable;
                PracownicyGrid.DataSource = bindingSource;
                adapter.Update(dt_dataTable);
                dt_dataTableCopy = dt_dataTable.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.vCloseConection();

        }

        private MySqlCommand GenerateParams(MySqlCommand Cmd)
        {
            foreach (string s_param in ps_parameters)
            {
                MySqlParameter param = new MySqlParameter();
                param.ParameterName = s_param;
                switch (s_param)
                {
                    case "@pracownicy_id":
                        param.Value = IDBox.Text;
                        break;
                    case "@name":
                        param.Value = NameBox.Text;
                        break;
                    case "@surname":
                        param.Value = SurnameBox.Text;
                        break;
                    case "@city":
                        param.Value = CityBox.Text;
                        break;
                    case "@sex":
                        if (FemaleRadio.Checked)
                            param.Value = 0;
                        else if (MaleRadio.Checked)
                            param.Value = 1;
                        break;
                    default:
                        break;
                }//switch (s_param)
                Cmd.Parameters.Add(param);
            }//foreach (string s_param in ps_parameters)
            return Cmd;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (CConnection cc_connection = new CConnection())
            {
                if (dt_dataTable != null && dt_dataTableCopy != null)
                    if (dt_dataTable.Rows.Count == dt_dataTableCopy.Rows.Count)
                    {
                        for (int i_row = 0; i_row < dt_dataTable.Rows.Count; i_row++)
                        {
                            for (int i_col = 0; i_col < dt_dataTable.Columns.Count; i_col++)
                            {
                                try
                                {
                                    if (!dt_dataTable.Rows[i_row].ItemArray[i_col].Equals(dt_dataTableCopy.Rows[i_row].ItemArray[i_col]))
                                    {
                                        if (i_col == 0)
                                        {
                                            MessageBox.Show("ID doesn't match up. Try again, please! \nLoad all again if needed.");
                                            return;
                                        }
                                        //TODO: Make sure that you cannot edit the row's cells empty
                                        string s_query = "UPDATE pracownicy SET NAME = \"" + dt_dataTable.Rows[i_row].ItemArray[1] + "\", SURNAME = \"" + dt_dataTable.Rows[i_row].ItemArray[2] + "\", CITY = \"" + dt_dataTable.Rows[i_row].ItemArray[3] + "\", SEX = " + dt_dataTable.Rows[i_row].ItemArray[4] + " WHERE PRACOWNICY_ID = " + (int)dt_dataTableCopy.Rows[i_row].ItemArray[0] + ";";

                                        MySqlCommand cmd = new MySqlCommand(s_query, cc_connection.MySqlConnection);

                                        cc_connection.vOpenConnection();
                                        cmd.ExecuteNonQuery();
                                        cc_connection.vCloseConection();
                                    }//if (!dt_dataTable.Rows[i_row].ItemArray[i_col].Equals(dt_dataTableCopy.Rows[i_row].ItemArray[i_col]))
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("A row has been deleted incorrectly. \nTo delete a row use the delete button. \nPlease try again.");
                                    return;
                                }
                            }//for (int i_col = 0; i_col < dt_dataTable.Columns.Count; i_col++)
                        }//for (int i_row = 0; i_row < dt_dataTable.Rows.Count; i_row++)
                        DialogResult dr_result = MessageBox.Show("Changes have been saved.");
                    }//if (dt_dataTable.Rows.Count == dt_dataTableCopy.Rows.Count)
            }//using (CConnection cc_connection = new CConnection())
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (PracownicyGrid.SelectedRows.Count > 0)
            {
                CConnection cc_connection = new CConnection();

                DialogResult dr_result = MessageBox.Show("Are you sure you want to delete " + PracownicyGrid.SelectedRows.Count + " row(s) from the table and database permanently?", "Delete selected row(s)?", MessageBoxButtons.YesNo);

                if (dr_result == DialogResult.Yes)
                    foreach (DataGridViewCell dgvc_selectedCell in PracownicyGrid.SelectedCells)
                    {
                        if (dgvc_selectedCell.Selected)
                        {
                            string s_query = "DELETE FROM pracownicy WHERE PRACOWNICY_ID = " + dgvc_selectedCell.Value + ";";
                            try { PracownicyGrid.Rows.RemoveAt(dgvc_selectedCell.RowIndex); }
                            catch (Exception) { MessageBox.Show("Make sure you select only existing rows."); break; }

                            MySqlCommand cmd = new MySqlCommand(s_query, cc_connection.MySqlConnection);

                            cc_connection.vOpenConnection();
                            try { cmd.ExecuteNonQuery(); }
                            catch (Exception) { return; }
                            cc_connection.vCloseConection();
                        }//if (dgvc_selectedCell.Selected)
                    }//foreach (DataGridViewCell dgvc_selectedCell in PracownicyGrid.SelectedCells)
                dt_dataTable.Clear();
            }//if (PracownicyGrid.SelectedRows.Count > 0)
        }
    }
}
