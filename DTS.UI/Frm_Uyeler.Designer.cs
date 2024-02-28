namespace DTS.UI
{
    partial class Frm_Uyeler
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button6 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbl_Birthday = new Label();
            lbl_BloodType = new Label();
            lbl_City = new Label();
            lbl_Surname = new Label();
            lbl_Name = new Label();
            lbl_TCK = new Label();
            panel1 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(627, 78);
            button6.Name = "button6";
            button6.Size = new Size(100, 23);
            button6.TabIndex = 22;
            button6.Text = "Sil";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 274);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(627, 48);
            button5.Name = "button5";
            button5.Size = new Size(100, 24);
            button5.TabIndex = 21;
            button5.Text = "Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(627, 20);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 4;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(401, 84);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(401, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 11;
            // 
            // lbl_Birthday
            // 
            lbl_Birthday.AutoSize = true;
            lbl_Birthday.Location = new Point(320, 60);
            lbl_Birthday.Name = "lbl_Birthday";
            lbl_Birthday.Size = new Size(78, 15);
            lbl_Birthday.TabIndex = 6;
            lbl_Birthday.Text = "Doğum Tarihi";
            // 
            // lbl_BloodType
            // 
            lbl_BloodType.AutoSize = true;
            lbl_BloodType.Location = new Point(320, 87);
            lbl_BloodType.Name = "lbl_BloodType";
            lbl_BloodType.Size = new Size(63, 15);
            lbl_BloodType.TabIndex = 4;
            lbl_BloodType.Text = "Kan Grubu";
            // 
            // lbl_City
            // 
            lbl_City.AutoSize = true;
            lbl_City.Location = new Point(320, 29);
            lbl_City.Name = "lbl_City";
            lbl_City.Size = new Size(33, 15);
            lbl_City.TabIndex = 3;
            lbl_City.Text = "Şehir";
            // 
            // lbl_Surname
            // 
            lbl_Surname.AutoSize = true;
            lbl_Surname.Location = new Point(37, 86);
            lbl_Surname.Name = "lbl_Surname";
            lbl_Surname.Size = new Size(39, 15);
            lbl_Surname.TabIndex = 2;
            lbl_Surname.Text = "Soyad";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(37, 57);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(22, 15);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "Ad";
            // 
            // lbl_TCK
            // 
            lbl_TCK.AutoSize = true;
            lbl_TCK.Location = new Point(37, 28);
            lbl_TCK.Name = "lbl_TCK";
            lbl_TCK.Size = new Size(75, 15);
            lbl_TCK.TabIndex = 0;
            lbl_TCK.Text = "TC Kimlik No";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbl_Birthday);
            panel1.Controls.Add(lbl_BloodType);
            panel1.Controls.Add(lbl_City);
            panel1.Controls.Add(lbl_Surname);
            panel1.Controls.Add(lbl_Name);
            panel1.Controls.Add(lbl_TCK);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 428);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(627, 107);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 26;
            button1.Text = "Bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 113);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Aktiflik";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(401, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // Frm_Uyeler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 452);
            Controls.Add(panel1);
            Name = "Frm_Uyeler";
            Text = "Form2";
            Load += Frm_Uyeler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbl_Birthday;
        private Label lbl_BloodType;
        private Label lbl_City;
        private Label lbl_Surname;
        private Label lbl_Name;
        private Label lbl_TCK;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Button button1;
    }
}