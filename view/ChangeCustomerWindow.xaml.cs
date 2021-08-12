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
    /// Логика взаимодействия для ChangeCustomerWindow.xaml
    /// </summary>
    public partial class ChangeCustomerWindow : Window
    {
        private CustomerModel model;
        public ChangeCustomerWindow(object model, customer customer = null)
        {
            InitializeComponent();
            if (customer == null)
                customer = new customer();
            DataContext = customer;
            this.model = model as CustomerModel;
        }

        private void btAdd(object sender, RoutedEventArgs e)
        {
            if (model.AddCustomer(DataContext as customer))
                Close();         
            else
                MessageBox.Show("Ошибка создания, проверте введенные поля еще раз");
        }


        private void btClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}