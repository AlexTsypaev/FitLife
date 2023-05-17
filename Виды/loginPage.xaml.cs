using Login.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Виды
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class loginPage : ContentPage
	{
		public loginPage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new Page1());
        }

        void Button_Clicked_1(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Userdatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUsersTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();
            if (myquery != null)
            {
                App.Current.MainPage = new HomePage();
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Ошибка", "Неверное имя или пароль", "Хорошо", "Закрыть");

                    if (result)
                        await Navigation.PushAsync(new loginPage());
                    else
                    {
                        await Navigation.PushAsync(new loginPage());
                    }
                });
            }
        }
    }
}