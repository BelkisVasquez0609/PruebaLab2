using System;
using System.Data.SqlClient;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrador\source\repos\lab2\lab2\DB.mdf;Integrated Security=True";
            sqlConnection.Open();
            Console.WriteLine(sqlConnection.State);
        }
    }
}
