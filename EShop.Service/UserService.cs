using EShop.Data.Repositories;
using EShop.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShop.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepository.GetAll();
        }
    }
}
