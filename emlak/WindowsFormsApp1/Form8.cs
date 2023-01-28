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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
        private void verigörüntüle()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from eklenecekler", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["adres"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["puan"].ToString());
                ekle.SubItems.Add(oku["acıklama"].ToString());
                ekle.SubItems.Add(oku["resim1"].ToString());
                ekle.SubItems.Add(oku["resim2"].ToString());

                listView1.Items.Add(ekle);

            }
            connection.Close();
        }
        private void verigörüntüle1()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from silinecekler", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["adres"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["puan"].ToString());
                ekle.SubItems.Add(oku["acıklama"].ToString());
                ekle.SubItems.Add(oku["resim1"].ToString());
                ekle.SubItems.Add(oku["resim2"].ToString());

                listView1.Items.Add(ekle);

            }
            connection.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into eklenecekler (Id,adres,fiyat,puan,acıklama,resim1,resim2) values (@Id,@a,@f,@p,@ac,@r,@re)", connection);
            ekle.Parameters.AddWithValue("@Id", textBox1.Text);
            ekle.Parameters.AddWithValue("@a", textBox2.Text);
            ekle.Parameters.AddWithValue("@f", textBox3.Text);
            ekle.Parameters.AddWithValue("@p", textBox4.Text);
            ekle.Parameters.AddWithValue("@ac", textBox5.Text);
            ekle.Parameters.AddWithValue("@r", textBox6.Text);
            ekle.Parameters.AddWithValue("@re", textBox7.Text);
            ekle.ExecuteNonQuery();
            connection.Close();
            verigörüntüle();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                connection.Open();
                SqlCommand ekle = new SqlCommand("insert into silinecekler (Id,adres,fiyat,puan,acıklama,resim1,resim2) values (@Id,@a,@f,@p,@ac,@r,@re)", connection);
                ekle.Parameters.AddWithValue("@Id", textBox1.Text);
                ekle.Parameters.AddWithValue("@a", textBox2.Text);
                ekle.Parameters.AddWithValue("@f", textBox3.Text);
                ekle.Parameters.AddWithValue("@p", textBox4.Text);
                ekle.Parameters.AddWithValue("@ac", textBox5.Text);
                ekle.Parameters.AddWithValue("@r", textBox6.Text);
                ekle.Parameters.AddWithValue("@re", textBox7.Text);
                ekle.ExecuteNonQuery();
                connection.Close();
                verigörüntüle1();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox6.Text = openFileDialog1.FileName;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            textBox7.Text = openFileDialog2.FileName;
        }
    }
}
