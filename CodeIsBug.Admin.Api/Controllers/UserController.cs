using CodeIsBug.Admin.Common.Helper;
using CodeIsBug.Admin.Model.Admin;
using CodeIsBug.Admin.Model.Dto;
using CodeIsBug.Admin.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace CodeIsBug.Admin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _iuserservice;

        public UserController(IUserService iuserservice)
        {
            _iuserservice = iuserservice;
        }
        [HttpPost]
        [Route("login")]

        public async Task<Result> Login([FromForm] LoginInputDto dto)
        {

            User user = await _iuserservice.Login(dto);
            if (user == null)
            {

                return Result.Error("用户查找失败");
            }
            return Result.Success(user);
        }
    }
}
