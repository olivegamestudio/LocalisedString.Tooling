﻿using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using Utility.Toolkit;

namespace LocalisedString;

public partial class LocaleStringViewModel : ObservableObject<LocaleStringItem>
{
    public LocaleStringViewModel(LocaleStringItem item) : base(item)
    {
        Culture = item.Culture;
        Text = item.Text;
    }

    [ObservableProperty]
    CultureInfo _culture;

    partial void OnCultureChanged(CultureInfo value)
    {
        Model.Culture = value;
    }

    [ObservableProperty]
    string _text;

    partial void OnTextChanged(string value)
    {
        Model.Text = value;
    }
}
