using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Source.Controllers
{
    public partial class SearchPersonControl : UserControl
    {
        private string[] parameters = { "@id", "@name", "@surname", "@city", "@sex" };

        private DataTable dataTable;
        private DataTable dataTableCopy;

        public SearchPersonControl()
        {
            InitializeComponent();
        }

        private void LoadAll_Click(object sender, EventArgs e)
        {
            using (Connection connection = new Connection())
            {
                string query = "SELECT ID, NAME as Name, SURNAME as Surname, CITY as City, SEX as Sex FROM pracownicy";
                MySqlCommand command = new MySqlCommand(query, connection.MySqlConnection);
                PullAll(connection, command);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (Connection connection = new Connection())
            {
                string query = "SELECT ID, NAME as Name, SURNAME as Surname, CITY as City, SEX as Sex FROM pracownicy WHERE (@id = \"\" OR ID = @id) AND " +
                    "(@name = \"\" OR NAME = @name) AND " +
                    "(@surname = \"\" OR SURNAME = @surname) AND " +
                    "(@city = \"\" OR CITY = @city) AND " +
                    "(@sex IS NULL OR SEX = @sex);";
                MySqlCommand command = new MySqlCommand(query, connection.MySqlConnection);
                command = GenerateParams(command);
                foreach (MySqlParameter parameter in command.Parameters)
                {
                    if (parameter.Value != (object)"" && parameter.Value != null)
                        PullAll(connection, command);
                }
            }
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

        private void PullAll(Connection connection, MySqlCommand command)
        {
            if (dataTable != null )
            {
                dataTable = null;
                dataTableCopy = null;
            }

            connection.OpenConnection();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = dataTable;
                PracownicyGrid.DataSource = bindingSource;
                adapter.Update(dataTable);
                dataTableCopy = dataTable.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.CloseConection();

        }

        private MySqlCommand GenerateParams(MySqlCommand cmd)
        {
            foreach (string str in parameters)
            {
                MySqlParameter param = new MySqlParameter();
                param.ParameterName = str;
                switch (str)
                {
                    case "@id":
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
                }
                cmd.Parameters.Add(param);
            }
            return cmd;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (Connection connection = new Connection())
            {
                if (dataTable != null && dataTableCopy != null)
                    if (dataTable.Rows.Count == dataTableCopy.Rows.Count)
                    {
                        for (int row = 0; row < dataTable.Rows.Count; row++)
                        {
                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                try
                                {
                                    if (!dataTable.Rows[row].ItemArray[col].Equals(dataTableCopy.Rows[row].ItemArray[col]))
                                    {
                                        if (col == 0)
                                        {
                                            MessageBox.Show("ID doesn't match up. Try again, please! \nLoad all again if needed.");
                                            return;
                                        }
                                        //TODO: Make sure that you cannot edit the row's cells empty
                                        string query = "UPDATE pracownicy SET NAME = \"" + dataTable.Rows[row].ItemArray[1] + "\", SURNAME = \"" + dataTable.Rows[row].ItemArray[2] + "\", CITY = \"" + dataTable.Rows[row].ItemArray[3] + "\", SEX = " + dataTable.Rows[row].ItemArray[4] + " WHERE ID = " + (int)dataTableCopy.Rows[row].ItemArray[0] + ";";

                                        var cmd = new MySqlCommand(query, connection.MySqlConnection);

                                        connection.OpenConnection();
                                        cmd.ExecuteNonQuery();
                                        connection.CloseConection();

                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("A row has been deleted incorrectly. \nTo delete a row use the delete button. \nPlease try again.");
                                    return;
                                }


                            }
                        }
                    }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (PracownicyGrid.SelectedRows.Count > 0)
            {
                Connection connection = new Connection();

                DialogResult result = MessageBox.Show("Are you sure you want to delete "+ PracownicyGrid.SelectedRows.Count + " row(s) from the table and database permanently?", "Delete selected row(s)?", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                    foreach (DataGridViewCell selectedCell in PracownicyGrid.SelectedCells)
                    {
                        if (selectedCell.Selected)
                        {
                            var query = "DELETE FROM pracownicy WHERE ID = " + selectedCell.Value + ";";
                            try { PracownicyGrid.Rows.RemoveAt(selectedCell.RowIndex); }
                            catch (Exception) { MessageBox.Show("Make sure you select only existing rows."); break; }

                            MySqlCommand cmd = new MySqlCommand(query, connection.MySqlConnection);

                            connection.OpenConnection();
                            try { cmd.ExecuteNonQuery(); }
                            catch (Exception) { return; }
                            connection.CloseConection();



                        }
                    }
                    dataTable.Clear();
            }
        }
    }
}
