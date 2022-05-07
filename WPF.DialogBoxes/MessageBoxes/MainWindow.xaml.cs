using System.Windows;

namespace MessageBoxes
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
            var result = MessageBox.Show("¿Quieres continuar?", 
                "Pregunta", 
                MessageBoxButton.YesNo, 
                MessageBoxImage.Question, 
                MessageBoxResult.Yes);
            if(result == MessageBoxResult.Yes)
                MessageBox.Show("Seleccionaste SI","Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.No)
                MessageBox.Show("Seleccionaste NO");
        }
    }
}
