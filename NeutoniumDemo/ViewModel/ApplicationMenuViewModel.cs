using NeutoniumDemo.Application.Navigation;
using NeutoniumDemo.ViewModel.Elements;
using System.Collections.Generic;

namespace NeutoniumDemo.ViewModel
{
    public class ApplicationMenuViewModel : RootMenuViewModel
    {
        public ApplicationMenuViewModel(INavigator navigator) : base(navigator)
        {
            SubMenu = new List<MenuViewModel>
            {
                new MenuViewModel
                {
                    Name= "Pages",
                    Descriptor= "Pages",
                    Children = new List<FinalMenuView>
                    {
                        new FinalMenuView<Page1ViewModel>
                        {
                            Name= "Page1"
                        },
                        new FinalMenuView<Page2ViewModel>
                        {
                            Name= "Page2"
                        },
                        new FinalMenuView<Page3ViewModel>
                        {
                            Name= "Page3"
                        }
                    }
                }
            };

            Children = new List<FinalMenuView>
            {
                new FinalMenuView<AboutViewModel>
                {
                    Name= "About",
                    Descriptor= "About"
                }
            };
        }
    }
}
