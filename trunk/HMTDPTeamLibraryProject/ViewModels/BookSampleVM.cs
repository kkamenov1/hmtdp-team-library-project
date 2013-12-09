using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class BookSampleVM
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public BookSampleVM()
        {
        }
    }
}
