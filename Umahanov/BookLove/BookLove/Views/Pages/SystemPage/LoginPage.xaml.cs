using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookLove.Views.Pages.SystemPage
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
        string GetCaptchaCode()
        {
            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            string password = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++) password += alphabet[random.Next(alphabet.Length)];
            return password;
        }
        private void ShowPassworButton_Click(object sender, RoutedEventArgs e)
        {

            if (PasswordTextBox.Visibility == Visibility.Collapsed)
            {
                PasswordTextBox.Text = psbPassword.Password;
                PasswordTextBox.Visibility = Visibility.Visible;
                psbPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                PasswordTextBox.Visibility = Visibility.Collapsed;
                psbPassword.Visibility = Visibility.Visible;
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Repack_Click(object sender, RoutedEventArgs e)
        {
            txbCaptchaText.Text = GetCaptchaCode();
        }
    }
}
