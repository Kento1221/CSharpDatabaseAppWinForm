using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        private UserControl activeControl = null;
        private Button activeButton = null;

        public Menu()
        {
            InitializeComponent();
            SwitchControls(homeControl1, homeButton);
            if(notificationController1.getNotificationCount() == 0){
                notificationCountLabel.Visible = false;
            }
            else if(notificationController1.getNotificationCount() >= 10)
            {
                notificationCountLabel.Text = "!!";
            }
            else
                notificationCountLabel.Text = notificationController1.getNotificationCount()+"";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SwitchControls(addPersonControl1, addButton);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SwitchControls(searchPersonControl1, showButton);
        }

        private void SwitchControls(UserControl control, Button button)
        {
            if(activeControl == null)
            {
                activeControl = control;
                activeControl.BringToFront();
                activeButton = button;
            }
            else if(control != activeControl)
            {
                activeButton.BackColor = Color.FromArgb(30, 30, 30);
                activeButton = button;
                activeControl.SendToBack();
                activeControl = control;
                activeControl.BringToFront();
            }

            activeButton.BackColor = Color.FromArgb(40, 40, 40);
            highlightPanel.Top = button.Top;
            highlightPanel.Height = button.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            SwitchControls(homeControl1, homeButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (notificationController1.Visible)
            {
                notificationController1.Hide();

            }
            else{
                notificationController1.Show();
                notificationController1.BringToFront();
                notificationController1.Height = notificationController1.Label.Bottom + 10;
            }
        }
    }
}
