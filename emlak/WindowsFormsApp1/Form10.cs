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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
        int sayac = 0;
        int puan = 0;
        int zaman = 21;
        private void updatee()
        {
            string kullaniciadi = textBox2.Text;
            if (!string.IsNullOrEmpty(kullaniciadi)) 
            {
                string sql = "update üyeler set puan = '" + label9.Text +  "' where kullanıcıadı = '" + kullaniciadi + "' ";
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
            if (button1.Text == label5.Text) 
            {
                puan = puan + 10;
                label4.Text = puan.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "sonraki soru";
            sayac++;
            label2.Text = sayac.ToString();

            connection.Open();
            SqlCommand komut = new SqlCommand("select * from sorular order by NEWID() ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                button1.Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                textBox1.Text = (oku["soru"].ToString());
                label5.Text = (oku["dogru"].ToString());
            }
            if (sayac == 11)
            {
                button5.Text = "oyun bitti";
                button5.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                textBox2.Visible = true;
                button7.Visible = true;
                label7.Visible = true;
                timer1.Enabled = false;
            }

                connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == label5.Text)
            {
                puan = puan + 10;
                label4.Text = puan.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == label5.Text)
            {
                puan = puan + 10;
                label4.Text = puan.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == label5.Text)
            {
                puan = puan + 10;
                label4.Text = puan.ToString();
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            int a;
            string pu="";
           // SqlConnection connection = new SqlConnection("Data Source = LAPTOP - QOBFV92U\\MSSQLGG; Initial Catalog = emlakisleri; Integrated Security = TRUE");
            connection.Open();  

            SqlCommand komut = new SqlCommand("Select * from üyeler where kullanıcıadı=@k ", connection);
            komut.Parameters.AddWithValue("@k", textBox2.Text);  
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {

                pu = dr["puan"].ToString();

                label8.Text = pu.ToString();
                a = Convert.ToInt32(label4.Text) + Convert.ToInt32(label8.Text);
                label9.Text = a.ToString();
                
            }
            

            connection.Close();
            button6.Enabled = false;
            label8.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            updatee();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            label13.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
            }
        }
    }
}
