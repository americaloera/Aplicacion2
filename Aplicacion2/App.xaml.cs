using Aplicacion2.Services;
using Aplicacion2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
