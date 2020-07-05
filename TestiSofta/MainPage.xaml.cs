using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace TestiSofta
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        //readonly AppDataHelper appDataHelper = new AppDataHelper();
        public MainPage()
        {
            InitializeComponent();
        }

        //private void BtnUpdate_Clicked(object sender, EventArgs e)
        //{
            
            
        //}

        //private void BtnDelete_Clicked(object sender, EventArgs e)
        //{
        //    EditBoxi.Text = string.Empty;
        //}

        private void BtnData_Clicked(object sender, EventArgs e)
        {
            //var temp = await AppDataHelper.GetData(LblText1.Text);
        }

        private void BtnTemp_Clicked(object sender, EventArgs e)
        {

        }
    }
}
