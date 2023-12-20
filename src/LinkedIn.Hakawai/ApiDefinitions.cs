using System;
using CoreGraphics;
using Foundation;
using LinkedIn.Hakawai;
using ObjCRuntime;
using UIKit;

namespace LinkedIn.Hakawai;

partial interface IHKWMentionsEntityProtocol {}
// @protocol HKWMentionsEntityProtocol <NSObject>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol, Model]
[BaseType (typeof(NSObject))]
interface HKWMentionsEntityProtocol
{
	// @required -(NSString *)entityId;
	[Abstract]
	[Export("entityId")]
	//[Verify (MethodToProperty)]
	NSString EntityId();

	// @required -(NSString *)entityName;
	[Abstract]
	[Export("entityName")]
	//[Verify (MethodToProperty)]
	NSString EntityName();

	// @required -(NSDictionary *)entityMetadata;
	[Abstract]
	[Export ("entityMetadata")]
	//[Verify (MethodToProperty)]
	NSDictionary EntityMetadata { get; }

	// @optional -(id)valueForCustomKey:(NSString *)customKey;
	[Export ("valueForCustomKey:")]
	NSObject ValueForCustomKey (string customKey);

	// @optional -(NSString *)uniqueId;
	[Export ("uniqueId")]
	//[Verify (MethodToProperty)]
	NSString UniqueId { get; }
}


// @protocol HKWTextViewDelegate <UITextViewDelegate>
[Protocol, Model]
interface HKWTextViewDelegate : IUITextViewDelegate
{
	// @optional -(void)textViewDidEnterSingleLineViewportMode:(HKWTextView * _Nonnull)textView;
	[Export ("textViewDidEnterSingleLineViewportMode:")]
	void TextViewDidEnterSingleLineViewportMode (HKWTextView textView);

	// @optional -(void)textViewDidExitSingleLineViewportMode:(HKWTextView * _Nonnull)textView;
	[Export ("textViewDidExitSingleLineViewportMode:")]
	void TextViewDidExitSingleLineViewportMode (HKWTextView textView);

	// @optional -(void)textViewWasTappedInSingleLineViewportMode:(HKWTextView * _Nonnull)textView;
	[Export ("textViewWasTappedInSingleLineViewportMode:")]
	void TextViewWasTappedInSingleLineViewportMode (HKWTextView textView);

	// @optional -(void)textViewDidHaveTextPastedIn:(HKWTextView * _Nonnull)textView;
	[Export ("textViewDidHaveTextPastedIn:")]
	void TextViewDidHaveTextPastedIn (HKWTextView textView);

	// @optional -(void)textView:(HKWTextView * _Nonnull)textView didChangeAttributedTextTo:(NSAttributedString * _Nonnull)newText originalText:(NSAttributedString * _Nonnull)originalText originalRange:(NSRange)originalRange;
	[Export ("textView:didChangeAttributedTextTo:originalText:originalRange:")]
	void DidChangeAttributedTextTo (HKWTextView textView, NSAttributedString newText, NSAttributedString originalText, NSRange originalRange);

	// @optional -(void)textView:(HKWTextView * _Nonnull)textView didReceiveNewTextAttachment:(NSTextAttachment * _Nonnull)attachment;
	[Export ("textView:didReceiveNewTextAttachment:")]
	void DidReceiveNewTextAttachment (HKWTextView textView, NSTextAttachment attachment);

	// @optional -(void)textView:(HKWTextView * _Nonnull)textView willBeginEditing:(BOOL)editing;
	[Export ("textView:willBeginEditing:")]
	void WillBeginEditing (HKWTextView textView, bool editing);

	// @optional -(void)textView:(HKWTextView * _Nonnull)textView willEndEditing:(BOOL)editing;
	[Export ("textView:willEndEditing:")]
	void WillEndEditing (HKWTextView textView, bool editing);
}

// @interface HKWTextView : UITextView
[BaseType (typeof(UITextView))]
interface HKWTextView
{
	// +(BOOL)enableMentionsPluginV2;
	// +(void)setEnableMentionsPluginV2:(BOOL)enabled;
	[Static]
	[Export ("enableMentionsPluginV2")]
	//[Verify (MethodToProperty)]
	bool EnableMentionsPluginV2 { get; set; }

	// +(BOOL)directlyUpdateQueryWithCustomDelegate;
	// +(void)setDirectlyUpdateQueryWithCustomDelegate:(BOOL)enabled;
	[Static]
	[Export ("directlyUpdateQueryWithCustomDelegate")]
	//[Verify (MethodToProperty)]
	bool DirectlyUpdateQueryWithCustomDelegate { get; set; }

	// +(BOOL)enableControlCharactersToPrepend;
	// +(void)setEnableControlCharactersToPrepend:(BOOL)enabled;
	[Static]
	[Export ("enableControlCharactersToPrepend")]
	//[Verify (MethodToProperty)]
	bool EnableControlCharactersToPrepend { get; set; }

	// +(BOOL)enableControlCharacterMaxLengthFix;
	// +(void)setEnableControlCharacterMaxLengthFix:(BOOL)enabled;
	[Static]
	[Export ("enableControlCharacterMaxLengthFix")]
	bool EnableControlCharacterMaxLengthFix { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame textContainer:(NSTextContainer * _Nullable)textContainer;
	[Export ("initWithFrame:textContainer:")]
	NativeHandle Constructor (CGRect frame, [NullAllowed] NSTextContainer textContainer);

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
	[Export ("initWithFrame:")]
	NativeHandle Constructor (CGRect frame);

	// @property (nonatomic, weak) id<HKWTextViewDelegate> _Nullable externalDelegate;
	[NullAllowed, Export ("externalDelegate", ArgumentSemantic.Weak)]
	NSObject WeakExternalDelegate { get; set; }

	[Wrap ("WeakSimpleDelegate")]
	[NullAllowed]
	UITextViewDelegate SimpleDelegate { get; set; }

	// @property (nonatomic) id<UITextViewDelegate> _Nullable simpleDelegate;
	[NullAllowed, Export ("simpleDelegate", ArgumentSemantic.Assign)]
	NSObject WeakSimpleDelegate { get; set; }

	// @property (readonly, nonatomic) NSArray * _Nonnull simplePlugins;
	[Export ("simplePlugins")]
	NSObject[] SimplePlugins { get; }

	// @property (nonatomic, strong) id<HKWDirectControlFlowPluginProtocol> _Nullable controlFlowPlugin;
	[NullAllowed, Export ("controlFlowPlugin", ArgumentSemantic.Strong)]
	HKWDirectControlFlowPluginProtocol ControlFlowPlugin { get; set; }

	// @property (nonatomic, strong) id<HKWAbstractionLayerControlFlowPluginProtocol> _Nullable abstractionControlFlowPlugin;
	[NullAllowed, Export ("abstractionControlFlowPlugin", ArgumentSemantic.Strong)]
	HKWAbstractionLayerControlFlowPluginProtocol AbstractionControlFlowPlugin { get; set; }

	// -(void)addSimplePlugin:(id<HKWSimplePluginProtocol> _Nonnull)plugin;
	[Export ("addSimplePlugin:")]
	void AddSimplePlugin (HKWSimplePluginProtocol plugin);

	// -(void)removeSimplePluginNamed:(NSString * _Nonnull)name;
	[Export ("removeSimplePluginNamed:")]
	void RemoveSimplePluginNamed (string name);

	// -(void)textViewDidProgrammaticallyUpdate;
	[Export ("textViewDidProgrammaticallyUpdate")]
	void TextViewDidProgrammaticallyUpdate ();

	// @property (readonly, nonatomic, weak) UIView * _Nullable attachedAccessoryView;
	[NullAllowed, Export ("attachedAccessoryView", ArgumentSemantic.Weak)]
	UIView AttachedAccessoryView { get; }

	// @property (readonly, nonatomic, weak) UIView * _Nullable customTopLevelView;
	[NullAllowed, Export ("customTopLevelView", ArgumentSemantic.Weak)]
	UIView CustomTopLevelView { get; }

	// @property (readonly, nonatomic) BOOL inSingleLineViewportMode;
	[Export ("inSingleLineViewportMode")]
	bool InSingleLineViewportMode { get; }
}

// @interface Plugins (HKWTextView)
[Category]
[BaseType (typeof(HKWTextView))]
interface HKWTextView_Plugins
{
	// -(CGRect)enterSingleLineViewportMode:(HKWViewportMode)mode captureTouches:(BOOL)shouldCaptureTouches;
	[Export ("enterSingleLineViewportMode:captureTouches:")]
	CGRect EnterSingleLineViewportMode (HKWViewportMode mode, bool shouldCaptureTouches);

