using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace UpdatingData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando SELECT a base de datos...");
            Task myTask = UpdateRows();
            myTask.Wait();
            Console.ReadKey();
        }
        public static async Task UpdateRows()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE People SET middlename = 'Jorge' WHERE id=3", connection);
                await connection.OpenAsync();
                int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
            }
        }
    }
}
