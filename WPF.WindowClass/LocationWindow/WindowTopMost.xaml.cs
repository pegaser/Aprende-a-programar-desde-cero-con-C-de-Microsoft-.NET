using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LocationWindow
{
    /// <summary>
    /// Lógica de interacción para WindowTopMost.xaml
    /// </summary>
    public partial class WindowTopMost : Window
    {
        public WindowTopMost()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"ActualWidth: {this.ActualWidth} ActualHight: {this.ActualHeight}");
        }
    }
}
