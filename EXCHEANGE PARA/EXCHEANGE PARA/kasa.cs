using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCHEANGE_PARA
{
    public partial class kasa : Form
    {
        /*private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-VHMUHAV\SQLEXPRESS;Initial Catalog=Exchange_money;Integrated Security=True");
        private SqlDataAdapter adapter;
        private DataTable table;*/
        veritabani db=new veritabani();
        
        public kasa()
        {
            InitializeComponent();
            

        }

        private void kasa_Load(object sender, EventArgs e)
        {
            checkBox1.Checked= true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            //GetData();
            this.KeyPreview = true;
                this.KeyDown += kasa_KeyDown;
            //keydown calistir
            

               comboBox1.SelectedIndex = 0;
            /*
               dataGridView1.Columns["Column1"].ReadOnly = true;
               dataGridView1.Columns["Column2"].ReadOnly = true;
               dataGridView1.Columns["Column3"].ReadOnly = true;
               dataGridView1.Columns["Column4"].ReadOnly = true;
               dataGridView1.RowHeadersVisible = false;
               foreach (DataGridViewColumn column in dataGridView1.Columns)
               {
                   column.ReadOnly = true;
                   column.Resizable = DataGridViewTriState.False;
                   column.Frozen = true;
               }
               dataGridView1.AllowUserToResizeColumns = false; 
               dataGridView1.AllowUserToResizeRows = false;*/
            

        }
        private void GetData()
        {
            try
            {
                dataGridView1.DataSource= db.Select("SELECT * FROM kasa");
                /* Veritabanından verileri çek
                 adapter = new SqlDataAdapter("SELECT * FROM kasa", connection);
                 table = new DataTable();
                 adapter.Fill(table);

                 // DataGridView'e verileri yükle
                 dataGridView1.DataSource = table;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler getirilirken bir hata oluştu: " + ex.Message);
            }
           
           


        }
        private void GetData1()
        {
           /* try
            {
                // Veritabanından verileri çek
                adapter = new SqlDataAdapter("SELECT * FROM kasa where bakiye ", connection);
                table = new DataTable();
                adapter.Fill(table);

                // DataGridView'e verileri yükle
                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {
                label1.Text = "0";
            }*/

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
           /* string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\build-ghost-tile.wav";
            player.SoundLocation = soundFile;
            player.Play();*/
        }

       // spark2

        SoundPlayer hafifbutunsesi = new SoundPlayer(@"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-green-button.wav");
        SoundPlayer guncelemesesi = new SoundPlayer(@"D:\C# PROJECT\EXCHEANGE PARA\data\sound\mouse_click.wav");
        SoundPlayer lightswitch2 = new SoundPlayer(@"D:\C# PROJECT\EXCHEANGE PARA\data\sound\lightswitch2.wav");
        SoundPlayer ac = new SoundPlayer(@"D:\C# PROJECT\EXCHEANGE PARA\data\sound\enemy_died.wav");
        SoundPlayer kapat = new SoundPlayer(@"D:\C# PROJECT\EXCHEANGE PARA\data\sound\friend_died.wav");
        
        private void button1_Click(object sender, EventArgs e)
        {
            string kosul = "0";
            if (checkBox1.Checked)
                kosul += ",1";
            if (checkBox2.Checked)
                kosul += ",2";
            if (checkBox3.Checked)
                kosul += ",3";
            dataGridView1.DataSource = db.Select("select icon,para,bakiye,dovizkuru,drum from kasa where dovizkuru_id in(" + kosul+")");









            //  GetData();
            // guncelemesesi.Play();



        }

        private void kasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
             
                this.Close();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                GetData();
                guncelemesesi.Play();

            }
            if (e.Shift && e.KeyCode == Keys.D1)
            {

                
                if (checkBox1.Checked == false)
                {
                    checkBox1.Checked = true;
                    ac.Play();
                }
                else
                {
                    checkBox1.Checked = false;
                    kapat.Play();   
                }
            }
            if (e.Shift && e.KeyCode == Keys.D2)
            {


                if (checkBox2.Checked == false)
                {
                    checkBox2.Checked = true;
                    ac.Play();
                }
                else
                {
                    checkBox2.Checked = false;
                    kapat.Play();
                }
            }
            if (e.Shift && e.KeyCode == Keys.D3)
            {


                if (checkBox3.Checked == false)
                {
                    checkBox3.Checked = true;
                    ac.Play();
                }
                else
                {
                    checkBox3.Checked = false;
                    kapat.Play();
                }
            }
        }
        private void PlaySound(string soundFile)
        {
           
           /* using (SoundPlayer player = new SoundPlayer(soundFile))
            {
                player.Play();
            }*/
        }

        private void kasa_KeyDown_1(object sender, KeyEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            hafifbutunsesi.Play();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hafifbutunsesi.Play();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

            private void parabirimisec(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*  private void RefreshData()
          {
             // dataGridView1.Refresh();
          }*/
    }
}
