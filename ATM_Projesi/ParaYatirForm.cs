using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Projesi
{
    public partial class ParaYatirForm : Form
    {
        public ParaYatirForm()
        {
            InitializeComponent();
        }

        public int MusteriId = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMiktar.Text)) return;

            try
            {
                decimal miktar = decimal.Parse(txtMiktar.Text);

                baglanti.Open();

                SqlCommand komut = new SqlCommand("UPDATE Accounts SET Balance = Balance + @p1 WHERE Id=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", miktar);
                komut.Parameters.AddWithValue("@p2", MusteriId);
                komut.ExecuteNonQuery();

                SqlCommand komutHareket = new SqlCommand("INSERT INTO Transactions (AccountId, TransactionType, Amount, TransactionDate) VALUES (@p1, 'Para Yatırma', @p2, @p3)", baglanti);
                komutHareket.Parameters.AddWithValue("@p1", MusteriId);
                komutHareket.Parameters.AddWithValue("@p2", miktar);
                komutHareket.Parameters.AddWithValue("@p3", DateTime.Now);

                komutHareket.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Para Yatırma İşlemi Başarılı!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        public void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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
