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
    public partial class Form2 : Form
    {
        public static Form2 bridge;
        public Label lab1;
        public MainForm MainForm
        { get; set; }
        public Form2()
        {
            InitializeComponent();
            bridge = this;
            lab1 = lab_result;
        }

        private void btn_magic_Click(object sender, EventArgs e)
        {
            if (!cb_agreement.Checked&&!cb_pick.Checked)
            {
                MessageBox.Show("Please checked the validation box", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(!rbtn_yellow.Checked&&!rbtn_pink.Checked&&!rbtn_blue.Checked&&!rbtn_green.Checked
                    &&!rbtn_red.Checked)
                {
                    MessageBox.Show("Please pick your background color", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rbtn_pink.Checked)
                    {
                        MainForm.BackColor = Color.Pink;
                    }
                    else if (rbtn_blue.Checked)
                    {
                        MainForm.BackColor = Color.Blue;
                    }
                    else if (rbtn_green.Checked)
                    {
                        MainForm.BackColor = Color.Green;
                    }
                    else if (rbtn_red.Checked)
                    {
                        MainForm.BackColor = Color.Red;
                    }
                    else if (rbtn_yellow.Checked)
                    {
                        MainForm.BackColor = Color.Yellow;
                    }
                } 
                if(!rbtn_text_blue.Checked&&!rbtn_text_green.Checked&&!rbtn_text_red.Checked)
                {
                    MessageBox.Show("Please pick your text color", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rbtn_text_blue.Checked)
                    {
                        MainForm.ForeColor = Color.Blue;
                    }
                    else if (rbtn_text_green.Checked)
                    {
                        MainForm.ForeColor = Color.Green;
                    }
                    else if (rbtn_text_red.Checked)
                    {
                        MainForm.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}