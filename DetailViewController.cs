using System;
using MonoTouch.UIKit;

namespace TabPlusNav1
{
	public class DetailViewController : UINavigationController
	{		
		public DetailViewController(string caption)
		{
			PushViewController(new ToDoViewController(caption), false);
			TopViewController.Title = caption;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
	}
}

