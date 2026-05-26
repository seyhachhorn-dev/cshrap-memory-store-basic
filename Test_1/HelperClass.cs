using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    internal class HelperClass
    {

 
        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;


            using (SqlConnection con = new SqlConnection(DatabaseConfiguration.con_string))

                try


                {
                    //we can do * but just selecet 1 for speed and using @parameter map for prevent sql Injection

                    string selectQuery = "select COUNT(1) from tbl_users where username = @Username and password = @Password";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))

                    {

                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        cmd.Parameters.AddWithValue("@Password", password.Trim());

                        con.Open();

                        // ExecuteScalar is much faster than a DataTable for checking existence

                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if(userCount > 0)
                        {
                            isValid = true;
                        }

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            return isValid;



        }



    }
}
