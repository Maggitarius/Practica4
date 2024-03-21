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
    public partial class Page1 : Page
    {
        private LibraryDatabaseEntities library = new LibraryDatabaseEntities();
        public Page1()
        {
            InitializeComponent();
            Authors.ItemsSource = library.Authors.ToList();
            ComboBxA.ItemsSource = library.Authors.ToList();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Authors.ItemsSource = library.Authors.ToList().Where(item => item.AuthorName.Contains(Search.Text));
        }

        private void Filtr_Click(object sender, RoutedEventArgs e)
        {
            Authors.ItemsSource = library.Authors.ToList();
        }

        private void ComboBxA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBxA.SelectedItem != null)
            {
                var sel = ComboBxA.SelectedItem as Authors;
                Authors.ItemsSource = library.Authors.ToList().Where(item => item == sel);
            }
        }
    }
}

