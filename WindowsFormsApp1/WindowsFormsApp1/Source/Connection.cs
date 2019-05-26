using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class Connection : IDisposable
    {
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private const string connectionString = "Server = localhost; Database = mojabazadanych; User Id = root; Password = ; charset = utf8;";

        public Connection() => MySqlConnection = new MySqlConnection(connectionString);

        public MySqlConnection MySqlConnection { get; }

        public void OpenConnection()
        {
            try
            {
                MySqlConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseConection() => MySqlConnection.Close();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                MySqlConnection.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
    }
}
