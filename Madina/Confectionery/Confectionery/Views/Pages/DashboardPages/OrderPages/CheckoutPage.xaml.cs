using Confectionery.Context;
using Confectionery.Model;
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

namespace Confectionery.Views.Pages.DashboardPages.OrderPages
{
    /// <summary>
    /// Interaction logic for CheckoutPage.xaml
    /// </summary>
    public partial class CheckoutPage : Page
    {
        private int _idClient;
        private int _idProduct;
        private int _balance = 1;
        private int _countProdcut { get; set; }
        private int _count = 1;
        private double _total { get; set; }
        private double _price { get; set; }
        public CheckoutPage()
        {
            InitializeComponent();
            txbCount.Visibility = Visibility.Hidden;
            selectedClient.ItemsSource = AppData.db.Client.ToList();
            selectedClient.DisplayMemberPath = "FullName";
            selectedProduct.ItemsSource = AppData.db.Product.ToList();
            selectedProduct.DisplayMemberPath = "GetProduct";
            typePayment.ItemsSource = AppData.db.PaymentType.ToList();
            typePayment.DisplayMemberPath = "title";
        }

        private void selectedClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _idClient = (selectedClient.SelectedItem as Client).id;
        }

        private void selectedProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _idProduct = (selectedProduct.SelectedItem as Product).id;
            _total = (selectedProduct.SelectedItem as Product).price;
            _countProdcut = (selectedProduct.SelectedItem as Product).count;
            _price = _total;
            txbCount.Visibility = Visibility.Visible;
            if (_idProduct != 0)
            {
                _count = 1;
                txbCount.Text = _count.ToString();
                txbTotalPrice.Text = "Итого: " + _total.ToString() + " руб.";
            }
            else
            {
                MessageBox.Show("Данного товара нет в наличии.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txbCount.Text = "0";
                txbTotalPrice.Text = "0";
            }
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            txbCount.Visibility = Visibility.Visible;
            if (_countProdcut != 0)
            {
                if (_countProdcut == _count)
                {
                    MessageBox.Show("Вы первысили количество товара, которое имеется в наличии склада.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    _count++;
                    _balance = _countProdcut - _count;
                    _total += _price;

                }
                txbTotalPrice.Text = "Итого: " + _total.ToString() + " руб.";
                txbCount.Text = _count.ToString();
            }
            else
            {
                MessageBox.Show("Вы первысили количество товара, которое имеется в наличии склада.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            if (_count != 0)
            {
                _count--;
                _total -= _price;
            }
            _balance = _countProdcut + _count;
            txbTotalPrice.Text = "Итого: " + _total.ToString() + " руб.";
            txbCount.Text = _count.ToString();
        }

        private void btnBasketAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckList checkList = new CheckList();
                Basket basket = new Basket();
                checkList.idClient = _idClient;
                checkList.idProduct = _idProduct;
                checkList.dateCheck = DateTime.Now;
                checkList.count = _count;
                checkList.totalPrice = _total;
                checkList.idPayment = (typePayment.SelectedItem as PaymentType).id;
                AppData.db.CheckList.Add(checkList);
                basket.idClient = _idClient;
                basket.idProduct = _idProduct;
                basket.totalPrice = _total;
                basket.count = _count;
                AppData.db.Basket.Add(basket);
                AppData.db.SaveChanges();
                BasketList.ItemsSource = AppData.db.Basket.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = BasketList.SelectedItem as Basket;
                if (selectedClient != null)
                {
                    AppData.db.Basket.Remove(selectedItem);
                    AppData.db.SaveChanges();
                    BasketList.ItemsSource = AppData.db.Basket.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnOrderDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var basket = AppData.db.Basket.ToList();
                AppData.db.Basket.RemoveRange(basket);
                AppData.db.SaveChanges();
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() == true)
                {
                    print.PrintVisual(BasketList, "Check");
                }
                MessageBox.Show("Оформление чека прошло успешно.", "Чек сохранен!", MessageBoxButton.OK, MessageBoxImage.Information);
                BasketList.ItemsSource = AppData.db.Basket.ToList();
                NavigationService.Navigate(new MenuPage());
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
