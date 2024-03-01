using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using Npgsql;
using System;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NpgsqlTypes;

namespace PostgreSQL
{
    public partial class OgrenciPanel : Form
    {
        private string ogrenciKimlik;
        public OgrenciPanel(string ogrenciKimlik)
        {
            InitializeComponent();
            this.ogrenciKimlik = ogrenciKimlik;
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432;" +
               "Database=obs; user Id=postgres; password=admin;");

        private void ilgiAlanEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertSql = "UPDATE ogrenci SET ilgialan = @ilgialan WHERE ogrenciid = @ogrenciid";
            using (NpgsqlCommand ilgiAlanEkle = new NpgsqlCommand(insertSql, connection))
            {
                ilgiAlanEkle.Parameters.AddWithValue("@ilgialan", txtilgiAlan.Text);
                ilgiAlanEkle.Parameters.AddWithValue("@ogrenciid", int.Parse(ogrenciKimlik));
                ilgiAlanEkle.ExecuteNonQuery();
                MessageBox.Show("İlgi alanı eklendi");
            }
            connection.Close();
        }

        private void transkript_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = openFileDialog.FileName;
                using (PdfReader pdfReader = new PdfReader(FilePath))
                {
                    string allText = "";
                    for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                    {
                        string pageText = PdfTextExtractor.GetTextFromPage(pdfReader, page);
                        allText += pageText;
                    }

                    string pattern = @"([A-Z]{3,4}\d{3})\s(.+)\s(AA|BA|BB|CB|CC|DC|DD|DF|FF)";
                    MatchCollection matches = Regex.Matches(allText, pattern);


                    connection.Open();
                        

                        foreach (Match match in matches)
                        {
                            string dersKodu = match.Groups[1].Value;
                            string dersAdi = match.Groups[2].Value;
                            string harfNotu = match.Groups[3].Value;

                            string insertSql = "INSERT INTO transkript (dersad, harfnotu) VALUES (@dersad, @harfnotu)";
                            using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertSql, connection))
                            {
                                insertCommand.Parameters.AddWithValue("dersad", dersAdi);
                                insertCommand.Parameters.AddWithValue("harfnotu", harfNotu);
                                insertCommand.ExecuteNonQuery();
                                
                            }
                        }
                        foreach (Match match in matches)
                        {
                            string dersKodu = match.Groups[1].Value;
                            string dersAdi = match.Groups[2].Value;
                            string harfNotu = match.Groups[3].Value;

                            string insertSql = "INSERT INTO notlar (dersad, harfnot, ogrenciid) VALUES (@dersad, @harfnot, @ogrenciid)";
                            using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertSql, connection))
                            {
                                insertCommand.Parameters.AddWithValue("dersad", dersAdi);
                                insertCommand.Parameters.AddWithValue("harfnot", harfNotu);
                                insertCommand.Parameters.AddWithValue("ogrenciid", int.Parse(ogrenciKimlik));
                                insertCommand.ExecuteNonQuery();
                            }
                        }
MessageBox.Show("Transkript eklendi.");
                    connection.Close();
                    }
                }
            }
        
        private void notButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string oku = "SELECT n.* FROM notlar n JOIN ogrenci o ON n.ogrenciid = o.ogrenciid WHERE o.ogrenciid = @ogrenciid";
            using (NpgsqlCommand command = new NpgsqlCommand(oku, connection))
            {
                command.Parameters.AddWithValue("@ogrenciid", int.Parse(ogrenciKimlik)); 
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            connection.Close();
        }

        private void hocaListele_Click(object sender, EventArgs e)
        {
            connection.Open();

            string hocaListele = "SELECT h.* FROM hoca h JOIN ogrenci o ON h.ilgialan = o.ilgialan WHERE o.ogrenciid = @ogrenciid";
            using (NpgsqlCommand command = new NpgsqlCommand(hocaListele, connection))
            {
                command.Parameters.AddWithValue("@ogrenciid", int.Parse(ogrenciKimlik)); // ogrenciKimlik'i int'e dönüştürüyoruz
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            connection.Close();
        }

        private void bilgiGoruntule_Click(object sender, EventArgs e)
        {
            connection.Open();
            string ogrenciListele = "Select * from ogrenci o where o.ogrenciid = @ogrenciid";
            NpgsqlCommand command = new NpgsqlCommand(ogrenciListele, connection);
            command.Parameters.AddWithValue("@ogrenciid", int.Parse(ogrenciKimlik));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();

        }

        private void dersSec_Click(object sender, EventArgs e)
        {
            DersSecim dersSecim = new DersSecim(ogrenciKimlik);
            dersSecim.Show();
        }
    }
}
