using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace LinkedIn.Hakawai;
	
[Native]
public enum HKWViewportMode : long
{
	Top = 0,
	Bottom
}

[Native]
public enum HKWAccessoryViewMode : long
{
	Sibling = 0,
	FreeFloating
}

[Native]
public enum HKWMentionsSearchType : long
{
	Implicit,
	Explicit,
	Initial
}

[Native]
public enum HKWChooserBorderMode : long
{
	Top,
	Bottom,
	None
}

[Native]
public enum HKWMentionsChooserPositionMode : long
{
	EnclosedTop = 0,
	EnclosedBottom,
	CustomLockTopArrowPointingUp,
	CustomLockTopArrowPointingDown,
	CustomLockTopNoArrow,
	CustomLockBottomArrowPointingUp,
	CustomLockBottomArrowPointingDown,
	CustomLockBottomNoArrow,
	CustomNoLockArrowPointingUp,
	CustomNoLockArrowPointingDown,
	CustomNoLockNoArrow
}

[Native]
public enum HKWMentionsPluginState : long
{
	Quiescent,
	CreatingMention
}

[Native]
public enum HKWMentionsState : long
{
	teQuiescent = 0,
	rtDetectionStateCreatingMention,
	teAboutToSelectMention,
	teSelectedMention,
	teLosingFocus
}