using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBakimiAPI.Models;

namespace YazilimBakimiAPI.Data
{
   public   interface IAuthRepository
    {
        Task<Users> Register(Users user, string password);
        Task<Users> Login(string userName, string password);
        Task<bool> UserExist(string username);

    }
}
