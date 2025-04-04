using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Title = "Products",
            
            });
            Children.Add(new ProductsPage());
            Children.Add(new ProductsPage());

        }

    }
}