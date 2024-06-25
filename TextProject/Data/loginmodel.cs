using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProject.Data
{
    class loginmodel
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Permission { get; set; }

        public string Designation { get; set; }

        public string insertdesignation { get; set; }

        public int insertedbyindex { get; set; }

        public int designationindex { get; set; }

        static string connstrng = ConfigurationManager.ConnectionStrings["myconnstrng"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstrng);

        public bool insert(loginmodel l)
        {
            bool issuccess = false;

            try
            {
                SqlCommand cmd = new SqlCommand("adduser3", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", l.Name);
                cmd.Parameters.AddWithValue("@Email", l.Email);
                cmd.Parameters.AddWithValue("@Password", l.Password);
                cmd.Parameters.AddWithValue("@Permission", l.Permission);
                cmd.Parameters.AddWithValue("@Designation", l.Designation);
                cmd.Parameters.AddWithValue("@insertedby", l.insertdesignation);
                cmd.Parameters.AddWithValue("@insertedbyindex", l.insertedbyindex);
                cmd.Parameters.AddWithValue("@designationinsex", l.designationindex);

                conn.Open();

                int success = cmd.ExecuteNonQuery();
                if (success > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return issuccess;
        }


    }
}
