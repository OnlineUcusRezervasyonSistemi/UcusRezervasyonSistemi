using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RezervasyonSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HAKAN; Initial Catalog=RezervasyonSistemi; Integrated Security=TRUE");


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        // Formu kapat
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isThere;

        // Giriş Yap butonu
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from kullanicilar", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(username == reader["kullanici_eposta"].ToString().TrimEnd() && pass == reader["kullanici_sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            connection.Close();

            if (isThere)
            {
                Form2 form2page = new Form2();
                form2page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-posta veya şifre yanlış !", "Program");
            }

        }

        // Kaydol butonu
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı kontrolü
                if(connection.State == ConnectionState.Closed){
                    connection.Open();
                }
                // kullanicilar tablomuz ile ilgili alanlara kayıt ekleme işlemi
                string register = "INSERT INTO kullanicilar(kullanici_adi, kullanici_soyadi, kullanici_sifre, kullanici_eposta) values (@kullanici_adi, @kullanici_soyadi, @kullanici_sifre, @kullanici_eposta)";
                // Sorgu ve bağlantıyı parametre olarak alan bir SqlCommand nesnesi oluşturduk.
                SqlCommand command = new SqlCommand(register, connection);

                // Parametrelere form üzerinden gelen verileri veriyoruz.
                command.Parameters.AddWithValue("@kullanici_adi", textBox3.Text);
                command.Parameters.AddWithValue("@kullanici_soyadi", textBox4.Text);
                command.Parameters.AddWithValue("@kullanici_eposta", textBox5.Text);
                command.Parameters.AddWithValue("@kullanici_sifre", textBox6.Text);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt işlemi tamamlandı.");
            }
            catch(Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
            }
        }

        
    }
}
