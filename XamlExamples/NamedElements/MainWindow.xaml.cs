using System.Windows;

namespace NamedElements
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
        private void RemoveThis_Click(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)e.Source;

            if (buttonContainer.Children.Contains(element))
                buttonContainer.Children.Remove(element);
        }
    }
}
