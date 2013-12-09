using HMTDPTeamLibraryProject.Search_and_Sort;
using HMTDPTeamLibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void SearchArticle(object sender, RoutedEventArgs e)
        {
            string xtext = searchtb.Text;

            if (xtext != null && xtext.Trim() != String.Empty)
            {
                int index = combotb.SelectedIndex;

                ArticleProp currentType = (ArticleProp)index;

                Search currentSearch = new Search();

                List<ArticleViewModel> tempList = currentSearch.SearchByWordAndProp(xtext, currentType);
                mainOperateList.Items.Clear();

                foreach (var art in tempList)
                {
                    mainOperateList.Items.Add(art);
                }       
            }
            else
            {
                //msg box
            }
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
    }
}
