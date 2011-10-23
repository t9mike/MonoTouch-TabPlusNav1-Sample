using System;
using MonoTouch.UIKit;

namespace TabPlusNav1
{
	public class ToDoViewController : UIViewController
	{
		public ToDoViewController(string caption)
		{
			var view = new ToDoView(caption);
			Add(view);
		}
	}
}

