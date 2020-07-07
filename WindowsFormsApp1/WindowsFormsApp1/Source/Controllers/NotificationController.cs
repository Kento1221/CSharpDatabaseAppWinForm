using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Source.Controllers
{
    public partial class NotificationController : UserControl
    {

        public Label lLabel;

        public NotificationController()
        {
            InitializeComponent();


                lLabel = bodyNotificationLabel;
                bodyNotificationLabel.Text = "You have "+iGetNotificationCount()+" notification(s).";

        }   

        //TODO...
        public int iGetNotificationCount()
        {
            return 1;
        }
    }
}
