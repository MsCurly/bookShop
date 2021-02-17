using bookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Services
{
    public interface IUserService
    {
        User ValidUser(string username, string password);
    }
}