	// -(void)exitSingleLineViewportMode;
	[Export ("exitSingleLineViewportMode")]
	void ExitSingleLineViewportMode ();

	// -(CGRect)rectForSingleLineViewportInMode:(HKWViewportMode)mode;
	[Export ("rectForSingleLineViewportInMode:")]
	CGRect RectForSingleLineViewportInMode (HKWViewportMode mode);

	// @property (copy, nonatomic) void (^onAccessoryViewAttachmentBlock)(UIView *, BOOL);
	[Export("onAccessoryViewAttachmentBlock", ArgumentSemantic.Copy)]
	Action<UIView, bool> GetOnAccessoryViewAttachmentBlock();
	
	[Export("onAccessoryViewAttachmentBlock", ArgumentSemantic.Copy)]
	void SetOnAccessoryViewAttachmentBlock(Action<UIView, bool> value);

	// -(void)attachSiblingAccessoryView:(UIView *)view position:(CGPoint)position;
	[Export ("attachSiblingAccessoryView:position:")]
	void AttachSiblingAccessoryView (UIView view, CGPoint position);

	// -(void)attachFreeFloatingAccessoryView:(UIView *)view absolutePosition:(CGPoint)position;
	[Export ("attachFreeFloatingAccessoryView:absolutePosition:")]
	void AttachFreeFloatingAccessoryView (UIView view, CGPoint position);

	// -(void)detachAccessoryView:(UIView *)view;
	[Export ("detachAccessoryView:")]
	void DetachAccessoryView (UIView view);

	// -(void)setTopLevelViewForAccessoryViewPositioning:(UIView *)view;
	[Export ("setTopLevelViewForAccessoryViewPositioning:")]
	void SetTopLevelViewForAccessoryViewPositioning (UIView view);

	// @property (readonly, nonatomic) BOOL firstResponderIsCycling;
	[Export("firstResponderIsCycling")]
	bool FirstResponderIsCycling();

	// @property (nonatomic) BOOL shouldRejectAutocorrectInsertions;
	[Export("shouldRejectAutocorrectInsertions")]
	bool GetShouldRejectAutocorrectInsertions();
	
	[Export("shouldRejectAutocorrectInsertions")]
	bool SetShouldRejectAutocorrectInsertions(bool value);
	

	// -(void)dismissAutocorrectSuggestion;
	[Export ("dismissAutocorrectSuggestion")]
	void DismissAutocorrectSuggestion ();

	// -(void)overrideAutocapitalizationWith:(UITextAutocapitalizationType)override;
	[Export ("overrideAutocapitalizationWith:")]
	void OverrideAutocapitalizationWith (UITextAutocapitalizationType @override);

	// -(void)restoreOriginalAutocapitalization:(BOOL)shouldCycle;
	[Export ("restoreOriginalAutocapitalization:")]
	void RestoreOriginalAutocapitalization (bool shouldCycle);

	// -(void)overrideAutocorrectionWith:(UITextAutocorrectionType)override;
	[Export ("overrideAutocorrectionWith:")]
	void OverrideAutocorrectionWith (UITextAutocorrectionType @override);

	// -(void)restoreOriginalAutocorrection:(BOOL)shouldCycle;
	[Export ("restoreOriginalAutocorrection:")]
	void RestoreOriginalAutocorrection (bool shouldCycle);

	// -(void)overrideSpellCheckingWith:(UITextSpellCheckingType)override;
	[Export ("overrideSpellCheckingWith:")]
	void OverrideSpellCheckingWith (UITextSpellCheckingType @override);

	// -(void)restoreOriginalSpellChecking:(BOOL)shouldCycle;
	[Export ("restoreOriginalSpellChecking:")]
	void RestoreOriginalSpellChecking (bool shouldCycle);

	// @property (readonly, nonatomic) UIFont * fontSetByApp;
	[Export("fontSetByApp")]
	UIFont GetFontSetByApp();

	// @property (readonly, nonatomic) UIColor * textColorSetByApp;
	[Export("textColorSetByApp")]
	UIColor GetTextColorSetByApp();
}

// @interface Extras (HKWTextView)
[Category]
[BaseType (typeof(HKWTextView))]
interface HKWTextView_Extras
{
	// @property (nonatomic) BOOL disableVerticalScrolling;
	[Export("disableVerticalScrolling")]
	bool GetDisableVerticalScrolling();
	
	[Export("disableVerticalScrolling")]
	void SetDisableVerticalScrolling(bool value);

	// -(CGRect)rectForWordPrecedingCursor;
	[Export("rectForWordPrecedingCursor")]
	CGRect RectForWordPrecedingCursor();

	// -(NSRange)rangeForWordPrecedingLocation:(NSUInteger)location searchToEnd:(BOOL)toEnd;
	[Export ("rangeForWordPrecedingLocation:searchToEnd:")]
	NSRange RangeForWordPrecedingLocation (nuint location, bool toEnd);

	// -(NSRange)rangeForWordPrecedingCursor;
	[Export("rangeForWordPrecedingCursor")]
	NSRange RangeForWordPrecedingCursor();

	// -(unichar)characterPrecedingLocation:(NSInteger)location;
	[Export ("characterPrecedingLocation:")]
	ushort CharacterPrecedingLocation (nint location);

	// -(BOOL)isCurrentlyLongPressing;
	[Export("isCurrentlyLongPressing")]
	bool IsCurrentlyLongPressing();
}

partial interface IHKWSimplePluginProtocol {}
// @protocol IHKWSimplePluginProtocol <NSObject>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol, Model]
[BaseType (typeof(NSObject))]
interface HKWSimplePluginProtocol
{
	// @required @property (readonly, nonatomic) NSString * pluginName;
	[Abstract]
	[Export ("pluginName")]
	string PluginName { get; }

	// @required @property (nonatomic, weak) HKWTextView * parentTextView;
	[Abstract]
	[Export ("parentTextView", ArgumentSemantic.Weak)]
	HKWTextView ParentTextView { get; set; }

	// @required -(void)performInitialSetup;
	[Abstract]
	[Export ("performInitialSetup")]
	void PerformInitialSetup ();

	// @required -(void)performFinalCleanup;
	[Abstract]
	[Export ("performFinalCleanup")]
	void PerformFinalCleanup ();

	// @optional @property (readwrite, nonatomic, strong) NSString * dictationString;
	[Export ("dictationString", ArgumentSemantic.Strong)]
	string DictationString { get; set; }
}

// @protocol HKWAbstractionLayerDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface HKWAbstractionLayerDelegate
{
	// @optional -(BOOL)textView:(UITextView *)textView textInserted:(NSString *)text atLocation:(NSUInteger)location autocorrect:(BOOL)autocorrect;
	[Export ("textView:textInserted:atLocation:autocorrect:")]
	bool TextInserted (UITextView textView, string text, nuint location, bool autocorrect);

	// @optional -(BOOL)textView:(UITextView *)textView textDeletedFromLocation:(NSUInteger)location length:(NSUInteger)length;
	[Export ("textView:textDeletedFromLocation:length:")]
	bool TextDeletedFromLocation (UITextView textView, nuint location, nuint length);

	// @optional -(BOOL)textView:(UITextView *)textView replacedTextAtRange:(NSRange)replacementRange newText:(NSString *)newText autocorrect:(BOOL)autocorrect;
	[Export ("textView:replacedTextAtRange:newText:autocorrect:")]
	bool ReplacedTextAtRange (UITextView textView, NSRange replacementRange, string newText, bool autocorrect);

	// @optional -(void)textView:(UITextView *)textView cursorChangedToInsertion:(NSUInteger)location;
	[Export ("textView:cursorChangedToInsertion:")]
	void CursorChangedToInsertion (UITextView textView, nuint location);

	// @optional -(void)textView:(UITextView *)textView cursorChangedToSelection:(NSRange)selectionRange;
	[Export ("textView:cursorChangedToSelection:")]
	void CursorChangedToSelection (UITextView textView, NSRange selectionRange);

	// @optional -(void)textView:(UITextView *)textView characterDeletionWasIgnoredAtLocation:(NSUInteger)location;
	[Export ("textView:characterDeletionWasIgnoredAtLocation:")]
	void CharacterDeletionWasIgnoredAtLocation (UITextView textView, nuint location);
}

// @interface HKWAbstractionLayer : NSObject
[BaseType (typeof(NSObject))]
interface HKWAbstractionLayer
{
	[Wrap ("WeakDelegate")]
	HKWAbstractionLayerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<HKWAbstractionLayerDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// +(instancetype)instanceWithTextView:(UITextView *)textView changeRejection:(BOOL)enabled;
	[Static]
	[Export ("instanceWithTextView:changeRejection:")]
	HKWAbstractionLayer InstanceWithTextView (UITextView textView, bool enabled);

