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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432;" +
                "Database=obs; user Id=postgres; password=admin;");
        private void UsernameTextBox(object sender, EventArgs e)
        {

        }
        private void PasswordTextBox(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // PostgreSQL veritabanına bağlanın
            connection.Open();

            // Kullanıcı adı ve şifreyi kontrol etmek için bir sorgu oluşturun
            string query = "SELECT COUNT(*) FROM yonetici WHERE username = @username AND password = @password";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            int count = Convert.ToInt32(command.ExecuteScalar());

            // Bağlantıyı kapatın
            connection.Close();

            // Kullanıcı adı ve şifre doğruysa giriş yapın, aksi takdirde hata mesajı gösterin
            if (count == 1)
            {
                MessageBox.Show("Giriş başarılı.");
                YoneticiPanel yoneticiPanel = new YoneticiPanel();
                yoneticiPanel.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
