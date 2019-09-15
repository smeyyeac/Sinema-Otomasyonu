using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sinema
{
    public partial class LoginFormu : Form
    {
        public LoginFormu()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

        String fototasarm = "C:\\Users\\BATUR\\source\\repos\\Sinema\\Sinema\\resim\\asd.jpg"; //dosya yolunu kendnze gore degistrn
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            pictureBox1.ImageLocation =fototasarm;
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataReader reader;
            connection.Open();
            command = new SqlCommand("Select * From kullanicilar where kEmail='" + textBox1.Text + "' and kParola='" + textBox2.Text + "'", connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {

                if (reader["kYetki"].ToString() == "0")
                {
                    MessageBox.Show("Admin", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    anasayfaForm kullaniciForm = new anasayfaForm (textBox1.Text,"");   //email gonderme
                    kullaniciForm.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }


    }
}