	// -(void)pushIgnore;
	[Export ("pushIgnore")]
	void PushIgnore ();

	// -(void)popIgnore;
	[Export ("popIgnore")]
	void PopIgnore ();

	// @property (readonly, nonatomic) NSUInteger ignoreStackDepth;
	[Export ("ignoreStackDepth")]
	nuint IgnoreStackDepth { get; }

	// @property (nonatomic) BOOL shouldIgnoreNextCharacterDeletion;
	[Export ("shouldIgnoreNextCharacterDeletion")]
	bool ShouldIgnoreNextCharacterDeletion { get; set; }

	// -(void)textViewDidProgrammaticallyUpdate;
	[Export ("textViewDidProgrammaticallyUpdate")]
	void TextViewDidProgrammaticallyUpdate ();

	// -(BOOL)textViewShouldChangeTextInRange:(NSRange)range replacementText:(NSString *)text wasPaste:(BOOL)wasPaste;
	[Export ("textViewShouldChangeTextInRange:replacementText:wasPaste:")]
	bool TextViewShouldChangeTextInRange (NSRange range, string text, bool wasPaste);

	// -(void)textViewDidChangeSelection;
	[Export ("textViewDidChangeSelection")]
	void TextViewDidChangeSelection ();

	// -(void)textViewDidChange;
	[Export ("textViewDidChange")]
	void TextViewDidChange ();
}

public interface IHKWDirectControlFlowPluginProtocol {}
// @protocol HKWDirectControlFlowPluginProtocol <UITextViewDelegate, HKWSimplePluginProtocol>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol, Model]
[BaseType(typeof(HKWSimplePluginProtocol))]
interface HKWDirectControlFlowPluginProtocol : IUITextViewDelegate
{
	// @optional -(void)singleLineViewportChanged;
	[Export ("singleLineViewportChanged")]
	void SingleLineViewportChanged ();

	// @optional -(void)singleLineViewportTapped;
	[Export ("singleLineViewportTapped")]
	void SingleLineViewportTapped ();

	// @optional -(void)textViewDidProgrammaticallyUpdate:(UITextView *)textView;
	[Export ("textViewDidProgrammaticallyUpdate:")]
	void TextViewDidProgrammaticallyUpdate (UITextView textView);

	// @optional -(void)textView:(UITextView *)textView willCustomPasteTextInRange:(NSRange)range;
	[Export ("textView:willCustomPasteTextInRange:")]
	void TextView (UITextView textView, NSRange range);
}

// @protocol HKWAbstractionLayerControlFlowPluginProtocol <HKWAbstractionLayerDelegate, HKWSimplePluginProtocol>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol, Model]
[BaseType(typeof(HKWAbstractionLayerDelegate))]
interface HKWAbstractionLayerControlFlowPluginProtocol 
{
	// @optional -(void)singleLineViewportChanged;
	[Export ("singleLineViewportChanged")]
	void SingleLineViewportChanged ();

	// @optional -(void)singleLineViewportTapped;
	[Export ("singleLineViewportTapped")]
	void SingleLineViewportTapped ();

	// @optional -(void)textViewDidProgrammaticallyUpdate:(UITextView *)textView;
	[Export ("textViewDidProgrammaticallyUpdate:")]
	void TextViewDidProgrammaticallyUpdate (UITextView textView);

	// @optional -(BOOL)textViewShouldBeginEditing:(UITextView *)textView;
	[Export ("textViewShouldBeginEditing:")]
	bool TextViewShouldBeginEditing (UITextView textView);

	// @optional -(BOOL)textViewShouldEndEditing:(UITextView *)textView;
	[Export ("textViewShouldEndEditing:")]
	bool TextViewShouldEndEditing (UITextView textView);

	// @optional -(void)textViewDidBeginEditing:(UITextView *)textView;
	[Export ("textViewDidBeginEditing:")]
	void TextViewDidBeginEditing (UITextView textView);

	// @optional -(void)textViewDidEndEditing:(UITextView *)textView;
	[Export ("textViewDidEndEditing:")]
	void TextViewDidEndEditing (UITextView textView);

	// @optional -(BOOL)textView:(UITextView *)textView shouldInteractWithURL:(NSURL *)URL inRange:(NSRange)characterRange;
	[Export ("textView:shouldInteractWithURL:inRange:")]
	bool ShouldInteractWithURL (UITextView textView, NSUrl URL, NSRange characterRange);

	// @optional -(BOOL)textView:(UITextView *)textView shouldInteractWithTextAttachment:(NSTextAttachment *)textAttachment inRange:(NSRange)characterRange;
	[Export ("textView:shouldInteractWithTextAttachment:inRange:")]
	bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange);
}

// @interface TextTransformation (HKWTextView)
[Category]
[BaseType (typeof(HKWTextView))]
interface HKWTextView_TextTransformation
{
	// -(void)transformSelectedTextWithTransformer:(NSAttributedString *(^)(NSAttributedString *))transformer;
	[Export ("transformSelectedTextWithTransformer:")]
	void TransformSelectedTextWithTransformer (Func<NSAttributedString, NSAttributedString> transformer);

	// -(void)transformTextAtRange:(NSRange)range withTransformer:(NSAttributedString *(^)(NSAttributedString *))transformer;
	[Export ("transformTextAtRange:withTransformer:")]
	void TransformTextAtRange (NSRange range, Func<NSAttributedString, NSAttributedString> transformer);

	// -(void)insertPlainText:(NSString *)text location:(NSUInteger)location;
	[Export ("insertPlainText:location:")]
	void InsertPlainText (string text, nuint location);

	// -(void)insertAttributedText:(NSAttributedString *)text location:(NSUInteger)location;
	[Export ("insertAttributedText:location:")]
	void InsertAttributedText (NSAttributedString text, nuint location);

	// -(void)insertTextAttachment:(NSTextAttachment *)attachment location:(NSUInteger)location;
	[Export ("insertTextAttachment:location:")]
	void InsertTextAttachment (NSTextAttachment attachment, nuint location);

	// -(void)removeTextForRange:(NSRange)range;
	[Export ("removeTextForRange:")]
	void RemoveTextForRange (NSRange range);

	// -(void)activateCustomAttributeWithName:(NSString *)name value:(id)value;
	[Export ("activateCustomAttributeWithName:value:")]
	void ActivateCustomAttributeWithName (string name, NSObject value);

	// -(void)deactivateCustomAttributeWithName:(NSString *)name;
	[Export ("deactivateCustomAttributeWithName:")]
	void DeactivateCustomAttributeWithName (string name);

	// -(void)deactivateAllCustomAttributes;
	[Export ("deactivateAllCustomAttributes")]
	void DeactivateAllCustomAttributes ();

	// -(void)stripAttributeFromTextAtRange:(NSRange)range attributeName:(NSString *)attributeName;
	[Export ("stripAttributeFromTextAtRange:attributeName:")]
	void StripAttributeFromTextAtRange (NSRange range, string attributeName);

	// -(void)transformTypingAttributesWithTransformer:(NSDictionary *(^)(NSDictionary *))transformer;
	[Export ("transformTypingAttributesWithTransformer:")]
	void TransformTypingAttributesWithTransformer (Func<NSDictionary, NSDictionary> transformer);
}

public interface IHKWMentionsCustomChooserViewDelegate { }
// @protocol HKWMentionsCustomChooserViewDelegate <NSObject>
[Protocol, Model ]
[BaseType (typeof(NSObject))]
interface HKWMentionsCustomChooserViewDelegate
{
	// @required -(void)didUpdateKeyString:(NSString * _Nonnull)keyString controlCharacter:(unichar)character;
	[Abstract]
	[Export ("didUpdateKeyString:controlCharacter:")]
	void DidUpdateKeyString (string keyString, ushort character);

	// @optional -(BOOL)entityCanBeTrimmed:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity;
	[Export ("entityCanBeTrimmed:")]
	bool EntityCanBeTrimmed (HKWMentionsEntityProtocol entity);
}

