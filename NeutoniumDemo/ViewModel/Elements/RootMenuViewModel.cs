using NeutoniumDemo.Application.Navigation;
using System.Collections.Generic;
using Micro.MVVM;

namespace NeutoniumDemo.ViewModel.Elements
{
    public class RootMenuViewModel : ViewModelBase
    {
        private readonly INavigator _Navigator;

        public List<FinalMenuView> Children { get; set; } = new List<FinalMenuView>();
        public List<MenuViewModel> SubMenu { get; set; } = new List<MenuViewModel>();

        private FinalMenuView _CurrentMenu;
        public FinalMenuView CurrentMenuView 
        {
            get { return _CurrentMenu;}
            set {
                if (Set(ref _CurrentMenu, value) && (value!=null)) 
                {
                    //Temporary Neutronium will call
                    //all property setter on UI thread
                    System.Windows.Application.Current.Dispatcher.Invoke(() => 
                    {
                        _Navigator.Navigate(_CurrentMenu.TargetedViewModel);
                    });                
                }
            }
        }

        public RootMenuViewModel(INavigator navigator)
        {
            _Navigator = navigator;
        }
    }
}
