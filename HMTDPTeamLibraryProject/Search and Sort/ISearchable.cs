using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMTDPTeamLibraryProject.ViewModels;

namespace HMTDPTeamLibraryProject.Search_and_Sort
{
    public interface ISearchable
    {
        List<ArticleViewModel> SearchByWordAndProp(string searchedWord, ArticleProp property);
    }
}
