using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ExecutingSql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando SELECT a base de datos...");
            Task myTask = SelectDataFromTable();
            myTask.Wait();
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Task myTask2 = SelectMultipleResultSets();
            myTask2.Wait();
            Console.ReadKey();
        }
        public static async Task SelectDataFromTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM People", connection);
                await connection.OpenAsync();
                SqlDataReader dataReader = await command.ExecuteReaderAsync();

                while (await dataReader.ReadAsync())
                {
                    string formatStringWithMiddleName = "Person({0}) is named {1} {2} {3}";
                    string formatStringWithoutMiddleName = "Person({0}) is named {1} {3}";
                    if ((dataReader["middlename"] == null))
                    {
                        Console.WriteLine(formatStringWithoutMiddleName,
                            dataReader.GetInt32(0),
                            dataReader.GetString(1),
                            dataReader.GetString(3));
                    }
                    else
                    {
                        Console.WriteLine(formatStringWithMiddleName,
                            dataReader["id"],
                            dataReader["firstname"],
                            dataReader["middlename"],
                            dataReader["lastname"]);
                    }
                }
                dataReader.Close();
            }
        }

        public static async Task SelectMultipleResultSets()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM People; SELECT TOP 1 * FROM People ORDER BY LastName", connection);
                await connection.OpenAsync();
                SqlDataReader dataReader = await command.ExecuteReaderAsync();
                await ReadQueryResults(dataReader);
                await dataReader.NextResultAsync(); // Move to the next result set
                await ReadQueryResults(dataReader);
                dataReader.Close();
            }
        }
        private static async Task ReadQueryResults(SqlDataReader dataReader)
        {
            while (await dataReader.ReadAsync())
            {
                string formatStringWithMiddleName = "Person({0}) is named {1} {2}  {3}";
                string formatStringWithoutMiddleName = "Person({0}) is named {1} {3}";
                if ((dataReader["middlename"] == null))
                {
                    Console.WriteLine(formatStringWithoutMiddleName,
                        dataReader["id"],
                        dataReader["firstname"],
                        dataReader["lastname"]);
                }
                else
                {
                    Console.WriteLine(formatStringWithMiddleName,
                        dataReader["id"],
                        dataReader["firstname"],
                        dataReader["middlename"],
                        dataReader["lastname"]);
                }
            }
        }
    }
}
