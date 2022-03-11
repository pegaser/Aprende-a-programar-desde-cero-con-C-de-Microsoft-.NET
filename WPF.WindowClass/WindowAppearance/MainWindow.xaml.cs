using System.Windows;

namespace WindowAppearance
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

        private void ResizeModeButton_Click(object sender, RoutedEventArgs e)
        {
            SizeModeWindow sizeModeWindow = new SizeModeWindow();   
            sizeModeWindow.Show();
        }

        private void NonRectangularButton_Click(object sender, RoutedEventArgs e)
        {
            NonRectangularWindow nonRectangularWindow = new NonRectangularWindow();
            nonRectangularWindow.Show();
        }

    }
}
