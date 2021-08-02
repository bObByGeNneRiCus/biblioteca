using System;
using System.Data.SqlClient;

namespace Infraestrutura.Repositorio
{
    public abstract class RepositorioBase : IDisposable
    {
        protected readonly SqlConnection _connection;

        public RepositorioBase()
        {
            _connection = getConnection();
        }

        private SqlConnection getConnection()
        {
            var connectionString = @"Data Source=(LocalDb)\\MSSQLLocalDB;Database=biblioteca;Integrated Security=SSPI;";

            return new SqlConnection(connectionString); ;
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
