using CodeIsBug.Admin.Common.Config;
using SqlSugar;

namespace CodeIsBug.Admin.Repository.Base;

public class BaseRepository<T> : SimpleClient<T> where T : class, new()
{
    public BaseRepository(ISqlSugarClient context = null) : base(context)//注意这里要有默认值等于null
    {
        if (context == null)
        {
            base.Context = new SqlSugarScope(new ConnectionConfig()
            {
                DbType = DbType.MySql,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
                ConnectionString = DBConfig.ConnectionString
            });

            base.Context.Aop.OnLogExecuting = (s, p) =>
            {
                Console.WriteLine(s);
            };
        }
    }
}
