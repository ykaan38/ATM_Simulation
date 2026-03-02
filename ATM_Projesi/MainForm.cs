using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Projesi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int MusteriId = 0;
        public string MusteriAdi = "";

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");


        public void BakiyeGuncelle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Balance FROM Accounts WHERE Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", MusteriId);

            decimal bakiye = (decimal)komut.ExecuteScalar();

            lblBakiye.Text = bakiye.ToString("N2") + "TL";
            baglanti.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Form açılınca ismi yaz ve bakiyeyi getir
            lblAdSoyad.Text = "Hoşgeldiniz Sayın " + MusteriAdi + ",";
            HareketleriGetir();
            BakiyeGuncelle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            ParaCekForm frm = new ParaCekForm();
            frm.MusteriId = MusteriId; 
            frm.ShowDialog();
            HareketleriGetir();
            BakiyeGuncelle(); 
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            ParaYatirForm frm = new ParaYatirForm();
            frm.MusteriId = MusteriId;
            frm.ShowDialog();
            HareketleriGetir();
            BakiyeGuncelle();
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            SifreDegistirForm frm = new SifreDegistirForm();
            frm.MusteriId = MusteriId; 
            frm.ShowDialog();
        }

        // --- HAREKETLERİ LİSTELEME METODU ---
        void HareketleriGetir()
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

            string sorgu = "SELECT TransactionType AS 'İşlem Türü', Amount AS 'Tutar', TransactionDate AS 'Tarih' FROM Transactions WHERE AccountId=@p1 ORDER BY TransactionDate DESC";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p1", MusteriId);

            DataTable dt = new DataTable();
            da.Fill(dt); 
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }
        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}
