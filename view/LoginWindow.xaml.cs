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
using DigitalSkills.model;

namespace DigitalSkills.view
{
    public partial class LoginWindow : Window
    {
        LoginModel model;
        public LoginWindow()
        {
            InitializeComponent();
            model = new LoginModel();
        }

        private void btAuthorization_Click(object sender, RoutedEventArgs e)
        {
            if (!model.Authorization(tbLogin.Text, pbPassword.Password))
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            DialogResult = true;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
