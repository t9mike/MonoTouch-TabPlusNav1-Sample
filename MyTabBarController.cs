using System;
using Com.Muegel.MonoTouch;
using MonoTouch.UIKit;

namespace TabPlusNav1
{
	public class MyTabBarController : MuegelUITabBarController
	{
		public MyTabBarController()
		{
			// Tab #1
			var spit_view = new MySplitViewController();
			spit_view.Delegate = new UISplitViewControllerDelegate();
			spit_view.ViewControllers = new UIViewController[] { new MyNavigationController(), new DetailViewController("Tab #1") };
			Add(UITabBarSystemItem.Search, spit_view);

			// Tab #2
			var detail2_vc = new ToDoViewController("Tab #2");
			Add(UITabBarSystemItem.Favorites, detail2_vc);
			 
			
			Done();			
			SelectedIndex = 0;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}		
	}
}

