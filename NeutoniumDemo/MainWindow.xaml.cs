using System.Windows;
using System;
using NeutoniumDemo.Application;
using NeutoniumDemo.App_Start;
using NeutoniumDemo.ViewModel;

namespace NeutoniumDemo
{
    public partial class MainWindow : Window
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
