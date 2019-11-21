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
    public partial class MyMentors : ContentPage
    {
        public MyMentors()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
            var users = db.Table<User>();
            List<User> listItems = new List<User>();
            foreach (var user in users)
            {

            }

            
      
        }
    }
}