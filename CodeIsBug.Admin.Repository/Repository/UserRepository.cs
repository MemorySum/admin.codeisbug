using CodeIsBug.Admin.Common.Helper;
using CodeIsBug.Admin.Model.Admin;
using CodeIsBug.Admin.Model.Dto;
using CodeIsBug.Admin.Repository.Base;

namespace CodeIsBug.Admin.Repository.Repository;

public class UserRepository : BaseRepository<User>
{
    public async Task<User> Login(LoginInputDto dto)
    {
        return await Context.Queryable<User>()
            .FirstAsync(a => a.UserName.Equals(dto.UserName) && a.Password.Equals(dto.Password.Md5Hash()));
    }
}
