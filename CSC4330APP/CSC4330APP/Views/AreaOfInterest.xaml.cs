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
    public partial class AreaOfInterest : ContentPage
    {
        public string userNameLookup;
       
        public AreaOfInterest(string userName)
        {
            InitializeComponent();
            userNameLookup = userName;

        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<UserAreaOfInterest>();
            Console.WriteLine("---------------");
            if(Agriculture.Checked == true)

            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Agriculture",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest,AOI.UserName);
            }
           else if (ArfitialIntelligence.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "ArfitialIntelligence",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
           else if (Astronomy.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Astronomy",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Biology.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Biology",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Civil.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Civil",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (ComputerScience.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "ComputerScience",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Chemistry.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Chemistry",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (DeepLearning.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "DeepLearning",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (English.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "English",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Finance.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Finance",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (MachineLearning.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "MachineLearning",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Mathematics.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Mathematics",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Mechanical.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Mechanical",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest, AOI.UserName);
            }
            else if (Psychology.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Psychology",
                    UserName = userNameLookup
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest,AOI.UserName);
            }
            Navigation.PushAsync(new StudentHome(userNameLookup));
        }
    }
}