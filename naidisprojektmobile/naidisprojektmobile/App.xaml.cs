using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using naidisprojektmobile.Views;
namespace naidisprojektmobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.FromHex("#4F63AC")
            };
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
