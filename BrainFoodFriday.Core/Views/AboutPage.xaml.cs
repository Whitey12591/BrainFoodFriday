using System;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainFoodFriday.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

		void Handle_Pressed(object sender, System.EventArgs e)
		{
			try
            {
                var crash = 0;
                var test = 10 / crash;
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
				DisplayAlert("Yikes! Something went wrong", "Please try again later", "OK");
            }
		}
    }
}