using System;
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
    internal partial class Main_Window : Form
    {
        CountryDetail CD = new CountryDetail();
        Players_Detail PD = new Players_Detail();
        MATCH_DETAILS MD = new MATCH_DETAILS();

        // Declear a global variable 
        int id;
        public Main_Window()
        {
            InitializeComponent();
        }

        // FOR DATA GRID 1 COUNTRY TABLE
        private void UpdateMyCountryGrid()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                var selectQuery =
                    from a in dc.CountryDetails
                    select a;

                dataGridAdminCountry.DataSource = selectQuery.ToList<CountryDetail>();
            }
        }
        // FOR DATA GRID 2 Players TABLE
        private void UpdateMyPlayerGrid()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                var selectQuery =
                from a in dc.Players_Detail
                select a;

                dataGridAdminPlayers.DataSource = selectQuery.ToList<Players_Detail>();
            }          
        }

        // FOR DATA GRID 3 Match TABLE
        private void UpdateMyMatchGrid()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                var selectQuery =
                   from a in dc.MATCH_DETAILS
                   select a;

                dataGridAdminMatches.DataSource = selectQuery.ToList<MATCH_DETAILS>();
            }         
        }

        private void ClearTextBoxes()
        {
            C_IDBox.Text = "";
            C_NAMEBox.Text = "";
            P_FBox.Text = "";
            P_LBox.Text = "";
            P_CIDBox.Text = "";
            P_AgeBox.Text = "";
            P_SBox.Text = "";
            P_DBox.Text = "";
            P_CBox.Text = "";
            TeamAtextBox.Text = "";
            VenuetextBox.Text = "";
            TeamBtextBox.Text = "";
            DTtextBox.Text = "";
            PteamtextBox.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateMyCountryGrid();
            UpdateMyPlayerGrid();
            UpdateMyMatchGrid();

            dataGridAdminCountry.Hide();
            dataGridAdminPlayers.Hide();
            dataGridAdminMatches.Hide();
        }

        //Country Details Created
        private void Main_WindowbtnCCreate_Click(object sender, EventArgs e)
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                CD.CountryID = Convert.ToInt32(C_IDBox.Text.Trim(), CultureInfo.CurrentCulture);
                CD.CountryName = C_NAMEBox.Text;
                dc.CountryDetails.Add(CD);
                dc.SaveChanges();
                MessageBox.Show("Country Details Inserted....");
                ClearTextBoxes();
                UpdateMyCountryGrid();
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        { }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridAdminCountry_MouseDoubleClick(object sender, MouseEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                id = Convert.ToInt32(dataGridAdminCountry.SelectedRows[0].Cells[0].Value, CultureInfo.CurrentCulture);
                CD = dc.CountryDetails.Where(x => x.CountryID == id).FirstOrDefault();
                C_IDBox.Text = Convert.ToString(CD.CountryID, CultureInfo.CurrentCulture);
                C_NAMEBox.Text = CD.CountryName;
            }
        }

        //Country Details Updated
#pragma warning disable IDE1006 // Naming Styles
        private void btnUpdate_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                CD.CountryID = id;
                CD.CountryID = Convert.ToInt32(C_IDBox.Text.Trim(), CultureInfo.CurrentCulture);
                CD.CountryName = C_NAMEBox.Text;

                dc.Entry(CD).State = EntityState.Modified;
                dc.SaveChanges();
                MessageBox.Show("Updated Successfully");
                ClearTextBoxes();
                UpdateMyCountryGrid();
            }
            
        }

        //Country Details Deleted
#pragma warning disable IDE1006 // Naming Styles
        private void btnCDelete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            DialogResult de = MessageBox.Show("Do You Want to Delete Your Data Permanently?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (de == DialogResult.Yes)
            {
                using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
                {
                    CD = dc.CountryDetails.Where(x => x.CountryID == id).FirstOrDefault();
                    dc.Entry(CD).State = EntityState.Deleted;
                    dc.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    UpdateMyCountryGrid();
                }
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
        }
        // GridView1 Show
#pragma warning disable IDE1006 // Naming Styles
        private void btnShow_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            dataGridAdminCountry.Show();
        }

        //Players Details Created
#pragma warning disable IDE1006 // Naming Styles
        private void btnPCreate_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                PD.CountryId = int.Parse(P_CIDBox.Text.Trim(), CultureInfo.CurrentCulture);
                PD.F_name = P_FBox.Text;
                PD.L_name = P_LBox.Text;
                PD.Age = int.Parse(P_AgeBox.Text, CultureInfo.CurrentCulture);
                PD.Skill = P_SBox.Text;
                PD.Designation = P_DBox.Text;
                PD.City = P_CBox.Text;

                dc.Players_Detail.Add(PD);
                dc.SaveChanges();
                MessageBox.Show("Player Details Created....");
                ClearTextBoxes();
                UpdateMyPlayerGrid();
            }
            
        }
