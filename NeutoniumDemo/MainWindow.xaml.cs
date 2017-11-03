using System;
using NeutroniumDemo.Application;
using NeutroniumDemo.ViewModel;

namespace NeutroniumDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            RoutingConfiguration.Register(HtmlView.NavigationBuilder);         
            var app = new ApplicationViewModel<ApplicationMenuViewModel>(HtmlView, DependencyInjectionConfiguration.Register);
            DataContext = app;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            HtmlView.Dispose();
            Menu.Dispose();
        }
    }
}
