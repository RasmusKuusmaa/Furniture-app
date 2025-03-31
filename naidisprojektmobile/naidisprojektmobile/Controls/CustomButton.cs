using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace naidisprojektmobile.Controls
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            BackgroundColor = Color.FromHex("#4F63AC");
            TextColor = Color.White;
            FontSize = 16;
            FontAttributes = FontAttributes.Bold;
            CornerRadius = 5;
            HeightRequest = 75;
            WidthRequest = 250;
        }
    }
 }