// @interface HKWRoundedRectBackgroundAttributeValue : NSObject
[BaseType (typeof(NSObject))]
interface HKWRoundedRectBackgroundAttributeValue
{
	// @property (nonatomic, strong) UIColor * backgroundColor;
	[Export ("backgroundColor", ArgumentSemantic.Strong)]
	UIColor BackgroundColor { get; set; }

	// +(instancetype)valueWithBackgroundColor:(UIColor *)color;
	[Static]
	[Export ("valueWithBackgroundColor:")]
	HKWRoundedRectBackgroundAttributeValue ValueWithBackgroundColor (UIColor color);
}

// @protocol HKWMentionsDefaultChooserViewDelegate <NSObject>
[Protocol, Model ]
[BaseType (typeof(NSObject))]
interface HKWMentionsDefaultChooserViewDelegate
{
	// @required -(void)asyncRetrieveEntitiesForKeyString:(NSString * _Nonnull)keyString searchType:(HKWMentionsSearchType)type controlCharacter:(unichar)character completion:(void (^ _Null_unspecified)(NSArray * _Null_unspecified, BOOL, BOOL))completionBlock;
	[Abstract]
	[Export ("asyncRetrieveEntitiesForKeyString:searchType:controlCharacter:completion:")]
	void AsyncRetrieveEntitiesForKeyString (string keyString, HKWMentionsSearchType type, ushort character, Action<NSArray, bool, bool> completionBlock);

	// @required -(UITableViewCell * _Null_unspecified)cellForMentionsEntity:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity withMatchString:(NSString * _Null_unspecified)matchString tableView:(UITableView * _Null_unspecified)tableView atIndexPath:(NSIndexPath * _Null_unspecified)indexPath;
	[Abstract]
	[Export ("cellForMentionsEntity:withMatchString:tableView:atIndexPath:")]
	UITableViewCell CellForMentionsEntity (HKWMentionsEntityProtocol entity, string matchString, UITableView tableView, NSIndexPath indexPath);

	// @required -(CGFloat)heightForCellForMentionsEntity:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity tableView:(UITableView * _Null_unspecified)tableView;
	[Abstract]
	[Export ("heightForCellForMentionsEntity:tableView:")]
	nfloat HeightForCellForMentionsEntity (HKWMentionsEntityProtocol entity, UITableView tableView);

	// @optional -(BOOL)entityCanBeTrimmed:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity;
	[Export ("entityCanBeTrimmed:")]
	bool EntityCanBeTrimmed (HKWMentionsEntityProtocol entity);

	// @optional -(NSString * _Nonnull)trimmedNameForEntity:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity;
	[Export ("trimmedNameForEntity:")]
	string TrimmedNameForEntity (HKWMentionsEntityProtocol entity);

	// @optional -(UITableViewCell * _Null_unspecified)loadingCellForTableView:(UITableView * _Null_unspecified)tableView;
	[Export ("loadingCellForTableView:")]
	UITableViewCell LoadingCellForTableView (UITableView tableView);

	// @optional -(CGFloat)heightForLoadingCellInTableView:(UITableView * _Null_unspecified)tableView;
	[Export ("heightForLoadingCellInTableView:")]
	nfloat HeightForLoadingCellInTableView (UITableView tableView);
}

public static class Constants
{
	public static readonly NSString HKWRoundedRectBackgroundAttributeName = new NSString("HKWRoundedRectBackgroundAttributeName");
}

public partial interface IHKWChooserViewProtocol
{
	
}

// @protocol HKWChooserViewProtocol <NSObject>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
[BaseType(typeof(UIView))]
interface HKWChooserViewProtocol 
{
	// @required -(void)becomeVisible;
	[Abstract]
	[Export ("becomeVisible")]
	void BecomeVisible ();

	// @required -(void)resetScrollPositionAndHide;
	[Abstract]
	[Export ("resetScrollPositionAndHide")]
	void ResetScrollPositionAndHide ();

	// @required -(void)reloadData;
	[Abstract]
	[Export ("reloadData")]
	void ReloadData ();

	// @optional +(id)chooserViewWithFrame:(CGRect)frame;
	[Static]
	[Export ("chooserViewWithFrame:")]
	NSObject ChooserViewWithFrame (CGRect frame);

	// @optional +(id)chooserViewWithFrame:(CGRect)frame delegate:(id<UITableViewDelegate>)delegate;
	[Static]
	[Export ("chooserViewWithFrame:delegate:")]
	NSObject ChooserViewWithFrame (CGRect frame, UITableViewDelegate @delegate);

	// @optional +(id)chooserViewWithFrame:(CGRect)frame delegate:(id<UITableViewDelegate>)delegate dataSource:(id<UITableViewDataSource>)dataSource;
	[Static]
	[Export ("chooserViewWithFrame:delegate:dataSource:")]
	NSObject ChooserViewWithFrame (CGRect frame, UITableViewDelegate @delegate, UITableViewDataSource dataSource);

	// @optional @property (nonatomic) HKWChooserBorderMode borderMode;
	[Export ("borderMode", ArgumentSemantic.Assign)]
	HKWChooserBorderMode BorderMode { get; set; }

	// @optional @property (nonatomic) UIEdgeInsets dataViewScrollIndicatorInsets;
	[Export ("dataViewScrollIndicatorInsets", ArgumentSemantic.Assign)]
	UIEdgeInsets DataViewScrollIndicatorInsets { get; set; }

	// @optional @property (nonatomic) UIEdgeInsets dataViewContentInset;
	[Export ("dataViewContentInset", ArgumentSemantic.Assign)]
	UIEdgeInsets DataViewContentInset { get; set; }

