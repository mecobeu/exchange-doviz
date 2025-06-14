using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EXCHEANGE_PARA
{
    public partial class dekontac : Form
    {
        public dekontac()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        veritabani veritaban=new veritabani();
        private void dekontac_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc = veritaban.Select("SELECT borçlu, alacakli, bakiye, ifade, [işlem tarihi], işlem_saati, işlem_numarası\r\nFROM musteri_doviz_adi");
            dataGridView1.DataSource = sonuc;
        }
    }
}
