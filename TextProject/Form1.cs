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

namespace TextProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connstrng = ConfigurationManager.ConnectionStrings["myconnstrng"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstrng);

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
               
                SqlCommand cmd = new SqlCommand("login1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successfully");
                    product p = new product();
                    p.Email = txtEmail.Text;
                    p.Show();

                }
                else
                {
                    MessageBox.Show("Failed To login");
                }
                conn.Close();
        }

        
    }
}
