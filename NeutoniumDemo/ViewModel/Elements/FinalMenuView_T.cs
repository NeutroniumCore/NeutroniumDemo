using Micro.MVVM;
using System;

namespace NeutoniumDemo.ViewModel.Elements
{
    public class FinalMenuView : ViewModelBase
    {
        internal Type TargetedViewModel { get; set; }

        public string Name { get; set; }

        public string Descriptor { get; set; }

        private bool _IsLoading = false;
        public bool IsLoading
        {
            get { return _IsLoading; }
            set { Set(ref _IsLoading, value); }
        }
    }
}