using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Navigation;
using kaulOV.Views;
using MySql.Data.MySqlClient;

namespace kaulOV.Classes
{
    public class Auth
    {
        

        private readonly string _dbc = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public bool Login(string token)
        {
      
            using (MySqlConnection conn = new MySqlConnection(_dbc))
            {
                conn.Open();
                string query = "SELECT * FROM personal_access_tokens WHERE token = @Token";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Token", token);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    conn.Close();

                    return true;
                }
                else
                {

                    return false;
                }

            }
        }
    }
}