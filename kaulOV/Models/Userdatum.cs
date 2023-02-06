using System;
using System.Collections.Generic;
using System.Text;
using kaulOV.Classes;

namespace kaulOV.Models
{
    public class Userdatum 
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
