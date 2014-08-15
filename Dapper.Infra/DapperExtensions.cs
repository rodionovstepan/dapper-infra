namespace Dapper.Infra
{
    using System.Collections.Generic;
    using System.Data;

    public static class DapperExtensions
    {
        public static IEnumerable<T> Query<T>(this IDbConnection connection, QueryObject queryObject)
        {
            return connection.Query<T>(queryObject.Sql, queryObject.QueryParams);
        }

        public static int Execute(this IDbConnection connection, QueryObject queryObject)
        {
            return connection.Execute(queryObject.Sql, queryObject.QueryParams);
        }
    }
}
