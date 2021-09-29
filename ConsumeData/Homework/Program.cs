using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** ADMINISTRACIÓN DE CLIENTES ****");
            bool isExit = false;
            while (!isExit)
            {
                try
                {
                    Console.WriteLine("Opciones: 1.Alta de cliente  2.Edición  3.Borrado  4.Salir");
                    Console.WriteLine("Selecciona una opcion.");
                    string name;
                    int id, age;
                    int integerOption = GetIntegerData(Console.ReadLine());
                    switch (integerOption)
                    {
                        case 1:
                            //ALTA
                            Console.WriteLine("Proporciona el nombre completo del cliente");
                            name = Console.ReadLine();
                            Console.WriteLine("Proporciona la edad del cliente");
                            age = GetIntegerData(Console.ReadLine());
                            InsertClient(name, age).Wait();
                            break;
                        case 2:
                            //EDICIÓN
                            ShowClients().Wait();
                            Console.WriteLine("Proporciona el ID del cliente que se editará.");
                            id = GetIntegerData(Console.ReadLine());
                            Console.WriteLine("Proporciona el nuevo nombre completo del cliente");
                            name = Console.ReadLine();
                            Console.WriteLine("Proporciona la nueva edad del cliente");
                            age = GetIntegerData(Console.ReadLine());
                            UpdateClient(id, name, age).Wait();
                            break;
                        case 3:
                            //BORRADO
                            ShowClients().Wait();
                            Console.WriteLine("Proporciona el ID del cliente que se eliminará.");
                            id = GetIntegerData(Console.ReadLine());
                            DeleteClient(id).Wait();
                            break;
                        case 4:
                            //SALIR
                            ShowGreenMessage("Adios.");
                            Console.ReadKey();
                            isExit = true;
                            break;
                        default:
                            ShowRedMessage("Opción inválida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception appEx)
                {
                    ShowRedMessage(appEx.Message);
                }
            }
        }

        private static int GetIntegerData(string option)
        {
            if (int.TryParse(option, out int result))
            {
                return result;
            }
            else
            {
                throw new ApplicationException("Dato proporcionado incorrecto. Debe ser un número entero.");
            }
        }

        public static void ShowRedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowGreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static async Task InsertClient(string name, int age)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Clients([Name], [Age]) VALUES(@name, @age)", connection);
                await connection.OpenAsync();

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
                ShowGreenMessage($"Se insertó {numberOfInsertedRows} ciente(s).");
            }
        }
        public static async Task ShowClients()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID, Name, Age FROM Clients", connection);
                await connection.OpenAsync();
                SqlDataReader dataReader = await command.ExecuteReaderAsync();
                if (dataReader.HasRows)
                {
                    while (await dataReader.ReadAsync())
                    {
                        ShowGreenMessage($"Id:{dataReader["ID"]}  Nombre:{dataReader["Name"]} Edad:{dataReader["Age"]}");

                    }
                }
                else
                {
                    throw new ApplicationException("No existen clientes en la base de datos.");
                }
                dataReader.Close();
            }
        }
        public static async Task UpdateClient(int id, string name, int age)
        {
            
        }
        public static async Task DeleteClient(int id)
        {
            
        }
    }
}
