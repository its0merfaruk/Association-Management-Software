using DTS.Bussiness.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTS.Entities.Concrete;

namespace DTS.UI
{

    public partial class Frm_Uyeler : Form
    {
        UyelerManager uyelerManager = new UyelerManager();
        int _id = 0;
        public Frm_Uyeler()
        {
            InitializeComponent();
            dataGridView1.DataSource = uyelerManager.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;

            button4.Enabled = false;
            button6.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(1990, 1, 1);

            Uyeler uyeler = new Uyeler();
            if (textBox1.Text != "")
            {
                uyeler.TC_Kimlik = textBox1.Text;
                textBox1.Text = "";
            }
            if (textBox2.Text != "")
            {
                uyeler.Adi = textBox2.Text;
                textBox2.Text = "";
            }
            if (textBox3.Text != "")
            {
                uyeler.Soyadi = textBox3.Text;
                textBox3.Text = "";
            }
            if (textBox4.Text != "")
            {
                uyeler.Sehir = textBox4.Text;
                textBox4.Text = "";
            }
            if (textBox5.Text != "")
            {
                uyeler.Kan_Grubu = textBox5.Text;
                textBox5.Text = "";
            }
            if (checkBox1.Checked == true)
            {
                uyeler.Aktif = checkBox1.Checked;
            }
            if (dateTimePicker1.Value != null)
            {
                uyeler.Dogum_Tarihi = dateTimePicker1.Value;
            }

            uyelerManager.Add(uyeler);
            dataGridView1.DataSource = uyelerManager.GetAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uyeler editUyeler = uyelerManager.GetById(_id);
            editUyeler.TC_Kimlik = textBox1.Text;
            editUyeler.Adi = textBox2.Text;
            editUyeler.Soyadi = textBox3.Text;
            editUyeler.Sehir = textBox4.Text;
            editUyeler.Dogum_Tarihi = dateTimePicker1.Value;
            editUyeler.Aktif = checkBox1.Checked;
            editUyeler.Kan_Grubu = textBox5.Text;
            uyelerManager.Update(editUyeler);
            button4.Enabled = false;
            button6.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            checkBox1.Checked = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = int.Parse(row.Cells[0].Value.ToString());
                Uyeler uyeler = uyelerManager.GetById(_id);
                textBox1.Text = uyeler.TC_Kimlik;
                textBox2.Text = uyeler.Adi;
                textBox3.Text = uyeler.Soyadi;
                textBox4.Text = uyeler.Sehir;
                textBox5.Text = uyeler.Kan_Grubu;
                checkBox1.Checked = uyeler.Aktif;
                dateTimePicker1.Value = uyeler.Dogum_Tarihi;
                button4.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void lbl_Active_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Uyeler_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Uyeler silUyeler = uyelerManager.GetById(_id);
            if (silUyeler != null)
            {
                uyelerManager.Delete(silUyeler);
                dataGridView1.DataSource = uyelerManager.GetAll();
                button4.Enabled = false;
                button6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                checkBox1.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = int.Parse(row.Cells[0].Value.ToString());
                Uyeler uyeler = uyelerManager.GetById(_id);
                textBox1.Text = uyeler.TC_Kimlik;
                textBox2.Text = uyeler.Adi;
                textBox3.Text = uyeler.Soyadi;
                textBox4.Text = uyeler.Sehir;
                textBox5.Text = uyeler.Kan_Grubu;
                button4.Enabled = true;
                button6.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
