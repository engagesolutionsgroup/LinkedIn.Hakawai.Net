﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using UIKit;

namespace LinkedIn.Hakawai.Sample;

public partial class MentionTableViewCell : UITableViewCell
{
    public MentionTableViewCell()
    {
    }

    public MentionTableViewCell(IntPtr handle) : base(handle)
    {
    }

    public void SetText(string name)
    {
        MainLabel.Text = name;
    }
}