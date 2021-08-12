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
using varchar_128_.database;
using varchar_128_.model;

namespace varchar_128_.view
{
    /// <summary>
    /// Логика взаимодействия для CirculationWindow.xaml
    /// </summary>
    public partial class CirculationWindow : Window
    {

        private CirculationModel model;
        private customer customer;
        public CirculationWindow()
        {
            InitializeComponent();
            model = new CirculationModel();
        }

        private void btInfoCustomer(object sender, RoutedEventArgs e)
        {
            spInfo.DataContext = null;
            this.customer = null;
            tbCity.Text = "";
            btEdit.IsEnabled = false;
            dgCurrent.ItemsSource = dgHistory.ItemsSource = null;
           var customer = model.GetCustomer(idCustoner.Text);
            if (customer == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            this.customer = customer;
            btEdit.IsEnabled = true;
            spInfo.DataContext = customer;
            tbCity.Text = $"{customer.zip} {customer.address}";
            dgCurrent.ItemsSource = customer.book_customer.Where(x=>x.return_date == null);
            dgHistory.ItemsSource = customer.book_customer.Where(x => x.return_date != null);
        }

        private void btEditInfo(object sender, RoutedEventArgs e)
        {
            new ChangeCustomerWindow(model, customer).ShowDialog();
        }

        private void tbBookSearch(object sender, TextChangedEventArgs e)
        {
            tbTitle.Text = "";
            var book = model.GetBook(bookSearch.Text);
            if (book == null)
                return;
            tbTitle.Text = $"Title: {book.title}";
        }
    }
}
