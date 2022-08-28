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

namespace personeltablosusqlprojem
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }
        // sınıf tanımıcaz nesne türetip komut kullanmak için
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B3IRVE0\\SQLEXPRESS;Initial Catalog=Personel_Tablosu;Integrated Security=True");
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtmeslek.Text = "";
            txtmaas.Text = "";
            txtsehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtad.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.personel_TablosuTableAdapter.Fill(this.personel_TablosuDataSet.Personel_Tablosu);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel_Tablosu (perad,persoyad,persehir,permaas,permeslek,perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtsehir.Text);
            komut.Parameters.AddWithValue("@p4", txtmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            


            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ekleme tamamlandı");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text=="True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text=="False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Personel_Tablosu Where perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayit silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Personel_Tablosu set perad=@a1,persoyad=@a2,persehir=@a3,permaas=@a4,perdurum=@a5,permeslek=@a6 where perid=@a7 ", baglanti);
            // sakın ama sakın where komutunu unutma.
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("personel bilgi güncellendi.");


            baglanti.Close();
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            personelistatistikform pi = new personelistatistikform();
            pi.Show();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            personelgrafikform fr = new personelgrafikform();
            fr.Show();
        }
    }
}
