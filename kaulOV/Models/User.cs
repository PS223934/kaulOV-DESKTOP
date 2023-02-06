using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace kaulOV.Models
{
    public class User
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
            set { email = value;; }
        }
    }

    /* public class UserManager
    {
        private ObservableCollection<Users> _users;

        public UserManager()
        {
            _users = new ObservableCollection<Users>();
        }

        public ObservableCollection<Users> GetUsers()
        {
            return _users;
        }

        public void AddUser(Users users)
        {
            _users.Add(users);
        }

        public void UpdateUser(Users users)
        {
            Users existingUser = _users.FirstOrDefault(u => u.Id == users.Id);
            if (existingUser != null)
            {
                existingUser.Id = users.Id;
                existingUser.Email = users.Email;
            }
        }

        public void DeleteUser(int id)
        {
            Users userToDelete = _users.FirstOrDefault(u => u.Id == id);
            if (userToDelete != null)
            {
                _users.Remove(userToDelete);
            }
        }
    }*/
}
