using System;
using System.Windows.Input;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace BrainFoodFriday.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

			OpenWebCommand = new Command(() => 
			{
				try
				{ 
					var crash = 0;
					var test = 10 / crash;
				}
				catch (Exception exception) 
				{ 
					Crashes.TrackError(exception); 
				}
			});
        }

        public ICommand OpenWebCommand { get; }
    }
}