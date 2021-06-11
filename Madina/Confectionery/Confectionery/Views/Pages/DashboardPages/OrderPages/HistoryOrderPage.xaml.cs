using Confectionery.Context;
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
    /// Interaction logic for HistoryOrderPage.xaml
    /// </summary>
    public partial class HistoryOrderPage : Page
    {
        public HistoryOrderPage()
        {
            InitializeComponent();
            HistoryProductList.ItemsSource = AppData.db.CheckList.ToList();
        }
    }
}
