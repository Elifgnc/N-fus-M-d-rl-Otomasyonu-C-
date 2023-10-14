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

namespace _202503071_nüfus_müdürlüğü_otomosyonu
{
    public partial class SifreDegistir : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public static string SqlCon= "Server=localhost\\SQLEXPRESS;Initial Catalog=202503071;Integrated Security=True";

        public int sonuc = 0;



        public SifreDegistir()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Captcha.Text == sonuc.ToString())
            {
                if(textBox_yenisifre .Text == textBox_yenisifreonay .Text)
                {
                    EskiSifreKontrol();
                    con.Open();
                    if(FrmGiris.kullanicimSession=="memur1987")

                    {
                        cmd = new SqlCommand("update Table_sifre_bilgileri set memur_sifre=@p1 where memur_kullanici_adi=@p3", con);

                        cmd.Parameters.AddWithValue("@p1", md5.MD5Sifrele(textBox_yenisifre.Text));
                        cmd.Parameters.AddWithValue("@p3", FrmGiris.kullanicimSession);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Şifre güncellendi");

                    }
                    else if(FrmGiris.kullanicimSession=="yönetici1987")
                    {
                        cmd = new SqlCommand("update Table_sifre_bilgileri set yönetici_sifre=@p2 where yönetici_kullanici_adi=@p4", con);

                        cmd.Parameters.AddWithValue("@p2", md5.MD5Sifrele(textBox_yenisifre.Text));
                        cmd.Parameters.AddWithValue("@p4", FrmGiris.kullanicimSession);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Şifre güncellendi");
                        
                    }
                    
                } 
                else
                {
                    label_Mesaj.Text = " Yeni Şifre ve Tekrarı aynı değil.";
                    
                } 
            }
            else
            {
                label_Mesaj.Text = "Captcha Hatalı.";
                
            } 
        }

        public void EskiSifreKontrol()
        {
            string sorgu = "select * from Table_sifre_bilgileri where (memur_kullanici_adi=@p1 and memur_sifre=@p2) or (yönetici_kullanici_adi=@p3 and yönetici_sifre=@p4)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@p1",FrmGiris .kullanicimSession);
            cmd.Parameters.AddWithValue("@p2", kayit_listesi.MD5Sifrele(textBox_eskisifre .Text ));
            cmd.Parameters.AddWithValue("@p3", FrmGiris.kullanicimSession);
            cmd.Parameters.AddWithValue("@p4", kayit_listesi.MD5Sifrele(textBox_eskisifre .Text ));

            con.Open();
            dr = cmd.ExecuteReader();
            

            if(dr.Read())
            {

                con.Close();
            }
            else
            {
                MessageBox.Show("Eski Şifre Hatalı");
                con.Close();

            }
            

          
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int ilk = r.Next(0, 50);
            int ikinci = r.Next(0, 50);
            sonuc = ilk + ikinci;
            label_Captcha.Text = ilk.ToString() + "+" + ikinci.ToString()+"=";

        }
    }
}
