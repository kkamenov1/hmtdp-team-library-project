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
    /// Interaction logic for SimpleAuthorPage.xaml
    /// </summary>
    public partial class SimpleAuthorPage : Page
    {
        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;
        public static string currentAuthorName;

        public SimpleAuthorPage()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stores = (this.DataContext as AuthorSampleStoreVM);
            var selected = e.AddedItems;
            if (stores.Authors.Count() > 0)
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

        private void OpenAuthorClick(object sender, RoutedEventArgs e)
        {
            AuthorSampleVM operatedNode = (AuthorSampleVM)mainOperateList.SelectedItem;
            currentAuthorName = operatedNode.Name;
            if (operatedNode != null)
            {
                LibraryListPageAuthor basicAuthorPage = new LibraryListPageAuthor();
                LibraryListPageAuthor.workNodeTransfer = operatedNode;
                NavigationService.Navigate(basicAuthorPage);

                //this.NavigationService.Navigate(new Uri("MainPages/ReadArticlePage.xaml", UriKind.Relative));
            }
        }
    }
}
