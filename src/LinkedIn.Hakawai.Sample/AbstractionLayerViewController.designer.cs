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
	[Register ("AbstractionLayerViewController")]
	partial class AbstractionLayerViewController
	{
		[Outlet]
		UIKit.UITextView ConsoleTextView { get; set; }

		[Outlet]
		LinkedIn.Hakawai.HKWTextView EditorTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ConsoleTextView != null) {
				ConsoleTextView.Dispose ();
				ConsoleTextView = null;
			}

			if (EditorTextView != null) {
				EditorTextView.Dispose ();
				EditorTextView = null;
			}

		}
	}
}
