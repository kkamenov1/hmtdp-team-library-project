using HMTDPTeamLibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject
{
    //TODO: We can add an interface here.
    public class Sort
    {
        private IEnumerable<ArticleViewModel> articles = DataPersister.GetArticle(MainWindow.mainFilePath);

        public IEnumerable<ArticleViewModel> SortByAttribute(string attributName)
        {
            //foreach (var prop in typeof(ArticleViewModel).GetProperties())
            //{
                PropertyInfo givenPropertyName = typeof(ArticleViewModel).GetProperty(attributName);
                if (givenPropertyName == typeof(ArticleViewModel).GetProperty("Author"))
                {
                    articles = this.articles.OrderBy(x => x.Author);
                }
                else if (givenPropertyName == typeof(ArticleViewModel).GetProperty("Category"))
                {
                    articles = this.articles.OrderBy(x => x.Category);
                }
                else if (givenPropertyName == typeof(ArticleViewModel).GetProperty("Contents"))
                {
                    articles = this.articles.OrderBy(x => x.Contents);
                }
                else if (givenPropertyName == typeof(ArticleViewModel).GetProperty("Title"))
                {
                    articles = this.articles.OrderBy(x => x.Title);
                }
                else if (givenPropertyName == typeof(ArticleViewModel).GetProperty("Year"))
                {
                    articles = this.articles.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day);
                }
                else
                {
                    //TODO: Maybe we should throw an exception here?
                }
            //}

            JustArrange(articles);

            return articles;
        }

        private void JustArrange(IEnumerable<ArticleViewModel> articles)
        {
            foreach (var item in articles)
            {
                DataPersister.RemoveStore(MainWindow.mainFilePath, item);
                DataPersister.AddArticle(MainWindow.mainFilePath, item);
            }
        }
    }
}