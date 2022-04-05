using CodeIsBug.Admin.Model;
using SqlSugar;

namespace CodeIsBug.Admin.Extension;
#region 分页查询扩展
/// <summary>
/// 分页查询扩展
/// </summary>
public static class QueryableExtension
{
    /// <summary>
    /// 读取列表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source">查询表单式</param>
    /// <param name="parm">分页参数</param>
    /// <returns></returns>
    public static PagedInfo<T> ToPage<T>(this ISugarQueryable<T> source, PagerInfo parm)
    {
        var page = new PagedInfo<T>();
        var total = 0;
        page.PageSize = parm.PageSize;
        page.PageIndex = parm.PageNum;

        page.Result = source.OrderByIF(!string.IsNullOrEmpty(parm.Sort), $"{parm.Sort} {(parm.SortType.Contains("desc") ? "desc" : "asc")}")
            .ToPageList(parm.PageNum, parm.PageSize, ref total);
        page.TotalNum = total;
        return page;
    }
}
#endregion
