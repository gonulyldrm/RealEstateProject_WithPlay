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
using System.Net.WebSockets;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
        private void verigörüntüle()
        {
            listView1.Items.Clear();
            
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from ürünler", connection);
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
            listView2.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from üyeler", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["kullanıcıadı"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());
                

                listView2.Items.Add(ekle);

            }
            connection.Close();
        }
        private void verigörüntüle2()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from editörler", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listView2.Items.Clear();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["kullanıcıadı"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());


                listView2.Items.Add(ekle);

            }
            connection.Close();
        }
        private void verigörüntüle4()
        {
            listView3.Items.Clear();
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

                listView3.Items.Add(ekle);

            }
            connection.Close();
        }
        private void verigörüntüle5()
        {
            listView3.Items.Clear();
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

                listView3.Items.Add(ekle);

            }
            connection.Close();
        }
        private void verigörüntüle6()
        {
            listView4.Items.Clear();

            connection.Open();
            SqlCommand komut = new SqlCommand("select * from sikayetler", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["sikayet"].ToString();
               

                listView4.Items.Add(ekle);

            }
            connection.Close();
        }
        private void ekleneceksil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from eklenecekler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            verigörüntüle();
            textBox1.Clear();
        }
        private void sililneceksil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from silinecekler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            verigörüntüle();
            textBox1.Clear();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from ürünler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            verigörüntüle();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verigörüntüle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into ürünler (Id,adres,fiyat,puan,acıklama,resim1,resim2) values (@Id,@a,@f,@p,@ac,@r,@re)", connection);
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

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("update ürünler set adres=@a,fiyat=@f,puan=@p,acıklama=@ac,resim1=@r,resim2=@re where Id=@Id ", connection);
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            listView1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            listView2.Visible = false;
            listView3.Visible = false;
            button11.Visible = false;
            button16.Visible = false;
            listView4.Visible = false;
            button12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            listView1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            listView2.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            listView3.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button16.Visible = false;
            listView4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from üyeler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            verigörüntüle1();
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from editörler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            verigörüntüle2();
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into ürünler (Id,adres,fiyat,puan,acıklama,resim1,resim2) values (@Id,@a,@f,@p,@ac,@r,@re)", connection);
            ekle.Parameters.AddWithValue("@Id", textBox1.Text);
            ekle.Parameters.AddWithValue("@a", textBox2.Text);
            ekle.Parameters.AddWithValue("@f", textBox3.Text);
            ekle.Parameters.AddWithValue("@p", textBox4.Text);
            ekle.Parameters.AddWithValue("@ac", textBox5.Text);
            ekle.Parameters.AddWithValue("@r", textBox6.Text);
            ekle.Parameters.AddWithValue("@re", textBox7.Text);
            ekle.ExecuteNonQuery();
            connection.Close();
            ekleneceksil();
            verigörüntüle4();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from ürünler where Id=@Id", connection);
            komut.Parameters.AddWithValue("@Id", textBox1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            sililneceksil();
            verigörüntüle5();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView3.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            listView2.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button16.Visible = false;
            listView4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox6.Text = openFileDialog1.FileName;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            textBox7.Text = openFileDialog2.FileName;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }
        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void listView3_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            listView1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            listView2.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            listView3.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button16.Visible = true;
            listView4.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            verigörüntüle6();
        }
    }
}
