using NeutoniumDemo.Application.Navigation;
using System.Collections.Generic;
using Micro.MVVM;
using System;
using System.Threading.Tasks;

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
                    Func<Task> dispatch = async () =>
                    {
                        _CurrentMenu.IsLoading = true;
                        await _Navigator.Navigate(_CurrentMenu.TargetedViewModel);
                        _CurrentMenu.IsLoading = false;
                    };


                    Delegate del = dispatch;
                    //Temporary Neutronium will call
                    //all property setter on UI thread
                    System.Windows.Application.Current.Dispatcher.BeginInvoke(del);   
                }
            }
        }

        public RootMenuViewModel(INavigator navigator)
        {
            _Navigator = navigator;
        }
    }
}
