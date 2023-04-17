using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace THA_W7_Daniel_O
{
    public partial class ahihihi : Form
    {
        static List<Button> buttons = new List<Button>();
        static ImageList image = new ImageList();
        static DataTable dt = new DataTable();
        int num = 0;
        static string name = "";
        int n = 0;
        string o = "";
        int pas = 0;
        public static ahihihi bridge;
        int poster = 0; 

        public ahihihi(string nama,ImageList imageList,DataTable data, int poster)
        {
            InitializeComponent();
            name = nama;
            image = imageList;
            dt = data;
            bridge = this;
            this.poster= poster;
        }
        private void ahihihi_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button seat = new Button();
                    seat.Location = new Point(x,y);
                    seat.Size = new Size(35,35);
                    seat.Tag = num;
                    num++;
                    buttons.Add(seat);
                    seat.Click += bttn_buy;
                    this.Controls.Add(seat);
                    x += 35;
                }
                x = 10;
                y += 35;
            }
            pictureBox1.Image = image.Images[poster];
        }
        private void bttn_buy(object sender, EventArgs e)
        {
            Button buy = sender as Button;
            if(buy.BackColor == Color.White)
            {
                buy.BackColor = Color.Green;
            }
            else if (buy.BackColor == Color.Green)
            {
                buy.BackColor= Color.White;
            }
        }
        private void button_jam1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (dt.Rows[i][0].ToString()==name)
                {
                    n=i;    
                }
            }
            o = dt.Rows[n][1].ToString();
            seat(1);
            pas = 1;
            add.Enabled = true;
            reset.Enabled = true;
        }
        private void back_Click(object sender, EventArgs e)
        {
            Form1.bridge.pnl.Visible = false;
            this.Close();
            buttons.Clear();
        }
        private void seat(int time)
        {
            dt.Rows[time][2] = o;

            int cek = 0;
            foreach (Button button in buttons)
            {
                if (o[cek] == '0')
                {
                    button.BackColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                cek++;
            }
        }

        private void button_jam2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (dt.Rows[i][0].ToString() == name)
                {
                    n = i;
                }
            }
            o = dt.Rows[n][2].ToString();
            seat(2);
            pas = 2;
            add.Enabled = true;
            reset.Enabled = true;
        }

        private void button_jam3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (dt.Rows[i][0].ToString() == name)
                {
                    n = i;
                }
            }
            o = dt.Rows[n][3].ToString();
            seat(3);
            pas = 3;
            add.Enabled = true;
            reset.Enabled = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            o = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            seat(pas);
        }

        private void add_Click(object sender, EventArgs e)
        {
           List<string> list = new List<string>();
            foreach (Button butt in buttons)
            {
                if (butt.BackColor == Color.Green)
                {
                    butt.BackColor = Color.Red;
                    list.Add(butt.Tag.ToString());
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
