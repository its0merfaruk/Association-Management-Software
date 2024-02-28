namespace DTS.UI
{
    partial class Frm_Aidatlar
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
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 428);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 26);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 30;
            label5.Text = "Ödeme Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 26);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 27;
            label2.Text = "Aidat Tutarı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 26;
            label1.Text = "TC Kimlik";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(438, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(91, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // button6
            // 
            button6.Location = new Point(586, 79);
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
            dataGridView1.Location = new Point(3, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 305);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(586, 50);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 21;
            button5.Text = "Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(586, 21);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 4;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 11;
            // 
            // Frm_Aidatlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(panel1);
            Name = "Frm_Aidatlar";
            Text = "Frm_Aidatlar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}