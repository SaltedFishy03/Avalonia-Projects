using System;
using System.Diagnostics;

namespace AvaloniaApplication1;

public class MouseClickEventArgs: EventArgs
{
    public int MouseButton { get; set; }

    
}

public delegate void MouseClickEventHandler(object? sender, MouseClickEventArgs e);