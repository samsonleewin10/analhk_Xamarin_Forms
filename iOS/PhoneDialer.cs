using System;
using Foundation;
using UIKit;
using Xamarin.Forms;
using analhk.iOS;

[assembly: Dependency(typeof(PhoneDialer))]
namespace analhk.iOS
{
	public class PhoneDialer : IDialer
	{
		public bool Dial(string number)
		{
			return UIApplication.SharedApplication.OpenUrl(
				new NSUrl("tel:" + number));
		}
	}
}
