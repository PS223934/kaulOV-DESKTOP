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
        
        Auth auth = new Auth();
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (TokenBox.Text.Length == 0)
            {
                errormessage.Text = "Enter a token.";
                TokenBox.Focus();
            }
            else
            {
                bool result = auth.Login(TokenBox.Text);
                
                if (result)
                {
                    MessageBox.Show("Login successfuld");
                    this.Close();
                    Welcome welcome = new Welcome();
                    welcome.Show();
                }
                else
                {
                    MessageBox.Show("Login failedz");
                }
            }
        }
    }
}