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
    public partial class Form5 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QOBFV92U\\MSSQLGG; Initial Catalog=emlakisleri; Integrated Security=TRUE");
  
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            string onaykodu = textBox3.Text;


            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from yöneticiler", connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (kullaniciadi == reader["kullanıcıadı"].ToString().TrimEnd() && sifre == reader["sifre"].ToString().TrimEnd()&& onaykodu==reader["onaykodu"].ToString().TrimEnd())
                {
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Hide();

                    break;

                }
                else
                {
                    
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                }
            }
            connection.Close();
        }
    }
}
