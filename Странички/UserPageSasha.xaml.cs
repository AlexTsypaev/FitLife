using Login.Виды;
using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitLife.Странички
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://t.me/AlexTsypaev"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }
    }
}