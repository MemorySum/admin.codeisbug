using CodeIsBug.Admin.Common.Attribute;
using CodeIsBug.Admin.Common.Helper;
using CodeIsBug.Admin.Model.Admin;
using CodeIsBug.Admin.Model.Dto;

namespace CodeIsBug.Admin.Repository.Repository
{
    [AppService(ServiceLifetime = LifeTime.Transient)]
    public class UserRepository : BaseRepository<User>
    {
        public async Task<User> Login(LoginInputDto user)
        {
            return await Context.Queryable<User>().FirstAsync(it => it.UserName == user.UserName && it.Password == user.Password.Md5Hash());
        }
    }
}
