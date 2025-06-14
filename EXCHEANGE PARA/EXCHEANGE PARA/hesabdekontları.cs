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
    public partial class hesabdekontları : Form
    {
        public hesabdekontları()
        {
            InitializeComponent();
        }
            veritabani db = new veritabani();
        private void button1_Click(object sender, EventArgs e)
        {
            string datacıkart = textBox1.Text as string;
            if (datacıkart == "muhammed-USD-hesabı-DOLAR")
            {
                dekontac dekontac=new dekontac();
                dekontac.ShowDialog();

                  
            }                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButton3.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void hesabdekontları_Load(object sender, EventArgs e)
        {
            
           
           dateTimePicker1.Enabled=false;
            dateTimePicker2.Enabled=false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var gelen = db.Select("select adi from musteriler where adi like '%"+textBox1.Text+"%'");
            textBox1.AutoCompleteCustomSource.Clear();
            foreach (DataRow item in gelen.Rows)
            {
                textBox1.AutoCompleteCustomSource.Add(item["adi"].ToString());
            }
        }
    }
}
