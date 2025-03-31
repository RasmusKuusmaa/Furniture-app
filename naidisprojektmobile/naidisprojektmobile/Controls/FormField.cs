using Xamarin.Forms;

namespace naidisprojektmobile.Controls
{
    public class FormField : StackLayout
    {

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create("Placeholder", typeof(string), typeof(FormField), string.Empty);


        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create("FontSize", typeof(double), typeof(FormField), 18.0);

        public static readonly BindableProperty IsPasswordProperty =
            BindableProperty.Create("IsPassword", typeof(bool), typeof(FormField), false);


        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        // IsPassword property
        public bool IsPassword
        {
            get => (bool)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }

        public FormField()
        {
            var frame = new Frame
            {
                BorderColor = Color.FromHex("#8D9BB5"),
                HasShadow = false,
                CornerRadius = 10,
                Padding = new Thickness(10)
            };

            var entry = new Entry
            {
                FontSize = FontSize
            };

            entry.SetBinding(Entry.PlaceholderProperty, new Binding("Placeholder", source: this));
            entry.SetBinding(Entry.IsPasswordProperty, new Binding("IsPassword", source: this));

            frame.Content = entry;

            this.Children.Add(frame);
        }
    }
}
