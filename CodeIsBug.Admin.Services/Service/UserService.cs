using CodeIsBug.Admin.Common.Attribute;
using CodeIsBug.Admin.Model.Admin;
using CodeIsBug.Admin.Model.Dto;
using CodeIsBug.Admin.Repository.Repository;
using CodeIsBug.Admin.Services.IService;

namespace CodeIsBug.Admin.Services.Service
{
    [AppService(ServiceType = typeof(IUserService), ServiceLifetime = LifeTime.Transient)]
    public class UserService : BaseService<User>, IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Login(LoginInputDto dto)
        {
            return await _userRepository.Login(dto);
        }
    }
}
