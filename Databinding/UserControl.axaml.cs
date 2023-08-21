using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Databinding;

public partial class UserControl1 : UserControl
{
    
    public string Username { get; set; }
    public string Password { get; set; }
    public string Password2 { get; set; }

    public UserControl1()
    {
        InitializeComponent();
        DataContext = this;
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Username = "";
        Password = "";
        Password2 = "";
        
        username.Text = Username;
        pwd1.Text = Password;
        pwd2.Text = Password2;

    }


}