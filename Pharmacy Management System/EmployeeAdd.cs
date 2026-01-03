using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_Management_System
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard Dashboard = new Dashboard();
            Dashboard.Visible = true;
            Dashboard.Show();
            this.Close();
        }
        db newdb = new db();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string SId = txtID.Text;
            string Sname = txtName.Text;
            string Snumber = txtNumber.Text;
            string Saddras = txtAddress.Text;
            string Srole = cmbTitel.Text;
            if (txtID.Text == null || txtName.Text == null || txtNumber == null || txtAddress == null || cmbTitel.Text == null)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "insert into Staff (SId, Sname , Snumber, Saddras, Srole) values ('" + SId + "','" + Sname + "','" + Snumber + "', '" + Saddras + "','" + Srole + "')";
                newdb.write(query);
                MessageBox.Show("staff added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            load_products();


        }
        private void load_products()
        {
            DataTable dt = newdb.readAll("SELECT * FROM Staff");
            if (dt != null)
            {
                dgvAdd.AutoGenerateColumns = true;
                dgvAdd.DataSource = dt;
                dgvAdd.Columns[0].HeaderText = "Id";
                dgvAdd.Columns[1].HeaderText = "name";
                dgvAdd.Columns[2].HeaderText = "number";
                dgvAdd.Columns[3].HeaderText = "adress";
                dgvAdd.Columns[4].HeaderText = "Role";
            }

        }

        private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_products();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SId = txtID.Text;
            string query = "DELETE FROM Staff WHERE SId = '" + SId + "'";
            newdb.write(query);
            MessageBox.Show("Staff deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_products();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_products();
        }

        
    }
}
