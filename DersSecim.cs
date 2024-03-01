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
    public partial class DersSecim : Form
    {
        private string ogrenciKimlik;
        public DersSecim(string ogrenciKimlik)
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            this.ogrenciKimlik = ogrenciKimlik;

        }
        
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432;" +
               "Database=obs; user Id=postgres; password=admin;");
        private void LoadDataIntoComboBox()
        {
            connection.Open();
            string query = "SELECT dersad FROM ders";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["dersad"].ToString());
            }
            connection.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedData = comboBox1.SelectedItem.ToString(); // Seçilen veriyi al
                                                                     // Seçilen veriyi veritabanına aktar
            InsertDataIntoDatabase(selectedData);
        }
        private void InsertDataIntoDatabase(string data)
        {
            try
            {
                string connectionString = "server=localhost; port=5432;" +
               "Database=obs; user Id=postgres; password=admin;";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                                      
                    data = comboBox1.SelectedItem.ToString();
                    string dersidQuery = "Select dersid From ders Where dersad=@dersad";
                    using (NpgsqlCommand dersidCmd = new NpgsqlCommand(dersidQuery, connection))
                    {
                        dersidCmd.Parameters.AddWithValue("@dersad", data);
                        object dersidResult = dersidCmd.ExecuteScalar();

                        if (dersidResult != null)
                        {
                            int dersid = Convert.ToInt32(dersidResult);

                            string query = "INSERT INTO ogrenciders (aldigiders, ogrenciid, dersid) VALUES (@aldigiders, @ogrenciid, @dersid)";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@aldigiders", data);
                                cmd.Parameters.AddWithValue("@ogrenciid", int.Parse(ogrenciKimlik));
                                cmd.Parameters.AddWithValue("@dersid", dersid);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Veri başarıyla veritabanına eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Ders bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }
}
