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
    public partial class BaslangicEkran : Form
    {
        public BaslangicEkran()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciGiris form4 = new OgrenciGiris();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocaGiris form3 = new HocaGiris();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiGiris form1 = new YoneticiGiris();
            form1.Show(); // Eğer Form1'ü açarken Form2'ün işlem yapmasına devam etmesini istiyorsanız
                          //form1.ShowDialog(); // Eğer Form1'ü açarken Form2'ün kapatılmasını beklemek istiyorsanız

        }
    }
}
