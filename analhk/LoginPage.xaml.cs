using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace analhk
{
	public partial class LoginPage : ContentPage
	{

		public LoginPage()
		{
			InitializeComponent();

			LoginBtn.Clicked += LoginBtn_Clicked;
		}

		public async void LoginBtn_Clicked(object sender, EventArgs e)
		{
			if (pwdInput.Text == "P@ssw0rd")
			{
				var selection = await DisplayAlert("Welcome!", "Welcome back, " + nameInput.Text + "!", "Thanks!", "Huh?");

				if (selection == true)
				{
					await Navigation.PushAsync(new TodoList());
				}
				else
				{
					int crasher = 0;
					int crashtaker = 5;
					int crashnow = crashtaker / crasher;
				}

			}
			else
			{
				await DisplayAlert("Login Failure", "Your password is incorrect. Please retry.", "OK");
			}
		}
	}
}
