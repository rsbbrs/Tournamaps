using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmashBros_Tournament_Locator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var theme = Preferences.Get("OSAppTheme", Enum.GetName(typeof(OSAppTheme), OSAppTheme.Unspecified));
            App.Current.UserAppTheme = (OSAppTheme)Enum.Parse(typeof(OSAppTheme), theme);

            MainPage = new MainPage();
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
