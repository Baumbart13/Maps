using Maps.Services;
using Maps.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maps
{
    public partial class App : Application
    {
        InternetService _IS = new InternetService();
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            if(_IS.HasConnection() == true)
            {
                MainPage = new AppShell();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
