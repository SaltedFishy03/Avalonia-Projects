using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AvaloniaApplication1;

public partial class NewWindow : UserControl
{
    static NewWindow? Instance;

    public NewWindow()
    {
        InitializeComponent();
        if (Instance == null)
        {
            Instance = this;
        }
    }
    

 

    public static void Navigate(UserControl control)
    {
        if (Instance == null)
        {
            return;
        }
        Instance.Content = control;
    }
}