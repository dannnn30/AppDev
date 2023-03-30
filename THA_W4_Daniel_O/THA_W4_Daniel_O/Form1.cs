using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static THA_W4_Daniel_O.Form1;

namespace THA_W4_Daniel_O
{
    public partial class Form1 : Form
    {
        public class defaultsetting
        {
            public Team ACM()
            {
                Team teams = new Team();
                teams.teamname = "AC Milan";
                teams.teamcity = "Milan";
                teams.teamcountry = "Italy";
                teams.player1 = new List<players>();
                string[] play = { "Ismael Bennacer", "Fode Toure", "Sandro Tonali", "Brahim Diaz", "Zlatan Ibrahimovic", "Mike Maignan", "Rafael Leão", "Pierre Kalulu Kyatengwa", "Fikayo Tomori", "Malick Thiaw", " Alexis Saelemaekers" };
                string[] num = { "04", "05", "08", "10", "11", "16", "17", "20", "23", "28", "56" };
                string[] pos = { "MF", "MF", "MF", "FW", "FW", "GK", "FW", "DF", "DF", "DF", "MF" };
                for (int i = 0; i < play.Length; i++)
                {
                    players player = new players();
                    player.playername = play[i];
                    player.playernum = num[i];
                    player.playerpos = pos[i];
                    teams.player1.Add(player);
                }
                return teams;
            }
            public Team IM()
            {
                Team teams = new Team();
                teams.teamname = "Inter Milan";
                teams.teamcity = "Milan";
                teams.teamcountry = "Italy";
                teams.player1 = new List<players>();

                string[] play = { "Edin Džeko", "Lautaro Martínez", "Francesco Acerbi", "Hakan Çalhanoğlu", "Henrikh Mkhitaryan",
                    "Nicolò Barella", "André Onana", "Federico Dimarco", "Matteo Darmian","Milan Škriniar","Alessandro Bastoni" };
                string[] num = { "09", "10", "15", "20", "22", "23", "24", "32", "36", "37", "95" };
                string[] pos = { "FW", "FW", "DF", "MF", "MF", "MF", "GK", "MF", "MF", "DF", "DF" };
                for (int i = 0; i < play.Length; i++)
                {
                    players player = new players();
                    player.playername = play[i];
                    player.playernum = num[i];
                    player.playerpos = pos[i];
                    teams.player1.Add(player);
                }
                return teams;
            }

            public Team ASR()
            {
                Team teams = new Team();
                teams.teamname = "AS Roma";
                teams.teamcity = "Roma";
                teams.teamcountry = "Italy";
                teams.player1 = new List<players>();
                string[] play = { "Rui Patrício", "Rick Karsdorp", "Roger Ibañez", "Bryan Cristante", "Chris Smalling", "Lorenzo Pellegrini", "Tammy Abraham", "Nicolò Zaniolo", "Gianluca Mancini", "Edoardo Bove", "Nicola Zalewski" };
                string[] num = { "01", "02", "03", "04", "06", "07", "09", "22", "23", "52", "59" };
                string[] pos = { "GK", "MF", "DF", "MF", "DF", "MF", "FW", "MF", "DF", "MF", "MF" };
                for (int i = 0; i < play.Length; i++)
                {
                    players player = new players();
                    player.playername = play[i];
                    player.playernum = num[i];
                    player.playerpos = pos[i];
                    teams.player1.Add(player);
                }
                return teams;
            }
        }

        public class Team
        {
            public string teamname;
            public string teamcountry;
            public string teamcity;
            public List<players> player1;
            
        }
        public class players
        {
            public string playername;
            public string playernum;
            public string playerpos;
        }
        public List<Team> teams = new List<Team>();

        public Form1()
        {
            InitializeComponent();
            defaultsetting defaultsetting = new defaultsetting();
            teams.Add(defaultsetting.ACM());
            teams.Add(defaultsetting.IM());
            teams.Add(defaultsetting.ASR());
            Update();
        }

        private void btn_addTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            if (tebox_tmCountry.Text == "" || tebox_tmCity.Text == "" || tebox_tmName.Text == "")
            {
                MessageBox.Show("please fill all the box");
            }
            else
            {
                int cek = 0;
                team.teamcountry = tebox_tmCountry.Text;
                team.teamcity = tebox_tmCity.Text;
                team.teamname = tebox_tmName.Text;
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].teamcountry == team.teamcountry)
                    {
                        cek++;
                    }
                }
                if (cek == 0)
                {
                    cbox_chooseCountry.Items.Add(tebox_tmCountry.Text);
                }
                else
                {
                    MessageBox.Show("Team is already exist");
                }
                tebox_tmCountry.Clear();
                tebox_tmName.Clear();
                tebox_tmCity.Clear();
                Update();
            }
        }

        private void cbox_chooseCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countryChoose = cbox_chooseCountry.Text;
            cbox_chooseTeam.Items.Clear();
            foreach (Team tim in teams)
            {
                if (tim.teamcountry == countryChoose)
                {
                   cbox_chooseTeam.Items.Add(tim.teamname);
                }
            }
        }
        private async void Update()
        {
            cbox_chooseCountry.Items.Clear();
            foreach (Team tim in teams)
            {
                if (cbox_chooseCountry.Items.Contains(tim.teamcountry))
                {

                }
                else
                {
                    cbox_chooseCountry.Items.Add(tim.teamcountry);
                }
            }
        }
        private void btn_addPlayer_Click(object sender, EventArgs e)
        {
            players players = new players();
            if (tebox_playName.Text == "" || tebox_playNum.Text == "" || combox_PlayPos.Text == "")
            {
                MessageBox.Show("please fill all the box");
            }
            else
            {
                bool kembar = false;
                players.playername = tebox_playName.Text;
                players.playernum = tebox_playNum.Text;
                players.playerpos = combox_PlayPos.Text;
                foreach (Team tim in teams)
                {
                    if (tim.teamname == cbox_chooseCountry.SelectedItem.ToString())
                    {
                        foreach (players main in tim.player1)
                        {
                            if (main.playername == tebox_playName.Text)
                            {
                                kembar = true;
                                break;
                            }
                        }
                    }
                    if (kembar == true)
                    {
                        tim.player1.Add(players);
                        Update();
                    }
                    else
                    {
                        MessageBox.Show("Player is already exist");
                    }

                }
            }
        }

        private void cbox_chooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_players.Items.Clear();
            foreach (Team tim in teams)
            {
                if (tim.teamname == cbox_chooseTeam.Text)
                {
                    foreach (players main in tim.player1)
                    {
                        listbox_players.Items.Add("(" + main.playernum + ") " + main.playername + ", " + main.playerpos);
                        listbox_players.Sorted = true;
                    }
                    break;
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listbox_players.Items.Count > 11)
            {
                MessageBox.Show("Player number are less than 11, player can't be remove");
            }
            else
            {
                foreach (Team tim in teams)
                {
                    if (tim.teamname == cbox_chooseTeam.Text)
                    {
                        foreach (players main in tim.player1)
                        {
                            if (listbox_players.SelectedItem.ToString().Contains(main.playername))
                            {
                                tim.player1.Remove(main);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void combox_PlayPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            combox_PlayPos.Items.Add("GK");
            combox_PlayPos.Items.Add("DF");
            combox_PlayPos.Items.Add("MF");
            combox_PlayPos.Items.Add("FW");
        }
    }
}
