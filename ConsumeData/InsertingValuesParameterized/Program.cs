using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace InsertingValuesParameterized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando INSERT a base de datos...");
            Task myTask = InsertRowWithParameterizedQuery();
            myTask.Wait();
            Console.ReadKey();
        }
        public static async Task InsertRowWithParameterizedQuery()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleName]) VALUES(@firstName, @lastName, @middleName)", connection);
                await connection.OpenAsync();

                command.Parameters.AddWithValue("@firstName", "Alejandro");
                command.Parameters.AddWithValue("@lastName", "Ramírez");
                command.Parameters.AddWithValue("@middleName", "Pablo");
                int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine($"Inserted {numberOfInsertedRows} rows");
            }
        }
    }
}
