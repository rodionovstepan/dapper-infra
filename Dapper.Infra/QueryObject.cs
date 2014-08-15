namespace Dapper.Infra
{
    public class QueryObject
    {
        public QueryObject(string sql, object queryParams = null)
        {
            Sql = sql;
            QueryParams = queryParams;
        }

        public string Sql { get; private set; }
        public object QueryParams { get; private set; }
    }
}