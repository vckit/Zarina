using JewerlyStore.Classes;
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

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public HistoryPage()
        {
            InitializeComponent();
            ChecksList.ItemsSource = ConnectClass.db.Check.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void dtpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ChecksList.ItemsSource = ConnectClass.db.Check.Where(item => item.Date == dtpDate.SelectedDate).ToList();
        }

        private void AllCheck_Click(object sender, RoutedEventArgs e)
        {
            dtpDate.SelectedDate = null;
            ChecksList.ItemsSource = ConnectClass.db.Check.ToList();
        }
    }
}
