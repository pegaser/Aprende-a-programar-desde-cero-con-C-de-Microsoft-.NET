using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlConecctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(local)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Aquí ejecutaremos operacion con la Base de Datos

            } // <-Automáticamente se cierra la Base de Datos

            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(localdb)\v11.0";
            sqlConnectionStringBuilder.InitialCatalog = "MyCatalog";
            connectionString = sqlConnectionStringBuilder.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
    }
}
