using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CConnection : IDisposable
    {
        bool b_disposed = false;
        SafeHandle sh_handle = new SafeFileHandle(IntPtr.Zero, true);

        private const string s_connectionString = "Server = localhost; User Id = root; Password = ; charset = utf8;";

        public CConnection() => MySqlConnection = new MySqlConnection(s_connectionString);

        public MySqlConnection MySqlConnection { get; }

        public void vOpenConnection()
        {
            try
            {
                MySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the server.\n\n\n" + ex);
            }
        }//public void vOpenConnection()


        public void vCloseConection() => MySqlConnection.Close();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }//public void Dispose()

        protected virtual void Dispose(bool disposing)
        {
            if (b_disposed)
                return;

            if (disposing)
            {
                sh_handle.Dispose();
                MySqlConnection.Dispose();
            }//if (disposing)

            b_disposed = true;
        }//protected virtual void Dispose(bool disposing)
    }//public class CConnection : IDisposable
}
