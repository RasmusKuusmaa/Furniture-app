using System;
using System.Reflection;
using Xamarin.Forms;

namespace naidisprojektmobile.Views
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();

            SplashImage.Source = ImageSource.FromResource("naidisprojektmobile.Images.splash.png",
                typeof(SplashPage).GetTypeInfo().Assembly);

        }
        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
        private async void OnSignInClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignInPage());
        }
    }
}
