using System.Windows;

namespace WPF.DialogBoxHomework
{
    /// <summary>
    /// Lógica de interacción para LoginDialogBox.xaml
    /// </summary>
    public partial class LoginDialogBox : Window
    {
        public LoginDialogBox()
        {
            InitializeComponent();
        }

        private void Button_Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult=false;
        }
    }
}
