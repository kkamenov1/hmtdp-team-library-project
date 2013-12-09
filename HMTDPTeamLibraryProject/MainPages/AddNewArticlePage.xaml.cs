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

namespace HMTDPTeamLibraryProject
{
    /// <summary>
    /// Interaction logic for AddNewArticlePage.xaml
    /// </summary>
    public partial class AddNewArticlePage : Page
    {
        public AddNewArticlePage()
        {
            InitializeComponent();
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
        }

        private void OnArticlesClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/LibraryListPage.xaml", UriKind.Relative));
        }

        private void SelectedDateClick(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = helpDatePicker.SelectedDate.Value;
            yearbox.Text = selectedDate.Year.ToString();
            yearbox.Focus();

            monthbox.Text = selectedDate.Month.ToString();
            monthbox.Focus();

            daybox.Text = selectedDate.Day.ToString();
            daybox.Focus();
        }

    }
}
