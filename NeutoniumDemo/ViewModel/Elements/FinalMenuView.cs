namespace NeutroniumDemo.ViewModel.Elements
{
    public class FinalMenuView<T>: FinalMenuView
    {
        public FinalMenuView()
        {
            TargetedViewModel = typeof(T);
        }
    }
}