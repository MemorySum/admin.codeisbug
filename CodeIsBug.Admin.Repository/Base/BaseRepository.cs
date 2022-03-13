using CodeIsBug.Admin.Common.Config;
using SqlSugar;
using SqlSugar.IOC;

namespace CodeIsBug.Admin.Repository.Base;

public class BaseRepository<T> : SimpleClient<T> where T : class, new()
{
    public BaseRepository(ISqlSugarClient context = null) : base(context)//注意这里要有默认值等于null
    {
        if (context == null)
        {
            Context = DbScoped.SugarScope;
            //调式代码 用来打印SQL 
            Context.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                                  Context.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName,
                                      it => it.Value)));
            };
        }
    }
}
