using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace InkDigital
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void InitializeComponent()
        {
            this.StartupUri = new Uri("MainWindow.xaml", System.UriKind.Relative);
        }

    }
}
