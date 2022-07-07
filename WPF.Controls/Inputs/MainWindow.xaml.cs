using System.Windows;
using System.Windows.Documents;

namespace Inputs
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
            txtMyTextBox.Text = "Hola desde CodeBehind";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FlowDocument flowDocument = new FlowDocument();
            flowDocument.Blocks.Add(new Paragraph(new Run("Saludos desde CodeBehind")));

            rtbMyRichTextBox.Document = flowDocument;
        }

        private void pbxMyPassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pbxMyPassBox.Password);
        }
    }
}
