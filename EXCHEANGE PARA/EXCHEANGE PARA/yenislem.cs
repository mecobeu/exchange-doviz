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
    public partial class yenislem : Form
    {
        public yenislem()
        {
            InitializeComponent();

            textBox8.KeyPress += textBox8_KeyPress;
            textBox8.TextChanged += textBox8_TextChanged;
        }
        SoundPlayer player = new SoundPlayer();
        private void yenislem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-slot-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                this.Close();

            }
        }

        private void yenislem_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            radioButton1.Checked = true;
            label18.Visible=false;
            label19.Visible = false;
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            dataGridView1.DataSource = veritabani.Select("select * FROM islemler\r\nWHERE \r\n    CONVERT(date, IslemTarihi) = CONVERT(date, GETDATE())");

            textBox2.KeyDown += new KeyEventHandler(textBox2_KeyDown);
            textBox5.KeyDown += new KeyEventHandler(textBox2_KeyDown);
            // button1.Click += new EventHandler(button1_Click);
            textBox2.Focus();

            

        }
        veritabani veritabani = new veritabani();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = veritabani.Select("select * FROM islemler\r\nWHERE \r\n    CONVERT(date, IslemTarihi) = CONVERT(date, GETDATE())");
            }
            if (radioButton2.Checked)
            {
                dataGridView1.DataSource = veritabani.Select("select * FROM islemler");
            }



            //pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            int selectionStart = textBox2.SelectionStart;
            int selectionLength = textBox2.SelectionLength;

            // TextBox'taki metni büyük harfe çevir
            textBox2.Text = textBox2.Text.ToUpper();

            // Caret pozisyonunu geri yükle
            textBox2.SelectionStart = selectionStart;
            textBox2.SelectionLength = selectionLength;


            var miktar = textBox2.Text;
            label13.Text = miktar;

            if (textBox2.Text.Length == 3 && !button2.Enabled)
            {
                if (textBox2.Text == "TRY")
                {
                   

                    pictureBox1.Image = Image.FromFile(TRY);
                }
                if (textBox2.Text == "USD")
                {


                    pictureBox1.Image = Image.FromFile(USD);
                }
                if (textBox2.Text == "EUR")
                {


                    pictureBox1.Image = Image.FromFile(EUR);
                }
                button2.Enabled = false;
            }
           
            else if (textBox2.Text.Length != 3 && button2.Enabled)
            {
                

                button2.Enabled = false;
            }

        }
        string TRY = @"D:\C# PROJECT\EXCHEANGE PARA\EXCHEANGE PARA\Resources\images.jpg";
        string USD = @"D:\C# PROJECT\EXCHEANGE PARA\EXCHEANGE PARA\Resources\american-flag-2043285_960_720.jpg";
        string EUR = @"D:\C# PROJECT\EXCHEANGE PARA\EXCHEANGE PARA\Resources\Flag_of_Europe.svg.jpg";
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox2.Text == "TRY")
                {


                    pictureBox1.Image = Image.FromFile(TRY);
                }
            }
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox2.Text == "USD")
                {


                    pictureBox1.Image = Image.FromFile(USD);
                }
            }
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox2.Text == "EUR")
                {


                    pictureBox1.Image = Image.FromFile(EUR);
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (textBox5.Text == "TRY")
                {


                    pictureBox2.Image = Image.FromFile(TRY);


                }
            }
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox5.Text == "USD")
                {


                    pictureBox2.Image = Image.FromFile(USD);

                }
            }
            if (e.KeyCode == Keys.Enter)
            {


                if (textBox5.Text == "EUR")
                {


                    pictureBox2.Image = Image.FromFile(EUR);

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var amiktar = textBox1.Text;
            label9.Text = amiktar;

            if (textBox2.Text.Length > 0 || textBox2.Text.Length ==0  && !button2.Enabled  )
            {
                if(textBox5.Text.Length > 0)
                    {
                    button2.Enabled = true;
                }
                button2.Enabled = false;
            }

            else if(textBox2.Text.Length == 0)
            {


                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "EUR" && textBox5.Text == "TRY")
            {

                var gelen = veritabani.Select("  select SatisKuru from DovizKurlari where dovizCifti ='EURTRY'");
                textBox3.Text = gelen.Rows[0]["SatisKuru"].ToString();
                textBox4.Text = gelen.Rows[0]["SatisKuru"].ToString();


                decimal satisKuru = Convert.ToDecimal(gelen.Rows[0]["SatisKuru"]);
                decimal miktar = Convert.ToDecimal(textBox1.Text);
                decimal sonuc = miktar * satisKuru;
                textBox6.Text = sonuc.ToString();

                label10.Text = sonuc.ToString();
            }
            if (textBox2.Text == "EUR" && textBox5.Text == "USD")
            {

                var gelen = veritabani.Select("  select SatisKuru from DovizKurlari where dovizCifti ='EURUSD'");
                textBox3.Text = gelen.Rows[0]["SatisKuru"].ToString();
                textBox4.Text = gelen.Rows[0]["SatisKuru"].ToString();


                decimal satisKuru = Convert.ToDecimal(gelen.Rows[0]["SatisKuru"]);
                decimal miktar = Convert.ToDecimal(textBox1.Text);
                decimal sonuc = miktar * satisKuru;
                textBox6.Text = sonuc.ToString();

                label10.Text = sonuc.ToString();
            }
            if (textBox2.Text == "USD" && textBox5.Text == "TRY")
            {

                var gelen = veritabani.Select("  select SatisKuru from DovizKurlari where dovizCifti ='USDTRY'");
                textBox3.Text = gelen.Rows[0]["SatisKuru"].ToString();
                textBox4.Text = gelen.Rows[0]["SatisKuru"].ToString();


                decimal satisKuru = Convert.ToDecimal(gelen.Rows[0]["SatisKuru"]);
                decimal miktar = Convert.ToDecimal(textBox1.Text);
                decimal sonuc = miktar * satisKuru;
                textBox6.Text = sonuc.ToString();

                label10.Text = sonuc.ToString();
            }
            if (textBox2.Text == "USD" && textBox5.Text == "EUR")
            {

                var gelen = veritabani.Select("  select AlisKuru from DovizKurlari where dovizCifti ='EURUSD'");
                textBox3.Text = gelen.Rows[0]["AlisKuru"].ToString();
                textBox4.Text = gelen.Rows[0]["AlisKuru"].ToString();


                decimal satisKuru = Convert.ToDecimal(gelen.Rows[0]["AlisKuru"]);
                decimal miktar = Convert.ToDecimal(textBox1.Text);
                decimal sonuc = miktar / satisKuru;
                textBox6.Text = sonuc.ToString();

                label10.Text = sonuc.ToString();
            }
            if (textBox2.Text == "TRY" && textBox5.Text == "EUR")
            {

                var gelen = veritabani.Select("  select AlisKuru from DovizKurlari where dovizCifti ='EURTRY'");
                textBox3.Text = gelen.Rows[0]["AlisKuru"].ToString();
                textBox4.Text = gelen.Rows[0]["AlisKuru"].ToString();


                decimal satisKuru = Convert.ToDecimal(gelen.Rows[0]["AlisKuru"]);
                decimal miktar = Convert.ToDecimal(textBox1.Text);
                decimal sonuc = miktar / satisKuru;
                textBox6.Text = sonuc.ToString();

                label10.Text = sonuc.ToString();
            }
            if (textBox2.Text == "TRY" && textBox5.Text == "USD")
            {

                var gelen = veritabani.Select("  select AlisKuru from DovizKurlari where dovizCifti ='USDTRY'");
                textBox3.Text = gelen.Rows[0]["AlisKuru"].ToString();
                textBox4.Text = gelen.Rows[0]["AlisKuru"].ToString();


                decimal satisKuru = Convert.ToDecimal(gelen.Rows[0]["AlisKuru"]);
                decimal miktar = Convert.ToDecimal(textBox1.Text);
                decimal sonuc = miktar / satisKuru;
                textBox6.Text = sonuc.ToString();

                label10.Text = sonuc.ToString();
            }




            string girilenMetin = label10.Text;
            int virgulIndex = girilenMetin.IndexOf(',');

            if (virgulIndex != -1)
            {

                string yeniMetin = girilenMetin.Substring(0, virgulIndex);

                label10.Text = yeniMetin;

            }



            if(textBox2.Text == "USD"&& textBox5.Text == "EUR"  )
            {
                textBox9.Text = textBox5.Text + textBox2.Text;
            }
            else if(textBox2.Text== "EUR")
            {
                textBox9.Text = textBox2.Text + textBox5.Text;
            }
            else if (textBox2.Text == "USD" && textBox5.Text == "TRY")
            {
                textBox9.Text = textBox2.Text + textBox5.Text;
            }
            else 
            {
                textBox9.Text = textBox5.Text + textBox2.Text;
            }

            


            //yetersiz bakıye
            var bakiye = veritabani.Select("select Miktar from PersonelKasa where ParaBirimi ='"+textBox5.Text+"'");
            string kasabakiye = bakiye.Rows[0]["Miktar"].ToString();
            string verim = textBox6.Text;
            decimal k;
            decimal v;

            bool k1 = decimal.TryParse(kasabakiye, out k);
            bool v1 = decimal.TryParse(verim, out v);

            if (k1 && v1)
            {
                if (v > k)
                {
                    label18.Visible = true;
                    button3.Enabled = false;
                    label18.Text = "Kasada yeterli "+textBox5.Text+" bulunmamakta";
                    linkLabel1.Text =textBox5.Text+" eklemek için tıklayın";
                    button4.Visible = true;
                    label19.Visible = true;
                    linkLabel1.Visible = true;
                }
                else
                {
                    label18.Visible = false;
                    label19.Visible = false;
                    button4.Visible = false;
                    linkLabel1 .Visible = false;
                    //dataGridView1.DataSource = veritabani.Select("  select*from PersonelKasa order by Miktar desc");
                }
            }



            if (label18.Visible == true)
            {
                textBox8.Enabled = false;
            }
            else
            {
                textBox8.Enabled = true;

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var gelen = veritabani.Select("  select Aliskuru from DovizKurlari where dovizCifti ='USDTRY'");
                textBox3.Text = gelen.Rows[0]["Aliskuru"].ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var yazi = textBox5.Text;
            label15.Text = yazi.ToString();
            int selectionStart = textBox5.SelectionStart;
            int selectionLength = textBox5.SelectionLength;
            textBox5.Text = textBox5.Text.ToUpper();
            textBox5.SelectionStart = selectionStart;
            textBox5.SelectionLength = selectionLength;



            if (textBox2.Text.Length == 3 && !button2.Enabled)
            {
                if (textBox5.Text == "TRY")
                {


                    pictureBox2.Image = Image.FromFile(TRY);
                }
                if (textBox5.Text == "USD")
                {


                    pictureBox2.Image = Image.FromFile(USD);
                }
                if (textBox5.Text == "EUR")
                {


                    pictureBox2.Image = Image.FromFile(EUR);
                }
                button2.Enabled = true;
            }

            else if (textBox5.Text.Length != 3 && button2.Enabled)
            {


                button2.Enabled = false;
            }
        }

  
        
        private void button3_Click(object sender, EventArgs e)
        {
            veritabani.Insert(" INSERT INTO islemler ( MusteriAdiSoyadi, MusteriTC, IslemTuru, AlinanMiktar, VerilenMiktar)   VALUES ( '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', " + textBox1.Text + ", " + textBox6.Text + ")");
            veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + '" + textBox1.Text + "' WHERE ParaBirimi = '" + textBox2.Text + "';");
            veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - '" + textBox6.Text + "' WHERE ParaBirimi = '" + textBox5.Text + "';");

            /*if (textBox9.Text=="EURUSD" || textBox9.Text == "EURTRY"|| textBox9.Text == "USDTRY")
            {
                
            }
           else

            {
                veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + '" + textBox6.Text + "' WHERE ParaBirimi = '" + textBox5.Text + "';");
                veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - '" + textBox1.Text + "' WHERE ParaBirimi = '" + textBox2.Text + "';");
            }*/
            MessageBox.Show("Yazı işlemi başarılı!", "Başarılı");


            //veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + '" + textBox1.Text + "' WHERE ParaBirimi = '" + textBox2.Text + "';");
            //veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - '" + textBox6.Text + "' WHERE ParaBirimi = '" + textBox5.Text + "';");
            button3.BackColor = SystemColors.Control;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            label10.Text = "0";
            label9.Text = "0";
            button7.PerformClick();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
          
                if (textBox8.Text.Length == 11)
                {
                    button3.Enabled = true;
                button3.BackColor = Color.LightGreen;
                }
                else
                {
                    button3.Enabled = false;
                }
                if (textBox8.Text.Length > 11)
                {
                    textBox8.Text = textBox8.Text.Substring(0, 11);
                    textBox8.SelectionStart = 11;
                }
            
            

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(textBox6.Text))
                return;
            string[] parts = textBox6.Text.Split(',');
            if (parts.Length == 2 && int.TryParse(parts[0], out int intValue) && int.TryParse(parts[1], out int decimalValue))
            {
                textBox6.Text = intValue.ToString();
            }*/
            string girilenMetin = textBox6.Text;
            int virgulIndex = girilenMetin.IndexOf(',');

            if (virgulIndex != -1)
            {
                
                string yeniMetin = girilenMetin.Substring(0, virgulIndex);
                
                textBox6.Text = yeniMetin;

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Select("  select*from PersonelKasa order by Miktar desc");


            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["parabirimi"].Value != null && row.Cells["parabirimi"].Value.ToString() == ""+textBox5.Text+"")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

   

        private void button6_Click(object sender, EventArgs e)
        {
          
            textBox7.Text = "muhammed suleyman";
            textBox8.Text = "25757364458";
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           // veritabani.Insert(" INSERT INTO islemler ( MusteriAdiSoyadi, MusteriTC, IslemTuru, AlinanMiktar, VerilenMiktar)   VALUES ( '" + q1.Text + "', '" + q2.Text + "', '" + q3.Text + "', " + q4.Text + ", " + q5.Text + ")");
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void q5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Select("  select*from PersonelKasa order by Miktar desc");
        }

        private void button8_Click(object sender, EventArgs e)
        {/*
            veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + '" + textBox10.Text + "' WHERE ParaBirimi = '" + textBox2.Text + "';");
          
            veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - '" + textBox11.Text + "' WHERE ParaBirimi = '" + textBox5.Text + "';");
            */
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            kasalararasindaparatransferleri kasa22=new kasalararasindaparatransferleri();
            kasa22.ShowDialog(this);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
