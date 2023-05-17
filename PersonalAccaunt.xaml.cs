using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace Login
{
	public partial class PersonalAccaunt : ContentPage
    {
        public PersonalAccaunt()
        {
            InitializeComponent();
        }

        //async void Button_Clicked(object sender, EventArgs e)
        //{
        //    var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));

        //    resultLocation.Text += $"lat: {result.Latitude}, lng: {result.Longitude}{Environment.NewLine}";
        //}
    }
}