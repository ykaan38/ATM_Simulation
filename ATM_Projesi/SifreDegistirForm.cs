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
    public partial class SifreDegistirForm : Form
    {
        public SifreDegistirForm()
        {
            InitializeComponent();
        }

        public int MusteriId = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYeniSifre.Text) || string.IsNullOrWhiteSpace(txtTekrar.Text))
            {
                MessageBox.Show("Lütfen Şifre Alanlarını Doldurun!");
                return;
            }
            if(txtYeniSifre.Text != txtTekrar.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Accounts SET PIN = @p1 WHERE Id = @p2", baglanti);

                komut.Parameters.AddWithValue("@p1", txtYeniSifre.Text);
                komut.Parameters.AddWithValue("@p2", MusteriId);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Şifreniz başarıyla değiştirildi!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        
        public void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SifreDegistirForm_Load(object sender, EventArgs e)
        {

        }
    }
}
