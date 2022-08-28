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
    public partial class personelgirispanelform : Form
    {
        public personelgirispanelform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B3IRVE0\\SQLEXPRESS;Initial Catalog=Personel_Tablosu;Integrated Security=True");
        private void btnkullanicigiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from  tablo_yöneticigiris where kullaniciad=@p1 and sifre=@p2 ", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkullanicigiris.Text);
            komut.Parameters.AddWithValue("@p2", txtkullanicisifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            

           if(dr.Read())
            {
                anaform frm = new anaform();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre");
            }
            baglanti.Close();
        }
    }
}
