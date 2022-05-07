using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Layouts
{
    /// <summary>
    /// Lógica de interacción para ThumbWindow.xaml
    /// </summary>
    public partial class ThumbWindow : Window
    {
        public ThumbWindow()
        {
            InitializeComponent();
        }
        private void OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            Canvas.SetLeft(myThumb, Canvas.GetLeft(myThumb) + e.HorizontalChange);
            Canvas.SetTop(myThumb, Canvas.GetTop(myThumb) + e.VerticalChange);
            txtPosition.Text = $"Position: {Canvas.GetLeft(myThumb)},{Canvas.GetTop(myThumb)}";
        }
        private void OnDragStarted(object sender, DragStartedEventArgs e)
        {
            myThumb.Background = Brushes.Orange;
        }
        private void OnDragCompleted(object sender, DragCompletedEventArgs e)
        {
            myThumb.Background = Brushes.Blue;
        }
        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.SetLeft(myThumb, 100 + e.NewValue);
        }
    }
}
