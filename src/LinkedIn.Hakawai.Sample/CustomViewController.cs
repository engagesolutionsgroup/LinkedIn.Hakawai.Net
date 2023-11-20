﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using LinkedIn.Hakawai;
using ObjCRuntime;
using UIKit;

namespace LinkedIn.Hakawai.Sample;

public partial class CustomViewController : UIViewController
{
    private HKWMentionsPluginV2 mentionsPlugin;

    public CustomViewController(IntPtr handle) : base(handle)
    {
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        var characterSet = NSCharacterSet.FromString("@+＠");

        HKWTextView.EnableMentionsPluginV2 = true;
        mentionsPlugin =
            HKWMentionsPluginV2.MentionsPluginWithChooserMode(
                HKWMentionsChooserPositionMode.CustomLockBottomNoArrow,
                characterSet, 1);

        // If the text view loses focus while the mention chooser is up, and then regains focus, it will automatically put
        //  the mentions chooser back up

        // Add edge insets so chooser view doesn't overlap the text view's cosmetic grey border
        //mentionsPlugin.ChooserViewEdgeInsets = new UIEdgeInsets(2f, 0.5f, 0.5f, 0.5f);

        MyTextView.ControlFlowPlugin = mentionsPlugin;

        var mentionsManager = new MentionsManager(MentionTableView);

        mentionsPlugin.CustomChooserViewDelegate = mentionsManager;
        mentionsPlugin.StateChangeDelegate = new MentionsStateChangeDelegate(MentionTableView);

        MentionTableView.Source = new MentionTableViewSource()
        {
            OnSelected = OnSelected
        };

        MyTextView.SetOnAccessoryViewAttachmentBlock((UIView view, bool enabled) =>
        {
            Console.WriteLine(view?.ToString() ?? "NULL");
            Console.WriteLine(enabled.ToString());
        });
    }

    private void OnSelected(MentionEntity obj)
    {
        mentionsPlugin.HandleSelectionForEntity(obj);
    }
}

public class MentionTableViewSource : UITableViewSource
{
    public Action<MentionEntity> OnSelected { get; set; }
    public List<MentionEntity> Source { get; set; } = new();

    public override IntPtr RowsInSection(UITableView tableView, IntPtr section)
    {
        return Source.Count;
    }

    public override IntPtr NumberOfSections(UITableView tableView)
    {
        return 1;
    }

    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
    {
        var mentionTableViewCell = tableView.DequeueReusableCell("MentionTableViewCell") as MentionTableViewCell;
        mentionTableViewCell!.SetText(Source.ElementAtOrDefault(indexPath.Row)?.Name);
        return mentionTableViewCell;
    }

    public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
    {
        tableView.DeselectRow(indexPath, true);
        if (Source.ElementAtOrDefault(indexPath.Row) is { } elementAtOrDefault)
            OnSelected?.Invoke(elementAtOrDefault);
    }
}

public class MentionsStateChangeDelegate : HKWMentionsStateChangeDelegate
{
    private readonly UITableView _mentionTableView;

    public MentionsStateChangeDelegate(UITableView mentionTableView)
    {
        _mentionTableView = mentionTableView;
    }

    public override void Selected(HKWMentionsEntityProtocol entity, NSIndexPath indexPath)
    {
        // base.Selected(entity, indexPath);
    }

    public override void MentionsPluginActivatedChooserView(HKWMentionsPlugin plugin)
    {
        base.MentionsPluginActivatedChooserView(plugin);
    }

    public override void MentionsPluginDeactivatedChooserView(HKWMentionsPlugin plugin)
    {
        base.MentionsPluginDeactivatedChooserView(plugin);
    }
}

public class MentionsManager : HKWMentionsCustomChooserViewDelegate
{
    private readonly UITableView _tableView;
    private readonly List<MentionEntity> fakeData;

    public MentionsManager(UITableView tableView)
    {
        _tableView = tableView;
        fakeData = Helpers.MentionEntities;
    }

    public override void DidUpdateKeyString(string keyString, ushort character)
    {
        var filtered = fakeData.Where(x => x.Name.Contains(keyString)).ToList();
        if (_tableView.Source is MentionTableViewSource mentionTableViewSource)
        {
            mentionTableViewSource.Source = filtered;
            _tableView.ReloadData();
        }
    }

    public override bool EntityCanBeTrimmed(HKWMentionsEntityProtocol entity)
    {
        return false;
    }
}

[Register("MentionEntity")]
public class MentionEntity : HKWMentionsEntityProtocol
{
    public MentionEntity(NativeHandle handle) : base(handle)
    {
    }

    public MentionEntity(string name, string entityId)
    {
        Name = name;
        Id = entityId;
    }

    public string Name { get; set; }
    public string Id { get; set; }

    [Export("entityId")]
    public NSString EntityId()
    {
        return new NSString(Id);
    }

    [Export("entityName")]
    public NSString EntityName()
    {
        return new NSString(Name);
    }

    [Export("entityMetadata")] public NSDictionary EntityMetadata => null;

    // Define a constructor that takes two parameters: name and entityId
    // Assign the parameters to the properties
}