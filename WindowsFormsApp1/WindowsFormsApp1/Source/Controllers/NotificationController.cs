using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Source.interfaces;
using System.IO;

namespace WindowsFormsApp1.Source.Controllers
{
    public partial class NotificationController : UserControl
    {

        private Queue<INotification> notifications = new Queue<INotification>();
        private Dictionary<string, INotification> notificationType;
        public Label Label;
        private string filePath = @"..\..\Source\Files\nots.txt";

        public NotificationController()
        {
            InitializeComponent();
            InitializeNotifications();
            //CheckNotifications();
            
            if (notifications != null)
            {
                //TODO: Add blank notification to be an element of the List.
                Label = bodyNotificationLabel;
                bodyNotificationLabel.Text = "You have no notifications.";
            }

            //WriteNotificationsToFile();
        }

        private void InitializeNotifications()
        {
            notificationType = new Dictionary<string, INotification>();

            notificationType.Add("P", new ProblemNotification());
        }

        //TODO: Creates a file with notifications that are valid for the user. Also cleans all seen ones from the file.
        private void CheckNotifications()
        {
            if (!Directory.Exists(@"..\..\Source\Files"))
            {
                Directory.CreateDirectory(@"..\..\Source\Files");
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    try
                    {
                        string[] readline = line.Split(';');
                        INotification notification = notificationType[readline[0]];
                        notification.Notify(readline[1], readline[2]);
                        notifications.Enqueue(notification);
                    }
                    catch (Exception ex)
                    {
                        //InvalidInput if someone broke the file
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            fileStream.Close();
        }

        private void WriteNotificationsToFile()
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write );

            var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            while(notifications.Count != 0)
            {
                INotification notification = notifications.Dequeue();
                streamWriter.WriteLine(notification.ToString());
            }
            streamWriter.Close();
        }

        public int getNotificationCount()
        {
            return notifications.Count;
        }
    }
}
