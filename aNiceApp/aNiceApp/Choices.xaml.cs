using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aNiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Choices : ContentPage
    {

        private readonly string SecureStorageKey1 = "MySecureStorageKey2";
        public Choices()
        {
            InitializeComponent();
        }

        async private void GameDetailPageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new GameDetailPage());

        }


        async private void ProfilePageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Profile());

        }


        async private void ChoicesPageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Choices());

        }

       
        async private void pickedThis1(object sender, EventArgs e)
        {

            await DisplayAlert("Done", "You Have Added That Game AAA To Your Fave", "Ok");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Game AAA");

        }


        async private void pickedThis2(object sender, EventArgs e)
        {

            await DisplayAlert("Done", "You Have Added That Game BBB To Your Fave", "Ok");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Game BBB");

        }


        async private void pickedThis3(object sender, EventArgs e)
        {

            await DisplayAlert("Done", "You Have Added That Game CCC To Your Fave", "Ok");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Game CCC");

        }


        async private void pickedThis4(object sender, EventArgs e)
        {

            await DisplayAlert("Done", "You Have Added That Game DDD To Your Fave", "Ok");
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey1, "Game DDD");

        }




    }
}