using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCHEANGE_PARA
{
    public partial class personelkasasi : Form
    {
        public personelkasasi()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();
        private void personelkasasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-slot-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                this.Close();

            }
        }

        private void personelkasasi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Select(" select *from personelkasa ORDER BY miktar DESC");
            var gelen = veritabani.Select("select Aliskuru,satiskuru from dovizkurlari");
            label11.Text = gelen.Rows[2]["Aliskuru"].ToString();
            label7.Text = gelen.Rows[2]["satiskuru"].ToString();
            label10.Text = gelen.Rows[0]["Aliskuru"].ToString();
            label8.Text = gelen.Rows[0]["satiskuru"].ToString();
            label9.Text = gelen.Rows[1]["Aliskuru"].ToString();
            label4.Text = gelen.Rows[1]["satiskuru"].ToString();



            comboBox1.SelectedIndex = 0;


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        veritabani veritabani=new veritabani();
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Select("select *from personelkasa ORDER BY miktar DESC");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yenislem yenislem = new yenislem();
            yenislem.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasalararasindaparatransferleri kasa22 = new kasalararasindaparatransferleri();
            kasa22.ShowDialog(this);
        }
    }
}
