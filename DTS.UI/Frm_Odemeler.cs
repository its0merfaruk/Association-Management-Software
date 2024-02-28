using DTS.Bussiness.Concrete;
using DTS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using iText.Layout.Element;

namespace DTS.UI
{
    public partial class Frm_Odemeler : Form
    {
        OdemelerManager odemelerManager = new OdemelerManager();
        int _id = 0;
        public Frm_Odemeler()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = odemelerManager.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }


        private void Frm_Odemeler_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = int.Parse(row.Cells[0].Value.ToString());
                Odemeler odemeler = odemelerManager.GetById(_id);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = button1.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dataGridView1, saveFileDialog.FileName);
            }
        }
        private void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var writer = new iText.Kernel.Pdf.PdfWriter(filePath))
                {
                    using (var pdf = new iText.Kernel.Pdf.PdfDocument(writer))
                    {
                        using (var document = new iText.Layout.Document(pdf))
                        {
                            // Başlık eklemek için
                            Paragraph title = new Paragraph(button1.Text);
                            document.Add(title);

                            // DataGridView verilerini PDF'e eklemek için
                            iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.Columns.Count);
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                table.AddHeaderCell(new Cell().Add(new Paragraph(dataGridView.Columns[i].HeaderText)));
                            }

                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    if (dataGridView[j, i].Value != null)
                                        table.AddCell(new Cell().Add(new Paragraph(dataGridView[j, i].Value.ToString())));
                                    else
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                }
                            }

                            document.Add(table);
                        }
                    }
                }

                MessageBox.Show("PDF dosyası başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
