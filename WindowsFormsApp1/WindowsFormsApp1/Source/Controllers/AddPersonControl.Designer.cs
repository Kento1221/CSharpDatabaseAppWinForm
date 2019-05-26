namespace WindowsFormsApp1.Source
{
    partial class AddPersonController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonController));
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.errorLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.errorLabel1.ForeColor = System.Drawing.Color.Red;
            this.errorLabel1.Location = new System.Drawing.Point(49, 108);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel1.Size = new System.Drawing.Size(158, 13);
            this.errorLabel1.TabIndex = 27;
            this.errorLabel1.Text = "You have to fill all the boxes!";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Gold;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.enterButton.Image = global::WindowsFormsApp1.Properties.Resources.round_checkmark_icon_16;
            this.enterButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.enterButton.Location = new System.Drawing.Point(384, 378);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(139, 25);
            this.enterButton.TabIndex = 21;
            this.enterButton.Text = "           Enter";
            this.enterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, -1);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(295, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(163, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 237);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.TabStop = false;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.maleRadio.Location = new System.Drawing.Point(3, 19);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(36, 17);
            this.maleRadio.TabIndex = 18;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "M";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.femaleRadio.Location = new System.Drawing.Point(472, 53);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(31, 17);
            this.femaleRadio.TabIndex = 19;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "F";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(298, 52);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(118, 20);
            this.cityBox.TabIndex = 17;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(166, 52);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(126, 20);
            this.surnameBox.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Gold;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addButton.Location = new System.Drawing.Point(49, 78);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 25);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "     Add";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(49, 52);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(111, 20);
            this.nameBox.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maleRadio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(422, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 39);
            this.panel1.TabIndex = 28;
            // 
            // AddPersonController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.panel1);
            this.Name = "AddPersonController";
            this.Size = new System.Drawing.Size(608, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel1;
    }
}
