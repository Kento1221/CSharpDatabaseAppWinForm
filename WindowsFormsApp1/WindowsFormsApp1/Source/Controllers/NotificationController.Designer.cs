namespace WindowsFormsApp1.Source.Controllers
{
    partial class NotificationController
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bodyNotificationLabel = new System.Windows.Forms.Label();
            this.nameNotification = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyNotificationLabel
            // 
            this.bodyNotificationLabel.AutoSize = true;
            this.bodyNotificationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodyNotificationLabel.ForeColor = System.Drawing.Color.White;
            this.bodyNotificationLabel.Location = new System.Drawing.Point(24, 20);
            this.bodyNotificationLabel.Name = "bodyNotificationLabel";
            this.bodyNotificationLabel.Size = new System.Drawing.Size(36, 13);
            this.bodyNotificationLabel.TabIndex = 0;
            this.bodyNotificationLabel.Text = "label1";
            // 
            // nameNotification
            // 
            this.nameNotification.AutoSize = true;
            this.nameNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nameNotification.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameNotification.ForeColor = System.Drawing.Color.White;
            this.nameNotification.Location = new System.Drawing.Point(3, 0);
            this.nameNotification.Name = "nameNotification";
            this.nameNotification.Size = new System.Drawing.Size(92, 17);
            this.nameNotification.TabIndex = 2;
            this.nameNotification.Text = "Notifications:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 17);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.nameNotification);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bodyNotificationLabel);
            this.Name = "NotificationController";
            this.Size = new System.Drawing.Size(200, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bodyNotificationLabel;
        private System.Windows.Forms.Label nameNotification;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
