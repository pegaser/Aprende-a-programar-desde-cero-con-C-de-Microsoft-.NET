using System;
using System.Windows;
using System.Windows.Media;

namespace Buttons
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
        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Red;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Red;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Purple;
            btn2.Background = Brushes.GreenYellow;
        }

        void Increase(object sender, RoutedEventArgs e)
        {
            int Num = Convert.ToInt32(txtValue.Text);

            txtValue.Text = ((Num + 1).ToString());
        }

        void Decrease(object sender, RoutedEventArgs e)
        {
            int Num = Convert.ToInt32(txtValue.Text);

            txtValue.Text = ((Num - 1).ToString());
        }
    }
}
