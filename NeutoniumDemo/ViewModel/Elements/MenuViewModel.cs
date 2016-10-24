using System.Collections.Generic;

namespace NeutoniumDemo.ViewModel.Elements
{
    public class MenuViewModel
    {
        public string Name { get; set; }

        public string Descriptor { get; set; }

        public bool Expanded { get; set; } = false;

        public List<FinalMenuView> Children { get; set; } = new List<FinalMenuView>();

        public List<MenuViewModel> SubMenu { get; set; } = new List<MenuViewModel>();
    }
}
