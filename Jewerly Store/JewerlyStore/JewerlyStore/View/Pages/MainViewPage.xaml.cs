using JewerlyStore.Classes;
using JewerlyStore.DB;
using JewerlyStore.View.Pages.FunctionsWithData;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Word = Microsoft.Office.Interop.Word;

namespace JewerlyStore.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainViewPage.xaml
    /// </summary>
    public partial class MainViewPage : Page
    {
        public MainViewPage()
        {
            InitializeComponent();
        }

        //Инициализация
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Jewelry.ToList();
        }

        //Поиск
        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Jewelry.Where(item => item.JewName.Contains(searchTxb.Text) || item.Material.Contains(searchTxb.Text) || item.Category.Title.Contains(searchTxb.Text)).ToList();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Добавление
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        //Удаление
        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Jewelry removeJewerly = (Jewelry)listDataView.SelectedItem;
                if(removeJewerly != null)
                {
                    if(MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Jewelry.Remove(removeJewerly);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                }
                else
                {
                    throw new Exception("Выберите элемент!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Экспорт данных в PDF
        private void pdfBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
            try
            {
                var document = word.Documents.Add();
                var paragraph = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragraph.Range;
                var jewerlyList = ConnectClass.db.Jewelry.ToList();
                var table = document.Tables.Add(tableRange, jewerlyList.Count, 7);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Наименование";
                table.Cell(1, 2).Range.Text = "Категория";
                table.Cell(1, 3).Range.Text = "Материал";
                table.Cell(1, 4).Range.Text = "Цена";
                table.Cell(1, 5).Range.Text = "Высота";
                table.Cell(1, 6).Range.Text = "Ширина";
                table.Cell(1, 7).Range.Text = "Вес";

                int i = 2;
                foreach (var item in jewerlyList)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.JewName;
                    table.Cell(i, 2).Range.Text = item.Category.Title;
                    table.Cell(i, 3).Range.Text = item.Material;
                    table.Cell(i, 4).Range.Text = (item.Pice).ToString();
                    table.Cell(i, 5).Range.Text = item.Parameters.Height;
                    table.Cell(i, 6).Range.Text = item.Parameters.Width;
                    table.Cell(i, 7).Range.Text = item.Parameters.Weight;
                    i++;
                }
                document.SaveAs2(@"A:\parts.pdf", Word.WdSaveFormat.wdFormatPDF);
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение!", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }

        //Двойное нажатие - изменение
        private void listDataView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Jewelry editJewelry = (Jewelry)listDataView.SelectedItem;
            if(editJewelry != null)
            {
                NavigationService.Navigate(new EditPage(editJewelry));
            }
        }
    }
}
