namespace Dapper.Infra.Impl
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class DefaultConnectionFactory : IConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }
    }
}