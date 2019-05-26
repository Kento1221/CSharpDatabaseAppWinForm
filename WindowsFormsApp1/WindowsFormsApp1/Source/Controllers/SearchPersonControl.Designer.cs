namespace WindowsFormsApp1.Source.Controllers
{
    partial class SearchPersonControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPersonControl));
            this.Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.PracownicyGrid = new System.Windows.Forms.DataGridView();
            this.LoadAll = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PracownicyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.AllowDrop = true;
            this.Clear.BackColor = System.Drawing.Color.Gold;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clear.Location = new System.Drawing.Point(454, 85);
            this.Clear.Name = "Clear";
            this.Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clear.Size = new System.Drawing.Size(69, 23);
            this.Clear.TabIndex = 33;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(47, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Workers:";
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FemaleRadio.Location = new System.Drawing.Point(418, 47);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(31, 17);
            this.FemaleRadio.TabIndex = 31;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "F";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(365, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sex:";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaleRadio.Location = new System.Drawing.Point(371, 47);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(36, 17);
            this.MaleRadio.TabIndex = 29;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "M";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(204, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(204, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name:";
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityBox.Location = new System.Drawing.Point(212, 88);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(138, 22);
            this.CityBox.TabIndex = 25;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameBox.Location = new System.Drawing.Point(212, 47);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(138, 22);
            this.SurnameBox.TabIndex = 24;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBox.Location = new System.Drawing.Point(49, 88);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(138, 22);
            this.NameBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Gold;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Search.Location = new System.Drawing.Point(373, 85);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 23);
            this.Search.TabIndex = 21;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // PracownicyGrid
            // 
            this.PracownicyGrid.AllowUserToAddRows = false;
            this.PracownicyGrid.AllowUserToDeleteRows = false;
            this.PracownicyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracownicyGrid.Location = new System.Drawing.Point(49, 135);
            this.PracownicyGrid.Name = "PracownicyGrid";
            this.PracownicyGrid.Size = new System.Drawing.Size(474, 237);
            this.PracownicyGrid.TabIndex = 20;
            // 
            // LoadAll
            // 
            this.LoadAll.BackColor = System.Drawing.Color.Gold;
            this.LoadAll.FlatAppearance.BorderSize = 0;
            this.LoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadAll.Image = ((System.Drawing.Image)(resources.GetObject("LoadAll.Image")));
            this.LoadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadAll.Location = new System.Drawing.Point(50, 381);
            this.LoadAll.Name = "LoadAll";
            this.LoadAll.Size = new System.Drawing.Size(116, 23);
            this.LoadAll.TabIndex = 19;
            this.LoadAll.Text = "    Load All";
            this.LoadAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadAll.UseVisualStyleBackColor = false;
            this.LoadAll.Click += new System.EventHandler(this.LoadAll_Click);
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDBox.Location = new System.Drawing.Point(50, 47);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(138, 22);
            this.IDBox.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(373, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 38);
            this.panel1.TabIndex = 34;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Gold;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(407, 381);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(116, 23);
            this.editButton.TabIndex = 35;
            this.editButton.Text = "        Edit";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deleteButton.Location = new System.Drawing.Point(282, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 23);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "     Delete";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SearchPersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.PracownicyGrid);
            this.Controls.Add(this.LoadAll);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.panel1);
            this.Name = "SearchPersonControl";
            this.Size = new System.Drawing.Size(608, 422);
            ((System.ComponentModel.ISupportInitialize)(this.PracownicyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView PracownicyGrid;
        private System.Windows.Forms.Button LoadAll;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
