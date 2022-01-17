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
using System.Data.Entity;
using System.Globalization;

namespace MiniProjectIccWorldCupSpace
{
    internal partial class AdminSignupInfo : Form
    {

        //AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2();
        
        public AdminSignupInfo()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            Dept_IDtextBox.Text = "";
            Adm_NametextBox.Text = "";
            Adm_PasswordtextBox.Text = "";
            Email_IDtextBox.Text = "";
            Contact_NumtextBox.Text = "";
            Last_ProjtextBox.Text = "";
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
#pragma warning disable IDE0017 // Simplify object initialization
                AdminDetail AD = new AdminDetail();
#pragma warning restore IDE0017 // Simplify object initialization
                AD.Department_ID = Convert.ToInt32(Dept_IDtextBox.Text.Trim(), CultureInfo.CurrentCulture);
                AD.username = Adm_NametextBox.Text;
                AD.Email_ID = Email_IDtextBox.Text;
                AD.Password = Adm_PasswordtextBox.Text;
                AD.Contact_No = Convert.ToInt64(Contact_NumtextBox.Text, CultureInfo.CurrentCulture);
                AD.Last_Project = Last_ProjtextBox.Text;

                dc.AdminDetails.Add(AD);

                dc.SaveChanges();
                MessageBox.Show("SignUp Successful....");
                ClearTextBoxes();
            }
            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void btnBack_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Hide();
            using (HomeWindow objHome = new HomeWindow())
            {
                MessageBox.Show("Redirecting to Home Page...");
                objHome.ShowDialog();
            }  
        }

        private void AdminSignupInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
