using System.Windows;

namespace CommonDialogBoxes
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

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document"; 
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                MessageBox.Show($"Aqui abririamos el archivo {dialog.FileName}");
            }

        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                MessageBox.Show($"Aqui guardariamos el archivo {dialog.FileName}");
            }

        }

        private void btnConfigurePrinter_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Controls.PrintDialog();
            dialog.PageRangeSelection = System.Windows.Controls.PageRangeSelection.AllPages;
            dialog.UserPageRangeEnabled = true;

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                MessageBox.Show("El documento fue impreso.");
            }
            else
            {
                MessageBox.Show("No se imprimió el documento.");
            }
        }
    }
}
