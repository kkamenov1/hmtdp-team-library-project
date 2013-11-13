using System.Collections.Generic;
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
                               ImagePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), articleElement.Element("image").Value),
                           };
            return articleVMs;
        }

        internal static void AddArticle(string documenPath, ArticleViewModel article)
        {
            var root = XDocument.Load(documenPath).Root;
            root.Add(new XElement("article",
                new XElement("author", article.Author),
                new XElement("title", article.Title),
                new XElement("year", article.Year),
                new XElement("image", article.ImagePath)));
            root.Document.Save(documenPath);
        }
    }
}
