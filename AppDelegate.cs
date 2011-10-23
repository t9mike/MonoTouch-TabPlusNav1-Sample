using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace TabPlusNav1
{

    [Register ("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        UIWindow Window;
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {   
            // Create the main window and add the navigation controller as a subview
            Window = new UIWindow (UIScreen.MainScreen.Bounds);
            Window.MakeKeyAndVisible ();
			
			MyApp.Tab_Bar_Controller = new MyTabBarController();			
			Window.AddSubviews(MyApp.Tab_Bar_Controller.View);	
					
			Window.SetNeedsDisplay();
			Window.MakeKeyAndVisible();
						
			return true;
        }		
    }
} 