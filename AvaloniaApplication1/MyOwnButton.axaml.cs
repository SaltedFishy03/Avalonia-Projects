using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class MyOwnButton : UserControl
{
    public event MouseClickEventHandler MouseClicked;
    
    public MyOwnButton()
    {
        InitializeComponent();
        PointerReleased += OnClick;
    }
    

    void OnClick(object o, PointerReleasedEventArgs e)
    {
        MouseClickEventArgs mouseClickEventArgs = new MouseClickEventArgs();
        switch (e.InitialPressMouseButton)
        {
            case MouseButton.Left:
                mouseClickEventArgs.MouseButton = 1;
                break;
            case MouseButton.Right:
                mouseClickEventArgs.MouseButton = 2;
                break;
            case MouseButton.Middle:
                mouseClickEventArgs.MouseButton = 3;
                break;
        }

        MouseClicked?.Invoke(this, mouseClickEventArgs);
        
    }
    
}

