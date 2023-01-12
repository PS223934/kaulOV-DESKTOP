using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows;
using MySql.Data.MySqlClient;

namespace kaulOV.Classes
{
    public class Auth
    {
        private readonly string _dbc = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public bool Login(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_dbc))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successful");
                    return true;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    return false;
                }

            }
        }
    }
}
