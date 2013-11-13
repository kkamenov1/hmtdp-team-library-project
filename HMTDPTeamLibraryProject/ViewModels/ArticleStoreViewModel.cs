using HMTDPTeamLibraryProject.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class ArticleStoreViewModel : ViewModelBase
    {
        private ObservableCollection<ArticleViewModel> articlesViewModels;

        private ICommand addNewCommand;

        private string successMessage;

        private string errorMessage;
        private ArticleViewModel newArticleViewModel;

        public string ArticleStoreDocumentPath { get; set; }

        public ArticleStoreViewModel()
        {
            this.ArticleStoreDocumentPath = "..\\..\\articles.xml";
            this.newArticleViewModel = new ArticleViewModel();
        }

        public ICommand AddNew
        {
            get
            {
                if (this.addNewCommand == null)
                {
                    this.addNewCommand = new RelayCommand(this.HandleAddNewCommand);
                }
                return this.addNewCommand;
            }
        }

        public ArticleViewModel NewArticle
        {
            get
            {
                return this.newArticleViewModel;
            }
            set
            {
                this.newArticleViewModel = value;
                this.OnPropertyChanged("NewArticle");
            }
        }

        public string SuccessMessage
        {
            get
            {
                return this.successMessage;
            }
            set
            {
                this.successMessage = value;
                this.OnPropertyChanged("SuccessMessage");
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
            set
            {
                this.errorMessage = value;
                this.OnPropertyChanged("ErrorMessage");
            }
        }

        public IEnumerable<ArticleViewModel> Articles
        {
            get
            {
                if (this.articlesViewModels == null)
                {
                    this.Articles = DataPersister.GetArticle(ArticleStoreDocumentPath);
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

        private void HandleAddNewCommand(object obj)
        {
            try
            {
                DataPersister.AddArticle(this.ArticleStoreDocumentPath, this.NewArticle);
                this.Articles = DataPersister.GetArticle(this.ArticleStoreDocumentPath);
                this.SetSuccessMessage(string.Format("{0} {1} successfully added!", this.NewArticle.Author, this.NewArticle.Title));
                this.NewArticle = new ArticleViewModel();
            }
            catch (Exception ex)
            {
                this.SetErrorMessage(string.Format("Adding {0} {1} failed with exception {2} ", this.NewArticle.Author, this.NewArticle.Title, ex.Message));
            }
        }

        private void SetSuccessMessage(string text)
        {
            this.SuccessMessage = text;
            var timer = new DispatcherTimer();
            timer.Tick += (snd, args) =>
            {
                this.SuccessMessage = "";
                timer.Stop();
            };
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Start();
        }

        private void SetErrorMessage(string text)
        {
            this.SuccessMessage = text;
            var timer = new DispatcherTimer();
            timer.Tick += (snd, args) =>
            {
                this.SuccessMessage = "";
                timer.Stop();
            };
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Start();
        }
    }
}
