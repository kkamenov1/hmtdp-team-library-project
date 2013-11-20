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
            InitializeFields();
        }

        private void InitializeFields()
        {
            DateTime todayDate = DateTime.Now;
            yearbox.Text = todayDate.Year.ToString();
            monthbox.Text = todayDate.Month.ToString();
            daybox.Text = todayDate.Day.ToString();
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            InitializeFields();
        }

        private void OnArticlesClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/LibraryListPage.xaml", UriKind.Relative));
        }
    }
}
