using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RegistrationForm;

public partial class Window1 : Window
{
    public string me { get; set; }
    //private string _email { get; set; }
    //private string _phone { get; set; }
    //private string _password { get; set; }
    public Window1(string me)
    {
        InitializeComponent();
        ame.Text = me;
        //_email = email;
        //_phone = phone;
        //_password = password;
    }
}