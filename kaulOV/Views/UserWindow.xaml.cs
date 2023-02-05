using kaulOV.Classes;
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
    public partial class UserWindow : Window
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region fields
        private readonly UsersDB db = new UsersDB();
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion

        #region Properties
        private ObservableCollection<Countries> countries = new();

        public ObservableCollection<Countries> Countries
        {
            get { return countries; }
            set { countries = value; OnPropertyChanged(); }
        }
        private Countries? selectedCountry;
        public Countries? SelectedCountry
        {
            get { return selectedCountry; }
            set { selectedCountry = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Users> users = new();

        public ObservableCollection<Users> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged(); }
        }
        private Users? selectedUser;
        public Users? SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; OnPropertyChanged(); }
        }
        #endregion
        
        public UserWindow()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditUserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
