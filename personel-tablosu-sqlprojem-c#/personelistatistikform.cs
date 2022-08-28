﻿using System;
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
    public partial class personelistatistikform : Form
    {
        public personelistatistikform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B3IRVE0\\SQLEXPRESS;Initial Catalog=Personel_Tablosu;Integrated Security=True");
        private void personelistatistikform_Load(object sender, EventArgs e)
        {  
            
            // toplam personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Personel_Tablosu ", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbltoplampersonel.Text = dr1[0].ToString();//sıfırncı indeksten kastımız veri tabanında karşımıza çıkan ilk değer

            }
            baglanti.Close();

            // evli personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Personel_Tablosu where perdurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
               lblevlipersonel.Text = dr2[0].ToString();

            }
            baglanti.Close();

            // bekar personel sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Personel_Tablosu where perdurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekarpersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();
            // şehir sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(persehir)) from Personel_Tablosu", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblşehirsayısı.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //toplam maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(permaas) from Personel_Tablosu", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltoplammaaş.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // ortalama maas
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(permaas) from Personel_Tablosu", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortalamamaaş.Text = dr6[0].ToString();
            }
            baglanti.Close();






        }
    }
}
