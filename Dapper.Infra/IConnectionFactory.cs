namespace Dapper.Infra
{
    using System.Data;

    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}