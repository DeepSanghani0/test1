using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextProject.Data;

namespace TextProject
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        productMethod pm = new productMethod();
       

        static string connstrng = ConfigurationManager.ConnectionStrings["myconnstrng"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstrng);

        public string Email { get; set; }
        private void product_Load(object sender, EventArgs e)
        {
            DataTable dt = pm.select();
            dgvProduct.DataSource = dt;
            username.Text = Email;

            //-----------------------------
            
            
            //----------------------------

            SqlCommand cmd = new SqlCommand("Permision",conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email",Email);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                string Permission = dr.GetValue(0).ToString();
                conn.Close();
                if(Permission == "1")
                {
                    register r = new register();
                    labeldesignation.Text = r.Designation;
                    SqlCommand cmd1 = new SqlCommand("searchdesignation3", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Email", Email);
                    conn.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        int designationindex, insertedbyindex;
                        designationindex = Convert.ToInt32(dr1.GetValue(0));
                        insertedbyindex = Convert.ToInt32(dr1.GetValue(1));
                        
                        
                        if(designationindex < insertedbyindex)
                        { 
                            btnUpdate.Hide();
                            btnDelete.Hide();
                        }
                        conn.Close();
                    }
                        
                    
                }
                else if(Permission == "2")
                {
                    btnDelete.Hide();
                }
                else if(Permission == "4")
                {
                    gp.Hide();
                }

            }
            conn.Close();
        }
        public void clear()
        {
            txtPId.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            dtpMDate.Text = "";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            pm.ProductName = txtProductName.Text;
            pm.Price = txtPrice.Text;
            pm.MDate = dtpMDate.Text;

            bool success = pm.insert(pm);
            if (success)
            {
                MessageBox.Show("Product Add Successfully");
                DataTable dt = pm.select();
                dgvProduct.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add product");
            }
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtPId.Text = dgvProduct.Rows[rowIndex].Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[rowIndex].Cells[2].Value.ToString();
            dtpMDate.Text = dgvProduct.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pm.ProductName = txtProductName.Text;
            pm.Price = txtPrice.Text;
            pm.MDate = dtpMDate.Text;
            pm.ProductId = int.Parse(txtPId.Text);

            bool success = pm.update(pm);
            if (success)
            {
                MessageBox.Show("Product Update Successfully");
                DataTable dt = pm.select();
                dgvProduct.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Update product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pm.ProductId = int.Parse(txtPId.Text);

            bool success = pm.delete(pm);
            if (success)
            {
                MessageBox.Show("Product delete Successfully");
                DataTable dt = pm.select();
                dgvProduct.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete product");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            register r = new register();

            SqlCommand cmd1 = new SqlCommand("searchdesignation2", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Email", Email);
            conn.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                

                r.Designation = dr1.GetValue(0).ToString();
                r.insertdesignation = dr1.GetValue(1).ToString();
                labeldesignation.Text = r.Designation;
            }
            r.Show();
            conn.Close();
        }

        
    }
}
