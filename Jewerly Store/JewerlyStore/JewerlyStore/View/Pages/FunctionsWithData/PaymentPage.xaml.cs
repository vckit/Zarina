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
        private int _balance = 1;
        private int _countJew { get; set; }
        private int _count = 1;
        private float _total { get; set; }
        private float _price { get; set; }
        public PaymentPage()
        {
            InitializeComponent();
            txbCount.Visibility = Visibility.Hidden;
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
                check.TotalPrice = _total;
                check.Count = _count;
                ConnectClass.db.Check.Add(check);
                var selectedCount = ConnectClass.db.Jewelry.FirstOrDefault(item => item.ID == check.IDJewelry);
                selectedCount.Count = _balance;
                ConnectClass.db.SaveChanges();
                NavigationService.Navigate(new BasketPage(check));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelectJewely_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _countJew = (cmbSelectJewely.SelectedItem as Jewelry).Count;
            _total = (cmbSelectJewely.SelectedItem as Jewelry).Pice;
            _price = _total;
            txbCount.Visibility = Visibility.Visible;
            if(_countJew != 0)
            {
                _count = 1;
                txbCount.Text = _count.ToString();
                txbTotalPrice.Text = _total.ToString();
            }
            else
            {
                MessageBox.Show("Данного товара нет в наличии.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txbCount.Text = "0";
                txbTotalPrice.Text = "0";
            } 
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnAddCount_Click(object sender, RoutedEventArgs e)
        {
            txbCount.Visibility = Visibility.Visible;
            if(_countJew != 0)
            {
                if (_countJew == _count)
                {
                    MessageBox.Show("Вы первысили количество товара, которое имеется в наличии склада.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    _count++;
                    _balance = _countJew - _count;
                    _total += _price;
                    
                }
                txbTotalPrice.Text = _total.ToString();
                txbCount.Text = _count.ToString();
            }
            else
            {
                MessageBox.Show("Вы первысили количество товара, которое имеется в наличии склада.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnRemoveCount_Click(object sender, RoutedEventArgs e)
        {
            if (_count != 0)
            {
                _count--;
                _total -= _price;
            }
            _balance = _countJew + _count;
            txbTotalPrice.Text = _total.ToString();
            txbCount.Text = _count.ToString();
        }
    }
}
