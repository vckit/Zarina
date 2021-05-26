using JewerlyStore.Classes;
using JewerlyStore.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Jewelry selectedItem;
        public EditPage(Jewelry selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            categoryCmb.ItemsSource = ConnectClass.db.Category.Select(item => item.Title).ToList();

            //Передача изображения на страницу
            if (selectedItem.JewImg != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.JewImg))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                imgLoad.Source = bitmap;
            }

            jewNameTxb.Text = selectedItem.JewName;
            categoryCmb.SelectedItem = selectedItem.Category.Title;
            materialTxb.Text = selectedItem.Material;
            priceTxb.Text = Convert.ToString(selectedItem.Pice);
            heightTxb.Text = selectedItem.Parameters.Height;
            widthTxb.Text = selectedItem.Parameters.Width;
            weightTxb.Text = selectedItem.Parameters.Weight;
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Кнопка изменения
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var editJewelry = ConnectClass.db.Jewelry.FirstOrDefault(item => item.ID == selectedItem.ID);

            //Добавление изображения
            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encoder.Save(stream);
            editJewelry.JewImg = stream.ToArray();

            editJewelry.JewName = jewNameTxb.Text;
            editJewelry.Category.Title = categoryCmb.Text;
            editJewelry.Material = materialTxb.Text;
            editJewelry.Pice = Convert.ToInt64(priceTxb.Text);
            editJewelry.Parameters.Height = heightTxb.Text;
            editJewelry.Parameters.Width = widthTxb.Text;
            editJewelry.Parameters.Weight = weightTxb.Text;

            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно изменены!");
            NavigationService.GoBack();
        }

        //Кнопка открытия изображения
        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
            if (file.ShowDialog() == true)
            {
                BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                imgLoad.Source = imgBitmap;
            }
        }
    }
}
