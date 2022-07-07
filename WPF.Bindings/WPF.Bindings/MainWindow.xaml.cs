using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPF.Bindings
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

        private void btnSmall_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 8;
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 16;
        }

        private void btnLarge_Click(object sender, RoutedEventArgs e)
        {
            //sliderFontSize.Value = 30;
            lblSampleText.FontSize = 30;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Binding binding = new Binding();
            //binding.Source = sliderFontSize;
            //binding.Path = new PropertyPath("Value");
            //binding.Mode = BindingMode.TwoWay;
            //lblSampleText.SetBinding(TextBlock.FontSizeProperty, binding);

            //BindingOperations.ClearAllBindings(lblSampleText);

            Binding binding2 = BindingOperations.GetBinding(lblSampleText, TextBlock.FontSizeProperty);
        }

    }
}
