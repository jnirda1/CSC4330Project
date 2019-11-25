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

        async void SignIn_Clicked(object sender, EventArgs e)
        {
            //connecting to database 
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
         //getting the user details and role from database and storing in variable
            var validUser = (db.Table<User>().Where(u => u.UserName.Equals(UserNameEntry.Text) &&
             u.Password.Equals(PasswordEntry.Text)).FirstOrDefault()); 
             var role = db.Table<UserRole>().Where(ur => ur.userName.Equals(validUser.UserName) && ur.Role.Equals(picker.SelectedItem)).FirstOrDefault()?.Role;
            //checking username and password correct
            if (validUser != null)
            {
                //checking role
                if (role == "Student")
                {
                    // App.Current.MainPage = new NavigationPage(new StudentHome(validUser.UserName));
                    await Navigation.PushAsync(new StudentHome(validUser.UserName));
                }
                else if(role==null){
                    await this.DisplayAlert("Error", "Select Correct Role", "ok");    
                 
            }
                else if (role == "Mentor")
                {
                    App.Current.MainPage = new NavigationPage(new MentorHome());
                }
                
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "User Name or Password is incorrect", "ok");
  
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