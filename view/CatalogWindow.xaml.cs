using DigitalSkills.view;
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
using System.Windows.Shapes;
using varchar_128_.model;
using varchar_128_.modelHelper;

namespace varchar_128_.view
{
    /// <summary>
    /// Логика взаимодействия для CatalogWindow.xaml
    /// </summary>
    public partial class CatalogWindow : Window
    {
        private CatalogModel model;
        private int countSkip;
        private double maxSkip;
        public CatalogWindow()
        {
            InitializeComponent();
            model = new CatalogModel();
            countSkip = 0;
            var books = model.GetBooks();
            maxSkip = Math.Ceiling(books.Count / 50.0);
            Filldg();
        }

        private void Filldg()
        {
            var books = model.GetBooks();
            dgBooks.ItemsSource = books.Skip(countSkip * 50).Take(50);
            tbMax.Text = $"of {maxSkip}";
            btCountBook.Text = $"{books.Count} Books found";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            dgBooks.ItemsSource = model.GetBooks(tbTitle.Text, tbAuthor.Text, tbSubject.Text);
        }

        private void dgBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var book = model.GetBook(dgBooks.SelectedItem);
            detailesInfoBook.DataContext = new authorHelper(book);
            var check = book.author.FirstOrDefault() != null && book.author.FirstOrDefault().bio != null;
            btOpenBio.Foreground = check ? Brushes.Blue : Brushes.Black;
            btOpenBio.IsEnabled = check;
            description.Visibility = Visibility.Visible;
        }

        private void MenuItemAuth_Click(object sender, RoutedEventArgs e)
        {
            if((bool)new LoginWindow().ShowDialog())
            {
                miLogin.Visibility = Visibility.Hidden;
                miCustomer.Visibility = miOutlogin.Visibility = Visibility.Visible;
            }
        }

        private void MenuItemClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinOneSkip(object sender, RoutedEventArgs e)
        {
            if(countSkip != 0)
                tbCountSkip.Text = (--countSkip + 1).ToString();
        }

        private void PlusOneSkip(object sender, RoutedEventArgs e)
        {
            if(countSkip + 1 != maxSkip)
                tbCountSkip.Text = (++countSkip + 1).ToString();
        }

        private void TextChangeSkip(object sender, TextChangedEventArgs e)
        {
            if (model == null)
                return;
            Filldg();
        }

        private void miOutlogin_Click(object sender, RoutedEventArgs e)
        {
            miLogin.Visibility = Visibility.Visible;
            miCustomer.Visibility = miOutlogin.Visibility = Visibility.Hidden;
        }

        private void btOpenBio_Click(object sender, RoutedEventArgs e)
        {
            var book = model.GetBook(dgBooks.SelectedItem);
            new AuthorBioWindow(book.author).ShowDialog();
        }

        private void MenuItemCustomer_Click(object sender, RoutedEventArgs e)
        {
            new CustomerWindow().ShowDialog();
        }

        private void MenuItemCirculation_Click(object sender, RoutedEventArgs e)
        {
            new CirculationWindow().ShowDialog();
        }

        private void MenuItemReport_Click(object sender, RoutedEventArgs e)
        {
            new ReportWindow().ShowDialog();
        }
    }
}
