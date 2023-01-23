using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using kaulOV.Classes;

namespace kaulOV.Views
{
    /// <summary>  
        /// Interaction logic for MainWindow.xaml  
        /// </summary>   
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        Auth _Auth = new Auth();
        Registration _Registration = new Registration();
        Welcome _Welcome = new Welcome();
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (TokenBox.Text.Length == 0)
            {
                errormessage.Text = "Enter a token.";
                TokenBox.Focus();
            }
            else
            {
                _Auth.Login(TokenBox.Text);
                this.Close();
            }
        }
    }
}