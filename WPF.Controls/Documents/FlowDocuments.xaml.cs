using System.Collections.Generic;
using System.Windows;

namespace Documents
{
    /// <summary>
    /// Lógica de interacción para FlowDocuments.xaml
    /// </summary>
    public partial class FlowDocuments : Window
    {
        public FlowDocuments()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstUsers.ItemsSource = new List<User>() {
                new User() {
                    Name = "Sergio", Age = 22
                },
                new User() {
                    Name="Alejandro", Age=44
                }
            };
        }

        class User
        {
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; } = 0;
        }
    }
}
