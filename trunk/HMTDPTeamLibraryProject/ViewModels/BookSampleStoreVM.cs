using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class BookSampleStoreVM : ViewModelBase
    {
        private ObservableCollection<BookSampleVM> bookStoreVM;


        public virtual IEnumerable<BookSampleVM> Books
        {
            get
            {
                if (this.bookStoreVM == null)
                {
                    this.Books = DataPersister.GetBooks(MainWindow.mainFilePath);
                }
                return bookStoreVM;
            }
            set
            {
                if (this.bookStoreVM == null)
                {
                    this.bookStoreVM = new ObservableCollection<BookSampleVM>();
                }
                this.bookStoreVM.Clear();
                foreach (var item in value)
                {
                    this.bookStoreVM.Add(item);
                }
            }
        }

        private BookSampleVM selectedStore;
        public BookSampleVM SelectedStore
        {
            get
            {
                return this.selectedStore;
            }
            set
            {
                this.selectedStore = value;
                OnPropertyChanged("SelectedStore");
            }
        }

        public void ChangeSelection(object store)
        {
            this.SelectedStore = store as BookSampleVM;
        }

    }
}
