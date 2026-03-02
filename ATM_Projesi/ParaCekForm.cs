using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Projesi
{
    public partial class ParaCekForm : Form
    {
        public ParaCekForm()
        {
            InitializeComponent();
        }

        public int MusteriId = 0; // Para kimden düşecek?
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMiktar.Text)) return;

            decimal miktar = decimal.Parse(txtMiktar.Text);

            baglanti.Open();

            // 1. Önce bakiyesi yetiyor mu diye kontrol et
            SqlCommand bakiyeSorgu = new SqlCommand("SELECT Balance FROM Accounts WHERE Id=@p1", baglanti);
            bakiyeSorgu.Parameters.AddWithValue("@p1", MusteriId);
            decimal mevcutBakiye = (decimal)bakiyeSorgu.ExecuteScalar();

            if (mevcutBakiye < miktar)
            {
                MessageBox.Show("Yetersiz Bakiye! En fazla " + mevcutBakiye + " TL çekebilirsin.");
            }
            else
            {
                // 2. Bakiyesi yetiyorsa parayı düşelim (UPDATE)
                SqlCommand komut = new SqlCommand("UPDATE Accounts SET Balance = Balance - @p1 WHERE Id=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", miktar);
                komut.Parameters.AddWithValue("@p2", MusteriId);
                komut.ExecuteNonQuery();

                // --- YENİ EKLENEN KISIM (TARİH VE HAREKET KAYDI) ---
                // "Para Çekme" işlemini tarihle birlikte kaydediyoruz
                SqlCommand komutHareket = new SqlCommand("INSERT INTO Transactions (AccountId, TransactionType, Amount, TransactionDate) VALUES (@p1, 'Para Çekme', @p2, @p3)", baglanti);

                komutHareket.Parameters.AddWithValue("@p1", MusteriId);      // Kim?
                komutHareket.Parameters.AddWithValue("@p2", miktar);         // Ne kadar?
                komutHareket.Parameters.AddWithValue("@p3", DateTime.Now);   // NE ZAMAN? (Tarih ve Saat)

                komutHareket.ExecuteNonQuery();
                // ----------------------------------------------------

                MessageBox.Show("Para Çekme İşlemi Başarılı!");
                this.Close();
            }

            baglanti.Close();
        }

        public void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }

        private void ParaCekForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Balance FROM Accounts WHERE Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", MusteriId);

            decimal bakiye = (decimal)komut.ExecuteScalar();
            baglanti.Close();

            lblBakiye.Text = "Mevcut Bakiyeniz: " + bakiye.ToString("N2") + " TL";
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}