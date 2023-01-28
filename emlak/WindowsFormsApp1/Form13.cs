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
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");

        private void satilanekle()
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into satilanlar(adsoyad,kullaniciadi,email,sifre,kredikart,guvenlik,yil,ay,gun,urunId) values (@a,@k,@e,@s,@kr,@g,@y,@ay,@gu,@u)", connection);
            ekle.Parameters.AddWithValue("@a", textBox1.Text);
            ekle.Parameters.AddWithValue("@k", textBox2.Text);
            ekle.Parameters.AddWithValue("@e", textBox4.Text);
            ekle.Parameters.AddWithValue("@s", textBox3.Text);
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
            SqlCommand ekle = new SqlCommand("insert into kiralananlar(adsoyad,kullaniciadi,email,sifre,kredikart,guvenlik,yil,ay,gun,urunId) values (@a,@k,@e,@s,@kr,@g,@y,@ay,@gu,@u)", connection);
            ekle.Parameters.AddWithValue("@a", textBox1.Text);
            ekle.Parameters.AddWithValue("@k", textBox2.Text);
            ekle.Parameters.AddWithValue("@e", textBox4.Text);
            ekle.Parameters.AddWithValue("@s", textBox3.Text);
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
            komut.Parameters.AddWithValue("@Id", label11.Text);
            komut.ExecuteNonQuery();
            connection.Close();
           

        }
        private void anasayfayagit()
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
             
            string kullaniciadi = textBox2.Text;
            string sifre = textBox3.Text;


            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from üyeler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (kullaniciadi == reader["kullanıcıadı"].ToString().TrimEnd() && sifre == reader["sifre"].ToString().TrimEnd())
                {

                    if (Convert.ToInt32(reader["puan"]) >= Convert.ToInt32(label12.Text))
                    {
                        
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        button2.Enabled = true;
                        break;
                    }
                    else
                    {
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        break;
                    }
                   


                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya sifreyı yanlış girdiniz... ");
                    textBox2.Clear();
                    textBox3.Clear();
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                }

                }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox2.Text;
            string sifre = textBox3.Text;
          
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from üyeler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (kullaniciadi == reader["kullanıcıadı"].ToString().TrimEnd() && sifre == reader["sifre"].ToString().TrimEnd())
                {
                   label13.Text=(Convert.ToInt32(reader["puan"]) - Convert.ToInt32(label12.Text)).ToString();
                }
            }
            connection.Close();
            updatee();
            satilanekle();
            urunsil();
            anasayfayagit();
            MessageBox.Show("işleminiz tamamlaandı bizi tercih ettiğiniz için tesekkurler... ");
        }
        private void updatee()
        {
            string kullaniciadi = textBox2.Text;
            
            if (!string.IsNullOrEmpty(kullaniciadi))
            {
                string sql = "update üyeler set puan = '" + label13.Text + "' where kullanıcıadı = '" + kullaniciadi + "' ";
                SqlCommand komut = new SqlCommand(sql, connection);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                komut.ExecuteNonQuery();
                connection.Close();

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

        private void button4_Click(object sender, EventArgs e)
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
}
