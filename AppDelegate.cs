using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace TabPlusNav1
{

    [Register ("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        UIWindow App_Window;
		UITabBarController Tab_Bar_Controller;
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {   
            App_Window = new UIWindow (UIScreen.MainScreen.Bounds);
			Tab_Bar_Controller = new MyTabBarController();	
			App_Window.RootViewController = Tab_Bar_Controller;
			App_Window.MakeKeyAndVisible();
						
			return true;
        }		
    }
} 