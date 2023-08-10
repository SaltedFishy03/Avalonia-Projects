using System;
using Avalonia.Controls;
using Avalonia.Dialogs.Internal;
using Avalonia.Interactivity;
using Avalonia.Remote.Protocol.Input;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    
    
    
    bool isClicked = false;

    public MainWindow()
    {
        InitializeComponent();
        NewWindow.Navigate(new MyUserControl());
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;
        isClicked = !isClicked;
        button.Content = isClicked ? "Clicked!" : "Click me!";
    }

    private void TitleChanged(object? sender, SelectionChangedEventArgs e)
    {
        ComboBox cb = (ComboBox)sender;
        ComboBoxItem item = (ComboBoxItem)cb.SelectedItem;
        Title = item.Content.ToString();
    }

    private void MultipleDates(object? sender, SelectionChangedEventArgs e)
    {
        if (cal.SelectedDates.Count > 4)
        {
            cal.IsVisible = false;
        }
    }

    private void TextBox_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (sender is TextBox tb)
        {
            try
            {

                tb.FontSize = int.Parse(tb.Text) * 10;
            }
            catch (Exception exception)
            {

            }

        }
        
    }

    private void onMouseClicked(object? sender, MouseClickEventArgs e)
    {
    }

    private void Button_Navigate(object? sender, RoutedEventArgs e)
    {
        NewWindow.Navigate(new MyOwnButton());
    }
}