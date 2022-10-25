using COIS_3850H_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace COIS_3850H_Project.MVVM.View_Model
{
    internal class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVm{ get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();

        }
    }
}
