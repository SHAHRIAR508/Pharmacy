using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string uname = txbUsername.Text;
            string pass = txbPassword.Text;
            if (uname == "" || pass == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassword.Clear();
                return;
            }
            if (uname == "admin" && pass == "admin")
            {
                MessageBox.Show("Login successful - Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
                return;
            }
            db newdb = new db();
            string query = "SELECT * FROM user_data WHERE Ename = '" + uname + "' AND Epassword = '" + pass + "'";
            DataRow dr = newdb.read(query);
            if (dr != null)
            {
                string userRole = dr["Erole"].ToString();
                if (userRole == "Manager")
                {
                    MessageBox.Show("Login successful - Manager", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Manager_DB manager_DB = new Manager_DB();
                    manager_DB.Show();
                }
                else if (userRole == "Staff")
                {
                    MessageBox.Show("Login successful - Staff", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Staff_DBcs Staff_DBcs = new Staff_DBcs();
                    Staff_DBcs.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPassword.Clear();
                    txbUsername.Focus();
                }
            }
        }
    }
}
        
    
