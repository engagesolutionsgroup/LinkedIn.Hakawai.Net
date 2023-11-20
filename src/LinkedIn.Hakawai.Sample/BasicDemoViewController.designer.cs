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
	[Register ("BasicDemoViewController")]
	partial class BasicDemoViewController
	{
		[Outlet]
		LinkedIn.Hakawai.HKWTextView MainTextView { get; set; }

		[Outlet]
		UIKit.UIButton PalindromButton { get; set; }

		[Outlet]
		UIKit.UIButton ROT13Button { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ROT13Button != null) {
				ROT13Button.Dispose ();
				ROT13Button = null;
			}

			if (PalindromButton != null) {
				PalindromButton.Dispose ();
				PalindromButton = null;
			}

			if (MainTextView != null) {
				MainTextView.Dispose ();
				MainTextView = null;
			}

		}
	}
}
