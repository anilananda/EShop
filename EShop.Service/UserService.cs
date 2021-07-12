using EShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Service
{
    public class UserService : IUserService
    {
        private readonly List<User> users = new List<User>()
            {
                new User()
                {
                    Id=1,
                    UserName="Anilananda"
                },
                new User()
                {
                    Id=2,
                    UserName="Arun"
                }
            };
        public User GetUserByIdAsync(int Id)
        {
            return users.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<User> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
