using System.Collections.Generic;
using Micro.MVVM;

namespace NeutroniumDemo.ViewModel.Elements
{
    public class MenuViewModel : ViewModelBase
    {
        public string Name { get; set; }

        public string Descriptor { get; set; }

        private bool _Expanded = false;
        public bool Expanded
        {
            get { return _Expanded; }
            set { Set(ref _Expanded, value); }
        }

        public List<FinalMenuView> Children { get; set; } = new List<FinalMenuView>();

        public List<MenuViewModel> SubMenu { get; set; } = new List<MenuViewModel>();
    }
}
