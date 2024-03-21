using System;
using System.Collections.Generic;
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
using FirstPractice2;

namespace FirstPractice1
{
    public partial class Page2 : Page
    {
        private LibraryDatabaseEntities library = new LibraryDatabaseEntities();
        public Page2()
        {
            InitializeComponent();
            Books.ItemsSource = library.Books.ToList();
        }

        private void Filtr_Click(object sender, RoutedEventArgs e)
        {
            Books.ItemsSource = library.Books.ToList();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Books.ItemsSource = library.Books.ToList().Where(item => item.GenreOfbOOK.Contains(Search.Text));
        }

        private void ComboBxB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBxB.SelectedItem != null)
            {
                var sel = ComboBxB.SelectedItem as Books;
                Books.ItemsSource = library.Books.ToList().Where(item => item == sel);
            }

        }
    }
}
