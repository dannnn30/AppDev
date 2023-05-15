using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace ASiap
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string sqlcon;
        string sqlquery;
        DataTable dtTim = new DataTable();
        DataTable dtNat = new DataTable();
        DataTable dtTim1 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon = "server=localhost;uid=root;pwd=;database=premier_league";
            conn = new MySqlConnection(sqlcon);
            conn.Open();

            sqlquery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtTim);
            comboBox_team.DataSource = dtTim;
            comboBox_team.ValueMember = "Team ID";
            comboBox_team.DisplayMember = "Team Name";

            sqlquery = "Select nation, nationality_id as nat_ID from nationality;";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtNat);
            comboBox_nat.DataSource = dtNat;
            comboBox_nat.ValueMember = "nat_ID";
            comboBox_nat.DisplayMember = "nation";

            sqlquery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtTim1);
            comboBox_Mteam.DataSource = dtTim1;
            comboBox_Mteam.ValueMember = "Team ID";
            comboBox_Mteam.DisplayMember = "Team Name";

            comboBox_pos.Items.Add("D");
            comboBox_pos.Items.Add("M");
            comboBox_pos.Items.Add("F");
            comboBox_pos.Items.Add("G");

            panel1.Visible = false;
            panel1.Enabled = false; 
            panel2.Visible = false;
            panel2.Enabled = false;
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string nama = textBox_name.Text;
            string height = textBox_hei.Text;
            string weight = textBox_wei.Text;
            string num = textBox_num.Text;
            string team = comboBox_team.SelectedValue.ToString();
            string nat = comboBox_nat.SelectedValue.ToString();
            string pos = comboBox_pos.SelectedItem.ToString();
            string date = dateTimePicker1.Text.ToString();
            sqlquery = $"Insert Into player values ('{id}','{num}','{nama}','{nat}','{pos}','{height}','{weight}','{date}','{team}',1,0)";
            cmd = new MySqlCommand(sqlquery, conn);
            cmd.ExecuteNonQuery();
        }

        private void editManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Enabled = true;
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Mteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtman = new DataTable();
            sqlquery = $"select team.manager_id, manager.manager_name, nationality.nation, manager.birthdate from team inner join manager on team.manager_id = manager.manager_id inner join nationality on manager.nationality_id = nationality.nationality_id where team.team_id = '{comboBox_Mteam.SelectedValue.ToString()}';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtman);
            dataGridView1.DataSource = dtman;

            DataTable dtman2 = new DataTable();
            sqlquery = $"select team.manager_id, manager.manager_name, nationality.nation, manager.birthdate from team inner join manager on team.manager_id = manager.manager_id inner join nationality on manager.nationality_id = nationality.nationality_id where manager.working = '0';";
            cmd = new MySqlCommand(sqlquery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtman2);
            dataGridView2.DataSource = dtman2;
        }
    }
}
