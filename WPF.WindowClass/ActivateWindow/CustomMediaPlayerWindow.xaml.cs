using System;
using System.Windows;

namespace ActivateWindow
{
    /// <summary>
    /// Lógica de interacción para CustomMediaPlayerWindow.xaml
    /// </summary>
    public partial class CustomMediaPlayerWindow : Window
    {
        public CustomMediaPlayerWindow()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            mediaElement.Play();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            mediaElement.Pause();
        }
    }
}
