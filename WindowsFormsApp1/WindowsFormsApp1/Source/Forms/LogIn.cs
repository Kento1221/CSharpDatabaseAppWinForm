using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApp1.Source;

namespace WindowsFormsApp1
{
    public partial class CLogInForm : Form
    {
        public CLogInForm()
        {
            InitializeComponent();
            vSetupDB();
            textBox1.Text = "Kamil";
            textBox2.Text = "Orkisz";
        }

        private void vSetupDB()
        {
            using (CConnection cc_connection = new CConnection())
            {
                cc_connection.vOpenConnection();

                using (MySqlCommand command = new MySqlCommand())
                {

                    string s_query = "CREATE DATABASE IF NOT EXISTS mojabazadanych;";
                    command.CommandText = s_query;
                    command.Connection = cc_connection.MySqlConnection;

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }


                    s_query = "USE mojabazadanych; CREATE TABLE IF NOT EXISTS pracownicy (PRACOWNICY_ID INT(11) NOT NULL AUTO_INCREMENT, NAME VARCHAR(30) NOT NULL, SURNAME VARCHAR(30) NOT NULL, CITY VARCHAR(30) NOT NULL, SEX VARCHAR(1) NOT NULL, PRIMARY KEY(PRACOWNICY_ID));";
                    command.CommandText = s_query;

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                    s_query = "CREATE TABLE IF NOT EXISTS users (USERS_ID INT(11) NOT NULL AUTO_INCREMENT, USERNAME VARCHAR(30) NOT NULL, PASS VARCHAR(30) NOT NULL, PRIMARY KEY(USERS_ID));";
                    command.CommandText = s_query;

                    try { command.ExecuteNonQuery(); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                    command.Dispose();
                    cc_connection.vCloseConection();
                }//using(MySqlCommand mySqlCommand = new MySqlCommand(s_query, cc_connection.MySqlConnection))
            }//using (CConnection cc_connection = new CConnection())
        }//private void vSetupDB()


        private void button1_Click(object sender, EventArgs e)
        {
            using (CConnection cc_connection = new CConnection())
            {
                using (MySqlDataReader results = null)
                {
                    if (LogIn(textBox1.Text, textBox2.Text, cc_connection, results))
                    {
                        Hide();
                        Form form = new CMenu();
                        form.ShowDialog();
                        Close();
                    }
                }   //using (MySqlDataReader results = null)
            }//using (CConnection cc_connection = new CConnection())
        }

        private void textBox2_TextChanged(object sender, EventArgs e) => textBox2.PasswordChar = '*';

        internal bool LogIn(string sUsername, string sPassword, CConnection ccConnection, MySqlDataReader results)
        {
            ccConnection.vOpenConnection();
            string s_query = "USE mojabazadanych; SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(s_query, ccConnection.MySqlConnection);

            try { results = command.ExecuteReader(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            if (!results.HasRows)
            {
                s_query = "INSERT INTO users (USERNAME, PASS) VALUES (\"Kamil\", \"Orkisz\")";
                command.CommandText = s_query;
                results.Dispose();
                try { command.ExecuteNonQuery(); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                s_query = "INSERT INTO users (USERNAME, PASS) VALUES (\"Jan\", \"Kowalski\")";
                command.CommandText = s_query;
                try { command.ExecuteNonQuery(); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }

            s_query = "USE mojabazadanych; SELECT * FROM users WHERE USERNAME = \'" + sUsername + "\' AND PASS = \'" + sPassword + "\';";
            command.CommandText = s_query;
            results.Dispose();

            try { results = command.ExecuteReader(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            if (results != null)
                if (results.HasRows)
                {
                    short i_count = 0;
                    while (results.Read()) { i_count++; }

                    if (i_count > 1)
                    {
                        MessageBox.Show("Multiple instances of this username. Could not log in!");
                        return false;
                    }
                    else
                    {
                        CUserInfo.vSetUser(results.GetInt32(0), results.GetString(1), results.GetString(2));
                        ccConnection.Dispose();
                        return true;
                    }
                }// if (results.HasRows)
                else
                {
                    MessageBox.Show("Wrong username or password. Try again!");
                    return false;
                }
            return false;
        }//internal bool LogIn(string sUsername, string sPassword, CConnection ccConnection, MySqlDataReader results)

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/Kento1221");
            Process.Start(sInfo);
        }
    }
}
