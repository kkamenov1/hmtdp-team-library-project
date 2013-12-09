using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMTDPTeamLibraryProject.ViewModels
{
    public class AuthorSampleStoreVM : ViewModelBase
    {
        private ObservableCollection<AuthorSampleVM> authorStoreVM;


        public virtual IEnumerable<AuthorSampleVM> Authors
        {
            get
            {
                if (this.authorStoreVM == null)
                {
                    this.Authors = DataPersister.GetAuthors(MainWindow.mainFilePath);
                }
                return authorStoreVM;
            }
            set
            {
                if (this.authorStoreVM == null)
                {
                    this.authorStoreVM = new ObservableCollection<AuthorSampleVM>();
                }
                this.authorStoreVM.Clear();
                foreach (var item in value)
                {
                    this.authorStoreVM.Add(item);
                }
            }
        }

        private AuthorSampleVM selectedStore;
        public AuthorSampleVM SelectedStore
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
            this.SelectedStore = store as AuthorSampleVM;
        }

    }
}
