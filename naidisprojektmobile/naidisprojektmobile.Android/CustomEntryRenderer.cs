using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using naidisprojektmobile.Droid; // Change this to your own project's namespace
using Android.Widget;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace naidisprojektmobile.Droid // Change this to your own project's namespace
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}
