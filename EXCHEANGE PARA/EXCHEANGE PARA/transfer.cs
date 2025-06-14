using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCHEANGE_PARA
{
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
            comboBox1.Focus();

            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }
        SoundPlayer player = new SoundPlayer();
        private void transfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-slot-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                this.Close();

            }
        }

        private void transfer_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;


            


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text== "*")
            { 
            button1.Text= "/";
            button1.BackColor=Color.FromArgb(128,128,255);
            textBox7.BackColor=Color.FromArgb(128, 128, 255);
            }
            else 
            {
                button1.Text = "*";
                button1.BackColor = Color.FromArgb(255, 128, 128);
                textBox7.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                label10.Visible=false;
                textBox5.Visible=false;
                textBox8.Visible = false;
            }
            if (comboBox2.SelectedIndex == 1 || comboBox2.SelectedIndex == 2)
            {
                label10.Visible = true;
                textBox5.Visible = true;
                textBox8.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Formun içeriğini çizdir
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(5, 5, this.Width, this.Height));
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox1.Focus();
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button5.Focus();
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Text == "*")
            {
                double miktar = double.Parse(textBox1.Text);
                double dovizkuru = double.Parse(textBox7.Text);
                int sonuc = (int)(miktar * dovizkuru);
                textBox11.Text = sonuc.ToString();
            }
            else if (button1.Text == "/")
            {
                double miktar = double.Parse(textBox1.Text);
                double dovizkuru = double.Parse(textBox7.Text);
                int sonuc = (int)(miktar / dovizkuru);
                textBox11.Text = sonuc.ToString();
            }
           

            if (comboBox2.SelectedIndex == 1)
            {
                double mik2 = double.Parse(textBox1.Text);
                double yuzde = double.Parse(textBox5.Text);
                double ilktoplam = (double)(mik2 * yuzde) / 1000;
                double sontoplam = (double)(mik2-ilktoplam);
                textBox8.Text= ilktoplam.ToString();
                textBox4.Text = sontoplam.ToString();
            }
            if (comboBox4.SelectedIndex == 1)
            {
                
            }
            

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button6.PerformClick();
                e.Handled= true;
            }
        }
    }
}
