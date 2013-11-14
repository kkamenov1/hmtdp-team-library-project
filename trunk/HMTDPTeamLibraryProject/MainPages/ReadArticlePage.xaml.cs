using HMTDPTeamLibraryProject.ViewModels;
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
    /// Interaction logic for ReadArticlePage.xaml
    /// </summary>
    public partial class ReadArticlePage : Page
    {
        public static ArticleViewModel workNodeTransfer;
        public string filePath = MainWindow.mainFilePath;

        public ReadArticlePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            titleArticle.Text = workNodeTransfer.Title;
            authorTextBox.Text = workNodeTransfer.Author;

            DateTime tempDate = new DateTime(workNodeTransfer.Year, workNodeTransfer.Month, workNodeTransfer.Day);
            dateTextBox.Text = String.Format("{0:dd.MM.yyyy}", tempDate); 

            categoryTextBox.Text = workNodeTransfer.Category;
            descriptionTextBox.Text = workNodeTransfer.Description;
            contentsTextBox.Text = workNodeTransfer.Contents;
        }

        private void AddNewArticleClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/AddNewArticlePage.xaml", UriKind.Relative));
        }

        private void ViewArticlesClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPages/LibraryListPage.xaml", UriKind.Relative));
        }

        private void EditArticlesClick(object sender, RoutedEventArgs e)
        {
            if (categoryTextBox.IsReadOnly == true)
            {
                categoryTextBox.IsReadOnly = false;
                descriptionTextBox.IsReadOnly = false;
                contentsTextBox.IsReadOnly = false;
                editButton.Content = "Save Article";
                editButton.ToolTip = "Save Edited Article";
            }
            else
            {

                ArticleViewModel editedArticle = new ArticleViewModel();
                editedArticle.Title = workNodeTransfer.Title;
                editedArticle.Author = workNodeTransfer.Author;
                editedArticle.Year = workNodeTransfer.Year;
                editedArticle.Month = workNodeTransfer.Month;
                editedArticle.Day = workNodeTransfer.Day;
                editedArticle.Category = categoryTextBox.Text;
                editedArticle.Description = descriptionTextBox.Text;
                editedArticle.Contents = contentsTextBox.Text;

                categoryTextBox.IsReadOnly = true;
                descriptionTextBox.IsReadOnly = true;
                contentsTextBox.IsReadOnly = true;
                editButton.Content = "Edit Article";
                editButton.ToolTip = "Edit Current Articles";

                DataPersister tempStore = new DataPersister();
                DataPersister.RemoveStore(filePath, workNodeTransfer);
                DataPersister.AddArticle(filePath, editedArticle);
            }
        }
    }
}