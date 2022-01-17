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
    internal partial class AdminOnly : Form
    {
        //AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2();

        AdminDetail AD = new AdminDetail();
        string myString = string.Empty;
        public AdminOnly()
        {
            InitializeComponent();
        }

        //Getting values in Admin datagrid
        private void SeeDetails()
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                var selectQuery =
                from a in dc.AdminDetails
                select a; 
                dataGridAdminDetails.DataSource = selectQuery.ToList<AdminDetail>();
            }
                     
        }
#pragma warning disable IDE1006 // Naming Styles
        private void btnShow_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            dataGridAdminDetails.Show();
        }

        //Load Method
        private void AdminOnly_Load(object sender, EventArgs e)
        {
            dataGridAdminDetails.Hide();
            //Calling Our function
            SeeDetails();
        }

        //Method with Query for admin grid
        public void UpdateAdminDetails()
        {
            using(AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                var selectQuery =
                from a in dc.AdminDetails
                select a;

                dataGridAdminDetails.DataSource = selectQuery.ToList<AdminDetail>();
            }
            
        }

        private void ClearTextBoxes()
        {
            textBoxDept_ID.Text = "";
            textBoxPW.Text = "";
            textBoxCont_No.Text = "";
            textBoxUser.Text = "";
            textBoxE_ID.Text = "";
            textBoxL_Proj.Text = "";
        }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridAdminDetails_MouseDoubleClick(object sender, MouseEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                myString = (string)dataGridAdminDetails.SelectedRows[0].Cells[0].Value;
                AD = dc.AdminDetails.Where(x => x.username == myString).FirstOrDefault();

                textBoxDept_ID.Text = AD.Department_ID.ToString();
                textBoxUser.Text = AD.username;
                textBoxPW.Text = AD.Password;
                textBoxCont_No.Text = AD.Contact_No.ToString();
                textBoxE_ID.Text = AD.Email_ID;
                textBoxL_Proj.Text = AD.Last_Project;
            }
            
            
        }
        //Updating admin data
#pragma warning disable IDE1006 // Naming Styles
        private void btnUpdate_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using (AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                AD.username = myString;
                AD.Department_ID = Convert.ToInt32(textBoxDept_ID.Text.Trim(), CultureInfo.CurrentCulture);
                AD.username = textBoxUser.Text;
                AD.Email_ID = textBoxE_ID.Text;
                AD.Password = textBoxPW.Text;
                AD.Contact_No = Convert.ToInt32(textBoxCont_No.Text, CultureInfo.CurrentCulture);
                AD.Last_Project = textBoxL_Proj.Text;

                dc.Entry(AD).State = EntityState.Modified;
                dc.SaveChanges();
                MessageBox.Show("Updated Successfully");
                ClearTextBoxes();
                UpdateAdminDetails();
            }
                //Assinging a globel variable to a table colomn..
            
            
        }

        //Deleting Admin data
#pragma warning disable IDE1006 // Naming Styles
        private void btnCDelete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            using(AdminDBIccWorldCupEntities2 dc = new AdminDBIccWorldCupEntities2())
            {
                DialogResult de = MessageBox.Show("Do You Want to Delete Your Data Permanently?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (de == DialogResult.Yes)
                {
                    AD = dc.AdminDetails.Where(x => x.username == myString).FirstOrDefault();
                    dc.Entry(AD).State = EntityState.Deleted;
                    dc.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    ClearTextBoxes();
                    UpdateAdminDetails();
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
            }
        }

        //Back to Admin Page
#pragma warning disable IDE1006 // Naming Styles
        private void btnBack_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Hide();
            using (Main_Window objHome = new Main_Window())
            {
                MessageBox.Show("Redirecting to Admin Dashboard...");
                objHome.ShowDialog();
            }
        }
    }
}
