using JewerlyStore.Classes;
using JewerlyStore.DB;
using JewerlyStore.View.Pages.PlaceHolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        private int _count { get; set; }
        public float total { get; set; }
        public PaymentPage()
        {
            InitializeComponent();
            cmbSelectClient.ItemsSource = ConnectClass.db.Client.ToList();
            cmbSelectClient.DisplayMemberPath = "FullName";
            cmbSelectJewely.ItemsSource = ConnectClass.db.Jewelry.ToList();
            cmbSelectJewely.DisplayMemberPath = "JewelryGet";
        }

        private void btnOrderDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Check check = new Check();
                check.IDClient = (cmbSelectClient.SelectedItem as Client).ID;
                check.IDJewelry = (cmbSelectJewely.SelectedItem as Jewelry).ID;
                check.Date = DateTime.Now;
                check.TotalPrice = total;
                check.Count = _count;
                ConnectClass.db.Check.Add(check);
                ConnectClass.db.SaveChanges();
                NavigationService.Navigate(new OrderDone(check));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelectJewely_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            total = (cmbSelectJewely.SelectedItem as Jewelry).Pice;
            txbTotalPrice.Text = total.ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            ComboBox combo = new ComboBox();
            combo.ItemsSource = ConnectClass.db.Jewelry.ToList();
            combo.DisplayMemberPath = "JewelryGet";
            
            SimpleComboBox.Children.Add(combo);
        }

        private void btnAddCount_Click(object sender, RoutedEventArgs e)
        {
            _count++;
            txbCount.Text = _count.ToString();
        }

        private void btnRemoveCount_Click(object sender, RoutedEventArgs e)
        {
            if (_count != 0)
                _count--;
            txbCount.Text = _count.ToString();
        }
    }
}
