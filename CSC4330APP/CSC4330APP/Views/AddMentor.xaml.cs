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
    public partial class AddMentor : ContentPage
    {
        public AddMentor()
        {
            InitializeComponent();
        }

        private void AddMentor_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);

            db.CreateTable<UserMentor>();
            var UserMentor = new UserMentor()
            {
                userName = UserName.Text,
                mentorUserName = MentorUserName.Text
            };
            db.Insert(UserMentor);
            Console.WriteLine(UserMentor.mentorUserName);
        }
    }
}