	// @optional @property (nonatomic, strong) UIColor * chooserBackgroundColor;
	[Export ("chooserBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ChooserBackgroundColor { get; set; }

	// @optional @property (nonatomic) BOOL insertionPointMarkerEnabled;
	[Export ("insertionPointMarkerEnabled")]
	bool InsertionPointMarkerEnabled { get; set; }

	// @optional -(void)moveInsertionPointMarkerToXPosition:(CGFloat)position;
	[Export ("moveInsertionPointMarkerToXPosition:")]
	void MoveInsertionPointMarkerToXPosition (nfloat position);
}

// @protocol HKWMentionsStateChangeDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface HKWMentionsStateChangeDelegate
{
	// @optional -(void)mentionsPlugin:(id<HKWMentionsPlugin> _Null_unspecified)plugin stateChangedTo:(HKWMentionsPluginState)newState from:(HKWMentionsPluginState)oldState;
	[Export ("mentionsPlugin:stateChangedTo:from:")]
	void StateChangedTo (HKWMentionsPlugin plugin, HKWMentionsPluginState newState, HKWMentionsPluginState oldState);

	// @optional -(void)mentionsPluginWillActivateChooserView:(id<HKWMentionsPlugin> _Null_unspecified)plugin;
	[Export ("mentionsPluginWillActivateChooserView:")]
	void MentionsPluginWillActivateChooserView (HKWMentionsPlugin plugin);

	// @optional -(void)mentionsPluginActivatedChooserView:(id<HKWMentionsPlugin> _Null_unspecified)plugin;
	[Export ("mentionsPluginActivatedChooserView:")]
	void MentionsPluginActivatedChooserView (HKWMentionsPlugin plugin);

	// @optional -(void)mentionsPluginDeactivatedChooserView:(id<HKWMentionsPlugin> _Null_unspecified)plugin;
	[Export ("mentionsPluginDeactivatedChooserView:")]
	void MentionsPluginDeactivatedChooserView (HKWMentionsPlugin plugin);

	// @optional -(void)mentionsPlugin:(id<HKWMentionsPlugin> _Null_unspecified)plugin createdMention:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity atLocation:(NSUInteger)location;
	[Export ("mentionsPlugin:createdMention:atLocation:")]
	void CreatedMention (HKWMentionsPlugin plugin, HKWMentionsEntityProtocol entity, nuint location);

	// @optional -(void)mentionsPlugin:(id<HKWMentionsPlugin> _Null_unspecified)plugin trimmedMention:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity atLocation:(NSUInteger)location;
	[Export ("mentionsPlugin:trimmedMention:atLocation:")]
	void TrimmedMention (HKWMentionsPlugin plugin, HKWMentionsEntityProtocol entity, nuint location);

	// @optional -(void)mentionsPlugin:(id<HKWMentionsPlugin> _Null_unspecified)plugin deletedMention:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity atLocation:(NSUInteger)location;
	[Export ("mentionsPlugin:deletedMention:atLocation:")]
	void DeletedMention (HKWMentionsPlugin plugin, HKWMentionsEntityProtocol entity, nuint location);

	// @optional -(void)selected:(id<HKWMentionsEntityProtocol> _Null_unspecified)entity atIndexPath:(NSIndexPath * _Null_unspecified)indexPath;
	[Export ("selected:atIndexPath:")]
	void Selected (HKWMentionsEntityProtocol entity, NSIndexPath indexPath);
}

// @protocol HKWMentionsPlugin <HKWDirectControlFlowPluginProtocol>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
[Protocol]
[BaseType(typeof(HKWDirectControlFlowPluginProtocol))]
interface HKWMentionsPlugin : HKWSimplePluginProtocol 
{
	// @required @property (nonatomic, strong) NSCharacterSet * _Nonnull controlCharacterSet;
	[Abstract]
	[Export ("controlCharacterSet", ArgumentSemantic.Strong)]
	NSCharacterSet ControlCharacterSet { get; set; }

	// @required @property (nonatomic) NSInteger implicitSearchLength;
	[Abstract]
	[Export ("implicitSearchLength")]
	nint ImplicitSearchLength { get; set; }

	// @required @property (readonly, nonatomic) BOOL implicitMentionsEnabled;
	[Abstract]
	[Export ("implicitMentionsEnabled")]
	bool ImplicitMentionsEnabled { get; }

	// @required @property (nonatomic) BOOL shouldEnableUndoUponUnregistration;
	[Abstract]
	[Export ("shouldEnableUndoUponUnregistration")]
	bool ShouldEnableUndoUponUnregistration { get; set; }

	[Wrap ("WeakDefaultChooserViewDelegate"), Abstract]
	[NullAllowed]
	HKWMentionsDefaultChooserViewDelegate DefaultChooserViewDelegate { get; set; }

	// @required @property (nonatomic, weak) id<HKWMentionsDefaultChooserViewDelegate> _Nullable defaultChooserViewDelegate;
	[Abstract]
	[NullAllowed, Export ("defaultChooserViewDelegate", ArgumentSemantic.Weak)]
	NSObject WeakDefaultChooserViewDelegate { get; set; }

	[Wrap ("WeakCustomChooserViewDelegate"), Abstract]
	[NullAllowed]
	HKWMentionsCustomChooserViewDelegate CustomChooserViewDelegate { get; set; }

	// @required @property (nonatomic, weak) id<HKWMentionsCustomChooserViewDelegate> _Nullable customChooserViewDelegate;
	[Abstract]
	[NullAllowed, Export ("customChooserViewDelegate", ArgumentSemantic.Weak)]
	NSObject WeakCustomChooserViewDelegate { get; set; }

	[Wrap ("WeakStateChangeDelegate"), Abstract]
	[NullAllowed]
	HKWMentionsStateChangeDelegate StateChangeDelegate { get; set; }

	// @required @property (nonatomic, weak) id<HKWMentionsStateChangeDelegate> _Nullable stateChangeDelegate;
	[Abstract]
	[NullAllowed, Export ("stateChangeDelegate", ArgumentSemantic.Weak)]
	NSObject WeakStateChangeDelegate { get; set; }

	// @required -(void)textViewDidProgrammaticallyUpdate:(UITextView * _Null_unspecified)textView;
	[Abstract]
	[Export ("textViewDidProgrammaticallyUpdate:")]
	void TextViewDidProgrammaticallyUpdate (UITextView textView);

	// @required -(void)textView:(UITextView * _Nonnull)textView willCustomPasteTextInRange:(NSRange)range;
	[Abstract]
	[Export ("textView:willCustomPasteTextInRange:")]
	void WillCustomPasteTextInRange (UITextView textView, NSRange range);

	// @required +(NSArray * _Null_unspecified)mentionsAttributesInAttributedString:(NSAttributedString * _Null_unspecified)attributedString;
	[Static, Abstract]
	[Export ("mentionsAttributesInAttributedString:")]
	NSObject[] MentionsAttributesInAttributedString (NSAttributedString attributedString);

	// @required -(NSArray * _Null_unspecified)mentions;
	[Abstract]
	[Export ("mentions")]
	NSObject[] Mentions { get; }

	// @required -(void)addMention:(HKWMentionsAttribute * _Null_unspecified)mention;
	[Abstract]
	[Export ("addMention:")]
	void AddMention (HKWMentionsAttribute mention);

	// @required -(void)addMentions:(NSArray * _Null_unspecified)mentions;
	[Abstract]
	[Export ("addMentions:")]
	void AddMentions (NSObject[] mentions);

	// @required @property (nonatomic) BOOL notifyTextViewDelegateOnMentionCreation;
	[Abstract]
	[Export ("notifyTextViewDelegateOnMentionCreation")]
	bool NotifyTextViewDelegateOnMentionCreation { get; set; }

	// @required @property (nonatomic) BOOL notifyTextViewDelegateOnMentionTrim;
	[Abstract]
	[Export ("notifyTextViewDelegateOnMentionTrim")]
	bool NotifyTextViewDelegateOnMentionTrim { get; set; }

	// @required @property (nonatomic) BOOL notifyTextViewDelegateOnMentionDeletion;
	[Abstract]
	[Export ("notifyTextViewDelegateOnMentionDeletion")]
	bool NotifyTextViewDelegateOnMentionDeletion { get; set; }

	// @required @property (nonatomic) BOOL resumeMentionsCreationEnabled;
	[Abstract]
	[Export ("resumeMentionsCreationEnabled")]
	bool ResumeMentionsCreationEnabled { get; set; }

	// @required @property (nonatomic) BOOL shouldContinueSearchingAfterEmptyResults;
	[Abstract]
	[Export ("shouldContinueSearchingAfterEmptyResults")]
	bool ShouldContinueSearchingAfterEmptyResults { get; set; }

	// @required -(void)dataReturnedWithEmptyResults:(BOOL)isEmptyResults keystringEndsWithWhiteSpace:(BOOL)keystringEndsWithWhiteSpace;
	[Abstract]
	[Export ("dataReturnedWithEmptyResults:keystringEndsWithWhiteSpace:")]
	void DataReturnedWithEmptyResults (bool isEmptyResults, bool keystringEndsWithWhiteSpace);

	// @required -(void)handleSelectionForEntity:(id<HKWMentionsEntityProtocol> _Nonnull)entity;
	[Abstract]
	[Export ("handleSelectionForEntity:")]
	void HandleSelectionForEntity (IHKWMentionsEntityProtocol entity);

	// @required @property (nonatomic) Class<HKWChooserViewProtocol> _Null_unspecified chooserViewClass;
	[Abstract]
	[Export ("chooserViewClass", ArgumentSemantic.Assign)]
	HKWChooserViewProtocol ChooserViewClass { get; set; }

	// @required -(CGRect)chooserViewFrame;
	[Abstract]
	[Export ("chooserViewFrame")]
	CGRect ChooserViewFrame { get; }

	// @required @property (readonly, nonatomic) UIView<HKWChooserViewProtocol> * _Null_unspecified chooserView;
	[Abstract]
	[Export ("chooserView")]
	HKWChooserViewProtocol ChooserView { get; }

	// @required @property (readonly, nonatomic) HKWMentionsChooserPositionMode chooserPositionMode;
	[Abstract]
	[Export ("chooserPositionMode")]
	HKWMentionsChooserPositionMode ChooserPositionMode { get; }

	// @required @property (nonatomic, strong) UIColor * _Nonnull chooserViewBackgroundColor;
	[Abstract]
	[Export ("chooserViewBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ChooserViewBackgroundColor { get; set; }

	// @required @property (nonatomic) UIEdgeInsets chooserViewEdgeInsets;
	[Abstract]
	[Export ("chooserViewEdgeInsets", ArgumentSemantic.Assign)]
	UIEdgeInsets ChooserViewEdgeInsets { get; set; }

	// @required @property (readonly, nonatomic) BOOL loadingCellSupported;
	[Abstract]
	[Export ("loadingCellSupported")]
	bool LoadingCellSupported { get; }

	// @required -(void)setChooserTopLevelView:(UIView * _Null_unspecified)topLevelView attachmentBlock:(void (^ _Null_unspecified)(UIView * _Null_unspecified))block;
	[Abstract]
	[Export ("setChooserTopLevelView:attachmentBlock:")]
	void SetChooserTopLevelView (UIView topLevelView, Action<UIView> block);

	// @required -(CGRect)calculatedChooserFrameForMode:(HKWMentionsChooserPositionMode)mode edgeInsets:(UIEdgeInsets)edgeInsets;
	[Abstract]
	[Export ("calculatedChooserFrameForMode:edgeInsets:")]
	CGRect CalculatedChooserFrameForMode (HKWMentionsChooserPositionMode mode, UIEdgeInsets edgeInsets);

	// @required -(unichar)getExplicitSearchControlCharacter;
	[Abstract]
	[Export ("getExplicitSearchControlCharacter")]
	ushort ExplicitSearchControlCharacter { get; }
}

// @interface HKWMentionsPluginV2 : NSObject <HKWMentionsPlugin>
[BaseType (typeof(HKWMentionsPlugin))]
interface HKWMentionsPluginV2 : HKWMentionsPlugin
{
	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode;
	[Static]
	[Export ("mentionsPluginWithChooserMode:")]
	HKWMentionsPluginV2 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet searchLength:(NSInteger)searchLength;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:searchLength:")]
	HKWMentionsPluginV2 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, nint searchLength);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet controlCharactersToPrepend:(NSCharacterSet * _Null_unspecified)controlCharactersToPrepend searchLength:(NSInteger)searchLength;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:controlCharactersToPrepend:searchLength:")]
	HKWMentionsPluginV2 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, NSCharacterSet controlCharactersToPrepend, nint searchLength);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet searchLength:(NSInteger)searchLength unhighlightedColor:(UIColor * _Null_unspecified)unhighlightedColor highlightedColor:(UIColor * _Null_unspecified)highlightedColor highlightedBackgroundColor:(UIColor * _Null_unspecified)highlightedBackgroundColor;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:searchLength:unhighlightedColor:highlightedColor:highlightedBackgroundColor:")]
	HKWMentionsPluginV2 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, nint searchLength, UIColor unhighlightedColor, UIColor highlightedColor, UIColor highlightedBackgroundColor);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet searchLength:(NSInteger)searchLength unhighlightedMentionAttributes:(NSDictionary * _Null_unspecified)unhighlightedAttributes highlightedMentionAttributes:(NSDictionary * _Null_unspecified)highlightedAttributes;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:searchLength:unhighlightedMentionAttributes:highlightedMentionAttributes:")]
	HKWMentionsPluginV2 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, nint searchLength, NSDictionary unhighlightedAttributes, NSDictionary highlightedAttributes);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet controlCharactersToPrepend:(NSCharacterSet * _Null_unspecified)controlCharactersToPrepend searchLength:(NSInteger)searchLength unhighlightedMentionAttributes:(NSDictionary * _Null_unspecified)unhighlightedAttributes highlightedMentionAttributes:(NSDictionary * _Null_unspecified)highlightedAttributes;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:controlCharactersToPrepend:searchLength:unhighlightedMentionAttributes:highlightedMentionAttributes:")]
	HKWMentionsPluginV2 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, NSCharacterSet controlCharactersToPrepend, nint searchLength, NSDictionary unhighlightedAttributes, NSDictionary highlightedAttributes);
	
	[Export("setChooserViewFactory:")]
	void SetChooserViewFactory(HKWChooserViewFactory chooserViewFactory);
}

