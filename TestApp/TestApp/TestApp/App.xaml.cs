using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Interfaces;
using TestApp.ViewModels;
using Xamarin.Forms;

namespace TestApp
{
    public partial class App : Application
    {
        public static ILocatorService LocatorService { get; set; }
        public App()
        {
            InitializeComponent();

            var main = LocatorService.Get<MainViewModel>();

            var page = new MainPage()
            {
                BindingContext = main
            };
            MainPage = page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
