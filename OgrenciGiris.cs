using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreSQL
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432;" +
               "Database=obs; user Id=postgres; password=admin;");
        string ogrenciKimlik;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();

            string query = "SELECT ogrenciid FROM ogrenci WHERE username = @username AND password = @password";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            // Sorguyu çalıştırın ve sonucu alın
            object result = command.ExecuteScalar();

            connection.Close();

            if (result != null)
            {
                ogrenciKimlik = result.ToString();
                MessageBox.Show("Giriş başarılı.");
                OgrenciPanel ogrenciPanel = new OgrenciPanel(ogrenciKimlik);
                ogrenciPanel.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}