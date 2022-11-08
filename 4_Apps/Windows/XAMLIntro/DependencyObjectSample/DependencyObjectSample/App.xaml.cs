﻿using Microsoft.UI.Xaml;

namespace DependencyObjectSample;

public partial class App : Application
{
    public App() => InitializeComponent();

    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        _window = new MainWindow();
        _window.Activate();
    }

    private Window? _window;
}
