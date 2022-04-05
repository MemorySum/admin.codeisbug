using CodeIsBug.Admin.Model.Admin;
using CodeIsBug.Admin.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIsBug.Admin.Services.IService
{
    public interface IUserService : IBaseService<User>
    {
        public Task<User> Login(LoginInputDto dto);
    }
}
