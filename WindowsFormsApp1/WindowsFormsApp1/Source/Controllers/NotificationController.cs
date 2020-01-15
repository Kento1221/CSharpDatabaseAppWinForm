using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Source.interfaces;

namespace WindowsFormsApp1.Source.Controllers
{
    public partial class NotificationController : UserControl
    {

        private Queue<INotification> q_notifications = new Queue<INotification>();
        private Dictionary<string, INotification> dict_notificationType;
        public Label lLabel;
        private string s_filePath = @"..\..\Source\Files\nots.txt";

        public NotificationController()
        {
            InitializeComponent();
            vInitializeNotifications();
            //CheckNotifications();

            if (q_notifications != null)
            {
                //TODO: Add blank notification to be an element of the List.
                lLabel = bodyNotificationLabel;
                bodyNotificationLabel.Text = "You have no notifications.";
            }

            //WriteNotificationsToFile();
        }

        private void vInitializeNotifications()
        {
            dict_notificationType = new Dictionary<string, INotification>();

            dict_notificationType.Add("P", new CProblemNotification());
        }

        //TODO: Creates a file with notifications that are valid for the user. Also cleans all already-seen ones from the file.
        private void vCheckNotifications()
        {
            if (!Directory.Exists(@"..\..\Source\Files"))
            {
                Directory.CreateDirectory(@"..\..\Source\Files");
            }
            if (!File.Exists(s_filePath))
            {
                File.Create(s_filePath);
            }

            var fs_fileStream = new FileStream(s_filePath, FileMode.Open, FileAccess.ReadWrite);
            using (var sr_streamReader = new StreamReader(fs_fileStream, Encoding.UTF8))
            {
                string s_line;
                while ((s_line = sr_streamReader.ReadLine()) != null)
                {
                    try
                    {
                        string[] ps_readline = s_line.Split(';');
                        INotification in_notification = dict_notificationType[ps_readline[0]];
                        in_notification.Notify(ps_readline[1], ps_readline[2]);
                        q_notifications.Enqueue(in_notification);
                    }
                    catch (Exception ex)
                    {
                        //InvalidInput if someone broke the file
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            fs_fileStream.Close();
        }

        private void vWriteNotificationsToFile()
        {
            FileStream fs_fileStream = new FileStream(s_filePath, FileMode.Open, FileAccess.Write);

            var sw_streamWriter = new StreamWriter(fs_fileStream, Encoding.UTF8);
            while (q_notifications.Count != 0)
            {
                INotification in_notification = q_notifications.Dequeue();
                sw_streamWriter.WriteLine(in_notification.ToString());
            }
            sw_streamWriter.Close();
        }

        public int iGetNotificationCount()
        {
            return q_notifications.Count;
        }
    }
}
