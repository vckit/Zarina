using JewerlyStore.Classes;
using JewerlyStore.DB;
using System.Linq;
using System.Windows.Controls;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Interaction logic for BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public Basket basket{ get; set; }
        public BasketPage(Basket basket)
        {
            InitializeComponent();
            this.basket = basket;
        }
    }
}
