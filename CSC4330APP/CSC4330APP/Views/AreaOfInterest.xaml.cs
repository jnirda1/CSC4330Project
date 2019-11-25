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
        public AreaOfInterest()
        {
            InitializeComponent();

        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Guidemate.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<UserAreaOfInterest>();
            Console.WriteLine("---------------");
            if(Civil.Checked == true)

            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Civil",
                    UserName = "vchith1"
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest);
            }
           else if (Mechanical.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Mechanical",
                    UserName = "vchith1"
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest);
            }
           else if (Computers.Checked == true)
            {
                var AOI = new UserAreaOfInterest()
                {
                    AreaOfInterest = "Computers",
                    UserName = "vchith1"
                };
                db.Insert(AOI);
                Console.WriteLine(AOI.AreaOfInterest);
            }
            Navigation.PushAsync(new Home());
        }
    }
}