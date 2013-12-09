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
    /// Interaction logic for LibraryListPageBook.xaml
    /// </summary>
    public partial class LibraryListPageBook : Page
    {
        public static BookSampleVM workNodeTransfer;
        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        public LibraryListPageBook()
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
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked != _lastHeaderClicked)
                {
                    direction = ListSortDirection.Ascending;
                }

                else
                {
                    if (_lastDirection == ListSortDirection.Ascending)
                    {
                        direction = ListSortDirection.Descending;
                    }
                    else
                    {
                        direction = ListSortDirection.Ascending;
                    }
                }
                string header = headerClicked.Column.Header as string;
                Sort(header, direction);
                _lastHeaderClicked = headerClicked;
                _lastDirection = direction;
            }
        }

        // Sort code
        private void Sort(string sortBy, ListSortDirection direction)
        {
            if (mainOperateList != null)
            {
                mainOperateList.Items.SortDescriptions.Clear();

                SortDescription sd = new SortDescription(sortBy, direction);

                mainOperateList.Items.SortDescriptions.Add(sd);

                mainOperateList.Items.Refresh();
            }
        }

        #endregion Sorting columns

        private void SearchArticleClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/SearchPage.xaml", UriKind.Relative));
        }

        private void OpenAllAuthorsclick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/SimpleAuthorPage.xaml", UriKind.Relative));
        }

        private void OpenAllBooks(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/SampleBookPage.xaml", UriKind.Relative));
        }
    }
}
