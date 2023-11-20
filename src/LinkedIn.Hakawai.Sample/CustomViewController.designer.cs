// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LinkedIn.Hakawai.Sample
{
	[Register ("CustomViewController")]
	partial class CustomViewController
	{
		[Outlet]
		UIKit.UITableView MentionTableView { get; set; }

		[Outlet]
		LinkedIn.Hakawai.HKWTextView MyTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyTextView != null) {
				MyTextView.Dispose ();
				MyTextView = null;
			}

			if (MentionTableView != null) {
				MentionTableView.Dispose ();
				MentionTableView = null;
			}

		}
	}
}
