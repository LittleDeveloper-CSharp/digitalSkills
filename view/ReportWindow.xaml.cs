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

namespace varchar_128_.view
{
    /// <summary>
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private ReportModel model;
        public ReportWindow()
        {
            InitializeComponent();
            model = new ReportModel();
            dgReport.ItemsSource = model.GetBooks();
        }

        private void idBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgReportBook.ItemsSource = null;
            titleBook.Text = subtitle.Text = "";
            var item = model.GetBook(idBook.Text);
            if (item == null)
                return;
            dgReportBook.ItemsSource = item.book_customer.Where(x=>x.return_date != null);
            titleBook.Text = item.title;
            subtitle.Text = item.subtitle;
        }
    }
}