#pragma warning disable IDE1006 // Naming Styles
        private void dataGridAdminPlayers_MouseDoubleClick(object sender, MouseEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                id = Convert.ToInt32(dataGridAdminPlayers.SelectedRows[0].Cells[0].Value, CultureInfo.CurrentCulture);
                PD = dc.Players_Detail.Where(x => x.Id == id).FirstOrDefault();
                P_CIDBox.Text = Convert.ToString(PD.CountryId, CultureInfo.CurrentCulture);
                P_FBox.Text = PD.F_name;
                P_LBox.Text = PD.L_name;
                P_AgeBox.Text = Convert.ToString(PD.Age, CultureInfo.CurrentCulture);
                P_SBox.Text = PD.Skill;
                P_DBox.Text = PD.Designation;
                P_CBox.Text = PD.City;
            } 
        }

        //Players Details Deleted
#pragma warning disable IDE1006 // Naming Styles
        private void btnPDelete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            DialogResult de = MessageBox.Show("Do You Want to Delete Your Data Permanently?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (de == DialogResult.Yes)
            {
                using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
                {
                    PD = dc.Players_Detail.Where(x => x.CountryId == id).FirstOrDefault();
                    dc.Entry(PD).State = EntityState.Deleted;
                    dc.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    UpdateMyPlayerGrid();
                }
                
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }

        }
        //Players Details Updated
#pragma warning disable IDE1006 // Naming Styles
        private void btnPUpdate_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                PD.CountryId = id;
                PD.CountryId = Convert.ToInt32(P_CIDBox.Text.Trim(), CultureInfo.CurrentCulture);
                PD.F_name = P_FBox.Text;
                PD.L_name = P_LBox.Text;
                PD.Age = int.Parse(P_AgeBox.Text, CultureInfo.CurrentCulture);
                PD.Skill = P_SBox.Text;
                PD.Designation = P_DBox.Text;
                PD.City = P_CBox.Text;

                dc.Entry(PD).State = EntityState.Modified;
                dc.SaveChanges();
                MessageBox.Show("Updated Successfully");
                ClearTextBoxes();
                UpdateMyPlayerGrid();
            }  
        }

        //GridView2 Show
#pragma warning disable IDE1006 // Naming Styles
        private void button1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            dataGridAdminPlayers.Show();
        }

        //Match Details Created
#pragma warning disable IDE1006 // Naming Styles
        private void btnMDCreate_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                MD.country1 = Convert.ToInt32(TeamAtextBox.Text, CultureInfo.CurrentCulture);
                MD.country2 = Convert.ToInt32(TeamBtextBox.Text, CultureInfo.CurrentCulture);
                MD.Matches = PteamtextBox.Text;
                MD.Venue = VenuetextBox.Text;
                MD.DateAndTime = DateTime.Parse(DTtextBox.Text, CultureInfo.CurrentCulture);

                dc.MATCH_DETAILS.Add(MD);
                dc.SaveChanges();
                MessageBox.Show("Country Details Inserted....");
                ClearTextBoxes();
                UpdateMyMatchGrid();
            }
            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridAdminMatches_MouseDoubleClick(object sender, MouseEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                id = Convert.ToInt32(dataGridAdminMatches.SelectedRows[0].Cells[0].Value, CultureInfo.CurrentCulture);
                MD = dc.MATCH_DETAILS.Where(x => x.MatchNo == id).FirstOrDefault();
                TeamAtextBox.Text = MD.country1.ToString();
                TeamBtextBox.Text = MD.country2.ToString();
                PteamtextBox.Text = MD.Matches;
                VenuetextBox.Text = MD.Venue;
                DTtextBox.Text = MD.DateAndTime.ToString();
            }
            
        }

        //Match Details Deleted
#pragma warning disable IDE1006 // Naming Styles
        private void btnMDDelete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            DialogResult de = MessageBox.Show("Do You Want to Delete Your Data Permanently?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (de == DialogResult.Yes)
            {
                using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
                {
                    MD = dc.MATCH_DETAILS.Where(x => x.MatchNo == id).FirstOrDefault();
                    dc.Entry(MD).State = EntityState.Deleted;
                    dc.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    UpdateMyMatchGrid();
                }
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }

        }
        //Match Details Updated
#pragma warning disable IDE1006 // Naming Styles
        private void btnMDUpdate_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                MD.country1 = Convert.ToInt32(TeamAtextBox.Text, CultureInfo.CurrentCulture);
                MD.country2 = Convert.ToInt32(TeamBtextBox.Text, CultureInfo.CurrentCulture);
                MD.Matches = PteamtextBox.Text;
                MD.Venue = VenuetextBox.Text;
                MD.DateAndTime = Convert.ToDateTime(DTtextBox.Text, CultureInfo.CurrentCulture);
                dc.SaveChanges();

                MessageBox.Show("Updated Successfully");
                UpdateMyMatchGrid();
            }
            
        }

        //GridView3 Show
#pragma warning disable IDE1006 // Naming Styles
        private void button2_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            dataGridAdminMatches.Show();
        }

        //Logout from main Window
#pragma warning disable IDE1006 // Naming Styles
        private void btnLogout_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using(HomeWindow objHome = new HomeWindow())
            {
                this.Hide();
                MessageBox.Show("Redirecting to Home Page...");
                objHome.ShowDialog();
            }
            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void btnDetails_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminOnly objA = new AdminOnly())
            {
                this.Hide();
                MessageBox.Show("Redirecting to Admin...");
                objA.ShowDialog();
            } 
        }
    }   
}
