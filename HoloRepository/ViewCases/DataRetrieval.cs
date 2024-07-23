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
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=HoloRepository";

        public static NpgsqlDataSource CreateDataSource()
        {
            return NpgsqlDataSource.Create(connectionString);
        }

        public static async Task<NpgsqlDataReader> ExecuteQuery (string query, NpgsqlDataSource dataSource)
        {
            await using var command = dataSource.CreateCommand(query);

            return await command.ExecuteReaderAsync();
        }
    }
}
