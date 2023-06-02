using PDC03_MODULE07.Services;
using PDC03_MODULE07.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE07
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Views.ShowEmployeePage());
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
