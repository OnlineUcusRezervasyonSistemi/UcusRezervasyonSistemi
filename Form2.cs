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

        
        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                
                Form3 form3page = new Form3();
                form3page.ucus_no = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                form3page.nereden = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                form3page.nereye = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                form3page.tarih = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                form3page.saat = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                form3page.sinif = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                form3page.bagaj = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                form3page.fiyat = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               
                
                form3page.Show();
                this.Hide();
                
                
            }  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection Pegasusconnection = new SqlConnection("Data Source=HAKAN; Initial Catalog=PEGASUS; Integrated Security=TRUE");

            

            DataTable dTable = new DataTable();
           

            string sql = "SELECT * FROM ucus_bilgileri WHERE tarih BETWEEN @tarih0 and @tarih1 and ucak_kalkis=@aranan";

            

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Pegasusconnection);

            

            dataAdapter.SelectCommand.Parameters.AddWithValue("@tarih0", dateTimePicker1.Value.ToString());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker2.Value.ToString());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@aranan", comboBox1.SelectedItem);

           


            Pegasusconnection.Open();
           

            dataAdapter.Fill(dTable);
            

            dataGridView1.DataSource = dTable;
            

            Pegasusconnection.Close();
            
            

            
            
        }
        public string koltuk_no;
        private void button3_Click(object sender, EventArgs e)
        {
            
            button3.BackColor = Color.Red;
            koltuk_no = "1 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            koltuk_no = "2 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            koltuk_no = "3 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            koltuk_no = "4 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            koltuk_no = "5 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            koltuk_no = "6 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;
            koltuk_no = "7 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            koltuk_no = "8 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;
            koltuk_no = "9 Numara";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

        }

  
       
    }
}
