using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMTDPTeamLibraryProject.ViewModels;

namespace HMTDPTeamLibraryProject.Search_and_Sort
{
    public class ISearchable
    {
        IEnumerable<ArticleViewModel> SearchByWordAndProp(string searchedWord, string property);
    }
}
