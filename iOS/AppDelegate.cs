using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

using HockeyApp.iOS;

namespace analhk.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// Initialize Azure Mobile Apps
			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

			// Initialize Xamarin Forms
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			var manager = BITHockeyManager.SharedHockeyManager;
			manager.Configure("319bad794f44430181d1525e1142858d");
			manager.StartManager();

			return base.FinishedLaunching (app, options);


		}
	}
}

