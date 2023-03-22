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
	public partial class MapPage : ContentPage
	{
		public MapPage ()
		{
			InitializeComponent ();
		}

        async private void HomePageOpen(object sender, EventArgs e)
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