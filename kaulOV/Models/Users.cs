using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace kaulOV.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class UserManager
    {
        private ObservableCollection<User> _users;

        public UserManager()
        {
            _users = new ObservableCollection<User>();
        }

        public ObservableCollection<User> GetUsers()
        {
            return _users;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void UpdateUser(User user)
        {
            User existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
            }
        }

        public void DeleteUser(int id)
        {
            User userToDelete = _users.FirstOrDefault(u => u.Id == id);
            if (userToDelete != null)
            {
                _users.Remove(userToDelete);
            }
        }
    }
}
