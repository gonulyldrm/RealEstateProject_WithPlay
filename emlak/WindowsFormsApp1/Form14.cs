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

namespace WindowsFormsApp1
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
   

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

         

        private void button2_Click_1(object sender, EventArgs e)
        {
            string resim = pictureBox2.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form15 f15 = new Form15();
                    f15.label9.Text = reader["Id"].ToString();
                    f15.label1.Text = reader["adres"].ToString();
                    f15.label2.Text = reader["fiyat"].ToString();
                    f15.label3.Text = reader["puan"].ToString();
                    f15.label4.Text = reader["acıklama"].ToString();
                    f15.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f15.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f15.Show();
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

                        Form15 f15 = new Form15();
                        f15.label9.Text = reader["Id"].ToString();
                        f15.label1.Text = reader["adres"].ToString();
                        f15.label2.Text = reader["fiyat"].ToString();
                        f15.label3.Text = reader["puan"].ToString();
                        f15.label4.Text = reader["acıklama"].ToString();
                        f15.pictureBox1.ImageLocation = reader["resim1"].ToString();
                        f15.pictureBox2.ImageLocation = reader["resim2"].ToString();
                        f15.Show();
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

                    Form15 f15 = new Form15();
                    f15.label9.Text = reader["Id"].ToString();
                    f15.label1.Text = reader["adres"].ToString();
                    f15.label2.Text = reader["fiyat"].ToString();
                    f15.label3.Text = reader["puan"].ToString();
                    f15.label4.Text = reader["acıklama"].ToString();
                    f15.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f15.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f15.Show();
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

                    Form15 f15 = new Form15();
                    f15.label9.Text = reader["Id"].ToString();
                    f15.label1.Text = reader["adres"].ToString();
                    f15.label2.Text = reader["fiyat"].ToString();
                    f15.label3.Text = reader["puan"].ToString();
                    f15.label4.Text = reader["acıklama"].ToString();
                    f15.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f15.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f15.Show();
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

                    Form15 f15 = new Form15();
                    f15.label9.Text = reader["Id"].ToString();
                    f15.label1.Text = reader["adres"].ToString();
                    f15.label2.Text = reader["fiyat"].ToString();
                    f15.label3.Text = reader["puan"].ToString();
                    f15.label4.Text = reader["acıklama"].ToString();
                    f15.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f15.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f15.Show();
                    this.Hide();
                    break;

                }
                
            }
            connection.Close();
        }
        

        private void üyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void şikayetEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            string resim = pictureBox1.ImageLocation.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from ürünler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (resim == reader["resim1"].ToString().TrimEnd())
                {

                    Form15 f15 = new Form15();
                    f15.label9.Text = reader["Id"].ToString();
                    f15.label1.Text = reader["adres"].ToString();
                    f15.label2.Text = reader["fiyat"].ToString();
                    f15.label3.Text = reader["puan"].ToString();
                    f15.label4.Text = reader["acıklama"].ToString();
                    f15.pictureBox1.ImageLocation = reader["resim1"].ToString();
                    f15.pictureBox2.ImageLocation = reader["resim2"].ToString();
                    f15.Show();
                    this.Hide();
                    break;

                }
             

            }
            connection.Close();

        }

 
    }
}
