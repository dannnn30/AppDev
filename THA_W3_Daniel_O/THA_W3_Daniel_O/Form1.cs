using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Daniel_O
{
    public partial class MainForm : Form
    {
        public static MainForm bridge;
        int cek = 0;
        public MainForm()
        {
            InitializeComponent();
            bridge = this;
        }

        private void cb_valid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!cb_valid.Checked)
            {
                MessageBox.Show("Please checked the validation box", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cek == 0)
            {
                MessageBox.Show("Please open the next form", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tb_fav.Text == "" || tb_name.Text == "")
                {
                    MessageBox.Show("Please fill the box", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Form2.bridge.lab1.Text = "Hi, my name is " + tb_name.Text +
                   " and my favorite artist is " + tb_fav.Text;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MainForm = this;
            form2.Show();
            cek = 1;
        }
    }
}