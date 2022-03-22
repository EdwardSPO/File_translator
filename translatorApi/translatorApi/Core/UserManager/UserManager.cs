using Microsoft.EntityFrameworkCore;
using translatorApi.Data;
using translatorApi.Helpers;
using translatorApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace translatorApi.Core.UserManager
{
    public class UserManager : IUserManager
    {
        private readonly UsersContext _context;

        public UserManager(UsersContext context)
        {
            _context = context;
        }


        public Task<ResultHelper<User>> CreateAsync(User user)
        {
            throw new System.NotImplementedException();
        }

    

        public Task<ResultHelper<User>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }



     
    }
}
