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
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");

        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
           
            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into üyeler (adsoyad,telefon,kullanıcıadı,email,sifre,sehir,puan) values (@a,@t,@k,@e,@s,@se,@p)", connection);
            ekle.Parameters.AddWithValue("@a", textBox1.Text);
            ekle.Parameters.AddWithValue("@t", textBox2.Text);
            ekle.Parameters.AddWithValue("@k", textBox3.Text);
            ekle.Parameters.AddWithValue("@e", textBox4.Text);
            ekle.Parameters.AddWithValue("@s", textBox5.Text);
            ekle.Parameters.AddWithValue("@se", comboBox1.Text);
            ekle.Parameters.AddWithValue("@p", label8.Text);

            ekle.ExecuteNonQuery();
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
            connection.Close();
        }
    }
}
