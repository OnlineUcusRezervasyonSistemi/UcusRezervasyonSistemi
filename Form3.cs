using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class Form3 : Form
    {
        public string nereden,nereye,tarih,saat,sinif;

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            label21.Text = textBox12.Text;
        }

        private void textBox13_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label19.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label20.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label20.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            label22.Text = maskedTextBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla ödeme yapıldı");
        }

        public string ucus_no, bagaj, fiyat;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 form2page = new Form2();

            int ay, yil;
            for(ay = 1; ay < 13; ay++)
            {
                comboBox1.Items.Add(ay);
            }
            
            for(yil = 21; yil < 30; yil++)
            {
                comboBox2.Items.Add(yil);
            }

            textBox1.Text = "PG" + ucus_no ;
            textBox2.Text = nereden;
            textBox3.Text = nereye;
            textBox4.Text = tarih;
            textBox5.Text = saat;
            textBox6.Text = sinif;
            textBox7.Text = bagaj;
            textBox8.Text = fiyat;
            
           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
