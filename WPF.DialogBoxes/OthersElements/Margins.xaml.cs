using System.Windows;

namespace OthersElements
{
    /// <summary>
    /// Lógica de interacción para Margins.xaml
    /// </summary>
    public partial class Margins : Window
    {
        public Margins()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            //DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            //DialogResult = false;
        }
    }
}
