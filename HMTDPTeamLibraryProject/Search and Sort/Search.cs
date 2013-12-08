using HMTDPTeamLibraryProject.Search_and_Sort;
using HMTDPTeamLibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace HMTDPTeamLibraryProject.Search_and_Sort
{
    public class Search : ISearchable
    {
        private IEnumerable<ArticleViewModel> articles = DataPersister.GetArticle(MainWindow.mainFilePath);

        public IEnumerable<ArticleViewModel> SearchByWordAndProp(string searchedWord, string property)
        {
            IList<ArticleViewModel> result = new IList<ArticleViewModel>();
            foreach (var art in articles)
            {
                if (property == ArticleProp.Author && art.Author.Contains(searchedWord))
                {
                    result.Add(art);
                }
                else if (property == ArticleProp.Category && art.Category.Contains(searchedWord))
                {
                    result.Add(art);
                }
                else if (property == ArticleProp.Contents && art.Contents.Contains(searchedWord))
                {
                    result.Add(art);
                }
                else if (property == ArticleProp.Title && art.Title.Contains(searchedWord))
                {
                    result.Add(art);
                }
                else if (property == ArticleProp.Year)
                {
                    string[] date = searchedWord.Split('.');
                    if (art.Year == (Convert.ToInt32(date[2])) && art.Month == (Convert.ToInt32(date[1]))
                        && art.Day == (Convert.ToInt32(date[0])))
                    {
                        result.Add(art);
                    }
                }
            }

            return (IEnumerable<ArticleViewModel>)result;
        }
    }
}
