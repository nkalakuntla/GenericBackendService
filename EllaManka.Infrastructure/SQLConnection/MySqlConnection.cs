using MySqlConnector;
using System.Data;

namespace EllaManka.Infrastructure
{
    public class MySqlConnectionFactory
    {
        private readonly string _connectionString;

/*
Host: sql3.freesqldatabase.com
Database name: sql3781166
Database user: sql3781166
Database password: htQ2YS4dlq
Port number: 3306
*/
        public MySqlConnectionFactory()
        {
            _connectionString = "Server=sql3.freesqldatabase.com;Database=sql3781166;User=sql3781166;Password=htQ2YS4dlq;Port=3306;";
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}