using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCHEANGE_PARA
{
    internal class veritabani
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VHMUHAV\SQLEXPRESS;Initial Catalog=Exchange_money;Integrated Security=True");
        public DataTable datatbl = new DataTable();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public SqlCommand sqlkomut = new SqlCommand();


        public DataTable Select(string sorgu)
        {
            if (baglan() == true)
            {
                datatbl = new DataTable();
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);
                baglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int Insert(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int UpdateDelete(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int SorguCalistir(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;

        }


        bool baglan()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        void baglantiKapat()
        {
            try
            {
                baglanti.Close();
            }
            catch
            {

            }
        }

    }
}
