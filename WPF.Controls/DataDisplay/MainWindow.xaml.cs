using System;
using System.Collections.Generic;
using System.Windows;

namespace DataDisplay
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
            CustomerGrid.DataContext = GetCustomerData();
            CustomerGrid2.DataContext = GetCustomerData();
            trvMyTreeView.ItemsSource = GetCustomerData();
            lsvCustomers.ItemsSource = GetCustomerData();
        }
        private List<Customer> GetCustomerData()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    Name = "Sergio",
                    Address = "Mi dirección",
                    Age = 40,
                    IsMember = true
                },
                new Customer()
                {
                    Name = "Alejandro",
                    Address = "Mi otra dirección",
                    Age = 41,
                    IsMember = false
                },
                new Customer()
                {
                    Name = "Gabriel",
                    Address = "Dirección de la otra casa",
                    Age = 42,
                    IsMember = false,
                    Partners = new List<Customer>
                    {
                        new Customer() { Name = "Miguel Ángel"},
                        new Customer() { Name = "Rafael"},
                        new Customer() { Name = "Donatelo"},
                        new Customer() { 
                            Name = "Leonardo", 
                            Partners = new List<Customer>
                            {
                                new Customer() { Name = "Miguel Ángel"},
                                new Customer() { Name = "Rafael"},
                                new Customer() { Name = "Donatelo"},
                                new Customer() { Name = "Leonardo"}
                            }}
                    }
                }
            };
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool IsMember { get; set; }
        public List<Customer> Partners { get; set; }
        public Customer()
        {
            Name = String.Empty;
            Address = String.Empty;
            Partners = new List<Customer>();
        }
    }
}
