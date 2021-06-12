using Confectionery.Context;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Word = Microsoft.Office.Interop.Word;

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

        private void dtpDateHistory_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            HistoryProductList.ItemsSource = AppData.db.CheckList.Where(item => item.dateCheck == dtpDateHistory.SelectedDate).ToList();
        }

        private void btnFilterOff_Click(object sender, RoutedEventArgs e)
        {
            dtpDateHistory.SelectedDate = null;
            HistoryProductList.ItemsSource = AppData.db.CheckList.ToList();
        }

        private void btnPDFExport_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
            try
            {
                var document = word.Documents.Add();
                var paragraph = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragraph.Range;
                var products = AppData.db.CheckList.ToList();
                var table = document.Tables.Add(tableRange, products.Count, 5);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Клиент";
                table.Cell(1, 2).Range.Text = "Выпечка";
                table.Cell(1, 3).Range.Text = "Цена";
                table.Cell(1, 4).Range.Text = "Тип оплаты";
                table.Cell(1, 5).Range.Text = "Дата";
                int i = 2;
                foreach (var item in products)
                {
                    table.Cell(i, 1).Range.Text = item.Client.FullName;
                    table.Cell(i, 2).Range.Text = item.Product.GetProduct;
                    table.Cell(i, 3).Range.Text = item.totalPrice.ToString();
                    table.Cell(i, 4).Range.Text = item.PaymentType.title;
                    table.Cell(i, 5).Range.Text = item.dateCheck.ToString();
                    i++;
                }
                document.SaveAs2(Environment.CurrentDirectory + @"history.pdf", Word.WdSaveFormat.wdFormatPDF);
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
                Process.Start(Environment.CurrentDirectory + @"history.pdf");
            }
        }

        private void btnCSV_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream stream = new FileStream(Environment.CurrentDirectory + @"history.csv", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    var products = AppData.db.CheckList.ToList();
                    writer.WriteLine("Клиент;Выпечка;Цена;Тип оплаты;Дата");
                    foreach (var item in products)
                    {
                        writer.WriteLine($"{item.Client.FullName};{item.Product.GetProduct};{item.totalPrice};{item.PaymentType.title};{item.dateCheck}");
                    }
                }
            }
            MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
