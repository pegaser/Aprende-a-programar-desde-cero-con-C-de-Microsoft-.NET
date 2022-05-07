using System.Windows;

namespace WPF.DialogBoxHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            LoginDialogBox login = new LoginDialogBox();
            bool? result = login.ShowDialog();
            if(result == true)
            {
                MessageBox.Show("Excelente, pásale!!!");
                this.WindowState=WindowState.Normal;
            }
            else
            {
                MessageBox.Show("Lo lamento, adios!!!");
                this.Close();
            }

        }
    }
}
