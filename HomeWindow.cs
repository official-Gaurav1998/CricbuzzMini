using System;
using MiniProjectIccWorldCupSpace;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;
using System.Globalization;

namespace MiniProjectIccWorldCupSpace
{
    internal partial class HomeWindow : Form
    {
        //int input = 0;
        public HomeWindow()
        {
            InitializeComponent();
        }
        //Login For Main Window..
#pragma warning disable IDE1006 // Naming Styles
        private void btnLogin_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using(AdminDBIccWorldCupEntities2 db = new AdminDBIccWorldCupEntities2())
            {
                if ((!string.IsNullOrEmpty(textBoxUserName.Text)) && (!string.IsNullOrEmpty(textBoxPassword.Text)))
                {
                    var adm1 = db.AdminDetails.FirstOrDefault(a => a.username.Equals(textBoxUserName.Text));
                    if (adm1 != null)
                    {
                        if (adm1.Password.Equals(textBoxPassword.Text))
                        {
                            using (Main_Window objForm1 = new Main_Window())
                            {
                                this.Hide();
                                MessageBox.Show("Login Successfully...");
                                objForm1.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password ..Try again!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect User Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Valid Username and Password!!!");
                }
            }
            
        }

        //Exit Completely
#pragma warning disable IDE1006 // Naming Styles
        private void btnExit_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Close();
        }
        //Main Load Method for Homepage
        private void HomeWindow_Load(object sender, EventArgs e)
        {
            UserCountryAccess();
            UserPlayerAccess();
            UserLeagueAccess();
           
            dataGridView1.Hide();
            dataGridViewLeagueMatches.Hide();
            dataGridViewTeamDetails.Hide();
        }
        //Userpage....Country Access
        public void UserCountryAccess()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                var selectQuery = from a in dc.CountryDetails
                                  select a;

                dataGridView1.DataSource = selectQuery.ToList<CountryDetail>();
            }        
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            dataGridView1.Show();
        }

        //Userpage....Player Details Access
        public void UserPlayerAccess()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                //input = int.Parse(, CultureInfo.CurrentCulture);
#pragma warning disable IDE0018 // Inline variable declaration
                int input;
#pragma warning restore IDE0018 // Inline variable declaration
                bool success = int.TryParse(teamdetailBox.Text, out input);
                var selectQuery = from player in dc.Players_Detail
                                  where player.CountryId == input
                                  select player;

                dataGridViewTeamDetails.DataSource = selectQuery.ToList<Players_Detail>();
            }
            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button2_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            UserPlayerAccess();
            dataGridViewTeamDetails.Show();
        }

        //Userpage....MatchLeague Details Access
        public void UserLeagueAccess()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                //int input = Convert.ToInt32(textBoxLeague.Text, CultureInfo.CurrentCulture);
#pragma warning disable IDE0018 // Inline variable declaration
                int input;
#pragma warning restore IDE0018 // Inline variable declaration
                bool success = int.TryParse(textBoxLeague.Text, out input);
                var selectQuery = from league in dc.MATCH_DETAILS.ToList()
                                  where league.country1 == input || league.country2 == input
                                  select league;

                dataGridViewLeagueMatches.DataSource = selectQuery.ToList<MATCH_DETAILS>();
            }   
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button3_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            UserLeagueAccess();
            dataGridViewLeagueMatches.Show();
        }

        //Redirect to sign up page...
#pragma warning disable IDE1006 // Naming Styles
        private void btnSignUp_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Hide();
            using (AdminSignupInfo obj = new AdminSignupInfo())
            {
                MessageBox.Show("Redirecting to Admin Sign Up...");
                obj.ShowDialog();
            }
            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void btnSeePW_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if(textBoxPassword.PasswordChar == '*')
            {
                btnSeePW.BringToFront();
                textBoxPassword.PasswordChar = '\0';
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (textBoxPassword.PasswordChar == '\0')
            {
                btnSeePW.BringToFront();
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
