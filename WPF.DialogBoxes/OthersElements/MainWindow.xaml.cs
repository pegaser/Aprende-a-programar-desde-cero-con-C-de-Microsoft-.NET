using System.Windows;

namespace OthersElements
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var marginsWindow = new Margins();

            marginsWindow.Closed += (sender, eventArgs) =>
            {
                MessageBox.Show($"You closed the margins window! It had the title of {marginsWindow.Title}");
            };

            marginsWindow.Show();

        }
    }
}
