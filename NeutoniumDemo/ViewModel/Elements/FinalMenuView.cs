using System;

namespace NeutoniumDemo.ViewModel.Elements
{
    public class FinalMenuView<T>: FinalMenuView
    {
        public FinalMenuView()
        {
            TargetedViewModel = typeof(T);
        }
    }
}