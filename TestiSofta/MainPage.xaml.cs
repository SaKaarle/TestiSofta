using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using TestiSofta.Droid;
using Newtonsoft.Json;

/*  linkkei
     https://www.c-sharpcorner.com/article/xamarin-forms-working-with-firebase-realtime-database-crud-operations/
     https://console.firebase.google.com/u/0/project/temperatureproject-666/database/temperatureproject-666/data
     https://stackoverflow.com/questions/34335114/derserialize-json-object-from-firebase-in-c-sharp
     https://github.com/susairajs/Xamarin-Firebase-RealtimeDatabase/tree/master/XamarinFirebase
     https://github.com/susairajs/Xamarin-Firebase-RealtimeDatabase/blob/master/XamarinFirebase/XamarinFirebase/Model/Person.cs
     https://github.com/susairajs/Xamarin-Firebase-RealtimeDatabase/blob/master/XamarinFirebase/XamarinFirebase/MainPage.xaml.cs
     https://github.com/susairajs/Xamarin-Firebase-RealtimeDatabase/blob/master/XamarinFirebase/XamarinFirebase/Helper/FirebaseHelper.cs
*/

namespace TestiSofta
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
 
        
        AppDataHelper appDataHelper = new AppDataHelper();


        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var allData = await appDataHelper.GetAllData();
            lstTempData.ItemsSource = allData;
        }

        //private void BtnUpdate_Clicked(object sender, EventArgs e)
        //{
            
            
        //}

        //private void BtnDelete_Clicked(object sender, EventArgs e)
        //{
        //    EditBoxi.Text = string.Empty;
        //}

        private async void BtnData_Clicked(object sender, EventArgs e)
        {
            var gettaaData = await appDataHelper.GetTempHum(txtTemp.Text, txtHum.Text); //GetTempHum(Convert.ToInt32(txtTemp), Convert.ToInt32(txtHum));
            if (gettaaData != null)
            {
                txtTemp.Text = gettaaData.Temp.ToString();

                txtHum.Text = gettaaData.Hum.ToString();

                await DisplayAlert("Success", "Retrive data Successfully", "OK"); // Call it a day, JSON lukemista ja katsoa Raspberry Pi:n koodia
            }
            else
            {
                await DisplayAlert("Success", "Not good", "OK");
            }
            //var temp = await appDataHelper.GetData(LblText1.Text);
        }

        private void BtnTemp_Clicked(object sender, EventArgs e)
        {

        }
    }
}
