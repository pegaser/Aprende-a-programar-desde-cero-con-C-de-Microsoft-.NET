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

namespace CloseWindow
{
    /// <summary>
    /// Lógica de interacción para DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        private bool _isDataDirty;
        public DataWindow()
        {
            InitializeComponent();
        }

        private void documentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _isDataDirty = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_isDataDirty)
            {
                var result = MessageBox.Show("Document has changed. Close without saving?",
                                             "Question",
                                             MessageBoxButton.YesNo);

                if (result == MessageBoxResult.No)
                    e.Cancel = true;
            }

        }
    }
}
