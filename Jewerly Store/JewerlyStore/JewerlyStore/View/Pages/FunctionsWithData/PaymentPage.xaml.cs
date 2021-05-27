using JewerlyStore.Classes;
using JewerlyStore.DB;
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
                ConnectClass.db.Check.Add(check);
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Success!");
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
    }
}
