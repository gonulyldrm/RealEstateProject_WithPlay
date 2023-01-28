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
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
 

            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from üyeler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (kullaniciadi == reader["kullanıcıadı"].ToString().TrimEnd() && sifre == reader["sifre"].ToString().TrimEnd())
                {
                    

                    Form4 f4 = new Form4();
                    f4.Show();
                    this.Hide();

                    break;

                  
                }
                else
                {
                     
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
            connection.Close();
        }
    }
}
