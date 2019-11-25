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
    class mentorData
    {
        string mentorName;
        string universtityName;

        public string MentorName
        {
            get
            {
                return mentorName;
            }
            set
            {
                mentorName = value;
            }
        }

        public string UniverstityName
        {
            get
            {
                return universtityName;
            }
            set
            {
                universtityName = value;
            }
        }
    }


        [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMentors : ContentPage
    {
            List<mentorData> students = new List<mentorData>();
        public MyMentors()
        {
            InitializeComponent();


            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
          
            List<User> mentorDetails = new List<User>();
            var mentorsmatched = db.Table<UserMentor>().Where(ur => ur.userName.Equals("vchith1"));
            List<string> mentors = new List<string>();
            foreach (var mentor in mentorsmatched) {
                Console.WriteLine("..................." + mentor.mentorUserName);
                mentors.Add(mentor.mentorUserName.ToString());
            }
            foreach(var mentor in mentors)
            {
                mentorDetails.AddRange( db.Table<User>().Where(ur => ur.UserName.Equals(mentor)).ToList());
               
            }
            MentorsListView.ItemsSource = mentorDetails;
            // MentorsListView.ItemsSource = mentorDetails;


        }
    }
}