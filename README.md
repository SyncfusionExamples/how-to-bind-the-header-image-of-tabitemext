# WPF TabControlExt Header Image Binding

This sample demonstrates how to bind an **image** to the header of a `TabItemExt` in a WPF application using Syncfusion's `TabControlExt`. The image is displayed alongside the tab header text, providing a visually enhanced tab interface.

## Features in This Sample
- **Image Binding**: Binds an image source from the ViewModel to the `Image` property of `TabItemExt`.
- **Image Alignment**: Positions the image relative to the header text using the `ImageAlignment` property.
- **MVVM Support**: Implements data binding for clean separation of UI and logic.

## Key Properties Used
- **Image**: Specifies the image source for the tab header.
- **ImageAlignment**: Defines the position of the image (e.g., `LeftOfText`).

## XAML Overview
```xml
<Window
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:local="clr-namespace:TabControlExtSample1"
    xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
    x:Class="TabControlExtSample1.MainWindow"
    mc:Ignorable="d"
    Title="MainWindow" Height="350" Width="525">

    <Window.DataContext>
        <local:ViewModel />
    </Window.DataContext>

    <Grid>
        <syncfusion:TabControlExt x:Name="tabcontrol" Grid.Row="1">
            <!-- Binding Image -->
            <syncfusion:TabItemExt Header="Tab 1" Image="{Binding DisplayedImage}" ImageAlignment="LeftOfText" x:Name="tabitem1" />
            <syncfusion:TabItemExt Header="Tab 2" />
            <syncfusion:TabItemExt Header="Tab 3" />
            <syncfusion:TabItemExt Header="Tab 4" />
        </syncfusion:TabControlExt>
    </Grid>
</Window>
```

## How It Works
1. The `ViewModel` exposes a property `DisplayedImage` that holds the image source.
2. The first tab binds its `Image` property to `DisplayedImage` and sets `ImageAlignment` to `LeftOfText`.
3. Other tabs display only text headers.

## Benefits
- Enhances tab headers with visual elements.
- Fully supports MVVM for maintainable and testable code.

## Documentation
For more details, refer to the official Syncfusion Knowledge Base article:  
[How to Bind the Header Image of TabItemExt](https://support.syncfusion.com/kb/article/7881/how-to-bind-the-header-image-of-tabitemext)

