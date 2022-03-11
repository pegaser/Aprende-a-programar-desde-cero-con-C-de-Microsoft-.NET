using System.Windows;

namespace LocationWindow
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Left: {this.Left} Top: {this.Top}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowTopMost window = new WindowTopMost();
            window.Topmost = true;
            window.Show();  
        }
    }
}
