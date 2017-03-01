using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebsiteClickerBot.Utility;

namespace WebsiteClickerBot.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private int _idCounter = 0;
        public ObservableCollection<WebsiteActionSettingViewModel> ActionSettingViewModels { get; set; } 
        public ICommand AddActionCommand { get; set; }

        public MainViewModel()
        {
            ActionSettingViewModels = new ObservableCollection<WebsiteActionSettingViewModel>();
            AddActionCommand = new RelayCommand(() =>
            {
                ActionSettingViewModels.Add(new WebsiteActionSettingViewModel(_idCounter++));
                //OnPropertyChanged("ActionSettingViewModels");
            });
        }
    }
}
