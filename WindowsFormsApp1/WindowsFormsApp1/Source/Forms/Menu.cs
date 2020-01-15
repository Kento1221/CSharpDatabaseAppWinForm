using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Source;

namespace WindowsFormsApp1
{
    public partial class CMenu : Form
    {
        private UserControl uc_activeControl = null;
        private Button bu_activeButton = null;
        public CMenu()
        {
            InitializeComponent();
            vSwitchControls(homeControl1, homeButton);
            label2.Text = CUserInfo.sGetUser(0) + " " + CUserInfo.sGetUser(1);
            if (notificationController1.iGetNotificationCount() == 0)
            {
                notificationCountLabel.Visible = false;
            }
            else if (notificationController1.iGetNotificationCount() >= 10)
            {
                notificationCountLabel.Text = "!!";
            }
            else
                notificationCountLabel.Text = notificationController1.iGetNotificationCount() + "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            vSwitchControls(addPersonControl1, addButton);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            vSwitchControls(searchPersonControl1, showButton);
        }

        private void vSwitchControls(UserControl ucControl, Button buButton)
        {
            if (uc_activeControl == null)
            {
                uc_activeControl = ucControl;
                uc_activeControl.BringToFront();
                bu_activeButton = buButton;
            }
            else if (ucControl != uc_activeControl)
            {
                bu_activeButton.BackColor = Color.FromArgb(30, 30, 30);
                bu_activeButton = buButton;
                uc_activeControl.SendToBack();
                uc_activeControl = ucControl;
                uc_activeControl.BringToFront();
            }

            bu_activeButton.BackColor = Color.FromArgb(40, 40, 40);
            highlightPanel.Top = buButton.Top;
            highlightPanel.Height = buButton.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            vSwitchControls(homeControl1, homeButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (notificationController1.Visible)
            {
                notificationController1.Hide();

            }
            else
            {
                notificationController1.Show();
                notificationController1.BringToFront();
                notificationController1.Height = notificationController1.lLabel.Bottom + 10;
            }
        }
    }
}
