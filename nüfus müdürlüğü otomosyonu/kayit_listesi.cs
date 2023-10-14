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
using System.Security.Cryptography;


namespace _202503071_nüfus_müdürlüğü_otomosyonu
{
    public partial class kayit_listesi : Form
    {
        public kayit_listesi()
        {
            InitializeComponent();
        }

    

        private void kayit_listesi_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=localhost\\SQLEXPRESS;Initial Catalog=202503071;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_vatandas", baglanti);

            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Table_vatandas");


            dataGridView1.DataSource = ds.Tables["Table_vatandas"];
            baglanti.Close();

        }

        public static string MD5Sifrele(string sifrelenecekmetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);

            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in dizi)

                sb.Append(item.ToString("x2").ToLower());
            return sb.ToString();
   }

 

        private void button2_Click(object sender, EventArgs e)
        {
            Frmkayit fr1 = new Frmkayit();
            fr1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEvlilik  fr2 = new FrmEvlilik ();
            fr2.ShowDialog();
        }

       
    }
}
