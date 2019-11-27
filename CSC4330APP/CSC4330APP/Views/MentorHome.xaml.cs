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
    public partial class MentorHome : ContentPage
    {
        public string userNameLookup;
        public MentorHome(string userName)
        {
            InitializeComponent();
            userNameLookup = userName;
            user.Text = userName;
        }

        
            async void Logout_Clicked(object sender, EventArgs e)
            {

                await Navigation.PushAsync(new Login());

            
        }

        async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MentorHome(userNameLookup));
        }

        async void AddAOI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AreaOfInterest(userNameLookup));
        }

        async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MentorSearch());
        }

        async void Mymentors_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MentorHome(userNameLookup));
        }

        async void Profile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MentorHome(userNameLookup));
        }
    }
}