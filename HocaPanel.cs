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
    public partial class HocaPanel : Form
    {
        private string hocaKimlik;
        public HocaPanel(string hocaKimlik)
        {
            InitializeComponent();
            this.hocaKimlik = hocaKimlik;
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432;" +
               "Database=obs; user Id=postgres; password=admin;");

        private void ilgiAlanEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertSql = "UPDATE hoca SET ilgialan = @ilgialan WHERE hocaid = @hocaid";
            using (NpgsqlCommand ilgiAlanEkle = new NpgsqlCommand(insertSql, connection))
            {
                ilgiAlanEkle.Parameters.AddWithValue("@ilgialan", txtilgiAlan.Text);
                ilgiAlanEkle.Parameters.AddWithValue("@hocaid", int.Parse(hocaKimlik));
                ilgiAlanEkle.ExecuteNonQuery();
                MessageBox.Show("İlgi alanı eklendi");
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string ogrenciListele = "SELECT o.ogrenciad,o.ogrencisoyad,o.ilgialan" +
                " FROM ogrenci o JOIN ogrenciders od ON o.ogrenciid=od.ogrenciid JOIN hoca h ON h.verdigiders = od.aldigiders WHERE h.hocaid = @hocaid";
            using (NpgsqlCommand command = new NpgsqlCommand(ogrenciListele, connection))
            {
                command.Parameters.AddWithValue("@ogrenciid", int.Parse(hocaKimlik)); // hocaKimlik'i int'e dönüştürüyoruz
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            connection.Close();
        }
    }
}
