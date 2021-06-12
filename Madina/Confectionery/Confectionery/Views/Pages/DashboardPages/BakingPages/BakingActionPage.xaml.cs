using Confectionery.Context;
using Confectionery.Model;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Confectionery.Views.Pages.DashboardPages.BakingPages
{
    /// <summary>
    /// Interaction logic for BakingActionPage.xaml
    /// </summary>
    public partial class BakingActionPage : Page
    {
        public Product Product { get; set; }
        public BakingActionPage(Product product)
        {
            InitializeComponent();
            Product = product;
            this.DataContext = this;
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (Product.id == 0)
            {
                AppData.db.Product.Add(Product);
            }
            File.Copy(file.FileName, $"pics\\{System.IO.Path.GetFileName(file.FileName).Trim()}", true);
            Product.GetPucture = "\\pics\\" + System.IO.Path.GetFileName(file.FileName);
            AppData.db.SaveChanges();
            MessageBox.Show("Данные успешно сохранены в Базе Данных.", "Внимание, операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
            GC.Collect();
            NavigationService.GoBack();
        }
        OpenFileDialog file = new OpenFileDialog();
        private void btnSelectPicture_Click(object sender, RoutedEventArgs e)
        {
            file.Filter = "Image (*.jpg;*.jpeg;*png;)|*.jpg;*.jpeg;*png;";
            Picture.Source = file.ShowDialog() == true ? Picture.Source = new BitmapImage(new Uri(file.FileName)) : null;
        }
    }
}
