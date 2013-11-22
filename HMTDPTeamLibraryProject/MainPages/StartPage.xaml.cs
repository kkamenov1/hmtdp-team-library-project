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
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void OpenNewArticleClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/AddNewArticlePage.xaml", UriKind.Relative));
        }

        private void OpenAllArticlesClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/LibraryListPage.xaml", UriKind.Relative));
        }

        private void OnSearchClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/SearchPage.xaml", UriKind.Relative));
        }
    }
}
