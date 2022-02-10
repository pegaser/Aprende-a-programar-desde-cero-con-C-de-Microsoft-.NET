using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EventsAndCodebehind
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
            var buttonControl = (Button)e.Source;
            buttonControl.Foreground = Brushes.Red;
        }
    }
}
