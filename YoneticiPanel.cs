using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgreSQL
{
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432;" +
               "Database=obs; user Id=postgres; password=admin;");
        private void ogrencigoruntule_Click(object sender, EventArgs e)
        {
            string sorgu;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataSet ds = new DataSet();
            
            if(string.IsNullOrWhiteSpace(id2.Text))
            {
                sorgu = "select * from ogrenci";
                da = new NpgsqlDataAdapter(sorgu, connection);
            }

            else
            {
                // Metin kutusu doluysa, belirli öğrenci ID'sine sahip olanı getir
                int ogrenciID;
                if (int.TryParse(id2.Text, out ogrenciID))
                {
                    sorgu = "SELECT * FROM ogrenci WHERE ogrenciid = @ogrenciID";
                    da = new NpgsqlDataAdapter(sorgu, connection);

                    // Parametre eklemek için NpgsqlCommand kullanılır.
                    NpgsqlCommand cmd = new NpgsqlCommand(sorgu, connection);
                    cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    da.SelectCommand = cmd;
                }
                else
                {
                    MessageBox.Show("Geçerli bir öğrenci ID'si giriniz.");
                    return;
                }
            }
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void hocagoruntule_Click(object sender, EventArgs e)
        {
            string sorgu;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataSet ds = new DataSet();

            if (string.IsNullOrWhiteSpace(id2.Text))
            {
                sorgu = "select * from hoca";
                da = new NpgsqlDataAdapter(sorgu, connection);
            }

            else
            {
                // Metin kutusu doluysa, belirli hoca ID'sine sahip olanı getir
                int hocaID;
                if (int.TryParse(id2.Text, out hocaID))
                {
                    sorgu = "SELECT * FROM hoca WHERE hocaid = @hocaID";
                    da = new NpgsqlDataAdapter(sorgu, connection);

                    // Parametre eklemek için NpgsqlCommand kullanılır.
                    NpgsqlCommand cmd = new NpgsqlCommand(sorgu, connection);
                    cmd.Parameters.AddWithValue("@hocaID", hocaID);
                    da.SelectCommand = cmd;
                }
                else
                {
                    MessageBox.Show("Geçerli bir hoca ID'si giriniz.");
                    return;
                }
            }
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id2.Text) || string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Tüm alanları doldurun.");
            }
            else
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand ogrenciekle = new NpgsqlCommand("insert into ogrenci (ogrenciid,ogrenciad,ogrencisoyad,username,password) values (@id,@ad,@soyad,@username,@password)", connection);
                    ogrenciekle.Parameters.AddWithValue("@id", int.Parse(id2.Text));
                    ogrenciekle.Parameters.AddWithValue("@ad", txtAd.Text);
                    ogrenciekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    ogrenciekle.Parameters.AddWithValue("@username", txtUsername.Text);
                    ogrenciekle.Parameters.AddWithValue("password", txtPassword.Text);
                    ogrenciekle.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Öğrenci Eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ogrencisil_Click(object sender, EventArgs e)
        {
            int ogrenciID = int.Parse(id2.Text);

            if (OgrenciMevcut(ogrenciID))
            {
                connection.Open();
                NpgsqlCommand ogrencisil = new NpgsqlCommand("delete from ogrenci where ogrenciid = @id", connection);
                ogrencisil.Parameters.AddWithValue("@id", ogrenciID);
                ogrencisil.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Öğrenci Silme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Öğrenci mevcut değil.");
            }
        }
        private bool OgrenciMevcut(int ogrenciID)
        {
            connection.Open(); 
            NpgsqlCommand kontrolSorgusu = new NpgsqlCommand("SELECT COUNT(*) FROM ogrenci WHERE ogrenciid = @id", connection);
             kontrolSorgusu.Parameters.AddWithValue("@id", ogrenciID);
            object sonuc = kontrolSorgusu.ExecuteScalar();
            if (sonuc != DBNull.Value && sonuc != null)
            {
                int ogrenciSayisi = Convert.ToInt32(sonuc);
                connection.Close();
                return ogrenciSayisi > 0;
            }
            else
            {
                connection.Close();// Eğer sonuç null veya DBNull.Value ise öğrenci mevcut değil
                return false;
            }
        }

        private void hocaekle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand hocaekle= new NpgsqlCommand("insert into hoca (hocaid,hocaad,hocasoyad,username," +
                "password) values (@id,@ad,@soyad,@username,@password)", connection);
            hocaekle.Parameters.AddWithValue("@id", int.Parse(id2.Text));
            hocaekle.Parameters.AddWithValue("@ad", txtAd.Text);
            hocaekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            hocaekle.Parameters.AddWithValue("@username", txtUsername.Text);
            hocaekle.Parameters.AddWithValue("password", txtPassword.Text);
            hocaekle.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Hoca Eklendi.");
        }

        private void hocasil_Click(object sender, EventArgs e)
        {
            int hocaID = int.Parse(id2.Text);

            if (HocaMevcut(hocaID))
            {
                connection.Open();
                NpgsqlCommand hocasil = new NpgsqlCommand("delete from hoca where hocaid = @id", connection);
                hocasil.Parameters.AddWithValue("@id", hocaID);
                hocasil.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Hoca Silme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Hoca mevcut değil.");
            }
        }

        private bool HocaMevcut(int hocaID)
        {
            connection.Open();
            NpgsqlCommand kontrolSorgusu = new NpgsqlCommand("SELECT COUNT(*) FROM hoca WHERE hocaid = @id", connection);
            kontrolSorgusu.Parameters.AddWithValue("@id", hocaID);
            object sonuc = kontrolSorgusu.ExecuteScalar();
            if (sonuc != DBNull.Value && sonuc != null)
            {
                int hocaSayisi = Convert.ToInt32(sonuc);
                connection.Close();
                return hocaSayisi > 0;
            }
            else
            {
                connection.Close();// Eğer sonuç null veya DBNull.Value ise öğrenci mevcut değil
                return false;
            }
        }

        private void ogrenciguncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand ogrenciGuncelle = new NpgsqlCommand("update ogrenci set ogrenciad=@p1,ogrencisoyad=@p2," +
                "username=@p3,password=@p4 where ogrenciid=@p5",connection);
            ogrenciGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            ogrenciGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            ogrenciGuncelle.Parameters.AddWithValue("@p3", txtUsername.Text);
            ogrenciGuncelle.Parameters.AddWithValue("@p4", txtPassword.Text);
            ogrenciGuncelle.Parameters.AddWithValue("@p5", int.Parse(id2.Text));
            ogrenciGuncelle.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Güncelleme İşlemi Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            connection.Close();
        }

        private void hocaguncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand hocaGuncelle = new NpgsqlCommand("update hoca set hocaad=@p1,hocasoyad=@p2," +
                "username=@p3,password=@p4 where hocaid=@p5", connection);
            hocaGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            hocaGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            hocaGuncelle.Parameters.AddWithValue("@p3", txtUsername.Text);
            hocaGuncelle.Parameters.AddWithValue("@p4", txtPassword.Text);
            hocaGuncelle.Parameters.AddWithValue("@p5", int.Parse(id2.Text));
            hocaGuncelle.ExecuteNonQuery();
            MessageBox.Show("Hoca Güncelleme İşlemi Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            connection.Close();
        }
        
    }
}