// @protocol HKWMentionsCreationStateMachineDelegate <HKWMentionsDefaultChooserViewDelegate, HKWMentionsCustomChooserViewDelegate>
[Protocol, Model]
[BaseType(typeof(HKWMentionsDefaultChooserViewDelegate))]
interface HKWMentionsCreationStateMachineDelegate : HKWMentionsCustomChooserViewDelegate
{
	// @required @property (readonly, nonatomic) BOOL loadingCellSupported;
	[Abstract]
	[Export ("loadingCellSupported")]
	bool LoadingCellSupported { get; }

	// @required @property (readonly, nonatomic) BOOL shouldContinueSearchingAfterEmptyResults;
	[Abstract]
	[Export ("shouldContinueSearchingAfterEmptyResults")]
	bool ShouldContinueSearchingAfterEmptyResults { get; }

	// @required -(CGRect)boundsForParentEditorView;
	[Abstract]
	[Export ("boundsForParentEditorView")]
	CGRect BoundsForParentEditorView { get; }

	// @required -(CGPoint)originForParentEditorView;
	[Abstract]
	[Export ("originForParentEditorView")]
	CGPoint OriginForParentEditorView { get; }

	// @required -(void)attachViewToParentEditor:(UIView *)view origin:(CGPoint)origin mode:(HKWAccessoryViewMode)mode;
	[Abstract]
	[Export ("attachViewToParentEditor:origin:mode:")]
	void AttachViewToParentEditor (UIView view, CGPoint origin, HKWAccessoryViewMode mode);

	// @required -(void)accessoryViewStateWillChange:(BOOL)activated;
	[Abstract]
	[Export ("accessoryViewStateWillChange:")]
	void AccessoryViewStateWillChange (bool activated);

	// @required -(void)accessoryViewActivated:(BOOL)activated;
	[Abstract]
	[Export ("accessoryViewActivated:")]
	void AccessoryViewActivated (bool activated);

	// @required -(void)createMention:(HKWMentionsAttribute *)mention cursorLocation:(NSUInteger)cursorLocation;
	[Abstract]
	[Export ("createMention:cursorLocation:")]
	void CreateMention (HKWMentionsAttribute mention, nuint cursorLocation);

	// @required -(void)selected:(id<HKWMentionsEntityProtocol>)entity atIndexPath:(NSIndexPath *)indexPath;
	[Abstract]
	[Export ("selected:atIndexPath:")]
	void Selected (HKWMentionsEntityProtocol entity, NSIndexPath indexPath);

	// @required -(void)cancelMentionFromStartingLocation:(NSUInteger)location;
	[Abstract]
	[Export ("cancelMentionFromStartingLocation:")]
	void CancelMentionFromStartingLocation (nuint location);

	// @required -(HKWMentionsChooserPositionMode)chooserPositionMode;
	[Abstract]
	[Export ("chooserPositionMode")]
	HKWMentionsChooserPositionMode ChooserPositionMode { get; }

	// @required -(CGFloat)heightForSingleLineViewport;
	[Abstract]
	[Export ("heightForSingleLineViewport")]
	nfloat HeightForSingleLineViewport { get; }

	// @required -(CGFloat)positionForChooserCursorRelativeToView:(UIView *)view atLocation:(NSUInteger)location;
	[Abstract]
	[Export ("positionForChooserCursorRelativeToView:atLocation:")]
	nfloat PositionForChooserCursorRelativeToView (UIView view, nuint location);
}

public interface IHKWMentionsCreationStateMachineDelegate
{
}

// @interface HKWMentionsAttribute : NSObject <HKWMentionsEntityProtocol>
[BaseType (typeof(NSObject))]
interface HKWMentionsAttribute : IHKWMentionsEntityProtocol
{
	// @property (nonatomic, strong) NSString * mentionText;
	[Export ("mentionText", ArgumentSemantic.Strong)]
	string MentionText { get; set; }

	// @property (nonatomic, strong) NSString * entityIdentifier;
	[Export ("entityIdentifier", ArgumentSemantic.Strong)]
	string EntityIdentifier { get; set; }

	// @property (nonatomic, strong) NSDictionary * metadata;
	[Export ("metadata", ArgumentSemantic.Strong)]
	NSDictionary Metadata { get; set; }

	// @property (nonatomic) NSRange range;
	[Export ("range", ArgumentSemantic.Assign)]
	NSRange Range { get; set; }

	// +(instancetype)mentionWithText:(NSString *)text identifier:(NSString *)identifier;
	[Static]
	[Export ("mentionWithText:identifier:")]
	HKWMentionsAttribute MentionWithText (string text, string identifier);
}

// @interface HKWAttribute : NSObject
[BaseType (typeof(NSObject))]
interface HKWAttribute
{
	// @property (readonly, nonatomic) NSString * attribute;
	[Export ("attribute")]
	string Attribute { get; }

	// @property (readonly, nonatomic) id parameter;
	[Export ("parameter")]
	NSObject Parameter { get; }

	// +(instancetype)fontAttributeWithFont:(UIFont *)font;
	[Static]
	[Export ("fontAttributeWithFont:")]
	HKWAttribute FontAttributeWithFont (UIFont font);

	// +(instancetype)paragraphStyleAttributeWithStyle:(NSParagraphStyle *)style;
	[Static]
	[Export ("paragraphStyleAttributeWithStyle:")]
	HKWAttribute ParagraphStyleAttributeWithStyle (NSParagraphStyle style);

