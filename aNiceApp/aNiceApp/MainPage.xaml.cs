using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aNiceApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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

        async private void MapPageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MapPage());

        }


    }
}
