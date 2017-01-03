using System;

using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;


namespace analhk
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			//MainPage = new TodoList();
			MainPage = new NavigationPage(new LoginPage());
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

