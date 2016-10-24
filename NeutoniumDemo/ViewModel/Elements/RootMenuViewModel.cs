using Micro.MVVM.Relay;
using NeutoniumDemo.Application.Navigation;
using System.Collections.Generic;
using System.Windows.Input;

namespace NeutoniumDemo.ViewModel.Elements
{
    public class RootMenuViewModel
    {
        public List<FinalMenuView> Children { get; set; } = new List<FinalMenuView>();
        public List<MenuViewModel> SubMenu { get; set; } = new List<MenuViewModel>();

        public ICommand Navigate { get; private set; }

        private readonly INavigator _Navigator;

        public RootMenuViewModel(INavigator navigator)
        {
            _Navigator = navigator;
            Navigate = new RelayCommand<FinalMenuView>(
                menu => 
                {
                    _Navigator.Navigate(menu.TargetedViewModel);
                });
        }
    }
}
