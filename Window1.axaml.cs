using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RegistrationForm;

public partial class Window1 : Window
{
    private string _name;
    private string _email;
    private string _phone;
    private string _password;
    public Window1(string name, string email, string phone, string password)
    {
        InitializeComponent();
        _name = name;
        _email = email;
        _phone = phone;
        _password = password;
        this.name.Text = _name;
        this.email.Text = _email;
        this.phone.Text = _phone;
        this.password.Text = _password;
    }
}