using EShop.Model;

namespace EShop.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
       // private readonly IRepository<User> userRepository;
        public UserRepository(EShopDbContext eShopDbContext) : base(eShopDbContext)
        {
           // this.userRepository = userRepository;
        }
    }
}
