using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aNiceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameDetailPage : ContentPage
    {


        ObservableCollection<string> gamegameDetails = new ObservableCollection<string> {"Release Date: 2023", "Owner: Liam McCabe", "Price: €59", "Platform: Sony PlayStation" }; 
        GameStuff games = new GameStuff();
        public GameDetailPage()
        {
            InitializeComponent();
            games.gamegameDetails = gamegameDetails;
            BindingContext = games;
        }

        async private void HomePageOpen(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

        }


    }





    public class GameStuff
    {

        public ObservableCollection<string> gamegameDetails { get; set; }
    }


}