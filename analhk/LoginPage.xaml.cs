using System;
using System.Collections.Generic;

using Microsoft.Azure.Mobile.Analytics;

using Xamarin.Forms;

namespace analhk
{
	public partial class LoginPage : ContentPage
	{

		public LoginPage()
		{
			InitializeComponent();

			LoginBtn.Clicked += LoginBtn_Clicked;
			HelpBtn.Clicked += OnCall;
		}

		public async void LoginBtn_Clicked(object sender, EventArgs e)
		{
			Analytics.TrackEvent("Login Attempt");
			if (pwdInput.Text == "P@ssw0rd")
			{
				Analytics.TrackEvent("Login Succeed");
				var selection = await DisplayAlert("Welcome!", "Welcome back, " + nameInput.Text + "!", "Thanks!", "Huh?");

				if (selection == true)
				{
					Analytics.TrackEvent("Navigate to MainPage");
					await Navigation.PushAsync(new TodoList());
				}
				else
				{
					Analytics.TrackEvent("Exit from LoginPage");
					int crasher = 0;
					int crashtaker = 5;
					int crashnow = crashtaker / crasher;
				}

			}
			else
			{
				Analytics.TrackEvent("Login Failed");
				await DisplayAlert("Login Failure", "Your password is incorrect. Please retry.", "OK");
			}

		}

		public async void OnCall(object sender, EventArgs e)
		{
			if (await this.DisplayAlert(
				"Dial a Number",
				"Would you like to call " + "51902387" + "?",
				"Yes",
				"No"))
			{
				var dialer = DependencyService.Get<IDialer>();
				if (dialer != null)
					dialer.Dial("51902387");
			}
		}
	}
}
