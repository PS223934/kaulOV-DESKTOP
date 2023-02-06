using kaulOV.Classes;
using kaulOV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kaulOV.Views
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //linking all the needed database classes so we're able to execute queries with them later
        User users = new User();


        #region Users

        private ObservableCollection<User> observable_Users = new ObservableCollection<User>();
        public ObservableCollection<User> Users
        {
            get { return observable_Users; }
            set { observable_Users = value; }
        }
        
        private User selectedUser;
        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged();
                //InitializeList("Favourites");
                //InitializeList("Countries");
            }
        }
        #endregion

        #region UserData

        private ObservableCollection<Userdatum> observable_UserData = new ObservableCollection<Userdatum>();
        public ObservableCollection<Userdatum> Userdatum
        {
            get { return observable_UserData; }
            set { observable_UserData = value; }
        }

        private Userdatum selectedUserdatum;
        public Userdatum SelectedUserdatum
        {
            get { return selectedUserdatum; }
            set
            {
                selectedUserdatum = value;
                OnPropertyChanged();
                //InitializeList("Favourites");
                //InitializeList("Countries");
            }
        }
        #endregion
    }
}
