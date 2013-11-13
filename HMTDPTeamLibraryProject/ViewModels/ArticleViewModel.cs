using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class ArticleViewModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        private string imagePath;
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                if (imagePath == null)
                {
                    imagePath = "..\\..\\Images\\NinjaPic.png";
                }
            }
        }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Contents { get; set; }

        public ArticleViewModel()
        {
            this.ImagePath = imagePath;
        }
    }
}