	// +(instancetype)foregroundColorAttributeWithColor:(UIColor *)color;
	[Static]
	[Export ("foregroundColorAttributeWithColor:")]
	HKWAttribute ForegroundColorAttributeWithColor (UIColor color);

	// +(instancetype)backgroundColorAttributeWithColor:(UIColor *)color;
	[Static]
	[Export ("backgroundColorAttributeWithColor:")]
	HKWAttribute BackgroundColorAttributeWithColor (UIColor color);

	// +(instancetype)ligatureAttributeWithMode:(BOOL)useLigatures;
	[Static]
	[Export ("ligatureAttributeWithMode:")]
	HKWAttribute LigatureAttributeWithMode (bool useLigatures);

	// +(instancetype)kernAttributeWithKerning:(CGFloat)kerning;
	[Static]
	[Export ("kernAttributeWithKerning:")]
	HKWAttribute KernAttributeWithKerning (nfloat kerning);

	// +(instancetype)strikethroughAttributeWithParams:(NSUInteger)params;
	[Static]
	[Export ("strikethroughAttributeWithParams:")]
	HKWAttribute StrikethroughAttributeWithParams (nuint @params);

	// +(instancetype)underlineAttributeWithParams:(NSUInteger)params;
	[Static]
	[Export ("underlineAttributeWithParams:")]
	HKWAttribute UnderlineAttributeWithParams (nuint @params);

	// +(instancetype)strokeColorAttributeWithColor:(UIColor *)color;
	[Static]
	[Export ("strokeColorAttributeWithColor:")]
	HKWAttribute StrokeColorAttributeWithColor (UIColor color);

	// +(instancetype)strokeWidthAttributeWithWidth:(CGFloat)width;
	[Static]
	[Export ("strokeWidthAttributeWithWidth:")]
	HKWAttribute StrokeWidthAttributeWithWidth (nfloat width);

	// +(instancetype)shadowAttributeWithShadow:(NSShadow *)shadow;
	[Static]
	[Export ("shadowAttributeWithShadow:")]
	HKWAttribute ShadowAttributeWithShadow (NSShadow shadow);

	// +(instancetype)textEffectAttributeWithEffect:(NSString *)effect;
	[Static]
	[Export ("textEffectAttributeWithEffect:")]
	HKWAttribute TextEffectAttributeWithEffect (string effect);

	// +(instancetype)attachmentAttributeWithAttachment:(NSTextAttachment *)attachment;
	[Static]
	[Export ("attachmentAttributeWithAttachment:")]
	HKWAttribute AttachmentAttributeWithAttachment (NSTextAttachment attachment);

	// +(instancetype)linkAttributeWithURL:(NSURL *)URL;
	[Static]
	[Export ("linkAttributeWithURL:")]
	HKWAttribute LinkAttributeWithURL (NSUrl URL);

	// +(instancetype)baselineOffsetAttributeWithOffset:(CGFloat)offset;
	[Static]
	[Export ("baselineOffsetAttributeWithOffset:")]
	HKWAttribute BaselineOffsetAttributeWithOffset (nfloat offset);

	// +(instancetype)underlineColorAttributeWithColor:(UIColor *)color;
	[Static]
	[Export ("underlineColorAttributeWithColor:")]
	HKWAttribute UnderlineColorAttributeWithColor (UIColor color);

	// +(instancetype)strikethroughColorAttributeWithColor:(UIColor *)color;
	[Static]
	[Export ("strikethroughColorAttributeWithColor:")]
	HKWAttribute StrikethroughColorAttributeWithColor (UIColor color);

	// +(instancetype)obliquenessAttributeWithObliqueness:(CGFloat)obliqueness;
	[Static]
	[Export ("obliquenessAttributeWithObliqueness:")]
	HKWAttribute ObliquenessAttributeWithObliqueness (nfloat obliqueness);

	// +(instancetype)expansionAttributeWithExpansion:(CGFloat)expansion;
	[Static]
	[Export ("expansionAttributeWithExpansion:")]
	HKWAttribute ExpansionAttributeWithExpansion (nfloat expansion);

	// +(NSDictionary *)attributeDictionaryWithAttributes:(NSArray *)attributes;
	[Static]
	[Export ("attributeDictionaryWithAttributes:")]
	//[Verify (StronglyTypedNSArray)]
	NSDictionary AttributeDictionaryWithAttributes (NSObject[] attributes);
}

// @interface HKWExternalMentionConstants : NSObject
[BaseType (typeof(NSObject))]
interface HKWExternalMentionConstants
{
	// @property (readonly, nonatomic, class) NSCharacterSet * _Nonnull atSymbols;
	[Static]
	[Export ("atSymbols")]
	NSCharacterSet AtSymbols { get; }
}

// @interface HKWMentionsCreationStateMachine : NSObject
[BaseType (typeof(NSObject))]
interface HKWMentionsCreationStateMachine
{
	// @property (nonatomic, strong) UIColor * _Nonnull chooserViewBackgroundColor;
	[Export ("chooserViewBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ChooserViewBackgroundColor { get; set; }

	// @property (nonatomic) UIEdgeInsets chooserViewEdgeInsets;
	[Export ("chooserViewEdgeInsets", ArgumentSemantic.Assign)]
	UIEdgeInsets ChooserViewEdgeInsets { get; set; }

	// @property (nonatomic) Class<HKWChooserViewProtocol> _Nonnull chooserViewClass;
	[Export ("chooserViewClass", ArgumentSemantic.Assign)]
	HKWChooserViewProtocol ChooserViewClass { get; set; }

	// @property (nonatomic) unichar explicitSearchControlCharacter;
	[Export ("explicitSearchControlCharacter")]
	ushort ExplicitSearchControlCharacter { get; set; }

	// -(void)dataReturnedWithEmptyResults:(BOOL)isEmptyResults keystringEndsWithWhiteSpace:(BOOL)keystringEndsWithWhiteSpace;
	[Export ("dataReturnedWithEmptyResults:keystringEndsWithWhiteSpace:")]
	void DataReturnedWithEmptyResults (bool isEmptyResults, bool keystringEndsWithWhiteSpace);

	// -(void)characterTyped:(unichar)c;
	[Export ("characterTyped:")]
	void CharacterTyped (ushort c);

	// -(void)validStringInserted:(NSString * _Nonnull)string;
	[Export ("validStringInserted:")]
	void ValidStringInserted (string @string);

	// -(void)stringDeleted:(NSString * _Nonnull)deleteString;
	[Export ("stringDeleted:")]
	void StringDeleted (string deleteString);

	// -(void)cursorMoved;
	[Export ("cursorMoved")]
	void CursorMoved ();

	// -(void)mentionCreationStartedWithPrefix:(NSString * _Nonnull)prefix usingControlCharacter:(BOOL)usingControlCharacter controlCharacter:(unichar)character location:(NSUInteger)location;
	[Export ("mentionCreationStartedWithPrefix:usingControlCharacter:controlCharacter:location:")]
	void MentionCreationStartedWithPrefix (string prefix, bool usingControlCharacter, ushort character, nuint location);

	// -(void)cancelMentionCreation;
	[Export ("cancelMentionCreation")]
	void CancelMentionCreation ();

	// -(void)setupChooserViewIfNeeded;
	[Export ("setupChooserViewIfNeeded")]
	void SetupChooserViewIfNeeded ();

	// -(void)resetChooserView;
	[Export ("resetChooserView")]
	void ResetChooserView ();

	// -(void)hideChooserArrow;
	[Export ("hideChooserArrow")]
	void HideChooserArrow ();

	// -(void)fetchInitialMentions;
	[Export ("fetchInitialMentions")]
	void FetchInitialMentions ();

	// -(CGRect)chooserViewFrame;
	[Export ("chooserViewFrame")]
	//[Verify (MethodToProperty)]
	CGRect ChooserViewFrame { get; }

	// -(UIView<HKWChooserViewProtocol> * _Nonnull)getEntityChooserView;
	[Export ("getEntityChooserView")]
	//[Verify (MethodToProperty)]
	HKWChooserViewProtocol EntityChooserView { get; }

	// -(CGRect)frameForMode:(HKWMentionsChooserPositionMode)mode;
	[Export ("frameForMode:")]
	CGRect FrameForMode (HKWMentionsChooserPositionMode mode);

	// -(void)showChooserView;
	[Export ("showChooserView")]
	void ShowChooserView ();

	// -(void)handleSelectionForEntity:(id<HKWMentionsEntityProtocol> _Nonnull)entity indexPath:(NSIndexPath * _Nonnull)indexPath;
	[Export ("handleSelectionForEntity:indexPath:")]
	void HandleSelectionForEntity (HKWMentionsEntityProtocol entity, NSIndexPath indexPath);

	// -(void)reloadChooserView;
	[Export ("reloadChooserView")]
	void ReloadChooserView ();

	// +(instancetype _Nonnull)stateMachineWithDelegate:(id<HKWMentionsCreationStateMachineDelegate> _Nonnull)delegate isUsingCustomChooserView:(BOOL)isUsingCustomChooserView;
	[Static]
	[Export ("stateMachineWithDelegate:isUsingCustomChooserView:")]
	HKWMentionsCreationStateMachine StateMachineWithDelegate (HKWMentionsCreationStateMachineDelegate @delegate, bool isUsingCustomChooserView);
}

// @interface HKWMentionDataProvider : NSObject <UITableViewDataSource, UITableViewDelegate>
[BaseType (typeof(NSObject))]
interface HKWMentionDataProvider : IUITableViewDataSource, IUITableViewDelegate
{
	// -(instancetype _Nonnull)initWithStateMachine:(HKWMentionsCreationStateMachine * _Nonnull)stateMachine delegate:(id<HKWMentionsCreationStateMachineDelegate> _Nonnull)delegate;
	[Export ("initWithStateMachine:delegate:")]
	NativeHandle Constructor (HKWMentionsCreationStateMachine stateMachine, HKWMentionsCreationStateMachineDelegate @delegate);

	// -(void)queryUpdatedWithKeyString:(NSString * _Nonnull)string searchType:(HKWMentionsSearchType)type isWhitespace:(BOOL)isWhitespace controlCharacter:(unichar)character;
	[Export ("queryUpdatedWithKeyString:searchType:isWhitespace:controlCharacter:")]
	void QueryUpdatedWithKeyString (string @string, HKWMentionsSearchType type, bool isWhitespace, ushort character);
}

// @interface HKWMentionsPluginV1 : NSObject <HKWMentionsPlugin>
[BaseType (typeof(HKWMentionsPlugin))]
interface HKWMentionsPluginV1 : HKWMentionsPlugin
{
	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode;
	[Static]
	[Export ("mentionsPluginWithChooserMode:")]
	HKWMentionsPluginV1 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet searchLength:(NSInteger)searchLength;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:searchLength:")]
	HKWMentionsPluginV1 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, nint searchLength);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet searchLength:(NSInteger)searchLength unselectedColor:(UIColor * _Null_unspecified)unselectedColor selectedColor:(UIColor * _Null_unspecified)selectedColor selectedBackgroundColor:(UIColor * _Null_unspecified)selectedBackgroundColor;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:searchLength:unselectedColor:selectedColor:selectedBackgroundColor:")]
	HKWMentionsPluginV1 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, nint searchLength, UIColor unselectedColor, UIColor selectedColor, UIColor selectedBackgroundColor);

