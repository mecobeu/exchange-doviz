using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace EXCHEANGE_PARA
{
    public partial class Form1 : Form
    {
        //SQL
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VHMUHAV\SQLEXPRESS;Initial Catalog=live;Integrated Security=True");
        //SQL
        private bool mouseDown;
        private Point lastLocation;
        
        public Form1()
        { 
            ///////////
            //this.Load += Form1_Load;
            ///////////
            InitializeComponent();
            InitializeDragFunctionality();
            //guncel fiyat icin timer -----------------------------
            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            timer2.Start();
            //guncel fiyat icin timer -----------------------------
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            //------------------------------------------------------------------------------------------------------------
            //eurusd
              Random eurusd = new Random();
              decimal randomeurusd = (decimal)(eurusd.NextDouble() * 0.0099);
              label9.Text = randomeurusd.ToString("0.00000");
            decimal orijinalFiyat = 1.08000m;
            decimal guncelFiyat = randomeurusd + 1.08000m; 
              label9.Text = guncelFiyat.ToString("0.00000"); 
            //%
            decimal yuzdelikArtis = ((guncelFiyat - orijinalFiyat) / orijinalFiyat) * 100;
            label11.Text = yuzdelikArtis.ToString("+ "+"0.00") + " %";
            //eurusd
            //------------------------------------------------------------------------------------------------------------
            //eurtry
            Random eurtry = new Random();
            decimal randomeurtry = (decimal)(eurtry.NextDouble() * 1.299);
            label18.Text = randomeurtry.ToString("00.000");
            decimal orijinalFiyateurtry = 36.000m;
            decimal guncelFiyateurtry = randomeurtry + 36.000m;

            label18.Text = guncelFiyateurtry.ToString("00.000");
            decimal yuzdelikArtiseurtry = ((guncelFiyateurtry - orijinalFiyateurtry) / orijinalFiyateurtry) * 100;
            label16.Text = yuzdelikArtiseurtry.ToString("+ " + "0.00") + " %";
            //eurtry
            //------------------------------------------------------------------------------------------------------------
            //usdtry
            Random usdtry = new Random();
            decimal randomusdtry = (decimal)(usdtry.NextDouble() * .500);
            label22.Text = randomeurtry.ToString("00.000");
            decimal orijinalFiyatusdtry = 33.200m;
            decimal guncelFiyatusdtry = randomusdtry + 33.200m;

            label22.Text = guncelFiyatusdtry.ToString("00.000");
            decimal yuzdelikArtisusdtry = ((guncelFiyatusdtry - orijinalFiyatusdtry) / orijinalFiyatusdtry) * 100;
            label20.Text = yuzdelikArtisusdtry.ToString("+ " + "0.00") + " %";
            //usdtry
            //------------------------------------------------------------------------------------------------------------
            //eurrsd
            Random eurrsd = new Random();
            decimal randomeurrsd = (decimal)(eurrsd.NextDouble() * 1.50);
            label26.Text = randomeurrsd.ToString("000.00");
            decimal orijinalFiyateurrsd = 117.80m;
            decimal guncelFiyateurrsd = 117.80m - randomeurrsd;

            label26.Text = guncelFiyateurrsd.ToString("000.00");
            decimal yuzdelikArtiseurrsd = ((guncelFiyateurrsd - orijinalFiyateurrsd) / orijinalFiyateurrsd) * 100;
            label24.Text = yuzdelikArtiseurrsd.ToString(" " + "0.00") + " %";
            //usdrsd
            //------------------------------------------------------------------------------------------------------------
            //eurrsd
            Random usdrsd = new Random();
            decimal randomusdrsd = (decimal)(usdrsd.NextDouble() * 1.00);
            label30.Text = randomusdrsd.ToString("000.00");
            decimal orijinalFiyatusdrsd = 108.50m;
            decimal guncelFiyatusdrsd = 108.50m - randomusdrsd;

            label30.Text = guncelFiyatusdrsd.ToString("000.00");
            decimal yuzdelikArtisusdrsd = ((guncelFiyatusdrsd - orijinalFiyatusdrsd) / orijinalFiyatusdrsd) * 100;
            label28.Text = yuzdelikArtisusdrsd.ToString(" " + "0.00") + " %";
            //usdrsd
            //------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------
            //gold
            Random gold = new Random();
            decimal randomgold = (decimal)(gold.NextDouble() * 8.00);
            label14.Text = randomgold.ToString("0000.00");
            decimal orijinalFiyatgold = 2158.00m;
            decimal guncelFiyatgold = 2158.00m - randomgold;

            label14.Text = guncelFiyatgold.ToString("0000.00");
            decimal yuzdelikArtisgold = ((guncelFiyatgold - orijinalFiyatgold) / orijinalFiyatgold) * 100;
            label12.Text = yuzdelikArtisgold.ToString(" " + "0.00") + " %";
            //gold
            //------------------------------------------------------------------------------------------------------------
            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
          
        }

        private void InitializeDragFunctionality()
        {
            panel1.MouseDown += Panel_MouseDown;
            panel1.MouseMove += Panel_MouseMove;
            panel1.MouseUp += Panel_MouseUp;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
           
            mouseDown = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////////////////
           /* Form2 form2 = new Form2();
            form2.Show();*/
            /////////////////
            textBox2.PasswordChar = '*';
        }
        SoundPlayer player = new SoundPlayer();

      
        private int progressValue = 0;

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            //alan bildiler
            string Adi, sifre;
            Adi = textBox1.Text;
            sifre = textBox2.Text;
            // alan bilgiler veri tabana bilgileri ile karşilaştirmak
            if (string.IsNullOrWhiteSpace(Adi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                conn.Open();
                string query = "SELECT * FROM guvenlik WHERE Adi = @Adi AND sifre = @Sifre";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Adi", Adi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı  veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    linkLabel1.Visible = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            //
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            progressValue += 10;
            progressBar2.Value = progressValue;
            label3.Text = progressValue.ToString() + "%";
            label3.Visible = true;
            label7.Visible = true;
            progressBar2.Visible = true;
            if (progressBar2.Value == 100)

            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                timer1.Stop();
            }

        }



        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {

            textBox2.PasswordChar = '\0';
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            textBox2.BackColor = Color.LightGray;
            panel5.BackColor = Color.LightGray;
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.BackColor = Color.White;
            panel5.BackColor = Color.White;
            textBox1.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "memet";
            textBox2.Text = "memet445472";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}