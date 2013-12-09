using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class DataPersister
    {
        public static IEnumerable<ArticleViewModel> GetArticle(string articleStoreDocumentPath)
        {
            var articleDocumentRoot = XDocument.Load(articleStoreDocumentPath).Root;

            var articleVMs =
                           from articleElement in articleDocumentRoot.Elements("article")
                           select new ArticleViewModel()
                           {
                               Author = articleElement.Element("author").Value,
                               Title = articleElement.Element("title").Value,
                               Year = int.Parse(articleElement.Element("year").Value),
                               Month = int.Parse(articleElement.Element("month").Value),
                               Day = int.Parse(articleElement.Element("day").Value),
                               ImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), articleElement.Element("image").Value),
                               Category = articleElement.Element("category").Value,
                               Description = articleElement.Element("description").Value,
                               Contents = articleElement.Element("contents").Value,
                           };
            return articleVMs;
        }

        public static IEnumerable<ArticleViewModel> GetArticleAuthor(string articleStoreDocumentPath, string givenAuthor)
        {
            var articleDocumentRoot = XDocument.Load(articleStoreDocumentPath).Root;

            var articleVMs =
                           from articleElement in articleDocumentRoot.Elements("article")
                           where articleElement.Element("author").Value == givenAuthor
                           select new ArticleViewModel()
                           {
                               Author = articleElement.Element("author").Value,
                               Title = articleElement.Element("title").Value,
                               Year = int.Parse(articleElement.Element("year").Value),
                               Month = int.Parse(articleElement.Element("month").Value),
                               Day = int.Parse(articleElement.Element("day").Value),
                               ImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), articleElement.Element("image").Value),
                               Category = articleElement.Element("category").Value,
                               Description = articleElement.Element("description").Value,
                               Contents = articleElement.Element("contents").Value,
                           };
            return articleVMs;
        }

        public static IEnumerable<ArticleViewModel> GetArticleBook(string articleStoreDocumentPath, string givenBook)
        {
            var articleDocumentRoot = XDocument.Load(articleStoreDocumentPath).Root;

            var articleVMs =
                           from articleElement in articleDocumentRoot.Elements("article")
                           where articleElement.Element("category").Value == givenBook
                           select new ArticleViewModel()
                           {
                               Author = articleElement.Element("author").Value,
                               Title = articleElement.Element("title").Value,
                               Year = int.Parse(articleElement.Element("year").Value),
                               Month = int.Parse(articleElement.Element("month").Value),
                               Day = int.Parse(articleElement.Element("day").Value),
                               ImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), articleElement.Element("image").Value),
                               Category = articleElement.Element("category").Value,
                               Description = articleElement.Element("description").Value,
                               Contents = articleElement.Element("contents").Value,
                           };
            return articleVMs;
        }

        public static IEnumerable<AuthorSampleVM> GetAuthors(string articleStoreDocumentPath)
        {
            var articleDocumentRoot = XDocument.Load(articleStoreDocumentPath).Root;

            var authorsVMs =
                           from articleElement in articleDocumentRoot.Elements("article")
                           select new AuthorSampleVM()
                           {
                               Name = articleElement.Element("author").Value,
                               AImagePath = "..\\..\\Images\\Author.png",
                           };
            return authorsVMs; // .Distinct
        }

        public static IEnumerable<BookSampleVM> GetBooks(string articleStoreDocumentPath)
        {
            var articleDocumentRoot = XDocument.Load(articleStoreDocumentPath).Root;

            var booksVMs =
                           from articleElement in articleDocumentRoot.Elements("article")
                           select new BookSampleVM()
                           {
                               Name = articleElement.Element("category").Value,
                           };
            return booksVMs; // .Distinct
        }

        internal static void AddArticle(string documenPath, ArticleViewModel article)
        {
            DateTime todayDate = DateTime.Now;
            //if (article.Year == 0) { article.Year = todayDate.Year; }
            //if (article.Month == 0) { article.Month = todayDate.Month; }
            //if (article.Day == 0) { article.Day = todayDate.Day; }

            if (article.ImagePath == null || article.ImagePath == String.Empty)
            {
                article.ImagePath = "..\\..\\Images\\TemplatePic.png";
            }

            var root = XDocument.Load(documenPath).Root;
            root.Add(new XElement("article",
                new XElement("author", article.Author),
                new XElement("title", article.Title),
                new XElement("year", article.Year),
                new XElement("month", article.Month),
                new XElement("day", article.Day),
                new XElement("image", article.ImagePath),
                new XElement("category", article.Category),
                new XElement("description", article.Description),
                new XElement("contents", article.Contents)
                ));
            root.Document.Save(documenPath);
        }

        internal static void RemoveStore(string documenPath, ArticleViewModel store)
        {
            var root = XDocument.Load(documenPath).Root;
            foreach (var storeChild in root.Elements("article"))
            {
                if (storeChild.Element("author").Value == store.Author && storeChild.Element("title").Value == store.Title &&
                    storeChild.Element("category").Value == store.Category && storeChild.Element("contents").Value == store.Contents)
                {
                    storeChild.Remove();
                    root.Document.Save(documenPath);
                    break;
                }
            }
        }     
    }
}
