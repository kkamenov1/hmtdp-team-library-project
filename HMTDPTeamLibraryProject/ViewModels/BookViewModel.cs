using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class BookViewModel : ArticleStoreViewModel
    {
        private ObservableCollection<ArticleViewModel> articlesViewModels;

        public override IEnumerable<ArticleViewModel> Articles
        {
            get
            {
                if (this.articlesViewModels == null)
                {
                    this.Articles = DataPersister.GetArticleBook(ArticleStoreDocumentPath, SampleBookPage.currentBookName);
                }
                return articlesViewModels;
            }
            set
            {
                if (this.articlesViewModels == null)
                {
                    this.articlesViewModels = new ObservableCollection<ArticleViewModel>();
                }
                this.articlesViewModels.Clear();
                foreach (var item in value)
                {
                    this.articlesViewModels.Add(item);
                }
            }
        }
    }
}
