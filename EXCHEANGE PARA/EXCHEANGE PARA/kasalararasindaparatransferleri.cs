using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXCHEANGE_PARA
{
    public partial class kasalararasindaparatransferleri : Form
    {
        public kasalararasindaparatransferleri()
        {
            InitializeComponent();
        }
        veritabani veritabani=new veritabani();
        private void kasalararasindaparatransferleri_Load(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = veritabani.Select("  select icon,bakiye from kasa");
            dataGridView2.DataSource = veritabani.Select("   select *from PersonelKasa order by Miktar desc  ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (comboBox1.SelectedIndex == 1)
            {
                textBox3.Text = "";
                dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='TRY'");
                dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='TRY'");
            }
            if (comboBox1.SelectedIndex == 1)
             {
                textBox3.Text = "TRY";
                dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='TRY'");
                 dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='TRY'");
             }
             if (comboBox1.SelectedIndex == 2)
             {
                textBox3.Text = "EUR";
                dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='EUR'");
                 dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='EUR'");
             }
             if (comboBox1.SelectedIndex == 3)
             {
                textBox3.Text = "USD";
                dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='USD'");
                 dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='USD'");
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender,e);
            if (textBox1.Text.Length == 2)
            {
                button2.Enabled = true;
                button2.BackColor = Color.LightGreen;
            }
            // textBox1.Text = textBox2.Text;
            /* var alinan = textBox1.Text;
             alinan = textBox2.Text;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alinan = textBox1.Text;
             textBox2.Text=alinan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    
                    veritabani.UpdateDelete("UPDATE kasa SET bakiye = bakiye - " + textBox2.Text + " WHERE icon = '" + textBox3.Text + "';");
                    veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + " + textBox2.Text + " WHERE ParaBirimi = '" + textBox3.Text + "';");
                   DialogResult onay = MessageBox.Show("Başarılı", "Aktarma ");
                    if(onay == DialogResult.OK)
                    {
                        dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='TRY'");
                        dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='TRY'");
                       
                        
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {

                    veritabani.UpdateDelete("UPDATE kasa SET bakiye = bakiye - " + textBox2.Text + " WHERE icon = '" + textBox3.Text + "';");
                    veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + " + textBox2.Text + " WHERE ParaBirimi = '" + textBox3.Text + "';");
                    DialogResult onay = MessageBox.Show("Başarılı","Aktarma ");
                    if (onay == DialogResult.OK)
                    {
                        dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='EUR'");
                        dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='EUR'");
                        

                    }
                }
                if (comboBox1.SelectedIndex == 3)
                {

                    veritabani.UpdateDelete("UPDATE kasa SET bakiye = bakiye - " + textBox2.Text + " WHERE icon = '" + textBox3.Text + "';");
                    veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + " + textBox2.Text + " WHERE ParaBirimi = '" + textBox3.Text + "';");
                    DialogResult onay = MessageBox.Show("Başarılı", "Aktarma ");
                    if (onay == DialogResult.OK)
                    {
                        dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='USD'");
                        dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='USD'");
                       

                    }
                }
            }
            if (radioButton2.Checked)
            {
                if (comboBox1.SelectedIndex == 1)
                {

                    veritabani.UpdateDelete("UPDATE kasa SET bakiye = bakiye + " + textBox2.Text + " WHERE icon = '" + textBox3.Text + "';");
                    veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - " + textBox2.Text + " WHERE ParaBirimi = '" + textBox3.Text + "';");
                    DialogResult onay = MessageBox.Show("Başarılı", "Aktarma ");
                    if (onay == DialogResult.OK)
                    {
                        dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='TRY'");
                        dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='TRY'");


                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {

                    veritabani.UpdateDelete("UPDATE kasa SET bakiye = bakiye + " + textBox2.Text + " WHERE icon = '" + textBox3.Text + "';");
                    veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - " + textBox2.Text + " WHERE ParaBirimi = '" + textBox3.Text + "';");
                    DialogResult onay = MessageBox.Show("Başarılı", "Aktarma ");
                    if (onay == DialogResult.OK)
                    {
                        dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='EUR'");
                        dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='EUR'");


                    }
                }
                if (comboBox1.SelectedIndex == 3)
                {

                    veritabani.UpdateDelete("UPDATE kasa SET bakiye = bakiye + " + textBox2.Text + " WHERE icon = '" + textBox3.Text + "';");
                    veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - " + textBox2.Text + " WHERE ParaBirimi = '" + textBox3.Text + "';");
                    DialogResult onay = MessageBox.Show("Başarılı", "Aktarma ");
                    if (onay == DialogResult.OK)
                    {
                        dataGridView1.DataSource = veritabani.Select("select icon,bakiye from kasa where icon='USD'");
                        dataGridView2.DataSource = veritabani.Select(" select *from PersonelKasa where ParaBirimi ='USD'");


                    }
                }
            }







            textBox1.Text = "";
            
            //veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar + '" + textBox1.Text + "' WHERE ParaBirimi = '" + comboBox1.SelectedIndex = 3 + "';");
            //  veritabani.UpdateDelete("UPDATE PersonelKasa SET Miktar = Miktar - '" + textBox2.Text + "' WHERE ParaBirimi = '" + comboBox1.SelectedIndex = 2 + "';");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
