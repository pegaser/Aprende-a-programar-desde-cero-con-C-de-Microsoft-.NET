using System;
using System.Windows;

namespace MyWpfLibrary
{
    public class CustomResources
    {
        public static ComponentResourceKey RedBrushKey
        {
            get
            {
                return new ComponentResourceKey(typeof(CustomResources), "brushRed");
            }
        }

    }
}
