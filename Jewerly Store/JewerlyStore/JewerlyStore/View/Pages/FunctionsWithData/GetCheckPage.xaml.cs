using JewerlyStore.Classes;
using JewerlyStore.DB;
using System;
using System.Linq;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Controls;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для GetCheckPage.xaml
    /// </summary>
    public partial class GetCheckPage : Page
    {
        private Basket Check;
        public GetCheckPage(Basket check)
        {
            InitializeComponent();
            this.Check = check;
            txbFioClient.Text = check.Check1.Client.FullName;
            txbJewName.Text = check.Check1.Jewelry.JewelryCheckGet;
            txbDate.Text = check.Check1.Date.ToString();
            txbCommission.Text = check.Check1.Commission.ToString();
            txbTotalPrice.Text = check.Check1.TotalPrice.ToString();
            txbCount.Text = check.Check1.Count.ToString();
        }

        private void btnCheckGet_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(pirntStackpanel, "Check");
            }
            MessageBox.Show("Оформление чека прошло успешно.", "Чек сохранен!", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new MenuPage());
        }
    }
}
