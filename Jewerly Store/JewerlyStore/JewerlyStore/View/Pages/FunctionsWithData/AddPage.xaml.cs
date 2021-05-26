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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            //Инициализация данных в комбобокс
            categoryCmb.ItemsSource = ConnectClass.db.Category.Select(item => item.Title).ToList();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Кнопка добавления
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Jewelry newJewelry = new Jewelry();
            Category newCategory = new Category();
            Parameters newParameteres = new Parameters();

            //Добавление изобржения
            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encoder.Save(stream);
            newJewelry.JewImg = stream.ToArray();
            //-------------------------------------------------------------------

            newJewelry.JewName = jewNameTxb.Text;
            newJewelry.Material = materialTxb.Text;
            newJewelry.Pice = Convert.ToInt64(priceTxb.Text);
            newJewelry.ParametersID = newParameteres.ID;

            var jewCategory = ConnectClass.db.Category.FirstOrDefault(item => item.Title == categoryCmb.Text);
            newJewelry.CategoryID = jewCategory.ID;

            newParameteres.Height = heightTxb.Text;
            newParameteres.Width = widthTxb.Text;
            newParameteres.Weight = widthTxb.Text;

            ConnectClass.db.Parameters.Add(newParameteres);
            ConnectClass.db.Jewelry.Add(newJewelry);

            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно добавлены!");
            NavigationService.GoBack();
        }

        //Кнопка открытия изображения
        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
            if(file.ShowDialog() == true)
            {
                BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                imgLoad.Source = imgBitmap;
            }
        }
    }
}
