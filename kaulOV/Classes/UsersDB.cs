using kaulOV.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Text;

namespace kaulOV.Classes
{
    public class UsersDB
    {

        private readonly string _dbc = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
        
        public List<User> All()
        {
            List<Users> r = new List<UsersDB>();
            using (MySqlConnection conn = new MySqlConnection(_dbc))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Users";

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    foreach (DataRow row in table.Rows)
                    {
                        User temp = new User();
                        temp.Id = Convert.ToInt32(row["id"]);
                        temp.Name = row["name"].ToString();
                        temp.Email = row["email"].ToString();
                        r.Add(temp);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Exception: " + e.ToString());
                    return null;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                return r;
            }
        }
    }
}
