using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aNiceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {

                BarBackgroundColor = Color.White,
                BarTextColor = Color.Blue,
            };
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
