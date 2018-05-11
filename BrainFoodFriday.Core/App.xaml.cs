using System;
using BrainFoodFriday.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
using Microsoft.AppCenter.Distribute;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BrainFoodFriday
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override async void OnStart()
        {
			// Handle when your app starts
			Microsoft.AppCenter.AppCenter.Start("ios=f3b72164-680d-4902-af59-ba57b9e7ddc5;" + "android=4e32e4b3-7d51-4b6b-ad13-0e2f26ab4804;", 
			                                    typeof(Analytics), 
			                                    typeof(Crashes), 
			                                    typeof(Push), 
			                                    typeof(Distribute));
			
			bool didAppCrash = await Crashes.HasCrashedInLastSessionAsync();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
