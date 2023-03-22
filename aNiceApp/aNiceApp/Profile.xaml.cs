using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aNiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class Profile : ContentPage
    {


        private readonly string SecureStorageKey = "MySecureStorageKey";
        private readonly string SecureStorageKey2 = "MySecureStorageKey2";
        public Profile()
        {
            InitializeComponent();
        }



        async private void HomePageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }

        async private void EditProfileOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EditProfile());

        }



        protected override async void OnAppearing()
        {

            base.OnAppearing();

            person.Text = await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey)
                ?? "Not Set Yet";


            fave.Text = await Xamarin.Essentials.SecureStorage.GetAsync(SecureStorageKey2)
               ?? "Go Pick A Game";
        }



        async void pickOne(object sender, EventArgs e)
        {

            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please Pick A Photo"

            });


            if (result == null)
            {

                var stream = await result.OpenReadAsync();

                iGotIt.Source = ImageSource.FromStream(() => stream);
            }



        }





        async void takeOne(object sender, EventArgs e)
        {

            var result = await MediaPicker.CapturePhotoAsync();


            if (result == null)
            {

                var stream = await result.OpenReadAsync();

                iGotIt.Source = ImageSource.FromStream(() => stream);
            }



        }







    }
}