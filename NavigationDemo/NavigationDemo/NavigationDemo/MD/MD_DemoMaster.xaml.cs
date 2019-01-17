using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo.MD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MD_DemoMaster : ContentPage
    {
        public ListView ListView;

        public MD_DemoMaster()
        {
            InitializeComponent();

            BindingContext = new MD_DemoMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MD_DemoMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MD_DemoMenuItem> MenuItems { get; set; }
            
            public MD_DemoMasterViewModel()
            {
                MenuItems = new ObservableCollection<MD_DemoMenuItem>(new[]
                {
                    new MD_DemoMenuItem { Id = 0, Title = "Page 1" },
                    new MD_DemoMenuItem { Id = 1, Title = "Page 2" },
                    new MD_DemoMenuItem { Id = 2, Title = "Page 3" },
                    new MD_DemoMenuItem { Id = 3, Title = "Page 4" },
                    new MD_DemoMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}