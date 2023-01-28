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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
        private void updatee()
        {
            string kullaniciadi = textBox1.Text;
            if (!string.IsNullOrEmpty(kullaniciadi))
            {
                string sql = "update üyeler set puan = '" + label9.Text + "' where kullanıcıadı = '" + kullaniciadi + "' ";
                SqlCommand komut = new SqlCommand(sql, connection);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                komut.ExecuteNonQuery();
                connection.Close();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\1.jpg";
            }
            if (b == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\1.jpg";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\2.jpg";
            }
            if (b == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\3.png2";
            }
            if (b == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\4.jpg";
            }
            if (b == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\4.jpg";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\5.png";
            }
            if (b == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\6.png";
            }
            if (b == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\İAÜ\\3.sınıf\\YAZILIM MÜHENDİSLİĞİ\\image\\6.png";
            }
            if (a > b) 
            {
                label6.Text = "10";
            }
            if (a==b)
            {
                label6.Text = "5";

            }
            if (a<b)
            {
                label6.Text = "0";
            }
            label6.Visible = true;
            label7.Visible= true;
            button2.Visible= true;
            textBox1.Visible = true;
            label5.Visible = true;
            button1.Enabled = false;

            label3.Text = a.ToString();
            label4.Text = b.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            string pu = "";
            // SqlConnection connection = new SqlConnection("Data Source = LAPTOP - QOBFV92U\\MSSQLGG; Initial Catalog = emlakisleri; Integrated Security = TRUE");
            connection.Open();

            SqlCommand komut = new SqlCommand("Select * from üyeler where kullanıcıadı=@k ", connection);
            komut.Parameters.AddWithValue("@k", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                pu = dr["puan"].ToString();

                label8.Text = pu.ToString();
                a = Convert.ToInt32(label6.Text) + Convert.ToInt32(label8.Text);
                label9.Text = a.ToString();

            }
            connection.Close();
            button2.Enabled = false;

            updatee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
 
