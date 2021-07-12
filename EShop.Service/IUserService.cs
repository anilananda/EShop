using EShop.Model;
using System.Collections.Generic;

namespace EShop.Service
{
    public interface IUserService
    {
        public IEnumerable<User> GetUsersAsync();
        public User GetUserByIdAsync(int Id);
    }
}
