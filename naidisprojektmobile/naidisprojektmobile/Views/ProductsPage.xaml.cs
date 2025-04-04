using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace naidisprojektmobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();

            SearchIcon.Source = ImageSource.FromResource("naidisprojektmobile.Images.search.png",
                typeof(ProductsPage).GetTypeInfo().Assembly);

         
        }
    }
}