using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace naidisprojektmobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        
        private async void OnSignInClicked(object sender, EventArgs e)
        {
            var email = EmailEntry.Text?.Trim();
            var password = PasswordEntry.Text?.Trim();
            Console.WriteLine($"Entered email: {email}");
            Console.WriteLine($"Entered password: {password}");
            if (email == "aa" && password == "aa")
            {
                await Navigation.PushAsync(new ProductsPage());
            }
            else
            {
                await DisplayAlert("Login Failed", "Invalid email or password.", "OK");
            }
        }
    }
}