
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

namespace Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MyListBox.ItemsSource = new List<ToDoTasks>()
            {
                new ToDoTasks()
                {
                    Name = "Tarea 1", Description ="Descripción de la tarea 1", Priority ="Alta"
                },
                new ToDoTasks()
                {
                    Name = "Tarea 2", Description ="Descripción de la tarea 2", Priority ="Media"
                },
                new ToDoTasks()
                {
                    Name = "Tarea 3", Description ="Descripción de la tarea 3", Priority ="Baja"
                }
            };
        }
    }
    
    public class ToDoTasks
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
