using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;

namespace UsingTransactionScope
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            using (TransactionScope transactionScope = new TransactionScope(TransactionScopeOption.Required))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("INSERT INTO People([firstname], [lastname], [middlename]) VALUES('Pablo', 'Morales', null)", connection);
                    SqlCommand command2 = new SqlCommand("INSERT INTO People([firstname], [lastname], [middlename]) VALUES('Janna', 'García', null)", connection);
                    command1.ExecuteNonQuery();
                    throw new ApplicationException("Mi error...");
                    command2.ExecuteNonQuery();
                }
                transactionScope.Complete();
            }
        }
    }
}
