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
    }
}
