using NeutoniumDemo.Application.Navigation;
using System.Collections.Generic;
using Micro.MVVM;
using System;

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
            get { return _CurrentMenu; }
            set
            {
                if (Set(ref _CurrentMenu, value) && (value != null))
                {
                    Nagigate(value.TargetedViewModel);
                }
            }
        }

        private async void Nagigate(Type type)
        {
            _CurrentMenu.IsLoading = true;
            await _Navigator.Navigate(type);
            _CurrentMenu.IsLoading = false;
        }

        public RootMenuViewModel(INavigator navigator)
        {
            _Navigator = navigator;
        }
    }
}
