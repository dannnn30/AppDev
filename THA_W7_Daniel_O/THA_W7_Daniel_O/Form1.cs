using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Daniel_O
{
    public partial class Form1 : Form
    {
        static List<string> movie = new List<string>() { "Tenki No Ko", "8 Mile", "Harry Potter", "Haikyuu Final", "Pitch Perfect", "The Nun", "Sing", "Spider-Man" };
        static List<Button> buttona = new List<Button>();
        static List<string> rndseat = new List<string>();
        static Random random = new Random();
        DataTable dt = new DataTable();
        public static Form1 bridge;
        public Panel pnl;
        static int cek = 0;
        public Form1()
        {
            InitializeComponent();
            bridge = this;
            pnl = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label2 = new Label();
            label2.Text = "MOVIE LIST";
            label2.Location = new Point(250, 10);
            label2.Font = new Font("Copperplate Gothic Light", 16);
            label2.Size=new Size (200,20);
            this.Controls.Add(label2);
            //Panel panel = new Panel();
            //panel.Dock = DockStyle.Fill;
            //panel.BackColor = Color.Transparent;
            //this.Controls.Add(panel);
            int posx = 50;
            int posy = 50;
            for (int i = 0; i < 8; i++)
            {
                if(i<=3)
                {
                    Label label = new Label();                      //judul
                    label.Location = new Point(posx, posy+160);
                    label.Tag = i;
                    label.Text = movie[i];
                    label.Font = new Font("Arial", 10,FontStyle.Bold);
                    this.Controls.Add(label);
                    PictureBox picture = new PictureBox();          //poster
                    picture.Location = new Point(posx, posy);
                    picture.Size = new Size(100, 150);
                    picture.Tag = i;
                    this.Controls.Add(picture);
                    picture.Image = imageList1.Images[i];
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    Button button = new Button();                   //button
                    button.Tag = i;
                    button.Text = "Watch";
                    button.Size = new Size(50, 20);
                    button.Location = new Point(posx+25, posy + 190);
                    button.BackColor = Color.White;
                    this.Controls.Add(button); 
                    buttona.Add(button);
                    button.Click += Button_Click;
                    posx = posx + 150;
                }
                else
                {
                    posx -= 150;
                    posy = 300;
                    Label label = new Label();              //judul
                    label.Location = new Point(posx, posy + 160);
                    label.Tag = i;
                    label.Text = movie[i];
                    label.Font = new Font("Arial", 10, FontStyle.Bold);
                    this.Controls.Add(label);
                    Button button = new Button();           //button
                    button.Tag = i;
                    button.Text = "Watch";
                    button.Size = new Size(50, 20);
                    button.Location = new Point(posx + 25, posy + 190);
                    button.BackColor= Color.White;
                    this.Controls.Add(button);
                    buttona.Add(button);
                    button.Click += Button_Click;
                    PictureBox picture = new PictureBox();  //poster
                    picture.Location = new Point(posx, posy);
                    picture.Size = new Size(100, 150);
                    picture.Tag = i;
                    this.Controls.Add(picture);
                    picture.Image = imageList1.Images[i];
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            for (int i = 0; i <24; i++)
            {
                string isi = "";
                for (int j = 0; j < 100; j++)
                {
                    int penuh = random.Next(0, 100);
                    if (penuh < 70)
                    {
                        isi = isi + 1.ToString();
                    }
                    else
                    {
                        isi = isi + 0.ToString();
                    }
                }
                rndseat.Add(isi);
            }
            dt.Columns.Add("Name");
            dt.Columns.Add("22:00");
            dt.Columns.Add("00:00");
            dt.Columns.Add("12:00");
            for (int i = 0; i < movie.Count; i++)
            {
                dt.Rows.Add(movie[i], rndseat[i], rndseat[i + 1], rndseat[i + 2]);
            }
        }
        private void Button_Click (object Sender, EventArgs e)
        {
            Button button = Sender as Button;
            int a = Convert.ToInt16(button.Tag);
            ahihihi ahihihi = new ahihihi(dt.Rows[a][0].ToString(), imageList1,dt,a);
            ahihihi.TopLevel = false;
            panel1.Visible = true;
            this.panel1.Controls.Add(ahihihi);
            ahihihi.Show();
        }
        public void Tutup()
        {
            panel1.Visible = false;
        }
    }
}
