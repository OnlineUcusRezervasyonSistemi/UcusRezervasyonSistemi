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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=HAKAN; Initial Catalog=RezervasyonSistemi; Integrated Security=TRUE");
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM havalimanlari";
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            SqlDataReader rd;
            connection.Open();
            rd = command.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["sehirler"]);
                comboBox2.Items.Add(rd["sehirler"]);
            }
            connection.Close();

        }
    }
}
