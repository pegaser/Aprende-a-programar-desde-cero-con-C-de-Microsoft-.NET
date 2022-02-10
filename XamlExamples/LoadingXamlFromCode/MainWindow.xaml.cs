using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;

namespace LoadingXamlFromCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Create the Button.
            Button originalButton = new Button();
            originalButton.Height = 50;
            originalButton.Width = 100;
            originalButton.Background = Brushes.AliceBlue;
            originalButton.Content = "Click Me";

            // Save the Button to a string.
            string savedButton = XamlWriter.Save(originalButton);

            // Load the button
            StringReader stringReader = new StringReader(savedButton);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Button readerLoadButton = (Button)XamlReader.Load(xmlReader);
        }
    }
}
