namespace THA_W4_Daniel_O
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_soccer = new System.Windows.Forms.Label();
            this.label_chosseCountry = new System.Windows.Forms.Label();
            this.label_chooseTeam = new System.Windows.Forms.Label();
            this.label_addTeam = new System.Windows.Forms.Label();
            this.cbox_chooseCountry = new System.Windows.Forms.ComboBox();
            this.cbox_chooseTeam = new System.Windows.Forms.ComboBox();
            this.label_teamName = new System.Windows.Forms.Label();
            this.label_teamCountry = new System.Windows.Forms.Label();
            this.label_teamCity = new System.Windows.Forms.Label();
            this.combox_PlayPos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_playerNumber = new System.Windows.Forms.Label();
            this.label_playerName = new System.Windows.Forms.Label();
            this.label_addplayers = new System.Windows.Forms.Label();
            this.tebox_tmCountry = new System.Windows.Forms.TextBox();
            this.tebox_tmCity = new System.Windows.Forms.TextBox();
            this.tebox_tmName = new System.Windows.Forms.TextBox();
            this.tebox_playName = new System.Windows.Forms.TextBox();
            this.tebox_playNum = new System.Windows.Forms.TextBox();
            this.listbox_players = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_addTeam = new System.Windows.Forms.Button();
            this.btn_addPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_soccer
            // 
            this.label_soccer.AutoSize = true;
            this.label_soccer.Location = new System.Drawing.Point(33, 46);
            this.label_soccer.Name = "label_soccer";
            this.label_soccer.Size = new System.Drawing.Size(162, 25);
            this.label_soccer.TabIndex = 0;
            this.label_soccer.Text = "soccer team list";
            // 
            // label_chosseCountry
            // 
            this.label_chosseCountry.AutoSize = true;
            this.label_chosseCountry.Location = new System.Drawing.Point(33, 112);
            this.label_chosseCountry.Name = "label_chosseCountry";
            this.label_chosseCountry.Size = new System.Drawing.Size(171, 25);
            this.label_chosseCountry.TabIndex = 1;
            this.label_chosseCountry.Text = "choose country: ";
            // 
            // label_chooseTeam
            // 
            this.label_chooseTeam.AutoSize = true;
            this.label_chooseTeam.Location = new System.Drawing.Point(33, 184);
            this.label_chooseTeam.Name = "label_chooseTeam";
            this.label_chooseTeam.Size = new System.Drawing.Size(147, 25);
            this.label_chooseTeam.TabIndex = 2;
            this.label_chooseTeam.Text = "choose team: ";
            // 
            // label_addTeam
            // 
            this.label_addTeam.AutoSize = true;
            this.label_addTeam.Location = new System.Drawing.Point(487, 46);
            this.label_addTeam.Name = "label_addTeam";
            this.label_addTeam.Size = new System.Drawing.Size(130, 25);
            this.label_addTeam.TabIndex = 3;
            this.label_addTeam.Text = "adding team";
            // 
            // cbox_chooseCountry
            // 
            this.cbox_chooseCountry.FormattingEnabled = true;
            this.cbox_chooseCountry.Location = new System.Drawing.Point(211, 112);
            this.cbox_chooseCountry.Name = "cbox_chooseCountry";
            this.cbox_chooseCountry.Size = new System.Drawing.Size(209, 33);
            this.cbox_chooseCountry.TabIndex = 4;
            this.cbox_chooseCountry.SelectedIndexChanged += new System.EventHandler(this.cbox_chooseCountry_SelectedIndexChanged);
            // 
            // cbox_chooseTeam
            // 
            this.cbox_chooseTeam.FormattingEnabled = true;
            this.cbox_chooseTeam.Location = new System.Drawing.Point(211, 184);
            this.cbox_chooseTeam.Name = "cbox_chooseTeam";
            this.cbox_chooseTeam.Size = new System.Drawing.Size(209, 33);
            this.cbox_chooseTeam.TabIndex = 5;
            this.cbox_chooseTeam.SelectedIndexChanged += new System.EventHandler(this.cbox_chooseTeam_SelectedIndexChanged);
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.Location = new System.Drawing.Point(487, 112);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(130, 25);
            this.label_teamName.TabIndex = 6;
            this.label_teamName.Text = "team name: ";
            // 
            // label_teamCountry
            // 
            this.label_teamCountry.AutoSize = true;
            this.label_teamCountry.Location = new System.Drawing.Point(487, 181);
            this.label_teamCountry.Name = "label_teamCountry";
            this.label_teamCountry.Size = new System.Drawing.Size(148, 25);
            this.label_teamCountry.TabIndex = 7;
            this.label_teamCountry.Text = "team country: ";
            // 
            // label_teamCity
            // 
            this.label_teamCity.AutoSize = true;
            this.label_teamCity.Location = new System.Drawing.Point(487, 238);
            this.label_teamCity.Name = "label_teamCity";
            this.label_teamCity.Size = new System.Drawing.Size(110, 25);
            this.label_teamCity.TabIndex = 8;
            this.label_teamCity.Text = "team city: ";
            // 
            // combox_PlayPos
            // 
            this.combox_PlayPos.FormattingEnabled = true;
            this.combox_PlayPos.Location = new System.Drawing.Point(1091, 235);
            this.combox_PlayPos.Name = "combox_PlayPos";
            this.combox_PlayPos.Size = new System.Drawing.Size(209, 33);
            this.combox_PlayPos.TabIndex = 18;
            this.combox_PlayPos.SelectedIndexChanged += new System.EventHandler(this.combox_PlayPos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "player position: ";
            // 
            // label_playerNumber
            // 
            this.label_playerNumber.AutoSize = true;
            this.label_playerNumber.Location = new System.Drawing.Point(923, 181);
            this.label_playerNumber.Name = "label_playerNumber";
            this.label_playerNumber.Size = new System.Drawing.Size(161, 25);
            this.label_playerNumber.TabIndex = 14;
            this.label_playerNumber.Text = "player number: ";
            // 
            // label_playerName
            // 
            this.label_playerName.AutoSize = true;
            this.label_playerName.Location = new System.Drawing.Point(924, 112);
            this.label_playerName.Name = "label_playerName";
            this.label_playerName.Size = new System.Drawing.Size(142, 25);
            this.label_playerName.TabIndex = 13;
            this.label_playerName.Text = "player name: ";
            // 
            // label_addplayers
            // 
            this.label_addplayers.AutoSize = true;
            this.label_addplayers.Location = new System.Drawing.Point(924, 46);
            this.label_addplayers.Name = "label_addplayers";
            this.label_addplayers.Size = new System.Drawing.Size(153, 25);
            this.label_addplayers.TabIndex = 12;
            this.label_addplayers.Text = "adding players";
            // 
            // tebox_tmCountry
            // 
            this.tebox_tmCountry.Location = new System.Drawing.Point(641, 178);
            this.tebox_tmCountry.Name = "tebox_tmCountry";
            this.tebox_tmCountry.Size = new System.Drawing.Size(199, 31);
            this.tebox_tmCountry.TabIndex = 19;
            // 
            // tebox_tmCity
            // 
            this.tebox_tmCity.Location = new System.Drawing.Point(641, 238);
            this.tebox_tmCity.Name = "tebox_tmCity";
            this.tebox_tmCity.Size = new System.Drawing.Size(199, 31);
            this.tebox_tmCity.TabIndex = 20;
            // 
            // tebox_tmName
            // 
            this.tebox_tmName.Location = new System.Drawing.Point(641, 106);
            this.tebox_tmName.Name = "tebox_tmName";
            this.tebox_tmName.Size = new System.Drawing.Size(199, 31);
            this.tebox_tmName.TabIndex = 21;
            // 
            // tebox_playName
            // 
            this.tebox_playName.Location = new System.Drawing.Point(1091, 106);
            this.tebox_playName.Name = "tebox_playName";
            this.tebox_playName.Size = new System.Drawing.Size(209, 31);
            this.tebox_playName.TabIndex = 22;
            // 
            // tebox_playNum
            // 
            this.tebox_playNum.Location = new System.Drawing.Point(1091, 175);
            this.tebox_playNum.Name = "tebox_playNum";
            this.tebox_playNum.Size = new System.Drawing.Size(209, 31);
            this.tebox_playNum.TabIndex = 23;
            // 
            // listbox_players
            // 
            this.listbox_players.FormattingEnabled = true;
            this.listbox_players.ItemHeight = 25;
            this.listbox_players.Location = new System.Drawing.Point(38, 241);
            this.listbox_players.Name = "listbox_players";
            this.listbox_players.Size = new System.Drawing.Size(425, 254);
            this.listbox_players.TabIndex = 24;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(38, 522);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(166, 43);
            this.btn_remove.TabIndex = 25;
            this.btn_remove.Text = "remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_addTeam
            // 
            this.btn_addTeam.Location = new System.Drawing.Point(641, 311);
            this.btn_addTeam.Name = "btn_addTeam";
            this.btn_addTeam.Size = new System.Drawing.Size(121, 43);
            this.btn_addTeam.TabIndex = 26;
            this.btn_addTeam.Text = "add";
            this.btn_addTeam.UseVisualStyleBackColor = true;
            this.btn_addTeam.Click += new System.EventHandler(this.btn_addTeam_Click);
            // 
            // btn_addPlayer
            // 
            this.btn_addPlayer.Location = new System.Drawing.Point(1091, 311);
            this.btn_addPlayer.Name = "btn_addPlayer";
            this.btn_addPlayer.Size = new System.Drawing.Size(117, 43);
            this.btn_addPlayer.TabIndex = 27;
            this.btn_addPlayer.Text = "add";
            this.btn_addPlayer.UseVisualStyleBackColor = true;
            this.btn_addPlayer.Click += new System.EventHandler(this.btn_addPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 577);
            this.Controls.Add(this.btn_addPlayer);
            this.Controls.Add(this.btn_addTeam);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.listbox_players);
            this.Controls.Add(this.tebox_playNum);
            this.Controls.Add(this.tebox_playName);
            this.Controls.Add(this.tebox_tmName);
            this.Controls.Add(this.tebox_tmCity);
            this.Controls.Add(this.tebox_tmCountry);
            this.Controls.Add(this.combox_PlayPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_playerNumber);
            this.Controls.Add(this.label_playerName);
            this.Controls.Add(this.label_addplayers);
            this.Controls.Add(this.label_teamCity);
            this.Controls.Add(this.label_teamCountry);
            this.Controls.Add(this.label_teamName);
            this.Controls.Add(this.cbox_chooseTeam);
            this.Controls.Add(this.cbox_chooseCountry);
            this.Controls.Add(this.label_addTeam);
            this.Controls.Add(this.label_chooseTeam);
            this.Controls.Add(this.label_chosseCountry);
            this.Controls.Add(this.label_soccer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_soccer;
        private System.Windows.Forms.Label label_chosseCountry;
        private System.Windows.Forms.Label label_chooseTeam;
        private System.Windows.Forms.Label label_addTeam;
        private System.Windows.Forms.ComboBox cbox_chooseCountry;
        private System.Windows.Forms.ComboBox cbox_chooseTeam;
        private System.Windows.Forms.Label label_teamName;
        private System.Windows.Forms.Label label_teamCountry;
        private System.Windows.Forms.Label label_teamCity;
        private System.Windows.Forms.ComboBox combox_PlayPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_playerNumber;
        private System.Windows.Forms.Label label_playerName;
        private System.Windows.Forms.Label label_addplayers;
        private System.Windows.Forms.TextBox tebox_tmCountry;
        private System.Windows.Forms.TextBox tebox_tmCity;
        private System.Windows.Forms.TextBox tebox_tmName;
        private System.Windows.Forms.TextBox tebox_playName;
        private System.Windows.Forms.TextBox tebox_playNum;
        private System.Windows.Forms.ListBox listbox_players;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_addTeam;
        private System.Windows.Forms.Button btn_addPlayer;
    }
}

