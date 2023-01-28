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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");

        private void satilanekle()
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into satilanlar(adsoyad,email,kredikart,guvenlik,yil,ay,gun,urunId) values (@a,@e,@kr,@g,@y,@ay,@gu,@u)", connection);
            ekle.Parameters.AddWithValue("@a", textBox1.Text);

            ekle.Parameters.AddWithValue("@e", textBox4.Text);
            ekle.Parameters.AddWithValue("@kr", textBox5.Text);
            ekle.Parameters.AddWithValue("@g", textBox6.Text);
            ekle.Parameters.AddWithValue("@y", comboBox1.Text);
            ekle.Parameters.AddWithValue("@ay", comboBox2.Text);
            ekle.Parameters.AddWithValue("@gu", comboBox3.Text);
            ekle.Parameters.AddWithValue("@u", label11.Text);
            ekle.ExecuteNonQuery();

            connection.Close();
        }
        private void kiralananekle()
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into kiralananlar(adsoyad,email,kredikart,guvenlik,yil,ay,gun,urunId) values (@a,@e,@kr,@g,@y,@ay,@gu,@u)", connection);
            ekle.Parameters.AddWithValue("@a", textBox1.Text);
            ekle.Parameters.AddWithValue("@e", textBox4.Text);
           
            ekle.Parameters.AddWithValue("@kr", textBox5.Text);
            ekle.Parameters.AddWithValue("@g", textBox6.Text);
            ekle.Parameters.AddWithValue("@y", comboBox1.Text);
            ekle.Parameters.AddWithValue("@ay", comboBox2.Text);
            ekle.Parameters.AddWithValue("@gu", comboBox3.Text);
            ekle.Parameters.AddWithValue("@u", label11.Text);
            ekle.ExecuteNonQuery();

            connection.Close();
        }


        private void urunsil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from ürünler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", label2.Text);
            komut.ExecuteNonQuery();
            connection.Close();


        }
        private void anasayfayagit()
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    if (!string.IsNullOrEmpty(comboBox1.Text))
                    {
                        if (!string.IsNullOrEmpty(comboBox2.Text))
                        {
                            if (!string.IsNullOrEmpty(comboBox3.Text))
                            {
                                satilanekle();
                                urunsil();
                                anasayfayagit();
                                MessageBox.Show("işleminiz tamamlaandı bizi tercih ettiğiniz için tesekkurler... ");
                            }
                            else
                            {
                                MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                    }
                }
                else
                {
                    MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    if (!string.IsNullOrEmpty(textBox6.Text))
                    {
                        if (!string.IsNullOrEmpty(comboBox1.Text))
                        {
                            if (!string.IsNullOrEmpty(comboBox2.Text))
                            {
                                if (!string.IsNullOrEmpty(comboBox3.Text))
                                {
                                    kiralananekle();
                                    anasayfayagit();
                                    MessageBox.Show("işleminiz tamamlaandı bizi tercih ettiğiniz için tesekkurler... ");


                                }
                                else
                                {
                                    MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                                }
                            }
                            else
                            {
                                MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                    }
                }
                else
                {
                    MessageBox.Show("kredi kartı bilgileri boş bırakılamaz...");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int u = textBox5.TextLength;

            if (u > 16)
            {
                MessageBox.Show("kredi kart no fazla girdiniz");
                textBox5.Clear();
            }


        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void üyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void sikayetEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }

        private void iletişimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void üyeOlToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void şikayetEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
  

