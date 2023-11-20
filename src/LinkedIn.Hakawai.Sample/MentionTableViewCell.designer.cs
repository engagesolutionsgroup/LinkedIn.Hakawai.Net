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
	[Register ("MentionTableViewCell")]
	partial class MentionTableViewCell
	{
		[Outlet]
		UIKit.UILabel MainLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MainLabel != null) {
				MainLabel.Dispose ();
				MainLabel = null;
			}

		}
	}
}
