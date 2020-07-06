using System;
using System.Collections.Generic;
using System.Text;

using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TestiSofta.Droid 
{
    public class AppDataHelper
    {

        FirebaseClient firebaseDB = new FirebaseClient("https://temperatureproject-666.firebaseio.com/");


        public async Task<List<GetData>> GetAllData()
        {
            return (await firebaseDB.Child("DHT").OnceAsync<GetData>()).Select(item => new GetData
            {
                Temp = item.Object.Temp,
                Hum = item.Object.Hum
            }).ToList();
        
        }

        public async Task<GetData> GetTempHum(string temp, string hum)
        {
            var allData = await GetAllData();
            await firebaseDB.Child("DHT").OnceAsync<GetData>();
            return allData.Where(a => a.Temp == temp)/*.Where(b => b.Hum == hum).FirstOrDefault();// */ .FirstOrDefault();
            
        }
        //public async Task<List<GetData>> GetAllData()
        //{ 
        //    return (await dBFirebase.Child) Jatka tästä Dorka vittu kulli kello on kaks vittu https://www.c-sharpcorner.com/article/xamarin-forms-working-with-firebase-realtime-database-crud-operations/

        //}


    }


}