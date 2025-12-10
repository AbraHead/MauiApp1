using Microsoft.Extensions.DependencyInjection;
using MauiApp1.Pages;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddStudentsPage), typeof(AddStudentsPage));
            Routing.RegisterRoute(nameof(StudentsPage), typeof(StudentsPage));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}