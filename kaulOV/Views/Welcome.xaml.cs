using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using kaulOV.Views;

namespace kaulOV.Views
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {

        public Welcome()
        {
            InitializeComponent();

        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            Window uw = new UserWindow();
            uw.Show();
        }
    }
}
