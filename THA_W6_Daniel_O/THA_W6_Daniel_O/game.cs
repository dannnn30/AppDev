using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_Daniel_O
{
    public partial class game : Form
    {
        List<Button> buttonList = new List<Button>();
        List<Button> buttonList2 = new List<Button>();
        int terima = 0;
        static Random Random = new Random();
        static string[] file = File.ReadAllText("Wordle Word List.txt").Split(',');
        static int rnd = Random.Next(14000);
        static string kata = file[rnd];
        static string kata2 = kata.ToUpper();
        List<string> keyboard = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "ENTER", "Z", "X", "C", "V", "B", "N", "M", "DELETE" };
        static int cek = 0;
        static int a = 0;
        static int stop = 0;
        static string full = "";
        int tag = 0;
        public game(int send)
        {
            InitializeComponent();
            terima = send;
        }

        private void game_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < terima; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(x,y);
                    this.Controls.Add(button);
                    button.Tag = tag;
                    tag++;
                    buttonList.Add(button);
                    x += 50;
                }
                x = 10;
                y += 50;
            }
            int pos1 = 0;
            int pos2=0;
            int a = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    pos1 = 300;
                    pos2 = 50;
                    for (int j = 0; j < 10; j++)
                    {
                        Button btn = new Button();
                        btn.Size = new System.Drawing.Size(50, 50);
                        btn.Location = new Point(pos1, pos2);
                        btn.Tag = keyboard[a].ToString();
                        btn.Text = keyboard[a].ToString();
                        pos1 += 50;
                        btn.Click += button_click;
                        a++;
                        buttonList2.Add(btn);
                        Controls.Add(btn);
                    }
                }
                else
                {
                    pos1 = 320;
                    pos2 += 50;
                    for (int m = 0; m < 9; m++)
                    {
                        Button btn2 = new Button();
                        btn2.Size = new System.Drawing.Size(50, 50);
                        btn2.Location = new Point(pos1, pos2);
                        btn2.Tag = keyboard[a].ToString();
                        btn2.Text = keyboard[a].ToString();
                        if (keyboard[a].ToString() == "ENTER")
                        {
                            btn2.Location = new Point(pos1 - 30, pos2);
                            btn2.Size = new Size(80, 50);
                            btn2.Click += button_enter;
                        }
                        else if (keyboard[a].ToString() == "DELETE")
                        {
                            btn2.Location = new Point(pos1, pos2);
                            btn2.Size = new Size(80, 50);
                            btn2.Click += button_delete;
                        }
                        else
                        {
                            btn2.Click += button_click;
                        }
                        pos1 += 50;
                        a++;
                        buttonList2.Add(btn2);
                        Controls.Add(btn2);
                    }
                }
            }
        }
        private void button_click(object sender, EventArgs e)
        {
            Button click = sender as Button;
            
            if(cek<5)
            {
                buttonList[a].Text= click.Tag.ToString();
                cek++;
                a++;
            }
            //MessageBox.Show(click.Tag.ToString());
        }
        private void button_enter(object sender, EventArgs e)
        {
            full = "";
            if (cek<5)
            {
                MessageBox.Show("harus 5 huruf blokk");
            }
            else
            {
                full = buttonList[a - 5].Text.ToLower() + buttonList[a - 4].Text.ToLower()
               + buttonList[a - 3].Text.ToLower() + buttonList[a - 2].Text.ToLower()
               + buttonList[a - 1].Text.ToLower();
                MessageBox.Show(kata2);
                //MessageBox.Show(full);
                if (file.Contains(full))
                {
                    
                    string full2 = full.ToUpper();
                    for (int i = kata2.Length-1; i >= 0; i--)
                    {
                       
                        if (kata2[i] == full2[i])
                        {
                            buttonList[(a-1)-(4-i)].BackColor=Color.Green;
                        }
                    }
                    if (cek == 5)
                    {
                        cek = 0;
                    }
                }
                else
                {
                    MessageBox.Show(full.ToUpper() + " bukan kata");
                }
            }
        }
        private void button_delete(object sender, EventArgs e)
        {
            if(cek>stop)
            {
                buttonList[a - 1].Text = "";
                cek--;
                a--;
            }
        }
    }
}
