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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cardNum = txtCardNum.Text;
            string sifre = txtPIN.Text;

            SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True");

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM Accounts WHERE CardNumber=@p1 AND PIN=@p2", baglanti);

                komut.Parameters.AddWithValue("@p1", cardNum);
                komut.Parameters.AddWithValue("@p2", sifre);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı! Hoşgeldiniz " + dr["FullName"].ToString());

                    MainForm anaEkran = new MainForm();

                    anaEkran.MusteriId = int.Parse(dr["Id"].ToString());
                    anaEkran.MusteriAdi = dr["FullName"].ToString();

                    anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kart Numarası veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
