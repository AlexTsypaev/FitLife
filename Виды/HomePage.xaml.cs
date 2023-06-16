using Android.Locations;
using Android.OS;
using FitLife.Странички;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Java.Util;
using Login.VievModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using static Android.Provider.MediaStore.Audio;
using static Xamarin.Essentials.Permissions;
using Location = Xamarin.Essentials.Location;

namespace Login.Виды
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        MapPageViewModel mapPageViewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = mapPageViewModel = new MapPageViewModel();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new loginPage());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new PersonalAccaunt();
        }



        async void Button_Clicked_2(object sender, EventArgs e)
        {
            var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));

            var userpin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(result.Latitude, result.Longitude),
                Label = "Это вы  ",
                Address = "Это ваше местоположение"
            };
            //map.Pins.Add(userpin);

            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.856073, 60.627893),
                Label = "Саша ",
                Address = "@Vitalik2008"
            };
            pin1.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new UserPage();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };

            //map.Pins.Add(pin1);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.856081, 60.630286),
                Label = "Саша ",
                Address = "@nokvix"
            };
            pin2.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new UserPage();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };
            //map.Pins.Add(pin2);

            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.769027, 60.614921),
                Label = "Саша ",
                Address = "@AlexTsypaev"
            };
            pin3.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new UserPage();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };
            //map.Pins.Add(pin3);

            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.812419, 60.692175),
                Label = "Саша ",
                Address = "@AlexTsypaev"
            };
            pin4.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new UserPage();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };
            //map.Pins.Add(pin4);

            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.842548, 60.641731),
                Label = "Саша ",
                Address = "@AlexTsypaev"
            };
            pin5.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new UserPage();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };
            //map.Pins.Add(pin5);

            var pin6 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.854860, 60.625063),
                Label = "Маша ",
                Address = "@nokvix"
            };
            pin6.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new Masha();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };
            //map.Pins.Add(pin6);


            var pin7 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(56.755450, 60.625463),
                Label = "Маша ",
                Address = "@nokvix"
            };
            pin7.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new Masha();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };

            var pin8 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(59.782723, 59.988352),
                Label = "Маша ",
                Address = "@AlexTsypaev"
            };
            pin8.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new Masha();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };

            var pin9 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(59.779061, 59.989489),
                Label = "Маша ",
                Address = "@AlexTsypaev"
            };
            pin9.MarkerClicked += async (sender, args) =>
            {
                App.Current.MainPage = new Masha();
                //var uri = new Uri("https://t.me/AlexTsypaev"); // Ссылка
                //Launcher.OpenAsync(uri);
            };
            //map.Pins.Add(pin7);
            var radius = 2.0; // 2 км


            //foreach (var pin in map.Pins)
            //{
            //    // Вычисляем расстояние между местоположением пользователя и данным местом.
            //        var distance = Location.CalculateDistance(
            //        result.Latitude, result.Longitude,
            //        pin.Position.Latitude, pin.Position.Longitude,
            //        DistanceUnits.Kilometers
            //    );

            //    if (distance <= radius)
            //    {
            //        map.Pins.Add(pin);
            //    }
            //}


            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin1.Position.Latitude, pin1.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin1);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin2.Position.Latitude, pin2.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin2);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin3.Position.Latitude, pin3.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin3);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin4.Position.Latitude, pin4.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin4);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin5.Position.Latitude, pin5.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin5);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin6.Position.Latitude, pin6.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin6);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin7.Position.Latitude, pin7.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin7);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin8.Position.Latitude, pin8.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin8);
            if (Location.CalculateDistance(result.Latitude, result.Longitude, pin9.Position.Latitude, pin9.Position.Longitude, DistanceUnits.Kilometers) <= radius)
                map.Pins.Add(pin9);



            //Xamarin.Forms.Maps.Geocoder geocoder = new Xamarin.Forms.Maps.Geocoder();
            //var location = await Geolocation.GetLocationAsync();
            //List<Pin> pinsInRadius = new List<Pin>();
            //foreach (var pin in map.Pins)
            //{
            //    var pinLocation = new Location(pin.Position.Latitude, pin.Position.Longitude);
            //    var distance = Location.CalculateDistance(location, pinLocation, DistanceUnits.Kilometers);
            //    if (distance <= 2)
            //    {
            //        pinsInRadius.Add(pin);
            //    }
            //    map.Pins.Clear();
            //}
            //foreach (var pin in pinsInRadius)
            //{
            //    map.Pins.Add(pin);
            //}





            // Добавляем дополнительные маркеры на карту в рассматриваемом радиусе.
            //foreach (var place in pin1)
            //{
            //    // Определяем расстояние между местоположением пользователя и местоположением метки
            //    var distance = Location.CalculateDistance(location, new Location(place.Latitude, place.Longitude), DistanceUnits.Kilometers);
            //    if (distance <= 2) // Если метка находится в заданном радиусе 2 км
            //    {
            //        // Добавляем метку на карту
            //        var position = new Position(place.Latitude, place.Longitude);
            //        map.Pins.Add(new Pin
            //        {
            //            Label = place.Name,
            //            Position = position,
            //            Type = PinType.Place
            //        });
            //    }
            //}
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new FitLife.Page2();

        }


        //async void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    //var radius = 2000.0; // 2 км
        //    //var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));

        //    //foreach (var pin in map.Pins)
        //    //{
        //    //    // Вычисляем расстояние между местоположением пользователя и данным местом.
        //    //    var distance = Location.CalculateDistance(
        //    //        result.Latitude, result.Longitude,
        //    //        pin.Position.Latitude, pin.Position.Longitude,
        //    //        DistanceUnits.Kilometers
        //    //    );

        //    //    if (distance >= radius)
        //    //    {
        //    //        map.Pins.Remove(pin);
        //    //    }
        //    //}
        //}
    }
}