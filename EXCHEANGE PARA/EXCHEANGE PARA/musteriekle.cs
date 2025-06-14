using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EXCHEANGE_PARA
{
    public partial class musteriekle : UserControl
    {
        public musteriekle()
        {
            InitializeComponent();
        }

        private void musteriekle_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }
        veritabani veritabani =new veritabani();    
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Select("  select musteriİD,hesaptipi,bakiye,h_o_t from musterihesablari");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veritabani.Insert("INSERT INTO musteriler(adi, soyadi, Email, t_numarasi, Addres, ulke, sehir, PostalCodu) VALUES('" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', '"+ textBox12.Text + "', '" + textBox11.Text + "',' " + textBox10.Text + "',' " + textBox15.Text + "')DECLARE @musteriİD INT\r\nSET @musteriİD = SCOPE_IDENTITY();\r\n\r\n\r\nINSERT INTO musterihesablari (musteriİD, hesaptipi, bakiye) VALUES (@musteriİD, 'TRY', 0.00);\r\nINSERT INTO musterihesablari (musteriİD, hesaptipi, bakiye) VALUES (@musteriİD, 'EUR', 0.00);\r\nINSERT INTO musterihesablari (musteriİD, hesaptipi, bakiye) VALUES (@musteriİD, 'USD', 0.00);");
            MessageBox.Show("hos geldin " + textBox8.Text , "musterimiz başarıyla eklendi" );
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked==true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else if(checkBox4.Checked==false)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void cl(object sender, UICuesEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Select("  select * from musteriler");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = ! string.IsNullOrEmpty(textBox8.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox9.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox15.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox11.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox12.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox13.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox14.Text);
            button3.Enabled = !string.IsNullOrEmpty(textBox10.Text);
        }
    }
}
