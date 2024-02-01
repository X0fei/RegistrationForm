using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RegistrationForm
{
    public partial class MainWindow : Window
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _password;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ButtonClicked(object source, RoutedEventArgs args)
        {
            _name = name.Text;
            _email = email.Text;
            _phone = phone.Text;
            _password = password.Text;
            if (name.Text != null && email.Text != null && phone.Text != null && password.Text != null && termsOfService.IsChecked == true)
            {
                new Window1(_name, _email, _phone, _password).Show();
                Close();
            }
        }
    }
}