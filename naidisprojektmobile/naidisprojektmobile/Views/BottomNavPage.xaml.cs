using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace naidisprojektmobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomNavPage : Xamarin.Forms.TabbedPage
    {
        public BottomNavPage ()
        {
            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetToolbarPlacement(this,
                  Xamarin.Forms.PlatformConfiguration.AndroidSpecific.ToolbarPlacement.Bottom);



            Children.Add(new NavigationPage(new ProductsPage())
            {
                IconImageSource = ImageSource.FromResource("naidisprojektmobile.Images.Vector.png",
                typeof(BottomNavPage).GetTypeInfo().Assembly),

            });

            Children.Add(new NavigationPage(new FavoritesPage())
            {
                IconImageSource = ImageSource.FromResource("naidisprojektmobile.Images.marker1.png",
                typeof(BottomNavPage).GetTypeInfo().Assembly),
             

            });

            Children.Add(new NavigationPage(new ProfilePage())
            {
                IconImageSource = ImageSource.FromResource("naidisprojektmobile.Images.bi_person.png",
                typeof(BottomNavPage).GetTypeInfo().Assembly),
             
            });
        }

    }
}