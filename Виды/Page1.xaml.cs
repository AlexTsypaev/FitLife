using Login.Tables;
using Microsoft.Data.Sqlite;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Environment;

namespace Login.Виды
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Userdatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUsersTable>();

            var item = new RegUsersTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text,
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("Поздравляем", "Пользователь успешно зарегистрирован", "Отлично!","Супер");

                if (result)
                    await Navigation.PushAsync(new loginPage());
            });
        }
    }
}