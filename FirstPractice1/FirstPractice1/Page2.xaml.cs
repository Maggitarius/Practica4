using System;
using System.Collections.Generic;
using System.Data;
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
using FirstPractice1.LibraryDatabaseDataSetTableAdapters;

namespace FirstPractice1
{
    public partial class Page2 : Page
    {
        BooksTableAdapter books = new BooksTableAdapter();
        public Page2()
        {
            InitializeComponent();
            Books.ItemsSource = books.GetData();
            ComboBxB.ItemsSource = books.GetData();
            ComboBxB.DisplayMemberPath = "GenreOfbOOK";
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Books.ItemsSource = books.SearchBooks(Search.Text);
        }
        private void ComboBxB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var id = (int)(ComboBxB.SelectedItem as DataRowView).Row[0];
            Books.ItemsSource = books.BooksSearch(id);
        }

        private void Filtr_Click(object sender, RoutedEventArgs e)
        { 
            Books.ItemsSource = books.GetData();
        }

    }
}