	// +(instancetype _Nonnull)mentionsPluginWithChooserMode:(HKWMentionsChooserPositionMode)mode controlCharacters:(NSCharacterSet * _Null_unspecified)controlCharacterSet searchLength:(NSInteger)searchLength unselectedMentionAttributes:(NSDictionary * _Null_unspecified)unselectedAttributes selectedMentionAttributes:(NSDictionary * _Null_unspecified)selectedAttributes;
	[Static]
	[Export ("mentionsPluginWithChooserMode:controlCharacters:searchLength:unselectedMentionAttributes:selectedMentionAttributes:")]
	HKWMentionsPluginV1 MentionsPluginWithChooserMode (HKWMentionsChooserPositionMode mode, NSCharacterSet controlCharacterSet, nint searchLength, NSDictionary unselectedAttributes, NSDictionary selectedAttributes);
}

// @interface HKWLayoutManager : NSLayoutManager
[BaseType (typeof(NSLayoutManager))]
interface HKWLayoutManager
{
}

// @protocol HKWMentionsStartDetectionStateMachineProtocol <NSObject>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol, Model]
[BaseType (typeof(NSObject))]
interface HKWMentionsStartDetectionStateMachineProtocol
{
	// @required -(NSCharacterSet *)controlCharacterSet;
	[Abstract]
	[Export ("controlCharacterSet")]
	//[Verify (MethodToProperty)]
	NSCharacterSet ControlCharacterSet { get; }

	// @required -(NSInteger)implicitSearchLength;
	[Abstract]
	[Export ("implicitSearchLength")]
	//[Verify (MethodToProperty)]
	nint ImplicitSearchLength { get; }

	// @required -(void)beginMentionsCreationWithString:(NSString *)prefix alreadyInserted:(BOOL)alreadyInserted usingControlCharacter:(BOOL)usingControlCharacter controlCharacter:(unichar)character;
	[Abstract]
	[Export ("beginMentionsCreationWithString:alreadyInserted:usingControlCharacter:controlCharacter:")]
	void AlreadyInserted (string prefix, bool alreadyInserted, bool usingControlCharacter, ushort character);

	// @required -(void)beginMentionsCreationWithString:(NSString *)prefix atLocation:(NSUInteger)location usingControlCharacter:(BOOL)usingControlCharacter controlCharacter:(unichar)character;
	[Abstract]
	[Export ("beginMentionsCreationWithString:atLocation:usingControlCharacter:controlCharacter:")]
	void AtLocation (string prefix, nuint location, bool usingControlCharacter, ushort character);
}

// @interface HKWMentionsStartDetectionStateMachine : NSObject
[BaseType (typeof(NSObject))]
interface HKWMentionsStartDetectionStateMachine
{
	// +(instancetype)stateMachineWithDelegate:(id<HKWMentionsStartDetectionStateMachineProtocol>)delegate;
	[Static]
	[Export ("stateMachineWithDelegate:")]
	HKWMentionsStartDetectionStateMachine StateMachineWithDelegate (HKWMentionsStartDetectionStateMachineProtocol @delegate);

	// -(void)validStringInserted:(NSString *)string atLocation:(NSUInteger)location usingControlCharacter:(BOOL)usingControlCharacter controlCharacter:(unichar)character;
	[Export ("validStringInserted:atLocation:usingControlCharacter:controlCharacter:")]
	void ValidStringInserted (string @string, nuint location, bool usingControlCharacter, ushort character);

	// -(void)characterTyped:(unichar)c asInsertedCharacter:(BOOL)inserted previousCharacter:(unichar)previousCharacter wordFollowingTypedCharacter:(NSString *)wordFollowingTypedCharacter;
	[Export ("characterTyped:asInsertedCharacter:previousCharacter:wordFollowingTypedCharacter:")]
	void CharacterTyped (ushort c, bool inserted, ushort previousCharacter, string wordFollowingTypedCharacter);

	// -(void)deleteTypedCharacter:(unichar)deletedChar withCharacterNowPrecedingCursor:(unichar)precedingChar location:(NSUInteger)location textViewText:(NSString *)textViewText;
	[Export ("deleteTypedCharacter:withCharacterNowPrecedingCursor:location:textViewText:")]
	void DeleteTypedCharacter (ushort deletedChar, ushort precedingChar, nuint location, string textViewText);

	// -(void)cursorMovedWithCharacterNowPrecedingCursor:(unichar)c;
	[Export ("cursorMovedWithCharacterNowPrecedingCursor:")]
	void CursorMovedWithCharacterNowPrecedingCursor (ushort c);

	// -(void)mentionCreationEnded:(BOOL)canImmediatelyRestart;
	[Export ("mentionCreationEnded:")]
	void MentionCreationEnded (bool canImmediatelyRestart);

	// -(void)mentionCreationResumed;
	[Export ("mentionCreationResumed")]
	void MentionCreationResumed ();

	// -(void)resetStateUsingString:(NSString *)string;
	[Export ("resetStateUsingString:")]
	void ResetStateUsingString (string @string);

	// +(NSString *)wordAfterLocation:(NSUInteger)location text:(NSString *)text;
	[Static]
	[Export ("wordAfterLocation:text:")]
	string WordAfterLocation (nuint location, string text);
}

// @interface HKWChooserViewFactory : NSObject
[BaseType (typeof(NSObject))]
[Protocol, Model]
interface HKWChooserViewFactory
{
	//- (id<HKWChooserViewProtocol>)chooserViewWithFrame:(CGRect)frame;
	[Abstract]
	[Export("chooserViewWithFrame:")]
	IHKWChooserViewProtocol ChooserViewWithFrame (CGRect frame);
}