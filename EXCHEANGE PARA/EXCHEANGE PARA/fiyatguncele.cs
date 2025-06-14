using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace EXCHEANGE_PARA
{
    public partial class fiyatguncele : Form
    {
        public fiyatguncele()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();
        private void fiyatguncele_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-slot-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                this.Close();

            }
        }
        private void fiyatguncele_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            //label9.Text=veritabani["kitapadi"].ToString();

            /* var gelen = veritabani.Select("  select alis_fiyat,satiş_fiyat from dovizkuru ;");
             label9.Text = gelen.Rows[0]["alis_fiyat"].ToString();
             label10.Text = gelen.Rows[0]["satiş_fiyat"].ToString();*/

            var gelen = veritabani.Select("  SELECT AlisKuru,SatisKuru from DovizKurlari");
            label9.Text = gelen.Rows[2]["AlisKuru"].ToString();
            label10.Text = gelen.Rows[2]["SatisKuru"].ToString();
            label12.Text = gelen.Rows[0]["AlisKuru"].ToString();
            label11.Text = gelen.Rows[0]["SatisKuru"].ToString();
            label7.Text = gelen.Rows[1]["AlisKuru"].ToString();
            label8.Text = gelen.Rows[1]["SatisKuru"].ToString();




            this.textBox1.Location = new Point(500, 500);
            this.textBox2.Location = new Point(500, 500);
            this.textBox3.Location = new Point(500, 500);
            this.textBox4.Location = new Point(500, 500);
            this.textBox5.Location = new Point(500, 500);
            this.textBox6.Location = new Point(500, 500);
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        veritabani veritabani = new veritabani();       
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true) {
                veritabani.UpdateDelete("UPDATE DovizKurlari\r\nSET AlisKuru = " + textBox1.Text + ", SatisKuru = " + textBox2.Text + "\r\nWHERE DovizCifti='EURTRY'");
                MessageBox.Show("fıyat başarıyla gunceledi");
                button1.Visible = false;    
            }
           else if(radioButton2.Checked==true) {
                veritabani.UpdateDelete("UPDATE DovizKurlari\r\nSET AlisKuru = " + textBox3.Text + ", SatisKuru = " + textBox4.Text + "\r\nWHERE DovizCifti='USDTRY'");
                MessageBox.Show("fıyat başarıyla gunceledi");
                button1.Visible = false;
            }
             else if (radioButton3.Checked == true)
             {
                 veritabani.UpdateDelete("UPDATE DovizKurlari\r\nSET AlisKuru = " + textBox3 + ", SatisKuru = " + textBox4 + "\r\nWHERE DovizCifti='EURUSD'");
                 MessageBox.Show("fıyat başarıyla gunceledi");
             }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            //label9.Text = "0";
            var gelen = veritabani.Select("  SELECT AlisKuru,SatisKuru from DovizKurlari");
            label9.Text = gelen.Rows[2]["AlisKuru"].ToString();
            label10.Text = gelen.Rows[2]["SatisKuru"].ToString();
            label12.Text = gelen.Rows[0]["AlisKuru"].ToString();
            label11.Text = gelen.Rows[0]["SatisKuru"].ToString();
            label7.Text = gelen.Rows[1]["AlisKuru"].ToString();
            label8.Text = gelen.Rows[1]["SatisKuru"].ToString();
            //label9.Text


            this.textBox1.Location = new Point(500, 500);
            this.textBox2.Location = new Point(500, 500);
            this.textBox3.Location = new Point(500, 500);
            this.textBox4.Location = new Point(500, 500);
            this.textBox5.Location = new Point(500, 500);
            this.textBox6.Location = new Point(500, 500);
        }

        private void EURTRY(object sender, UICuesEventArgs e)
        {
           // button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
           // button1.Enabled = !string.IsNullOrEmpty(textBox2.Text);

        }

        private void USDTRY(object sender, UICuesEventArgs e)
        {
           // button1.Enabled = !string.IsNullOrEmpty(textBox3.Text);
           // button1.Enabled = !string.IsNullOrEmpty(textBox4.Text);
        }

        private void EURUSD(object sender, UICuesEventArgs e)
        {
          //  button1.Enabled = !string.IsNullOrEmpty(textBox5.Text);
           // button1.Enabled = !string.IsNullOrEmpty(textBox6.Text);
        }

        private void tx1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                button1.Visible = false;
            }
            
        }

        private void tx2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = veritabani.Select("select alis_fiyat,satiş_fiyat from dovizkuru ");
        }


        private void tx4(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                button1.Visible = false;
            }
            
        }
        private void tx3(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

       
        private void tx5(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                button1.Visible = false;
            }
           
        }
        private void tx6(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.textBox1.Location = new Point(200, 80);
                this.textBox2.Location = new Point(293, 80);
                this.textBox3.Location = new Point(500, 500);
                this.textBox4.Location = new Point(500, 500);
                this.textBox5.Location = new Point(500, 500);
                this.textBox6.Location = new Point(500, 500);
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.textBox1.Location = new Point(500, 500);
                this.textBox2.Location = new Point(500, 500);
                this.textBox3.Location = new Point(200, 135);
                this.textBox4.Location = new Point(293, 135);
                this.textBox5.Location = new Point(500, 500);
                this.textBox6.Location = new Point(500, 500);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.textBox1.Location = new Point(500, 500);
                this.textBox2.Location = new Point(500, 500);
                this.textBox3.Location = new Point(500, 500);
                this.textBox4.Location = new Point(500, 500);
                this.textBox5.Location = new Point(200, 190);
                this.textBox6.Location = new Point(298, 190);
            }
        }
    }
}
