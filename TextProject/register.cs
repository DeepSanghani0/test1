using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextProject.Data;

namespace TextProject
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        loginmodel l = new loginmodel();

        public string insertdesignation { get; set; }
        public string Designation { get; set; }

        private void register_Load(object sender, EventArgs e)
        {
            cmbinsertedby.Text = Designation;
        }

        product p = new product();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            l.Name = txtName.Text;
            l.Email = txtEmail.Text;
            l.Password = txtPassword.Text;
            l.Permission = int.Parse(cmbPermission.Text);
            l.Designation = cmbDesignation.Text;
            l.insertdesignation = cmbinsertedby.Text;
            l.insertedbyindex = cmbinsertedby.SelectedIndex;
            l.designationindex = cmbDesignation.SelectedIndex;
            
          
           
            bool success = l.insert(l);

            if (success)
            {
                MessageBox.Show("Regisration SuccessFully");
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Regisration Failed");
            }
        }

        
    }
}
