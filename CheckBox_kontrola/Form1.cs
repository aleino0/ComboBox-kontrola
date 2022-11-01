using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dorucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vecera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sakrijNarudzbu_CheckedChanged(object sender, EventArgs e)
        {
            if(sakrijNarudzbu.Checked)
            {
                narudzba.Visible = false;
            }
            else
            {
                narudzba.Visible = true;
            }
        }

        private void posalji_Click(object sender, EventArgs e)
        {
            narudzba.Text = "Odabrali ste:";
            if(dorucak.Checked)
            {
                narudzba.Text = narudzba.Text + "\r\nDoručak";
            }
            if(rucak.Checked)
            {
                narudzba.Text = narudzba.Text + "\r\nRučak";
            }
            if(Vecera.Checked)
            {
                narudzba.Text = narudzba.Text + "\r\nVečera";
            }
        }

        private void narudzba_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
