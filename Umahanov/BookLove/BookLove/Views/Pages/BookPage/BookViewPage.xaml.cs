using BookLove.Context;
using BookLove.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace BookLove.Views.Pages.BookPage
{
    /// <summary>
    /// Interaction logic for BookViewPage.xaml
    /// </summary>
    public partial class BookViewPage : Page
    {
        public BookViewPage()
        {
            InitializeComponent();
        }

        private void CreateBookPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BookActionPage(new Book(), new Author()));
        }

        private void EditBookPage_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = BookListView.SelectedItem as Book;
            var selectedAuthor = selectedBook.Author;
            if (selectedBook != null)
                NavigationService.Navigate(new BookActionPage(selectedBook, selectedAuthor));
            else
                MessageBox.Show("Чтобы редактировать запись, вам необходимо его выбрать.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BookListView.ItemsSource = AppData.db.Book.ToList();
        }

        private void RemoveSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = BookListView.SelectedItem as Book;
            if (selectedBook != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить данные? Данные будут удалены навсегда.", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    AppData.db.Book.Remove(selectedBook);
                    AppData.db.SaveChanges();
                    Page_Loaded(null, null);
                    GC.Collect();
                }
                else
                    MessageBox.Show("Чтобы удалить запись, вам необходимо его выбрать.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
