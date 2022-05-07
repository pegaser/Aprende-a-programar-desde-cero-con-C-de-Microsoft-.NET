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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Layouts
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

        private void BulletDecoratorButton_Click(object sender, RoutedEventArgs e)
        {
            BulletDecoratorWindow window = new BulletDecoratorWindow();
            window.Show();
        }

        private void CanvasButton_Click(object sender, RoutedEventArgs e)
        {
            CanvasWindow window = new CanvasWindow();
            window.Show();
        }

        private void ExpanderButton_Click(object sender, RoutedEventArgs e)
        {
            ExpanderWindow window = new ExpanderWindow();
            window.Show();
        }

        private void GridButton_Click(object sender, RoutedEventArgs e)
        {
            GridWindow window = new GridWindow();
            window.Show();
        }

        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow window = new StackPanelWindow();
            window.Show();
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow window = new DockPanelWindow();
            window.Show();
        }

        private void GridSplitterButton_Click(object sender, RoutedEventArgs e)
        {
            GridSplitterWindow window = new GridSplitterWindow();
            window.Show();
        }

        private void GroupBoxButton_Click(object sender, RoutedEventArgs e)
        {
            GroupBoxWindow window = new GroupBoxWindow();
            window.Show();
        }

        private void ThumbButton_Click(object sender, RoutedEventArgs e)
        {
            ThumbWindow window = new ThumbWindow();
            window.Show();
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow window = new WrapPanelWindow();
            window.Show();
        }
    }
}
