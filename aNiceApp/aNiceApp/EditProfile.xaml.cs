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
    public partial class EditProfile : ContentPage
    {

        private readonly string SecureStorageKey = "MySecureStorageKey";
        public EditProfile()
        {
            InitializeComponent();
        }


        async private void HomePageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }



        async private void ProfilePageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Profile());

        }


        async void SaveMe(object sender, EventArgs e)
        {
            await Xamarin.Essentials.SecureStorage.SetAsync(SecureStorageKey, you.Text);
            await Navigation.PushAsync(new Profile());

        }
    }
}