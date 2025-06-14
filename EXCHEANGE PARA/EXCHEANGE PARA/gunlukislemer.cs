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

namespace EXCHEANGE_PARA
{
    public partial class gunlukislemer : Form
    {
        public gunlukislemer()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();
        private void gunlukislemer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                string soundFile = @"D:\C# PROJECT\EXCHEANGE PARA\data\sound\gui-slot-button.wav";
                player.SoundLocation = soundFile;
                player.Play();
                this.Close();

            }
        }

        private void gunlukislemer_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;

            dataGridView1.Columns["Column1"].ReadOnly = true;
            dataGridView1.Columns["Column2"].ReadOnly = true;
            dataGridView1.Columns["Column3"].ReadOnly = true;
            //dataGridView1.Columns["Column4"].ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
                column.Frozen = true;
            }
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
