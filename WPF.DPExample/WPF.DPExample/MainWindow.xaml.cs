using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPF.DPExample
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnMain.Margin = new Thickness(20, 20, 20, 20);
            ScrollBar bar = new ScrollBar();
            bar.Value = 100; // (Right now bar.Value returns 1.) 
            bar.Minimum = 1; // (bar.Value still returns 1.) 
            bar.Maximum = 200; // (Now now bar.Value returns 100.) 


        }

        //static FrameworkElement()
        //{
        //    FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.AffectsArrange);
        //    metadata.CoerceValueCallback = new CoerceValueCallback(CoerceMaximum);
        //    MarginProperty = DependencyProperty.Register("Margin", typeof(Thickness), typeof(FrameworkElement), metadata, new ValidateValueCallback(FrameworkElement.IsMarginValid));
        //}
        //private static bool IsMarginValid(object value)
        //{
        //    Thickness thickness1 = (Thickness)value;
        //    return thickness1.IsValid(true, false, true, false);
        //}
        //private static object CoerceMaximum(DependencyObject d, object value)
        //{
        //    RangeBase base1 = (RangeBase)d;
        //    if (((double)value) < base1.Minimum)
        //    {
        //        return base1.Minimum;
        //    }
        //    return value;
        //}

        //public Thickness Margin
        //{
        //    set { SetValue(MarginProperty, value); }
        //    get { return (Thickness)GetValue(MarginProperty); }
        //}

        //private int myProperty;
        //public int MyProperty
        //{
        //    get
        //    {
        //        return myProperty;
        //    }
        //    set
        //    {
        //        myProperty = value;
        //    }
        //}

        private void btnMain2_Click(object sender, RoutedEventArgs e)
        {
            btnMain.ClearValue(Control.FontSizeProperty);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
