using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_Daniel_O
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tebox_guess_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tebox_guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if(int.Parse(tebox_guess.Text)<=3)
            {
                MessageBox.Show("Must be greater than 3");
            }
            else
            {
                game game = new game(int.Parse(tebox_guess.Text));
                game.Show();
            }
        }
    }
}
