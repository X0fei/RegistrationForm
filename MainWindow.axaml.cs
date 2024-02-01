using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RegistrationForm
{
    public partial class MainWindow : Window
    {
        public string Name { get; set; }
        //public string _email { get; set; }
        //public string _phone { get; set; }
        //public string _password { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ButtonClicked(object source, RoutedEventArgs args)
        {
            Name = name.Text;
            //_email = email.Text;
            //_phone = phone.Text;
            //_password = password.Text;
            //if (name.Text != null && email.Text != null && phone.Text != null && password.Text != null && termsOfService.IsChecked == true)
            //{
                new Window1(Name).Show();
                Close();
            //}
        }
    }
}