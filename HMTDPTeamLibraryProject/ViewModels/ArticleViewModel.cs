using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class ArticleViewModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        private int year;
        public int Year 
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        private int month;
        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                if (value > 12 || value < 0)
                {
                    MessageBox.Show("You should insert a month value between 1 and 12!");
                }
                this.month = value;
                
            }
        }

        private int day;
        public int Day
        {
            get
            {
                return this.day;
            }
            set
            {
                if (value > 31 || value < 0)
                {
                    MessageBox.Show("You should insert a day value between 1 and 31!");
                }
                this.day = value;
            }
        }

        private string imagePath;
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                this.imagePath = value;
            }
        }

        private string subcontent;
        public string SubContent
        {
            get
            {
                return this.subcontent;
            }
            set
            {
                this.subcontent = value;
            }
        }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Contents { get; set; }

        public ArticleViewModel()
        {
            //this.ImagePath = imagePath;
        }
    }
}
