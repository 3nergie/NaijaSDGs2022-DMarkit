using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DMarkitMobile.Services;
using DMarkitMobile.Views;

namespace DMarkitMobile
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new LandingPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

