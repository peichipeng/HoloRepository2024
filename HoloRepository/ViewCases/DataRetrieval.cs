using Npgsql;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository.ViewCases
{
    public class DataRetrieval
    {
        public static NpgsqlDataSource CreateDataSource()
        {
            var dbConnection = new DatabaseConnection();
            return NpgsqlDataSource.Create(dbConnection.ConnectionString);
        }

        public static async Task<NpgsqlDataReader> ExecuteQuery (string query, NpgsqlDataSource dataSource)
        {
            await using var command = dataSource.CreateCommand(query);

            return await command.ExecuteReaderAsync();
        }
    }
}
