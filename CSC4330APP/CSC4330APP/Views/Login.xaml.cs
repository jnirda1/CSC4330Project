using CSC4330APP.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSC4330APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Button1_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
           
            var check = db.Table<User>().Where(u => u.UserName.Equals(UserNameEntry.Text) && u.Password.Equals(PasswordEntry.Text)).FirstOrDefault();
            if(check!= null)
            {
                App.Current.MainPage = new NavigationPage(new Home());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "User Name or Password is incorrect", "Yes", "Cancel");
                    Console.WriteLine(result);
                    if (result)
                    {
                        App.Current.MainPage = new NavigationPage(new Login());
                    }
                    else
                    {
                        App.Current.MainPage = new NavigationPage(new Login());
                    }
                }
                  );
            }
        }
        async void SignUpClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Registration());
        }
        async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ForgotPassword());
        }
    }
}