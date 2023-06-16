using Login;
using Login.Виды;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var inputText = myEntry.Text; // получаем текст из элемента Entry
            var newLabel = new Label { Text = inputText }; // создаем новый элемент Label с нужным текстом
            myStackLayout.Children.Add(newLabel); // добавляем этот элемент в StackLayout 
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }
    }
}