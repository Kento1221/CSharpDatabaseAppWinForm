using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.Source;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            textBox1.Text = "Kamil";
            textBox2.Text = "Orkisz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Connection connection = new Connection())
            {
                using (MySqlDataReader results = null)
                {
                    if (LogIn(textBox1.Text, textBox2.Text, connection, results))
                    {
                        Hide();
                        Form form = new Menu();
                        form.ShowDialog();
                        Close();
                    }
                }   
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e) => textBox2.PasswordChar = '*';

        internal bool LogIn(string username, string password, Connection connection, MySqlDataReader results)
        {
                connection.OpenConnection();

                string query = "SELECT * FROM users WHERE NAME = \'"+username+"\' AND PASS = \'"+password+"\';";
                MySqlCommand command = new MySqlCommand(query, connection.MySqlConnection);

                try { results = command.ExecuteReader(); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                
                if(results!=null)
                    if (results.HasRows)
                    {
                        short count = 0;
                        while (results.Read()) { count++; }
                
                        if(count > 1)
                        {
                            MessageBox.Show("Multiple instances of this username. Could not log in!");
                            return false;
                        }
                        else
                        {
                            UserInfo.SetUser(results.GetInt32(0), results.GetString(1), results.GetString(2));
                            connection.Dispose();
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password. Try again!");
                        return false;
                    }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
