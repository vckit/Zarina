using JewerlyStore.Classes;
using JewerlyStore.DB;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Interaction logic for BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public Check check{ get; set; }
        public BasketPage(Check check)
        {
            InitializeComponent();
            this.check = check;
            BasketList.ItemsSource = ConnectClass.db.Basket.Where(item => item.IDCheck == check.ID).ToList();
        }

        private void btnBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnRemove_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var selectedItem = BasketList.SelectedItem as Basket;
            if (selectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный вами объект? Данные будут удалены навсегда.", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ConnectClass.db.Basket.Remove(selectedItem);
                    ConnectClass.db.SaveChanges();
                    
                }
            }
            else
                MessageBox.Show("Выберите элемент!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnPayment_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new GetCheckPage(BasketList.SelectedItem as Basket));
        }
    }
}
