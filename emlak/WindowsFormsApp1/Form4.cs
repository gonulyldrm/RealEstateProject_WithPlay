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
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }



        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void şikayetEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void bilgiYarışmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();

        }

        private void zarAtmaOyunuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string resim = pictureBox1.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();

                    break;

                }
                
            }
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string resim = pictureBox1.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form12 f12 = new Form12();
                    f12.label9.Text = reader["Id"].ToString();
                    f12.label1.Text = reader["adres"].ToString();
                    f12.label2.Text = reader["fiyat"].ToString();
                    f12.label3.Text = reader["puan"].ToString();
                    f12.label4.Text = reader["acıklama"].ToString();
                    f12.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f12.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f12.Show();
                    this.Hide();
                    break;

                }
         
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resim = pictureBox2.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form12 f12 = new Form12();
                    f12.label9.Text = reader["Id"].ToString();
                    f12.label1.Text = reader["adres"].ToString();
                    f12.label2.Text = reader["fiyat"].ToString();
                    f12.label3.Text = reader["puan"].ToString();
                    f12.label4.Text = reader["acıklama"].ToString();
                    f12.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f12.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f12.Show();
                    this.Hide();
                    break;

                }
              
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string resim = pictureBox3.ImageLocation.ToString();
                connection.Open();
                SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (resim == reader["resim1"].ToString().TrimEnd())
                    {

                        Form12 f12 = new Form12();
                        f12.label9.Text = reader["Id"].ToString();
                        f12.label1.Text = reader["adres"].ToString();
                        f12.label2.Text = reader["fiyat"].ToString();
                        f12.label3.Text = reader["puan"].ToString();
                        f12.label4.Text = reader["acıklama"].ToString();
                        f12.pictureBox1.ImageLocation = reader["resim1"].ToString();
                        f12.pictureBox2.ImageLocation = reader["resim2"].ToString();
                        f12.Show();
                        this.Hide();
                        break;

                    }
                    

                }
              

               
                connection.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string resim = pictureBox6.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form12 f12 = new Form12();
                    f12.label9.Text = reader["Id"].ToString();
                    f12.label1.Text = reader["adres"].ToString();
                    f12.label2.Text = reader["fiyat"].ToString();
                    f12.label3.Text = reader["puan"].ToString();
                    f12.label4.Text = reader["acıklama"].ToString();
                    f12.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f12.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f12.Show();
                    this.Hide();
                    break;

                }
              
            }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string resim = pictureBox5.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form12 f12 = new Form12();
                    f12.label9.Text = reader["Id"].ToString();
                    f12.label1.Text = reader["adres"].ToString();
                    f12.label2.Text = reader["fiyat"].ToString();
                    f12.label3.Text = reader["puan"].ToString();
                    f12.label4.Text = reader["acıklama"].ToString();
                    f12.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f12.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f12.Show();
                    this.Hide();
                    break;

                }
              

            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string resim = pictureBox4.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form12 f12 = new Form12();
                    f12.label9.Text = reader["Id"].ToString();
                    f12.label1.Text = reader["adres"].ToString();
                    f12.label2.Text = reader["fiyat"].ToString();
                    f12.label3.Text = reader["puan"].ToString();
                    f12.label4.Text = reader["acıklama"].ToString();
                    f12.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f12.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f12.Show();
                    this.Hide();
                    break;

                }
         

            }
            connection.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
} 
