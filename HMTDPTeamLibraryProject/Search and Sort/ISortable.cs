using HMTDPTeamLibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.Search_and_Sort
{
    public interface ISortable
    {
        IEnumerable<ArticleViewModel> SortByAttribute(string attributName);
    }
}
