using Confectionery.Context;
using Confectionery.Model;
using System.Windows;
using System.Windows.Controls;

namespace Confectionery.Views.Pages.DashboardPages.OrderPages
{
    /// <summary>
    /// Interaction logic for OrderCreatePage.xaml
    /// </summary>
    public partial class OrderCreatePage : Page
    {
        public Client Client { get; set; }
        public OrderCreatePage(Client client)
        {
            InitializeComponent();
            Client = client;
            this.DataContext = this;
        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            if(Client.id == 0)
                AppData.db.Client.Add(Client);
            AppData.db.SaveChanges();
            MessageBox.Show("Клиент успешно зарегистрирован, пожалуйста, перейдите к оформлению заказа.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new CheckoutPage());

        }

        private void btnSkipAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckoutPage());
        }
    }
}
