using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Database;
using FirebaseOptions = Firebase.FirebaseOptions;

namespace TestiSofta.Droid 
{
    public class AppDataHelper
    {
        readonly FirebaseClient firebaseDB = new FirebaseClient("https://temperatureproject-666.firebaseio.com/");
        public static FirebaseDatabase GetDatabase()
        {
            var app = FirebaseApp.InitializeApp(Application.Context);
            FirebaseDatabase dBFirebase;

            if (app == null)
            {
                var option = new FirebaseOptions.Builder().SetApplicationId("temperatureproject - 666").SetApiKey("AIzaSyCBNm9kA7zszEwzuJ864tRElPnVT4Kc99w")
                    .SetDatabaseUrl("https://temperatureproject-666.firebaseio.com").SetStorageBucket("temperatureproject-666.appspot.com").Build();

                app = FirebaseApp.InitializeApp(Application.Context, option);
                dBFirebase = FirebaseDatabase.GetInstance(app);
            }
            else
            {
                dBFirebase = FirebaseDatabase.GetInstance(app);
            }

            return dBFirebase;
        }
        //public async Task<List<GetData>> GetAllData()
        //{ 
        //    return (await dBFirebase.Child) Jatka tästä Dorka vittu kulli kello on kaks vittu https://www.c-sharpcorner.com/article/xamarin-forms-working-with-firebase-realtime-database-crud-operations/

        //}


    }


}