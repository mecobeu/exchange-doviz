using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EXCHEANGE_PARA
{
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        ToolTip toolTip = new ToolTip();
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = veritabani.Select("SELECT TOP 14 *FROM islemler ORDER BY IslemID desc;");
            var gelen = veritabani.Select("  SELECT COUNT(*) AS BugunIslemSayisi\r\nFROM islemler\r\nWHERE CAST(IslemTarihi AS DATE) = CAST(GETDATE() AS DATE);");
            label10.Text = gelen.Rows[0]["BugunIslemSayisi"].ToString();
            //this.SendToBack();
            //this.TopMost = true;
            this.ControlBox = true;
            this.MinimizeBox = true;

            toolTip.SetToolTip(pictureBox1, "hesab makinesi \n Ctrl+9");
            toolTip.SetToolTip(pictureBox2, "hesab Kılavuzu \n Ctrl+1");
            toolTip.SetToolTip(pictureBox3, "günlük işlemler \n Ctrl+2");
            toolTip.SetToolTip(pictureBox4, "genel bakıye \n Ctrl+3");
            toolTip.SetToolTip(pictureBox5, "********** \n Ctrl+4");
            toolTip.SetToolTip(pictureBox6, "Kasa \n Ctrl+5");
            toolTip.SetToolTip(pictureBox7, "Çıkışlar \n Ctrl+6");
            toolTip.SetToolTip(pictureBox8, "Girişler \n Ctrl+7");
            toolTip.SetToolTip(pictureBox9, "Transfer \n Ctrl+8");
            toolTip.SetToolTip(pictureBox10, "kasabilgisi \n Ctrl+0");
            toolTip.SetToolTip(pictureBox11, "hesab makinesi \n Ctrl+(+)");
            toolTip.SetToolTip(pictureBox12, "Yeni işlem \n Ctrl+Enter");
        }





        private void geceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // BackColor = Color.FromArgb(22, 41, 45);
            //  menuStrip1.BackColor = Color.FromArgb(22, 41, 45);
            //  label1.ForeColor= Color.FromArgb(61, 61, 61);
            // menuStrip1.ForeColor = Color.FromArgb(255, 255, 255);
            //  ayarlarToolStripMenuItem1.BackColor = Color.FromArgb(22, 41, 45);
            //pictureBox1.Image = Image.FromFile(@"D:\C# PROJECT\EXCHEANGE PARA\data\icon\arkaplang.jpg");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //     Form3 form3 = new Form3();
            //    form3.ShowDialog(this);

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
          SoundPlayer player = new SoundPlayer();
        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {

                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\build-ghost-tile.wav";
                player.SoundLocation = soundFile;
                player.Play();
               // pictureBox10.BackColor = Color.Black;
                PictureBox pictureBox = (PictureBox)sender;
            if (openToolStripMenuItem.Checked)
            {
                if (pictureBox.Name == "pictureBox1")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox2")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox3")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox4")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox5")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox6")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox7")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox8")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox9")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == "pictureBox10")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
                if (pictureBox.Name == " pictureBox11")
                {
                    pictureBox.BackColor = Color.LightGray;
                }
            }
           
              else
            { 
               if (pictureBox.Name == "pictureBox1")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox2")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox3")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox4")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox5")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox6")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox7")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox8")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox9")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
               if (pictureBox.Name == "pictureBox10")
               {
                   pictureBox.BackColor = Color.SkyBlue;
               }
                if (pictureBox.Name == " pictureBox11")
                {
                    pictureBox.BackColor = Color.SkyBlue;
                }

            }
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
             string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
               player.SoundLocation = soundFile;
              player.Play();
            PictureBox pictureBox1 = (PictureBox)sender;
            if (openToolStripMenuItem.CheckOnClick)
            
                if (pictureBox1.Name == "pictureBox5")
                {
                    hesabkilavuzu hesabkilavuzu = new hesabkilavuzu();
                    hesabkilavuzu.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox6")
                {
                    kasa form4 = new kasa();
                    form4.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox3")
                {
                    gunlukislemer gunlukislemer = new gunlukislemer();
                    gunlukislemer.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox4")
                {
                    genelbakiye genelbakiye = new genelbakiye();
                    genelbakiye.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox7")
                {
                    cikislar cikislar = new cikislar();
                    cikislar.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox8")
                {
                     girisler girisler = new girisler();
                     girisler.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox2")
                {
                     hesabkilavuzu hesabkilavuzu = new hesabkilavuzu();
                     hesabkilavuzu.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox9")
                {
                     transfer transfer = new transfer();
                     transfer.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox10")
                {
                fiyatguncele fiyatguncele = new fiyatguncele();
                fiyatguncele.ShowDialog(this);
            }
                if (pictureBox1.Name == "pictureBox1")
                {
                    personelkasasi personelkasasi = new personelkasasi();
                    personelkasasi.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox12")
                {
                yenislem yenislem = new yenislem();
                yenislem.ShowDialog(this);
                }
                if (pictureBox1.Name == "pictureBox5")
                {
                hesabdekontları hesabdekontları = new hesabdekontları();
                hesabdekontları.ShowDialog(this);
                }


        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox.Name == "pictureBox1")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox2")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox3")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox4")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox5")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox6")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox7")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox8")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox9")
            {
                pictureBox.BackColor = Color.Transparent;
            }
            if (pictureBox.Name == "pictureBox10")
            {
                pictureBox.BackColor = Color.Transparent;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(22, 41, 45);
            menuStrip1.BackColor = Color.FromArgb(22, 41, 45);
            label1.ForeColor = Color.FromArgb(61, 61, 61);
            menuStrip1.ForeColor = Color.FromArgb(255, 255, 255);
            ayarlarToolStripMenuItem1.BackColor = Color.FromArgb(22, 41, 45);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255);
            menuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(61, 61, 61);
            menuStrip1.ForeColor = Color.FromArgb(22, 41, 45);
            ayarlarToolStripMenuItem1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            hesabmakinesi hesabmakinesi = new hesabmakinesi();
            hesabmakinesi.ShowDialog(this);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
            player.SoundLocation = soundFile;
            player.Play();
            kasa kasa = new kasa();
            kasa.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D1)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                hesabkilavuzu hesabkilavuzu = new hesabkilavuzu();
                hesabkilavuzu.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D2)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                gunlukislemer gunlukislemer = new gunlukislemer();
                gunlukislemer.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D3)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                genelbakiye genelbakiye = new genelbakiye();
                genelbakiye.ShowDialog(this);
            }
             if (e.Control && e.KeyCode == Keys.D4)
             {
            string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                 player.SoundLocation = soundFile;
                 player.Play();
                 gunlukislemer gunlukislemer = new gunlukislemer();
                 gunlukislemer.ShowDialog(this);
               
             }
            if (e.Control && e.KeyCode == Keys.D5)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                kasa kasa = new kasa();
                kasa.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D6)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                cikislar cikislar = new cikislar();
                cikislar.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D7)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                girisler girisler = new girisler();
                girisler.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D8)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                transfer transfer = new transfer();
                transfer.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D9)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                personelkasasi personelkasasi = new personelkasasi();
                personelkasasi.ShowDialog(this);
            }
            if (e.Control && e.KeyCode == Keys.D0)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                fiyatguncele fiyatguncele = new fiyatguncele();
                fiyatguncele.ShowDialog(this);
            }
            /*if (e.Control && e.KeyCode == Keys.D0)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                fiyatguncele fiyatguncele = new fiyatguncele();
                fiyatguncele.ShowDialog(this);
            }*/
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                yenislem yenislem = new yenislem();
                yenislem.ShowDialog(this);
            }















            if (e.Control && e.KeyCode == Keys.F11)
            {
                ToggleFullScreen();
            }

        }
        private bool isFullScreen = false;
        private FormBorderStyle previousFormBorderStyle;
        private FormWindowState previousWindowState;
        private void ToggleFullScreen()
        {
            if (isFullScreen)
            {
                // Eski form boyutunu ve durumunu geri yükle
                this.FormBorderStyle = previousFormBorderStyle;
                this.WindowState = previousWindowState;
                isFullScreen = false;
            }
            else
            {
                // Tam ekran moduna geç
                previousFormBorderStyle = this.FormBorderStyle;
                previousWindowState = this.WindowState;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox11, "hesab makinesi \n ctrl+0");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox2, "hesab makinesi \n ctrl+1");
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            
        }
        veritabani veritabani= new veritabani();    
        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = veritabani.Select("");
            dataGridView2.DataSource=veritabani.Select("SELECT TOP 14 *FROM islemler ORDER BY IslemID desc;");
            var gelen = veritabani.Select("  SELECT COUNT(*) AS BugunIslemSayisi\r\nFROM islemler\r\nWHERE CAST(IslemTarihi AS DATE) = CAST(GETDATE() AS DATE);");
            label10.Text = gelen.Rows[0]["BugunIslemSayisi"].ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            yenislem yenislem = new yenislem();
            yenislem.ShowDialog(this);
        }
    }
}
