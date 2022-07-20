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

namespace WPF.Commands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isDirty = false;
        public MainWindow()
        {
            ApplicationCommands.New.Text = "Nuevo archivo";
            InitializeComponent();
            //CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            //binding.Executed += NewCommand_Executed;
            //this.CommandBindings.Add(binding);
        }


        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New");
        }

        private void txtMyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplicationCommands.New.Execute(null, this);
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Guardar");
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _isDirty;
        }

        private void txtMyTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            _isDirty = true;
        }
    }
}
