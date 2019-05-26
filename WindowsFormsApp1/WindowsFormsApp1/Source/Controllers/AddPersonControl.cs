using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Source
{
    public partial class AddPersonController : UserControl
    {
        private const string EMPTY = "";
        
        private DataTable dataTable;

        public AddPersonController()
        {
            InitializeComponent();
            InitializeDataTable();
            errorLabel1.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != EMPTY && surnameBox.Text != EMPTY && cityBox.Text != EMPTY && (maleRadio.Checked || femaleRadio.Checked))
            {
                dataTable.Rows.Add(nameBox.Text, surnameBox.Text, cityBox.Text, maleRadio.Checked);
                ClearInput();
                errorLabel1.Visible = false;
            }
            else{ errorLabel1.Visible = true; }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                int count = dataTable.Rows.Count;
                using (Connection connection = new Connection())
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        bool isComplete = true;
                        for (short i = 0; i < dataTable.Columns.Count; i++)
                        {
                            if (row[i].ToString() == "" || row[i] == null)
                            {
                                isComplete = false;
                                count--;
                                break;
                            }
                        }

                        if (isComplete)
                        {
                            string query = "INSERT INTO pracownicy (NAME, SURNAME, CITY, SEX) VALUES (\"" + row[0].ToString() + "\",\"" + row[1].ToString() + "\",\"" + row[2].ToString() + "\"," + row[3].ToString() + ");";
                            MySqlCommand command = new MySqlCommand(query, connection.MySqlConnection);

                            connection.OpenConnection();
                            command.ExecuteNonQuery();
                            connection.CloseConection();
                        }
                    }
                }

                try
                {
                    dataTable.Rows.Clear();
                }
                catch (InvalidConstraintException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show(count + " row(s) added!");
            }
            else{ MessageBox.Show("There is no records to enter into the database."); }
        }

        private void ClearInput()
        {
            nameBox.Clear();
            surnameBox.Clear();
            cityBox.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
        }

        private void InitializeDataTable()
        {
            string[] collumns = { "Name", "Surname", "City", "Sex" };
            Type[] types = { typeof(string), typeof(string), typeof(string), typeof(bool) };

            dataTable = new DataTable();

            for (int i = 0; i < collumns.Length; i++)
                dataTable.Columns.Add(collumns[i], types[i]);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
