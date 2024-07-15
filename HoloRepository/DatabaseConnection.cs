using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

public class DatabaseConnection
{ 
    private string connectionString;

    public DatabaseConnection()
    {
        this.connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=HoloRepository";
    }

    public NpgsqlConnection GetConnection()
    {
        try 
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        catch (Exception ex)
        {
            throw new Exception("Cannot connect to the database because ", ex);
        }
    }

    public void ExecuteNonQuery(string query) 
    {
        using (NpgsqlConnection connection = GetConnection())
        {
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                command.ExecuteNonQuery();
                }
        }
    }

    public NpgsqlDataReader ExecuteReader(string query) 
    {
        NpgsqlConnection connection = GetConnection();
        NpgsqlCommand command = new NpgsqlCommand(query, connection);
        return command.ExecuteReader(CommandBehavior.CloseConnection);
    }
}
