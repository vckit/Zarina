using Confectionery.Model;
using Confectionery.Views.Pages.DashboardPages.BakingPages;
using Confectionery.Views.Pages.DashboardPages.OrderPages;
using Confectionery.Views.Pages.FunctionPages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Confectionery.Views.Pages.DashboardPages
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnBaking_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BakingListPage());
        }

        private void btnOrderCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderCreatePage(new Client()));
        }


        private void btnOrderHistory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HistoryOrderPage());
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Вниманиме!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                NavigationService.Navigate(new LoginPage());
            GC.Collect();
        }
    }
}
