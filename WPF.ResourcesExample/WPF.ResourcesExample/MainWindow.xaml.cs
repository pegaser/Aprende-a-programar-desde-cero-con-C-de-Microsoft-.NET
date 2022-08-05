using System;
using System.Windows;
using System.Windows.Media;

namespace WPF.ResourcesExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush brush = (ImageBrush)this.Resources["TileBrush"];
            brush.Viewport = new Rect(0, 0, 5, 5);
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("MyWpfLibrary;component/MyDictionary.xaml", UriKind.Relative);
            btnPink.Background = (Brush)resourceDictionary["brushPink"];

        }

        private void btnChangeResource_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["TileBrush"] = new SolidColorBrush(Colors.LightBlue);
        }

        private void btnOpenWindow2_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow otherWindow = new SecondWindow();
            otherWindow.Show();
        }
    }
}
