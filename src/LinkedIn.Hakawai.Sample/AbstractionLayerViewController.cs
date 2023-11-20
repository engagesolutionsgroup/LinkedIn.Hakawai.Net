﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using LinkedIn.Hakawai;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace LinkedIn.Hakawai.Sample;

public partial class AbstractionLayerViewController : UIViewController
{
    private SampleAbstractionLayerPlugin abstractionLayerPlugin;

    public AbstractionLayerViewController(IntPtr handle) : base(handle)
    {
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        var textView = EditorTextView;
        // Add a border to the text view to make it look nicer
        textView.Layer.BorderWidth = 0.5f;
        textView.Layer.BorderColor = UIColor.LightGray.CGColor;

        ConsoleTextView.Layer.BorderWidth = 0.5f;
        ConsoleTextView.Layer.BorderColor = UIColor.LightGray.CGColor;

        // Set up the plug-in
        abstractionLayerPlugin = new SampleAbstractionLayerPlugin()
        {
            ChangesEnabled = true,
            WriteToParentTextView = WriteToConsoleTextView
        };

        textView.AbstractionControlFlowPlugin = abstractionLayerPlugin;
    }

    private void WriteToConsoleTextView(string obj)
    {
        ConsoleTextView.Text += obj + "\n";
    }

    public class SampleAbstractionLayerPlugin : HKWAbstractionLayerControlFlowPluginProtocol
    {
        public SampleAbstractionLayerPlugin()
        {
        }

        protected SampleAbstractionLayerPlugin(NSObjectFlag t) : base(t)
        {
        }

        protected internal SampleAbstractionLayerPlugin(NativeHandle handle) : base(handle)
        {
        }

        public bool ChangesEnabled { get; set; }
        public Action<string> WriteToParentTextView { get; set; }

        public override bool TextInserted(UITextView textView, string text, UIntPtr location, bool autocorrect)
        {
            if (ChangesEnabled)
                WriteToParentTextView?.Invoke($"TextInserted {text} at location {location} autocorrect {autocorrect}");

            return ChangesEnabled;
        }

        public override bool ReplacedTextAtRange(UITextView textView, NSRange replacementRange, string newText,
            bool autocorrect)
        {
            if (ChangesEnabled)
                WriteToParentTextView?.Invoke(
                    $"ReplacedTextAtRange {replacementRange} with {newText} autocorrect {autocorrect}");

            return ChangesEnabled;
        }

        public override void CursorChangedToInsertion(UITextView textView, UIntPtr location)
        {
            WriteToParentTextView?.Invoke($"CursorChangedToInsertion {location}");
        }

        public override void CursorChangedToSelection(UITextView textView, NSRange selectionRange)
        {
            WriteToParentTextView?.Invoke(
                $"CursorChangedToSelection {selectionRange.Location} {selectionRange.Length}");
        }

        public override void CharacterDeletionWasIgnoredAtLocation(UITextView textView, UIntPtr location)
        {
        }
    }
}