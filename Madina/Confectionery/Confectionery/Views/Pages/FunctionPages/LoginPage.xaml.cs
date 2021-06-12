using Confectionery.Context;
using Confectionery.Views.Pages.DashboardPages;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Confectionery.Views.Pages.FunctionPages
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var currentLogin = AppData.db.Login.FirstOrDefault(item => item.username == txbLogin.Text && item.password == psbPassword.Password);
            if (txbCaptchaText.Text == CaptchaTextBox.Text)
            {
                if (currentLogin != null)
                {
                    NavigationService.Navigate(new MenuPage());
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует!", "В доступе отказано!", MessageBoxButton.OK, MessageBoxImage.Error);
                    txbCaptchaText.Text = GetCaptchaCode();
                    StackCaptche.Visibility = Visibility;
                }
            }
            else
            {
                MessageBox.Show("Вы не прошли капчу, пожалуйста повторите попытку", "Вниманиме!", MessageBoxButton.OK, MessageBoxImage.Error);
                txbCaptchaText.Text = GetCaptchaCode();
                StackCaptche.Visibility = Visibility;
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }

        private void btnRepack_Click(object sender, RoutedEventArgs e) => txbCaptchaText.Text = GetCaptchaCode();
    }
}
