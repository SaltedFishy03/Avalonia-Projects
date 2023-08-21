using Avalonia.Controls;

namespace Databinding;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }
}