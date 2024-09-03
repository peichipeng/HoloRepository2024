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
        this.connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=holorepository1";
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

    public void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (NpgsqlConnection connection = GetConnection())
        {
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                command.ExecuteNonQuery();
            }
        }
    }

    public NpgsqlDataReader ExecuteReader(string query, Dictionary<string, object> parameters = null)
    {
        NpgsqlConnection connection = GetConnection();
        NpgsqlCommand command = new NpgsqlCommand(query, connection);

        if (parameters != null)
        {
            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }
        }

        return command.ExecuteReader(CommandBehavior.CloseConnection);
    }

    public string ConnectionString
    {
        get {return connectionString;}
    }
}
