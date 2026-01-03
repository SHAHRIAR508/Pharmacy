using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class MedecineForm : Form
    {
        public MedecineForm()
        {
            InitializeComponent();
            load_products();

        }

        db newdb = new db();
        private void btSave_Click(object sender, EventArgs e)
        {
            string medtype = cmbType.Text;
            string medname = txbName.Text;
            string medqantity = txbQuantity.Text;
            string medprice = txbPrice.Text;

            if (cmbType.Text == null || txbName.Text == null || txbQuantity == null || txbPrice == null)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "insert into Medicine (medType, medName , medQuantity, medPrice) values ('" + medtype + "  ','" + medname + "','" + medqantity + "', '" + medprice + "')";
                newdb.write(query);
                MessageBox.Show("Medicine added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            load_products();
        }

        private void load_products()
        {
            DataTable dt = newdb.readAll("SELECT * FROM Medicine");
            if (dt != null)
            {
                dgvMed.AutoGenerateColumns = true;
                dgvMed.DataSource = dt;
                dgvMed.Columns[0].HeaderText = "MED Type";
                dgvMed.Columns[1].HeaderText = "name";
                dgvMed.Columns[2].HeaderText = "quant";
                dgvMed.Columns[3].HeaderText = "price";
            }

        }

        private void MedecineForm_Load(object sender, EventArgs e)
        {
            load_products();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string medname = txbName.Text;
            if (txbName.Text == null)
            {
                MessageBox.Show("Please enter the medicine name to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "DELETE FROM Medicine WHERE medName = '" + medname + "'";
                int rowsAffected = newdb.write(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Medicine deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No medicine found with the given name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            load_products();
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            cmbType.SelectedIndex = -1;
            txbName.Clear();
            txbQuantity.Clear();
            txbPrice.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard Dashboard = new Dashboard();
            Dashboard.Visible = true;
            Dashboard.Show();
            this.Close();
        }

        private void dgvMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSEARCH_Click(object sender, EventArgs e)
        {
            string medname = txbName.Text;
            string type = cmbType.Text;
            string query = "SELECT * FROM Medicine WHERE medName LIKE '%" + medname + "%' OR medType LIKE '%" + type + "%'";
            DataTable dt = newdb.readAll(query);
            if (dt != null)
            {
                dgvMed.AutoGenerateColumns = true;
                dgvMed.DataSource = dt;
                dgvMed.Columns[0].HeaderText = "MED Type";
                dgvMed.Columns[1].HeaderText = "name";
                dgvMed.Columns[2].HeaderText = "quant";
                dgvMed.Columns[3].HeaderText = "price";
            }
            else
            {
                MessageBox.Show("No medicine found with the given name or type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string medtype = cmbType.Text;
            string medname = txbName.Text;  
            string medqantity = txbQuantity.Text;
            string medprice = txbPrice.Text;
            string type = cmbType.Text;
            if (txbName.Text == null)
            {
                MessageBox.Show("Please enter the medicine name to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "UPDATE Medicine SET medType = '" + medtype + "', medQuantity = '" + medqantity + "', medPrice = '" + medprice + "' WHERE medName = '" + medname + "'";
                int rowsAffected = newdb.write(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Medicine updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No medicine found with the given name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            load_products();
        }
    }
}
