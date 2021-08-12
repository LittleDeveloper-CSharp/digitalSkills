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
    /// Логика взаимодействия для CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private CustomerModel model;
        public CustomerWindow()
        {
            InitializeComponent();
            model = new CustomerModel();
            dgCustomers.ItemsSource = model.GetCustomers();
        }

        private void btAdd(object sender, RoutedEventArgs e)
        {
            new ChangeCustomerWindow(model:model).ShowDialog();
            Search(null, null);
        }

        private void btEdit(object sender, RoutedEventArgs e)
        {
            var item = dgCustomers.SelectedItem as customer;
            if(item == null)
            {
                MessageBox.Show("Выберите объект");
                return;
            }
            new ChangeCustomerWindow(model, item).ShowDialog();
            Search(null, null);
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            dgCustomers.ItemsSource = model.GetCustomers(tbId.Text, tbName.Text);
        }
    }
}
