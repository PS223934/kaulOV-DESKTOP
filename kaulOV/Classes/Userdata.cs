using System;
using System.Collections.Generic;
using System.Text;
using kaulOV.Models;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace kaulOV.Classes
{
    public class Userdata
    {
        private readonly string _dbc = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public List<Userdatum> All()
        {
            List<Userdatum> r = new List<Userdatum>();
            using (MySqlConnection conn = new MySqlConnection(_dbc))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users";

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    foreach (DataRow row in table.Rows)
                    {
                        Userdatum temp = new Userdatum();
                        temp.Id = Convert.ToInt32(row["id"]);
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
