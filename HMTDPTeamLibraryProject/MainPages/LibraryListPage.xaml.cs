using HMTDPTeamLibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for LibraryListPage.xaml
    /// </summary>
    public partial class LibraryListPage : Page
    {
        public LibraryListPage()
        {
            InitializeComponent();
        }

        private void AddNewArticleClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/AddNewArticlePage.xaml", UriKind.Relative));
        }

        private void OpenArticleClick(object sender, RoutedEventArgs e)
        {
            ArticleViewModel operatedNode = (ArticleViewModel)mainOperateList.SelectedItem;
            if (operatedNode != null)
            {
                ReadArticlePage basicArticleReadPage = new ReadArticlePage();
                ReadArticlePage.workNodeTransfer = operatedNode;
                NavigationService.Navigate(basicArticleReadPage);

                //this.NavigationService.Navigate(new Uri("MainPages/ReadArticlePage.xaml", UriKind.Relative));
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stores = (this.DataContext as ArticleStoreViewModel);
            var selected = e.AddedItems;
            if (stores.Articles.Count() > 0)
            {
                stores.ChangeSelection(selected[0]);
            }
        }

        #region Sorting columns

        // Header click event
        void results_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;

            if (headerClicked != null)
            {
                string header = headerClicked.Column.Header as string;

                Sort newSort = new Sort();
                newSort.SortByAttribute(header);
                this.NavigationService.Refresh();
            }
        }

        #endregion Sorting columns
    }
}
