using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSC4330APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentHome : ContentPage
    {
        public string userNameLookup;
        public StudentHome(string userName)
        {
            InitializeComponent();
            userNameLookup = userName;
            user.Text = userName;
        }
        async void Logout_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Login());


        }

        async void Profile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentProfile());
        }

        async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentHome(userNameLookup));
        }

        async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentSearch(userNameLookup));
        }

        async void AddAOI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AreaOfInterest(userNameLookup));
        }

        async void Mymentors_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMentors());
        }
    }
}