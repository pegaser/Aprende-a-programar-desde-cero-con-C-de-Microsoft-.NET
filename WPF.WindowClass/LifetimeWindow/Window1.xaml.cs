using System;
using System.Diagnostics;
using System.Windows;

namespace LifetimeWindow
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            Debug.WriteLine("Entré a SourceInitialized");
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Entré a Activated");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Entré a Loaded");
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Debug.WriteLine("Entré a ContentRendered");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Debug.WriteLine("Entré a Closing");
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Debug.WriteLine("Entré a Deactivated");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Debug.WriteLine("Entré a Closed");
        }

    }
}
