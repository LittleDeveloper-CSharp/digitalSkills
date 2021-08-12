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

namespace varchar_128_.view
{
    /// <summary>
    /// Логика взаимодействия для AuthorBioWindow.xaml
    /// </summary>
    public partial class AuthorBioWindow : Window
    {
        public AuthorBioWindow(ICollection<author> authors)
        {
            InitializeComponent();
            listAuthor.ItemsSource = authors;
            listAuthor.SelectedIndex = 0;
        }

        private void listAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var author = listAuthor.SelectedItem as author;
            tbBio.Text = author.bio;
            tbDate.Text = $"{author.birth_date:yyyy-MM-dd} - {author.deat_hdate:yyyy-MM-dd}";
            linkWiki.Foreground = string.IsNullOrEmpty(author.wikipedia) ? Brushes.Black : Brushes.Blue;
            linkWiki.IsEnabled = !string.IsNullOrEmpty(author.wikipedia);
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Тут переход на вики");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
