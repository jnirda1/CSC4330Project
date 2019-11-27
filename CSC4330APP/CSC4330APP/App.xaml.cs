using CSC4330APP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSC4330APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
          // MainPage = new NavigationPage(new StudentProfile());
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
