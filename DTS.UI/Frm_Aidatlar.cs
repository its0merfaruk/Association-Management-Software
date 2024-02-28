using DTS.Bussiness.Concrete;
using DTS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DTS.UI
{
    public partial class Frm_Aidatlar : Form
    {
        AidatlarManager aidatlarManager = new AidatlarManager();
        int _id = 0;
        public Frm_Aidatlar()
        {
            InitializeComponent();
            dataGridView1.DataSource = aidatlarManager.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            button4.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aidatlar editAidatlar = aidatlarManager.GetById(_id);
            editAidatlar.TC_Kimlik = textBox1.Text;
            editAidatlar.Aidat_Tutari = textBox2.Text;
            editAidatlar.Ay = dateTimePicker1.Value.Month.ToString();
            editAidatlar.Yil = dateTimePicker1.Value.Year.ToString();
            aidatlarManager.Update(editAidatlar);
            button4.Enabled = false;
            button6.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(1990, 1, 1);

            Aidatlar aidatlar = new Aidatlar();
            if (textBox1.Text != "")
            {
                aidatlar.TC_Kimlik = textBox1.Text;
                textBox1.Text = "";
            }
            if (textBox2.Text != "")
            {
                aidatlar.Aidat_Tutari = textBox2.Text;
                textBox2.Text = "";
            }
            
            if (dateTimePicker1.Value != null)
            {
                aidatlar.Ay = dateTimePicker1.Value.Month.ToString();
                aidatlar.Yil = dateTimePicker1.Value.Year.ToString();
            }

            aidatlarManager.Add(aidatlar);
            dataGridView1.DataSource = aidatlarManager.GetAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aidatlar silAidatlar = aidatlarManager.GetById(_id);
            if (silAidatlar != null)
            {
                aidatlarManager.Delete(silAidatlar);
                dataGridView1.DataSource = aidatlarManager.GetAll();
                button4.Enabled = false;
                button6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = int.Parse(row.Cells[0].Value.ToString());
                Aidatlar aidatlar = aidatlarManager.GetById(_id);
                textBox1.Text = aidatlar.TC_Kimlik;
                textBox2.Text = aidatlar.Aidat_Tutari;
                button4.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
