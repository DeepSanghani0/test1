using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProject.Data
{
    class productMethod
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Price { get; set; }

        public string MDate { get; set; }

        public int Permission { get; set; }


        static string connstrng = ConfigurationManager.ConnectionStrings["myconnstrng"].ConnectionString;
        SqlConnection conn = new SqlConnection(connstrng);

        public bool insert(productMethod pm)
        {
            bool issuccess = false;

            try
            {
                SqlCommand cmd = new SqlCommand("addproduct", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductName", pm.ProductName);
                cmd.Parameters.AddWithValue("@Price", pm.Price);
                cmd.Parameters.AddWithValue("@MDate", pm.MDate);
                cmd.Parameters.AddWithValue("@Permission", 1);


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
                
            }
            finally
            {
                conn.Close();
            }

            return issuccess;
        }

        public DataTable select()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("showdatadgv1", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool update(productMethod pm)
        {
            bool issuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("updatedata1", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", pm.ProductName);
                cmd.Parameters.AddWithValue("@Price", pm.Price);
                cmd.Parameters.AddWithValue("@MDate", pm.MDate);
                cmd.Parameters.AddWithValue("Id", pm.ProductId);


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

        public bool delete(productMethod pm)
        {
            bool issuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("deletedata", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Permission = 0;
                cmd.Parameters.AddWithValue("@Permission", Permission);
                cmd.Parameters.AddWithValue("Id", pm.ProductId);


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
