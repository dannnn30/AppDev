using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionString;
        string sqlQuery;
        DataTable dtPlayer = new DataTable();
        DataTable dtManager = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtmatch = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            conn = new MySqlConnection(connectionString);
            sqlQuery = "SELECT team_name as 'teamName', team_id as 'teamID'  FROM team t;";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtTeam);
            combo_teamName.DataSource = dtTeam;
            combo_teamName.ValueMember = "teamName";
            combo_teamName.DisplayMember = "teamName";
            combo_team.DataSource = dtTeam;
            combo_team.ValueMember = "teamID";
            combo_team.DisplayMember = "teamName";
        }
        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_data.Visible = true;
            pnl_data.Enabled = true;
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            dtManager.Clear();
            string team = combo_teamName.SelectedValue.ToString();
            sqlQuery = $"SELECT player_name as 'Player Name', team_name as 'Team Name',playing_pos as 'Position', weight, height as 'Player Height' FROM player INNER JOIN team ON player.team_id = team.team_id WHERE team_name ='" + team + "';";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtPlayer);
            dataGridView1.DataSource = dtPlayer;
            sqlQuery = $"SELECT team_name as 'Team Name',manager_name as 'Manager Name', birthdate as 'Birthday', nation as 'Nationality' FROM team, manager, nationality WHERE team.manager_id = manager.manager_id and manager.nationality_id = nationality.nationality_id and team_name ='" + team + "';";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtManager);
            dataGridView2.DataSource = dtManager;
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_data.Visible = false;
            pnl_data.Enabled = false;
            panel1.Visible = true;
            panel1.Enabled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            dtmatch.Clear();
            string team = combo_team.SelectedValue.ToString();
            sqlQuery = $"SELECT t.team_name as 'Home Team', t1.team_name as'Away Team',match_date as 'Date', goal_home as 'Goal Home', goal_away as 'Goal Away',referee_name as 'Referee Name'  FROM team t,team t1, `match` ,referee  WHERE t.team_id = team_home and t1.team_id = team_away and referee.referee_id = match.referee_id and team_home = '{team}' union SELECT t.team_name as 'Home Team', t1.team_name as'Away Team',match_date as 'Date', goal_home as 'Goal Home', goal_away as 'Goal Away',referee_name as 'Referee Name'  FROM team t,team t1, `match` ,referee WHERE t.team_id = team_home and t1.team_id = team_away and referee.referee_id = match.referee_id and team_away = '{team}';";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmatch);
            dataGridView3.DataSource = dtmatch;
        }
    }
}
