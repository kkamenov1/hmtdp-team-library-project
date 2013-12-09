using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class AuthorSampleVM
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

        private string imagePath;
        public string AImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                if (imagePath == null)
                {
                    imagePath = "..\\..\\Images\\Author.png";
                }
            }
        }

        public AuthorSampleVM()
        {
        }
    }
}
