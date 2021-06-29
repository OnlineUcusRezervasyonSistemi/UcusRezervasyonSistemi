using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RezervasyonSistemi
{
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HAKAN; Initial Catalog=RezervasyonSistemi; Integrated Security=TRUE");


        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string bildirim = "INSERT INTO bildirimler(kimden, kime, bildirim, tarih) values (@kimden, @kime, @bildirim, @tarih)";
            SqlCommand command = new SqlCommand(bildirim, connection);

            command.Parameters.AddWithValue("@kimden", textBox1.Text);
            command.Parameters.AddWithValue("@kime", textBox2.Text);
            command.Parameters.AddWithValue("@bildirim", richTextBox1.Text);
            command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);

            connection.Close();
        }
    }
}
