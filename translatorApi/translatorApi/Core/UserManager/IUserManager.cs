using translatorApi.Helpers;
using translatorApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace translatorApi.Core.UserManager
{
    public interface IUserManager
    {
        Task<ResultHelper<User>> GetByIdAsync(int id);
        Task<ResultHelper<User>> CreateAsync(User user);
       
    }
}