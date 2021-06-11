using Confectionery.Context;
using Confectionery.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Word = Microsoft.Office.Interop.Word;

namespace Confectionery.Views.Pages.DashboardPages.BakingPages
{
    /// <summary>
    /// Interaction logic for BakingListPage.xaml
    /// </summary>
    public partial class BakingListPage : Page
    {
        public BakingListPage()
        {
            InitializeComponent();
        }

        private void btnAddNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BakingActionPage(new Product()));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = ProductList.SelectedItem as Product;
                if (selectedItem != null)
                {
                    if (MessageBox.Show("Вы действительно хотите удалить Агента? Данные будут удалены навсегда.", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        AppData.db.Product.Remove(selectedItem);
                        AppData.db.SaveChanges();
                        Page_Loaded(null, null);
                        //var photo = selectedItem.photo;
                        //File.Delete(Environment.CurrentDirectory + photo);
                    }
                }
                else
                    MessageBox.Show("Чтобы удалить запись, вам необходимо его выбрать.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = ProductList.SelectedItem as Product;
                if (selectedItem != null)
                    NavigationService.Navigate(new BakingActionPage(selectedItem));
                else
                    MessageBox.Show("Чтобы редактировать запись, вам необходимо его выбрать.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProductList.ItemsSource = AppData.db.Product.ToList();
        }

        private void btnPDFExport_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
            try
            {
                var document = word.Documents.Add();
                var paragraph = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragraph.Range;
                var products = AppData.db.Product.ToList();
                var table = document.Tables.Add(tableRange, products.Count, 3);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Наименование";
                table.Cell(1, 2).Range.Text = "Описание";
                table.Cell(1, 3).Range.Text = "Вес";
                int i = 2;
                foreach (var item in products)
                {
                    table.Cell(i, 1).Range.Text = item.title;
                    table.Cell(i, 2).Range.Text = item.description;
                    table.Cell(i, 3).Range.Text = item.weight.ToString();
                    i++;
                }
                document.SaveAs2(Environment.CurrentDirectory + @"parts.pdf", Word.WdSaveFormat.wdFormatPDF);
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение!", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }

            if (MessageBox.Show("Документ PDF успешно сформирован. Хотите открыть его?", "Операция прошла успешно!", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Process.Start(Environment.CurrentDirectory + @"parts.pdf");
            }
        }

        private void btnCSVExport_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream stream = new FileStream(Environment.CurrentDirectory + @"parts.csv", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    var products = AppData.db.Product.ToList();
                    writer.WriteLine("Название;Описание;Вес;");
                    foreach (var item in products)
                    {
                        writer.WriteLine($"{item.title};{item.description};{item.weight};");
                    }
                }
            }
            MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
