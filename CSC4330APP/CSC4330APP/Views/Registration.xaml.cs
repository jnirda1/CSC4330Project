﻿
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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<User>();
            db.CreateTable<UserRole>();
            string role1 = null;
            string role2 = null;
            if (MentorCheckBox.IsChecked == true)
            {
                role2 = "Mentor";

            }
            else
            {
                role2 = null;
            }
            if (StudentCheckBox.IsChecked == true)
            {
                role1 = "Student";

            }
            else
            {
                role1 = null;
            }
            var user = new User()
            {
                FirstName = FirstNameEntry.Text,
                MiddleName = MiddleNameEntry.Text,
                LastName = LastNameEntry.Text,
                UniversityName = UniversityNameEntry.Text,
                Email = EmailEntry.Text,
                Country = CountryEntry.Text,
                State = StateEntry.Text,
                City = CityEntry.Text,
                Zipcode = ZipCodeEntry.Text,
                UserName = UserNameEntry.Text,
                Password = PasswordEntry.Text,
                Role1 = role1,
                Role2 = role2
            };
            db.Insert(user);

            if ((StudentCheckBox.IsChecked == true && MentorCheckBox.IsChecked == true)){
                var userRole = new UserRole()
                {
                    UserId = user.UserId,
                    Role = role1,


                };
                var userRole1 = new UserRole()
                {
                    UserId = user.UserId,
                    Role = role2,

                };

                db.Insert(userRole);
                db.Insert(userRole1);
            }
            if ((StudentCheckBox.IsChecked == true && MentorCheckBox.IsChecked == false)){
                var userRole = new UserRole()
                {
                    UserId = user.UserId,
                    Role = role1,


                };
                db.Insert(userRole);

            }

            if ((StudentCheckBox.IsChecked == false && MentorCheckBox.IsChecked == true))
            {
                var userRole = new UserRole()
                {
                    UserId = user.UserId,
                    Role = role2,


                };
                db.Insert(userRole);

            }





            var Pswd = PasswordEntry.Text;
            var ReEnteredPswd = RePasswordEntry.Text;
            if(Pswd == ReEnteredPswd) {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert("Congratulations", "User Registered Successfully", "OK");
                    await Navigation.PushAsync(new Login()); 
                   
                }
                  );
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                   await DisplayAlert("Error", "Password Mismatch", "OK");}
                );
            }
            
        }

         async void AlreadyExistingUserClicked(object sender, EventArgs e)
        {
            // App.Current.MainPage = new NavigationPage(new Login());
            await Navigation.PushAsync(new Login());
        }
    }
}