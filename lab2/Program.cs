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

            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert into tlPersonas(Nombres, Apellidos) values ('Yazmin', 'Vasquez')";

            command.Connection = sqlConnection;
            int Respuesta= command.ExecuteNonQuery(); //Devuelve cuantos registros fueron ejecutados
            Console.WriteLine($"{Respuesta} registros afectados");
        }
    }
}
