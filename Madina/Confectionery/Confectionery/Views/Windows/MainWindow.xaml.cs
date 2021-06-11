using Confectionery.Views.Pages.DashboardPages;
using System;
using System.Windows;

namespace Confectionery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MenuPage());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            btnBack.Visibility = MainFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
