using EShop.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShop.Service
{
    public interface IUserService
    {
        public Task<List<User>> GetUsersAsync();
        
    }
}
