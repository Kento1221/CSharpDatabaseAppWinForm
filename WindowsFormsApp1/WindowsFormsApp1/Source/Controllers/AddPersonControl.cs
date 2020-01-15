using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Source
{
    public partial class AddPersonController : UserControl
    {
        private const string EMPTY = "";

        private DataTable dt_dataTable;

        public AddPersonController()
        {
            InitializeComponent();
            vInitializeDataTable();
            errorLabel1.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != EMPTY && surnameBox.Text != EMPTY && cityBox.Text != EMPTY && (maleRadio.Checked || femaleRadio.Checked))
            {
                dt_dataTable.Rows.Add(nameBox.Text, surnameBox.Text, cityBox.Text, maleRadio.Checked);
                vClearInput();
                errorLabel1.Visible = false;
            }//if
            else { errorLabel1.Visible = true; }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (dt_dataTable.Rows.Count > 0)
            {
                int i_count = dt_dataTable.Rows.Count;

                using (CConnection cc_connection = new CConnection())
                {
                    foreach (DataRow dr_row in dt_dataTable.Rows)
                    {
                        bool b_isComplete = true;
                        for (short ii = 0; ii < dt_dataTable.Columns.Count; ii++)
                        {
                            if (dr_row[ii].ToString() == "" || dr_row[ii] == null)
                            {
                                b_isComplete = false;
                                i_count--;
                                break;
                            }
                        }//for (short ii = 0; ii < dt_dataTable.Columns.Count; ii++)

                        if (b_isComplete)
                        {
                            string s_query = "INSERT INTO pracownicy (NAME, SURNAME, CITY, SEX) VALUES (\"" + dr_row[0].ToString() + "\",\"" + dr_row[1].ToString() + "\",\"" + dr_row[2].ToString() + "\"," + dr_row[3].ToString() + ");";
                            MySqlCommand command = new MySqlCommand(s_query, cc_connection.MySqlConnection);

                            cc_connection.vOpenConnection();
                            command.ExecuteNonQuery();
                            cc_connection.vCloseConection();
                        }//if (b_isComplete)
                    }//foreach (DataRow dr_row in dt_dataTable.Rows)
                }//using (CConnection cc_connection = new CConnection())

                try
                {
                    dt_dataTable.Rows.Clear();
                }
                catch (InvalidConstraintException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show(i_count + " row(s) added!");
            }//if (dt_dataTable.Rows.Count > 0)
            else
            {
                MessageBox.Show("There is no records to enter into the database.");
            }
        }

        private void vClearInput()
        {
            nameBox.Clear();
            surnameBox.Clear();
            cityBox.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
        }

        private void vInitializeDataTable()
        {
            string[] ps_collumns = { "Name", "Surname", "City", "Sex" };
            Type[] pt_types = { typeof(string), typeof(string), typeof(string), typeof(bool) };

            dt_dataTable = new DataTable();

            for (int ii = 0; ii < ps_collumns.Length; ii++)
                dt_dataTable.Columns.Add(ps_collumns[ii], pt_types[ii]);

            BindingSource bs_bindingSource = new BindingSource();
            bs_bindingSource.DataSource = dt_dataTable;
            dataGridView1.DataSource = bs_bindingSource;
        }
    }
}
