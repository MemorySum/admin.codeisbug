using CodeIsBug.Admin.Model.Admin;
using CodeIsBug.Admin.Model.Dto;

namespace CodeIsBug.Admin.Services.IService
{
    public interface IUserService : IBaseService<User>
    {
        public Task<User> Login(LoginInputDto dto);
    }
}
