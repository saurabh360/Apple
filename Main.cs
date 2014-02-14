using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace IOSappl
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
			Console.WriteLine("Test of Apple ");
			Console.WriteLine("Test of Apple test ");
			Console.WriteLine("Test of Apple test123 ");
			Console.WriteLine("Test of Apple test123 ");
		}
	}
}
