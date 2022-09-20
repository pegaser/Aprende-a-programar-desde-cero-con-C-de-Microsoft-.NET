using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF.DPExample
{
    internal class MyButton : Button
    {
        private static PropertyMetadata metadata = new PropertyMetadata(false, new PropertyChangedCallback(ChangeBackGround));
        public static readonly DependencyProperty setGreenBackGroundProperty = DependencyProperty.Register(
            "SetGreenBackGround",
             typeof(bool), typeof(MyButton),
             metadata,
             new ValidateValueCallback(IsPropertyValid));
        
        public bool SetGreenBackGround
        {
            get => (bool)GetValue(setGreenBackGroundProperty);
            set => SetValue(setGreenBackGroundProperty, value);
        }

        private static bool IsPropertyValid(object value)
        {
            if (value is not null)
                return true;
            else
                return false;
        }
        private static void ChangeBackGround(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue && d is not null)
                (d as Button).Background = Brushes.Green;
        }
    }
}
