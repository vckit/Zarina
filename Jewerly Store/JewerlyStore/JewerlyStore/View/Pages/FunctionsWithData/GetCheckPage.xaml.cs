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
        private Check Check;
        public GetCheckPage(Check check)
        {
            InitializeComponent();
            this.Check = check;
            txbFioClient.Text = check.Client.FullName;
            txbJewName.Text = check.Jewelry.JewelryGet;
            txbDate.Text = check.Date.ToString();
            txbCommission.Text = check.Commission.ToString();
            txbTotalPrice.Text = check.TotalPrice.ToString();
        }

        private void btnCheckGet_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
             var document = word.Documents.Add();
                var paragraph = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragraph.Range;
                var check = ConnectClass.db.Check.ToList();
                var table = document.Tables.Add(tableRange, check.Count, 5);
                table.Borders.Enable = 1;

                table.Cell(1, 1).Range.Text = "ID";
                table.Cell(1, 2).Range.Text = "ФИО Клиента";
                table.Cell(1, 3).Range.Text = "Изделие";
                table.Cell(1, 4).Range.Text = "Дата";
                table.Cell(1, 5).Range.Text = "Итоговая цена";
                int i = 2;

                foreach (var item in check)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.Client.FullName;
                    table.Cell(i, 2).Range.Text = item.Jewelry.JewelryGet;
                    table.Cell(i, 3).Range.Text = item.Date.ToString();
                    table.Cell(i, 4).Range.Text = item.TotalPrice.ToString();
                    i++;
                }
            document.SaveAs2(@"С:\check.pdf", Word.WdSaveFormat.wdFormatPDF);
            document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
            word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
