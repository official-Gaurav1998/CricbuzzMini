
namespace MiniProjectIccWorldCupSpace
{
    partial class HomeWindow
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
            this.components = new System.ComponentModel.Container();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btnSeePW = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.Admtag = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.AdmName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.AdmPassword = new System.Windows.Forms.Label();
            this.tagLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLeague = new System.Windows.Forms.TextBox();
            this.teamdetailBox = new System.Windows.Forms.TextBox();
            this.btnTeam_Show = new System.Windows.Forms.Button();
            this.btnCountry_Show = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.Label();
            this.btnLeague_Show = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TeamBoxLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LeagueMatchesLabel = new System.Windows.Forms.Label();
            this.MidLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.userTag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewLeagueMatches = new System.Windows.Forms.DataGridView();
            this.dataGridViewTeamDetails = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagueMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDetailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPanel.Controls.Add(this.btnSeePW);
            this.adminPanel.Controls.Add(this.btnSignUp);
            this.adminPanel.Controls.Add(this.btnExit);
            this.adminPanel.Controls.Add(this.Admtag);
            this.adminPanel.Controls.Add(this.btnLogin);
            this.adminPanel.Controls.Add(this.AdmName);
            this.adminPanel.Controls.Add(this.textBoxPassword);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Controls.Add(this.label3);
            this.adminPanel.Controls.Add(this.textBoxUserName);
            this.adminPanel.Controls.Add(this.AdmPassword);
            this.adminPanel.Location = new System.Drawing.Point(12, 91);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(473, 273);
            this.adminPanel.TabIndex = 20;
            // 
            // btnSeePW
            // 
            this.btnSeePW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePW.Location = new System.Drawing.Point(413, 155);
            this.btnSeePW.Name = "btnSeePW";
            this.btnSeePW.Size = new System.Drawing.Size(43, 23);
            this.btnSeePW.TabIndex = 20;
            this.btnSeePW.UseVisualStyleBackColor = false;
            this.btnSeePW.Click += new System.EventHandler(this.btnSeePW_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(174, 232);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(95, 27);
            this.btnSignUp.TabIndex = 19;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(237, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Admtag
            // 
            this.Admtag.AutoSize = true;
            this.Admtag.BackColor = System.Drawing.Color.Coral;
            this.Admtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admtag.Location = new System.Drawing.Point(104, 43);
            this.Admtag.Name = "Admtag";
            this.Admtag.Size = new System.Drawing.Size(254, 38);
            this.Admtag.TabIndex = 11;
            this.Admtag.Text = "ADMIN LOGIN ";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(111, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 34);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AdmName
            // 
            this.AdmName.AutoSize = true;
            this.AdmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AdmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmName.Location = new System.Drawing.Point(80, 109);
            this.AdmName.Name = "AdmName";
            this.AdmName.Size = new System.Drawing.Size(115, 27);
            this.AdmName.TabIndex = 12;
            this.AdmName.Text = "UserName";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(266, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(128, 27);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = ":";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(266, 110);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(128, 27);
            this.textBoxUserName.TabIndex = 16;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // AdmPassword
            // 
            this.AdmPassword.AutoSize = true;
            this.AdmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AdmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmPassword.Location = new System.Drawing.Point(80, 149);
            this.AdmPassword.Name = "AdmPassword";
            this.AdmPassword.Size = new System.Drawing.Size(108, 27);
            this.AdmPassword.TabIndex = 13;
            this.AdmPassword.Text = "Password";
            // 
            // tagLabel
            // 
            this.tagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagLabel.BackColor = System.Drawing.Color.LightBlue;
            this.tagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLabel.Location = new System.Drawing.Point(12, 9);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(1406, 62);
            this.tagLabel.TabIndex = 23;
            this.tagLabel.Text = "ICC WORLD CUP";
            this.tagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxLeague);
            this.panel2.Controls.Add(this.teamdetailBox);
            this.panel2.Controls.Add(this.btnTeam_Show);
            this.panel2.Controls.Add(this.btnCountry_Show);
            this.panel2.Controls.Add(this.textbox);
            this.panel2.Controls.Add(this.txtbox);
            this.panel2.Controls.Add(this.btnLeague_Show);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TeamBoxLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LeagueMatchesLabel);
            this.panel2.Controls.Add(this.MidLabel);
            this.panel2.Controls.Add(this.CountryLabel);
            this.panel2.Controls.Add(this.userTag);
            this.panel2.Location = new System.Drawing.Point(12, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 300);
            this.panel2.TabIndex = 24;
            // 
            // textBoxLeague
            // 
            this.textBoxLeague.Location = new System.Drawing.Point(256, 226);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(88, 22);
            this.textBoxLeague.TabIndex = 41;
            // 
            // teamdetailBox
            // 
            this.teamdetailBox.Location = new System.Drawing.Point(256, 175);
            this.teamdetailBox.Name = "teamdetailBox";
            this.teamdetailBox.Size = new System.Drawing.Size(88, 22);
            this.teamdetailBox.TabIndex = 40;
            // 
            // btnTeam_Show
            // 
            this.btnTeam_Show.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTeam_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam_Show.Location = new System.Drawing.Point(367, 167);
            this.btnTeam_Show.Name = "btnTeam_Show";
            this.btnTeam_Show.Size = new System.Drawing.Size(89, 36);
            this.btnTeam_Show.TabIndex = 39;
            this.btnTeam_Show.Text = "SHOW";
            this.btnTeam_Show.UseVisualStyleBackColor = false;
            this.btnTeam_Show.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCountry_Show
            // 
            this.btnCountry_Show.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCountry_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountry_Show.Location = new System.Drawing.Point(367, 112);
            this.btnCountry_Show.Name = "btnCountry_Show";
            this.btnCountry_Show.Size = new System.Drawing.Size(89, 36);
            this.btnCountry_Show.TabIndex = 37;
            this.btnCountry_Show.Text = "SHOW";
            this.btnCountry_Show.UseVisualStyleBackColor = false;
            this.btnCountry_Show.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(77, 76);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(293, 18);
            this.textbox.TabIndex = 35;
            this.textbox.Text = "Welcome to Icc World Cup User page";
            // 
            // txtbox
            // 
            this.txtbox.AutoSize = true;
            this.txtbox.Location = new System.Drawing.Point(3, 62);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(0, 17);
            this.txtbox.TabIndex = 34;
            // 
            // btnLeague_Show
            // 
            this.btnLeague_Show.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLeague_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeague_Show.Location = new System.Drawing.Point(367, 213);
            this.btnLeague_Show.Name = "btnLeague_Show";
            this.btnLeague_Show.Size = new System.Drawing.Size(89, 36);
            this.btnLeague_Show.TabIndex = 33;
            this.btnLeague_Show.Text = "SHOW";
            this.btnLeague_Show.UseVisualStyleBackColor = false;
            this.btnLeague_Show.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = ":";
            // 
            // TeamBoxLabel
            // 
            this.TeamBoxLabel.AutoSize = true;
            this.TeamBoxLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.TeamBoxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamBoxLabel.Location = new System.Drawing.Point(24, 173);
            this.TeamBoxLabel.Name = "TeamBoxLabel";
            this.TeamBoxLabel.Size = new System.Drawing.Size(157, 23);
            this.TeamBoxLabel.TabIndex = 23;
            this.TeamBoxLabel.Text = "TEAM DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = ":";
            // 
            // LeagueMatchesLabel
            // 
            this.LeagueMatchesLabel.AutoSize = true;
            this.LeagueMatchesLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.LeagueMatchesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueMatchesLabel.Location = new System.Drawing.Point(24, 226);
            this.LeagueMatchesLabel.Name = "LeagueMatchesLabel";
            this.LeagueMatchesLabel.Size = new System.Drawing.Size(195, 23);
            this.LeagueMatchesLabel.TabIndex = 18;
            this.LeagueMatchesLabel.Text = "LEAGUE MATCHES";
            // 
            // MidLabel
            // 
            this.MidLabel.AutoSize = true;
            this.MidLabel.BackColor = System.Drawing.SystemColors.Info;
            this.MidLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidLabel.Location = new System.Drawing.Point(233, 118);
            this.MidLabel.Name = "MidLabel";
            this.MidLabel.Size = new System.Drawing.Size(17, 23);
            this.MidLabel.TabIndex = 14;
            this.MidLabel.Text = ":";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.CountryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLabel.Location = new System.Drawing.Point(24, 118);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(195, 23);
            this.CountryLabel.TabIndex = 13;
            this.CountryLabel.Text = "COUNTRY DETAILS";
            // 
            // userTag
            // 
            this.userTag.AutoSize = true;
            this.userTag.BackColor = System.Drawing.Color.Coral;
            this.userTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTag.Location = new System.Drawing.Point(128, 33);
            this.userTag.Name = "userTag";
            this.userTag.Size = new System.Drawing.Size(206, 32);
            this.userTag.TabIndex = 12;
            this.userTag.Text = "USER SPACE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImage = global::MiniProjectIccWorldCupSpace.Properties.Resources.BackGroundImage;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewLeagueMatches);
            this.panel1.Controls.Add(this.dataGridViewTeamDetails);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(511, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 588);
            this.panel1.TabIndex = 25;
            // 
            // dataGridViewLeagueMatches
            // 
            this.dataGridViewLeagueMatches.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewLeagueMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeagueMatches.Location = new System.Drawing.Point(30, 406);
            this.dataGridViewLeagueMatches.Name = "dataGridViewLeagueMatches";
            this.dataGridViewLeagueMatches.ReadOnly = true;
            this.dataGridViewLeagueMatches.RowHeadersWidth = 51;
            this.dataGridViewLeagueMatches.RowTemplate.Height = 24;
            this.dataGridViewLeagueMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeagueMatches.Size = new System.Drawing.Size(884, 163);
            this.dataGridViewLeagueMatches.TabIndex = 2;
            // 
            // dataGridViewTeamDetails
            // 
            this.dataGridViewTeamDetails.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewTeamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamDetails.Location = new System.Drawing.Point(78, 208);
            this.dataGridViewTeamDetails.Name = "dataGridViewTeamDetails";
            this.dataGridViewTeamDetails.ReadOnly = true;
            this.dataGridViewTeamDetails.RowHeadersWidth = 51;
            this.dataGridViewTeamDetails.RowTemplate.Height = 24;
            this.dataGridViewTeamDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeamDetails.Size = new System.Drawing.Size(778, 192);
            this.dataGridViewTeamDetails.TabIndex = 1;
            this.dataGridViewTeamDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(337, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // adminDetailsBindingSource
            // 
            this.adminDetailsBindingSource.DataMember = "AdminDetails";
            // 
            // playersDetailBindingSource
            // 
            this.playersDetailBindingSource.DataMember = "Players_Detail";
            // 
            // playersDetailBindingSource1
            // 
            this.playersDetailBindingSource1.DataMember = "Players_Detail";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1430, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tagLabel);
            this.Controls.Add(this.adminPanel);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWindow";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagueMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDetailBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Admtag;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label AdmName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label AdmPassword;
        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTeam_Show;
        private System.Windows.Forms.Button btnCountry_Show;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label txtbox;
        private System.Windows.Forms.Button btnLeague_Show;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TeamBoxLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LeagueMatchesLabel;
        private System.Windows.Forms.Label MidLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label userTag;
        private System.Windows.Forms.Panel panel1;
        //private AdminDBIccWorldCupDataSet adminDBIccWorldCupDataSet;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource;
        //private AdminDBIccWorldCupDataSetTableAdapters.AdminDetailsTableAdapter adminDetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewLeagueMatches;
        private System.Windows.Forms.DataGridView dataGridViewTeamDetails;
        private System.Windows.Forms.BindingSource playersDetailBindingSource;
        //private AdminDBIccWorldCupDataSetTableAdapters.Players_DetailTableAdapter players_DetailTableAdapter;
        private System.Windows.Forms.Label btnSignUp;
        private System.Windows.Forms.BindingSource playersDetailBindingSource1;
        private System.Windows.Forms.TextBox teamdetailBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxLeague;
        private System.Windows.Forms.Button btnSeePW;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}