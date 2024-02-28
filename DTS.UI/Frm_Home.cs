using DTS.Bussiness.Concrete;

namespace DTS.UI
{
    public partial class Frm_Home : Form
    {
        UyelerManager uyelerManager = new UyelerManager();
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Uyeler f2 = new Frm_Uyeler();
            f2.ShowDialog();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Odemeler f2 = new Frm_Odemeler();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Aidatlar f2 = new Frm_Aidatlar();
            f2.ShowDialog();
        }
    }
}
